using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correlation_and_Regression
{
    public partial class frmRegression : Form
    {
        double _aljfaForRestoration = 0.05,
               _aljfaForCoefs = 0.05;
        int _accuracyForRestoration = 4,
            _accuracyForCoefs = 4;

        OneDimensionaryScatterPlot _currScatterPlot;
        LinearRegressionInfo _restoreLinRegression;
        PolinomialRegressionInfo _restorePolinomRegression;
        PointData _currPointRegr = new PointData(0, double.NaN);

        bool _dataTableIsEmpty = false;
        bool _linear;

        public frmRegression()
        {
            InitializeComponent();
        }

        private void frmRegression_Load(object sender, EventArgs e)
        {
            dGV_CorrelationCoefficients.RowCount = 3;
            dGV_CorrelationCoefficients.Rows[0].HeaderCell.Value = "Коефіцієнт кореляції\nПірсона";
            dGV_CorrelationCoefficients.Rows[1].HeaderCell.Value = "Ранговий коефіцієнт\nкореляції Спірмена";
            dGV_CorrelationCoefficients.Rows[2].HeaderCell.Value = "Ранговий коефіцієнт\nкореляції Кендалла";

            ClearTableRestoration();
            cmB_Degree.SelectedIndex = 0;
        }

        private void ClearTableRestoration()
        {
            dGV_RestoreRegression.Rows.Clear();
            dGV_RestoreRegression.RowCount = 6;
            dGV_RestoreRegression.Rows[0].HeaderCell.Value = "Значення\nоцінки";
            dGV_RestoreRegression.Rows[1].HeaderCell.Value = "Дисперсія";
            dGV_RestoreRegression.Rows[2].HeaderCell.Value = "Статистика";
            dGV_RestoreRegression.Rows[3].HeaderCell.Value = "Квантиль";
            dGV_RestoreRegression.Rows[4].HeaderCell.Value = "Значущість";
            dGV_RestoreRegression.Rows[5].HeaderCell.Value = "Довірчий\nінтервал";
        }

        private void rdB_ScatterPlot_CheckedChanged(object sender, EventArgs e)
        {
            chtScatterPlot.Visible = rdB_ScatterPlot.Checked;
        }

        private void rdB_ResidualPlot_CheckedChanged(object sender, EventArgs e)
        {
            lblHorizAxesResidualPlot.Visible = cmB_HorizAxesResidualPlot.Visible = chtResidualPlot.Visible = rdB_ResidualPlot.Checked;
        }

        private void txB_AljfaForRestoration_Validated(object sender, EventArgs e)
        {
            double aljfaForRestoration;
            if (double.TryParse(txB_AljfaForRestoration.Text, out aljfaForRestoration) && (aljfaForRestoration > 0) && (aljfaForRestoration < 1))
                _aljfaForRestoration = aljfaForRestoration;
            else
                txB_AljfaForRestoration.Text = _aljfaForRestoration.ToString();
            _accuracyForRestoration = txB_AljfaForRestoration.Text.Length - txB_AljfaForRestoration.Text.IndexOf(',') - 1;
        }

        private void txB_AljfaForCoefs_Validated(object sender, EventArgs e)
        {
            double aljfaForCoefs;
            if (double.TryParse(txB_AljfaForCoefs.Text, out aljfaForCoefs) && (aljfaForCoefs > 0) && (aljfaForCoefs < 1))
                _aljfaForCoefs = aljfaForCoefs;
            else
                txB_AljfaForCoefs.Text = _aljfaForCoefs.ToString();
            _accuracyForCoefs = txB_AljfaForCoefs.Text.Length - txB_AljfaForCoefs.Text.IndexOf(',') - 1;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (oFD_LoaderDataSet.ShowDialog() == DialogResult.OK)
            {
                StreamReader readerDataSet = new StreamReader(oFD_LoaderDataSet.FileName);
                try
                {
                    List<double> dataSet_y = new List<double>(),
                                 dataSet_x = new List<double>();
                    string[] numbers;
                    char[] splitters = new char[2] { ' ', '\t' };
                    while (!(readerDataSet.EndOfStream))
                    {
                        dataSet_y.Add(Convert.ToDouble((numbers = readerDataSet.ReadLine().Replace('.', ',').Split(splitters, 2, StringSplitOptions.RemoveEmptyEntries))[1]));
                        dataSet_x.Add(Convert.ToDouble(numbers[0]));
                    }

                    _currScatterPlot = new OneDimensionaryScatterPlot(dataSet_y.ToArray(), dataSet_x.ToArray());
                    txB_CurrFile.Text = oFD_LoaderDataSet.FileName;
                    _dataTableIsEmpty = false;
                    dGV_Data.RowCount = _currScatterPlot.Count;
                    chtScatterPlot.Series["srsData"].Points.Clear();
                    chtScatterPlot.Series["srsFuncRegression"].Points.Clear();
                    chtScatterPlot.Series["srsBottomFR"].Points.Clear();
                    chtScatterPlot.Series["srsTopFR"].Points.Clear();
                    chtScatterPlot.Series["srsLowBoundForecastValues"].Points.Clear();
                    chtScatterPlot.Series["srsHighBoundForecastValues"].Points.Clear();
                    rdB_ScatterPlot.Checked = true;
                    rdB_ResidualPlot.Enabled = false;
                    dGV_Data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dGV_Data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    for (int i = 0; i < dGV_Data.RowCount; i++)
                    {
                        dGV_Data.Rows[i].HeaderCell.Value = (i + 1).ToString();
                        dGV_Data.Rows[i].Cells[0].Value = dataSet_x[i];
                        dGV_Data.Rows[i].Cells[1].Value = dataSet_y[i];
                        chtScatterPlot.Series["srsData"].Points.AddXY(dataSet_x[i], dataSet_y[i]);
                    }
                    dGV_Data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dGV_Data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    _dataTableIsEmpty = true;
                    dGV_Data.Rows[0].Selected = true;
                    btnReCalcCoefs_Click(btnReCalcCoefs, new EventArgs());

                    lblInfoAboutRestoreRegression.Text = "...";
                    dGV_RestoreRegression.Columns["cln_a2"].Visible = false;
                    dGV_RestoreRegression.Rows[0].Cells["cln_a0"].Value = "";
                    dGV_RestoreRegression.Rows[1].Cells["cln_a0"].Value = "";
                    dGV_RestoreRegression.Rows[2].Cells["cln_a0"].Value = "";
                    dGV_RestoreRegression.Rows[3].Cells["cln_a0"].Value = "";
                    dGV_RestoreRegression.Rows[4].Cells["cln_a0"].Value = "";
                    dGV_RestoreRegression.Rows[5].Cells["cln_a0"].Value = "";
                    dGV_RestoreRegression.Rows[0].Cells["cln_a1"].Value = "";
                    dGV_RestoreRegression.Rows[1].Cells["cln_a1"].Value = "";
                    dGV_RestoreRegression.Rows[2].Cells["cln_a1"].Value = "";
                    dGV_RestoreRegression.Rows[3].Cells["cln_a1"].Value = "";
                    dGV_RestoreRegression.Rows[4].Cells["cln_a1"].Value = "";
                    dGV_RestoreRegression.Rows[5].Cells["cln_a1"].Value = "";
                    lbl1.Visible = false;
                    lbl2.Visible = false;
                    txB_x.Visible = false;
                    txB_y.Visible = false;

                    grB_CorrelationCoefficients.Visible = true;
                    grB_RestorationRegression.Visible = true;
                }
                catch (IOException eIO)
                {
                    MessageBox.Show(String.Format("Помилка зчитування рядка текстового файлу {0}.\n {1}",
                        oFD_LoaderDataSet.SafeFileName, eIO.ToString()), "Помилка зчитування рядка з текстового файлу");
                }
                catch (FormatException eFE)
                {
                    MessageBox.Show(eFE.ToString(), "У вказаному файлі наявні недопустимі рядки, що не містять числа");
                }
                catch (OverflowException eOE)
                {
                    MessageBox.Show(eOE.ToString(), "Числа у вказаному файлі виходять за межі допустимого діапазону значень");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString(), "НЕПЕРЕДБАЧЕНА ПОМИЛКА");
                }
                finally
                {
                    readerDataSet.Close();
                }
            }
        }

        private void btnReCalcCoefs_Click(object sender, EventArgs e)
        {
            double stat, bottom, top, quantile;
            bool significance;
            dGV_CorrelationCoefficients.Rows[0].Cells["clnValueCoef"].Value = Math.Round(_currScatterPlot.PearsonCorrelationCoefficient(_aljfaForCoefs, out stat, out quantile, out significance, out bottom, out top), _accuracyForCoefs).ToString();
            dGV_CorrelationCoefficients.Rows[0].Cells["clnStatCoef"].Value = Math.Round(stat, _accuracyForCoefs).ToString();
            dGV_CorrelationCoefficients.Rows[0].Cells["clnQuantileCoef"].Value = Math.Round(quantile, _accuracyForCoefs).ToString();
            dGV_CorrelationCoefficients.Rows[0].Cells[3].Value = (significance) ? "ЗНАЧУЩИЙ" : "НЕЗНАЧУЩИЙ";
            dGV_CorrelationCoefficients.Rows[0].Cells["clnInterval"].Value = (double.IsNaN(bottom) || double.IsNaN(top)) ? " - " : "[" + Math.Round(bottom, _accuracyForCoefs).ToString() + "; " + Math.Round(top, _accuracyForCoefs).ToString() + "]";

            dGV_CorrelationCoefficients.Rows[1].Cells["clnValueCoef"].Value = Math.Round(_currScatterPlot.SpearmansRankCorrelationCoefficient(_aljfaForCoefs, out stat, out quantile, out significance, out bottom, out top), _accuracyForCoefs).ToString();
            dGV_CorrelationCoefficients.Rows[1].Cells["clnStatCoef"].Value = Math.Round(stat, _accuracyForCoefs).ToString();
            dGV_CorrelationCoefficients.Rows[1].Cells["clnQuantileCoef"].Value = Math.Round(quantile, _accuracyForCoefs).ToString();
            dGV_CorrelationCoefficients.Rows[1].Cells[3].Value = (significance) ? "ЗНАЧУЩИЙ" : "НЕЗНАЧУЩИЙ";
            dGV_CorrelationCoefficients.Rows[1].Cells["clnInterval"].Value = (double.IsNaN(bottom) || double.IsNaN(top)) ? " - " : "[" + Math.Round(bottom, _accuracyForCoefs).ToString() + "; " + Math.Round(top, _accuracyForCoefs).ToString() + "]";

            dGV_CorrelationCoefficients.Rows[2].Cells["clnValueCoef"].Value = Math.Round(_currScatterPlot.KendallsRankCorrelationCoefficient(_aljfaForCoefs, out stat, out quantile, out significance, out bottom, out top), _accuracyForCoefs).ToString();
            dGV_CorrelationCoefficients.Rows[2].Cells["clnStatCoef"].Value = Math.Round(stat, _accuracyForCoefs).ToString();
            dGV_CorrelationCoefficients.Rows[2].Cells["clnQuantileCoef"].Value = Math.Round(quantile, _accuracyForCoefs).ToString();
            dGV_CorrelationCoefficients.Rows[2].Cells[3].Value = (significance) ? "ЗНАЧУЩИЙ" : "НЕЗНАЧУЩИЙ";
            dGV_CorrelationCoefficients.Rows[2].Cells["clnInterval"].Value = (double.IsNaN(bottom) || double.IsNaN(top)) ? " - " : "[" + Math.Round(bottom, _accuracyForCoefs).ToString() + "; " + Math.Round(top, _accuracyForCoefs).ToString() + "]";

            lblInfoForAljfaForCoefs.Text = "...Перераховані для α = " + _aljfaForCoefs.ToString() + ".";
        }

        private void dGV_Data_SelectionChanged(object sender, EventArgs e)
        {
            if (_dataTableIsEmpty)
            {
                chtScatterPlot.Series["srsSelectedPoint"].Points.Clear();
                if (dGV_Data.SelectedRows.Count > 0)
                    chtScatterPlot.Series["srsSelectedPoint"].Points.AddXY((double)dGV_Data.SelectedRows[0].Cells["clnX"].Value, (double)dGV_Data.SelectedRows[0].Cells["clnY"].Value);
            }
        }

        private void btnRestoreLinearRegression_Click(object sender, EventArgs e)
        {
            double quanOfSt, quanOfFish;
            _restoreLinRegression = _currScatterPlot.RestoreLinearRegression(_aljfaForRestoration, out quanOfSt, out quanOfFish);

            _linear = true;
            btnRestorePolinomRegression.BackColor = Color.Gray;
            btnRestoreLinearRegression.BackColor = Color.Green;
            cmB_Degree.SelectedIndex = 0;
            ClearTableRestoration();            

            dGV_RestoreRegression.Rows[0].Cells["cln_a0"].Value = Math.Round(_restoreLinRegression.A0, _accuracyForRestoration);
            dGV_RestoreRegression.Rows[1].Cells["cln_a0"].Value = Math.Round(_restoreLinRegression.Dispersion_A0, _accuracyForRestoration);
            dGV_RestoreRegression.Rows[2].Cells["cln_a0"].Value = Math.Round(_restoreLinRegression.Stat_A0, _accuracyForRestoration);
            dGV_RestoreRegression.Rows[3].Cells["cln_a0"].Value = Math.Round(quanOfSt, _accuracyForRestoration);
            dGV_RestoreRegression.Rows[4].Cells["cln_a0"].Value = _restoreLinRegression.Significance_A0 ? "ЗНАЧУЩА" : "НЕЗНАЧУЩА";
            dGV_RestoreRegression.Rows[5].Cells["cln_a0"].Value = _restoreLinRegression.Significance_A0 ? ("[" + Math.Round(_restoreLinRegression.A0_bottom, _accuracyForRestoration) + "; " + Math.Round(_restoreLinRegression.A0_top, _accuracyForRestoration) + "]") : " - ";

            dGV_RestoreRegression.Rows[0].Cells["cln_a1"].Value = Math.Round(_restoreLinRegression.A1, _accuracyForRestoration);
            dGV_RestoreRegression.Rows[1].Cells["cln_a1"].Value = Math.Round(_restoreLinRegression.Dispersion_A1, _accuracyForRestoration);
            dGV_RestoreRegression.Rows[2].Cells["cln_a1"].Value = Math.Round(_restoreLinRegression.Stat_A1, _accuracyForRestoration);
            dGV_RestoreRegression.Rows[3].Cells["cln_a1"].Value = Math.Round(quanOfSt, _accuracyForRestoration);
            dGV_RestoreRegression.Rows[4].Cells["cln_a1"].Value = _restoreLinRegression.Significance_A1 ? "ЗНАЧУЩА" : "НЕЗНАЧУЩА";
            dGV_RestoreRegression.Rows[5].Cells["cln_a1"].Value = _restoreLinRegression.Significance_A1 ? ("[" + Math.Round(_restoreLinRegression.A1_bottom, _accuracyForRestoration) + "; " + Math.Round(_restoreLinRegression.A1_top, _accuracyForRestoration) + "]") : " - ";

            chtScatterPlot.Series["srsFuncRegression"].Points.Clear();
            chtScatterPlot.Series["srsBottomFR"].Points.Clear();
            chtScatterPlot.Series["srsTopFR"].Points.Clear();
            chtScatterPlot.Series["srsLowBoundForecastValues"].Points.Clear();
            chtScatterPlot.Series["srsHighBoundForecastValues"].Points.Clear();
            SortedSet<double> points = new SortedSet<double>();
            for (int i = 0, N = _currScatterPlot.Count; i < N; i++)
                points.Add(_currScatterPlot[i].x);

            foreach (double x in points)
            {
                chtScatterPlot.Series["srsFuncRegression"].Points.AddXY(x, _restoreLinRegression.F(x));
                chtScatterPlot.Series["srsBottomFR"].Points.AddXY(x, _restoreLinRegression.F_bottom(x));
                chtScatterPlot.Series["srsTopFR"].Points.AddXY(x, _restoreLinRegression.F_top(x));
                chtScatterPlot.Series["srsLowBoundForecastValues"].Points.AddXY(x, _restoreLinRegression.Y_bottom(x));
                chtScatterPlot.Series["srsHighBoundForecastValues"].Points.AddXY(x, _restoreLinRegression.Y_top(x));
            }
            rdB_ResidualPlot.Enabled = true;
            if (cmB_HorizAxesResidualPlot.SelectedIndex == 1)
                cmB_HorizAxesResidualPlot_SelectedIndexChanged(cmB_HorizAxesResidualPlot, new EventArgs());
            else
                cmB_HorizAxesResidualPlot.SelectedIndex = 1;
            lblInfoAboutRestoreRegression.Text = "Відновлена регресія виду ŷ(x) = â₀ + â₁x" + 
                                               "\nR² = " + Math.Round(_restoreLinRegression.DeterminitionCoefficient, _accuracyForRestoration) + 
                                               "\nСтатистика F = " + Math.Round(_restoreLinRegression.F_statistic, _accuracyForRestoration) + 
                                               "\nКвантиль F₍₁₋ 𝛼₎,₁,₍ₙ₋₁₎ = " + Math.Round(quanOfFish, _accuracyForRestoration) + 
                                               "\nВисновок: РЕГРЕСІЯ " + ((_restoreLinRegression.SignificanceRegression) ? "ЗНАЧУЩА" : "НЕЗНАЧУЩА") + "на рівні значущості " + _restoreLinRegression.LevelSignificance.ToString();
            lbl1.Visible = true;
            lbl2.Visible = true;
            txB_x.Visible = true;
            txB_y.Visible = true;
            txB_x.Text = 0.ToString();
            txB_y.Text = _restoreLinRegression.F(0).ToString();
        }

        private void txB_x_Validated(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(txB_x.Text, out x))
                txB_y.Text = (_currPointRegr = new PointData((_linear) ? _restoreLinRegression.F(x) : _restorePolinomRegression.F(x), x)).y.ToString();
            else
                txB_x.Text = _currPointRegr.x.ToString();
        }

        private void cmB_HorizAxesResidualPlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            chtResidualPlot.Series["srsResiduals"].Points.Clear();
            PointData point;
            if (_linear)
                switch (cmB_HorizAxesResidualPlot.SelectedIndex)
                {
                    case 0:
                        chtResidualPlot.ChartAreas[0].Axes[0].Title = "ŷ";
                        for (int i = 0, N = _currScatterPlot.Count; i < N; i++)
                            chtResidualPlot.Series["srsResiduals"].Points.AddXY(_restoreLinRegression.F((point = _currScatterPlot[i]).x), point.y - _restoreLinRegression.F(point.x));
                        break;
                    case 1:
                        chtResidualPlot.ChartAreas[0].Axes[0].Title = "x";
                        for (int i = 0, N = _currScatterPlot.Count; i < N; i++)
                            chtResidualPlot.Series["srsResiduals"].Points.AddXY((point = _currScatterPlot[i]).x, point.y - _restoreLinRegression.F(point.x));
                        break;
                    case 2:
                        chtResidualPlot.ChartAreas[0].Axes[0].Title = "i";
                        for (int i = 0, N = _currScatterPlot.Count; i < N; i++)
                            chtResidualPlot.Series["srsResiduals"].Points.AddXY(i, (point = _currScatterPlot[i]).y - _restoreLinRegression.F(point.x));
                        break;
                    default:
                        break;
                }
            else
                switch (cmB_HorizAxesResidualPlot.SelectedIndex)
                {
                    case 0:
                        chtResidualPlot.ChartAreas[0].Axes[0].Title = "ŷ";
                        for (int i = 0, N = _currScatterPlot.Count; i < N; i++)
                            chtResidualPlot.Series["srsResiduals"].Points.AddXY(_restorePolinomRegression.F((point = _currScatterPlot[i]).x), point.y - _restorePolinomRegression.F(point.x));
                        break;
                    case 1:
                        chtResidualPlot.ChartAreas[0].Axes[0].Title = "x";
                        for (int i = 0, N = _currScatterPlot.Count; i < N; i++)
                            chtResidualPlot.Series["srsResiduals"].Points.AddXY((point = _currScatterPlot[i]).x, point.y - _restorePolinomRegression.F(point.x));
                        break;
                    case 2:
                        chtResidualPlot.ChartAreas[0].Axes[0].Title = "i";
                        for (int i = 0, N = _currScatterPlot.Count; i < N; i++)
                            chtResidualPlot.Series["srsResiduals"].Points.AddXY(i, (point = _currScatterPlot[i]).y - _restorePolinomRegression.F(point.x));
                        break;
                    default:
                        break;
                }
        }

        private void cmB_Degree_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 2; i < cmB_Degree.SelectedIndex + 2; i++)
                dGV_RestoreRegression.Columns[i].Visible = true;
            for (int i = cmB_Degree.SelectedIndex + 2; i < cmB_Degree.Items.Count + 1; i++)
                dGV_RestoreRegression.Columns[i].Visible = false;
        }

        private void btnRestorePolinomRegression_Click(object sender, EventArgs e)
        {
            double quanOfSt, quanOfFish;
            _restorePolinomRegression = _currScatterPlot.RestorePolinomialRegression(Convert.ToInt32(cmB_Degree.SelectedItem.ToString()), _aljfaForRestoration, out quanOfSt, out quanOfFish);

            _linear = false;
            btnRestorePolinomRegression.BackColor = Color.Green;
            btnRestoreLinearRegression.BackColor = Color.Gray;
            ClearTableRestoration();

            for (int i = 0; i <= _restorePolinomRegression.Degree; i++)
            {
                dGV_RestoreRegression.Rows[0].Cells[i].Value = Math.Round(_restorePolinomRegression[CharacteristicsPolinomialCoefs.PointEstimation, i], _accuracyForRestoration);
                dGV_RestoreRegression.Rows[1].Cells[i].Value = Math.Round(_restorePolinomRegression[CharacteristicsPolinomialCoefs.Dispersion, i], _accuracyForRestoration);
                dGV_RestoreRegression.Rows[2].Cells[i].Value = Math.Round(_restorePolinomRegression[CharacteristicsPolinomialCoefs.Statistic, i], _accuracyForRestoration);
                dGV_RestoreRegression.Rows[3].Cells[i].Value = Math.Round(quanOfSt, _accuracyForRestoration);
                dGV_RestoreRegression.Rows[4].Cells[i].Value = Convert.ToBoolean(_restorePolinomRegression[CharacteristicsPolinomialCoefs.Significance, i]) ? "ЗНАЧУЩА" : "НЕЗНАЧУЩА";
                dGV_RestoreRegression.Rows[5].Cells[i].Value = Convert.ToBoolean(_restorePolinomRegression[CharacteristicsPolinomialCoefs.Significance, i]) ? ("[" + Math.Round(_restorePolinomRegression[CharacteristicsPolinomialCoefs.LowBound, i], _accuracyForRestoration) + "; " + Math.Round(_restorePolinomRegression[CharacteristicsPolinomialCoefs.HighBound, i], _accuracyForRestoration) + "]") : " - ";
            }
             
            chtScatterPlot.Series["srsFuncRegression"].Points.Clear();
            chtScatterPlot.Series["srsBottomFR"].Points.Clear();
            chtScatterPlot.Series["srsTopFR"].Points.Clear();
            chtScatterPlot.Series["srsLowBoundForecastValues"].Points.Clear();
            chtScatterPlot.Series["srsHighBoundForecastValues"].Points.Clear();
            SortedSet<double> points = new SortedSet<double>();
            for (int i = 0, N = _currScatterPlot.Count; i < N; i++)
                points.Add(_currScatterPlot[i].x);

            foreach (double x in points)
            {
                chtScatterPlot.Series["srsFuncRegression"].Points.AddXY(x, _restorePolinomRegression.F(x));
                chtScatterPlot.Series["srsBottomFR"].Points.AddXY(x, _restorePolinomRegression.F_bottom(x));
                chtScatterPlot.Series["srsTopFR"].Points.AddXY(x, _restorePolinomRegression.F_top(x));
                chtScatterPlot.Series["srsLowBoundForecastValues"].Points.AddXY(x, _restorePolinomRegression.Y_bottom(x));
                chtScatterPlot.Series["srsHighBoundForecastValues"].Points.AddXY(x, _restorePolinomRegression.Y_top(x));
            }
            rdB_ResidualPlot.Enabled = true;
            if (cmB_HorizAxesResidualPlot.SelectedIndex == 1)
                cmB_HorizAxesResidualPlot_SelectedIndexChanged(cmB_HorizAxesResidualPlot, new EventArgs());
            else
                cmB_HorizAxesResidualPlot.SelectedIndex = 1;
            lblInfoAboutRestoreRegression.Text = "Відновлена регресія виду ŷ(x) = â₀ + â₁x" + ((_restorePolinomRegression.Degree == 1) ? "" : ((_restorePolinomRegression.Degree == 2) ? " + â₂x²" : " + ... + â" + NumberToLowIndex(_restorePolinomRegression.Degree) + "x" + NumberToHighIndex(_restorePolinomRegression.Degree))) +
                                               "\nR² = " + Math.Round(_restorePolinomRegression.DeterminitionCoefficient, _accuracyForRestoration) +
                                               "\nСтатистика F = " + Math.Round(_restorePolinomRegression.F_statistic, _accuracyForRestoration) +
                                               "\nКвантиль F₍₁₋𝛼₎,ᵢ,₍ₙ₋ᵢ₋₁₎ = " + Math.Round(quanOfFish, _accuracyForRestoration) +
                                               "\nВисновок: РЕГРЕСІЯ " + ((_restorePolinomRegression.SignificanceRegression) ? "ЗНАЧУЩА" : "НЕЗНАЧУЩА") + " на рівні значущості " + _restorePolinomRegression.LevelSignificance.ToString();
            lbl1.Visible = true;
            lbl2.Visible = true;
            txB_x.Visible = true;
            txB_y.Visible = true;
            txB_x.Text = 0.ToString();
            txB_y.Text = _restorePolinomRegression.F(0).ToString();
        }

        public static string NumberToLowIndex(int number)
        {
            string result = "",
                   source = number.ToString();
            for (int i = 0; i < source.Length; i++)
                switch (source[i])
                {
                    case '1':
                        result += '₁';
                        break;
                    case '2':
                        result += '₂';
                        break;
                    case '3':
                        result += '₃';
                        break;
                    case '4':
                        result += '₄';
                        break;
                    case '5':
                        result += '₅';
                        break;
                    case '6':
                        result += '₆';
                        break;
                    case '7':
                        result += '₇';
                        break;
                    case '8':
                        result += '₈';
                        break;
                    case '9':
                        result += '₉';
                        break;
                    case '0':
                        result += '₀';
                        break;
                    case '-':
                        result += '₋';
                        break;
                    default:
                        break;
                }
            return result;
        }

        public static string NumberToHighIndex(int number)
        {
            string result = "",
                   source = number.ToString();
            for (int i = 0; i < source.Length; i++)
                switch (source[i])
                {
                    case '1':
                        result += '¹';
                        break;
                    case '2':
                        result += '²';
                        break;
                    case '3':
                        result += '³';
                        break;
                    case '4':
                        result += '⁴';
                        break;
                    case '5':
                        result += '⁵';
                        break;
                    case '6':
                        result += '⁶';
                        break;
                    case '7':
                        result += '⁷';
                        break;
                    case '8':
                        result += '⁸';
                        break;
                    case '9':
                        result += '⁹';
                        break;
                    case '0':
                        result += '⁰';
                        break;
                    case '-':
                        result += '⁻';
                        break;
                    default:
                        break;
                }
            return result;
        }
    }
}
