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

namespace MashineLearning.Clusterization
{
    public partial class frmMashineLearning : Form
    {
        const char MARK_MODEL = 'M',
                   MARK_NOISE_IMAGE = 'N';
        private int _oldSelectIndex = 0;
        private bool _multiSelect;
        private List<ClusterImBinary> _lastSeparationFromSection;         
        private DrawerImBinary _drawerObjectsInCluster, _drawerAllObjects;
        private Dictionary<string, List<ImBinary>> _allImages;
        private List<ImBinary[]> _setsOfImages;
        private List<List<int>> _setsOfIndexImages;
        
        private uint _K = 8;
        private List<ImBinary> _sequenceImInDendro;
        private DendrogramInfo _currDendro = null;
        private int _seriesCounter;

        int _indexSelectCluster;

        public frmMashineLearning()
        {
            InitializeComponent();            
            _drawerAllObjects = new DrawerImBinary(ref pcB_ViewImages, 40, 40);
            _drawerObjectsInCluster = new DrawerImBinary(ref pcB_ViewObject, 30, 30);
            _setsOfImages = new List<ImBinary[]>(); 
            _allImages = new Dictionary<string,List<ImBinary>>();
            _setsOfIndexImages = new List<List<int>>();
        }

        private void cmB_Dimensionality_SelectedIndexChanged(object sender, EventArgs e)
        {
            cLB_Objects.Items.Clear();
            cLB_Objects.Items.AddRange(_allImages[(string)cmB_Dimensionality.Items[cmB_Dimensionality.SelectedIndex]].ToArray());
        }

        private void cLB_Objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _oldSelectIndex =  cLB_Objects.SelectedIndex;
            _drawerAllObjects.DrawIm((ImBinary)cLB_Objects.Items[cLB_Objects.SelectedIndex]);
        }

        private void cLB_Objects_MouseClick(object sender, MouseEventArgs e)
        {
            if (((sender as CheckedListBox).Items.Count > 0) && (e.Button == System.Windows.Forms.MouseButtons.Left))
                if (_multiSelect)
                {
                    int endSelect = (sender as CheckedListBox).IndexFromPoint(e.Location),
                        begSelect;
                    if (_oldSelectIndex > endSelect)
                    {
                        begSelect = endSelect;
                        endSelect = _oldSelectIndex;
                    }
                    else
                        begSelect = _oldSelectIndex;
                    for (int i = begSelect; i < endSelect; i++)
                        (sender as CheckedListBox).SetItemChecked(i, ! (sender as CheckedListBox).GetItemChecked(i));
                    _oldSelectIndex = endSelect;
                }
        }

        private void cLB_Objects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
                _multiSelect = true;
        }

        private void cLB_Objects_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
                _multiSelect = false;
        }

        private void ltB_ObjectsInCluster_SelectedIndexChanged(object sender, EventArgs e)
        {
            _drawerObjectsInCluster.DrawIm((ImBinary)(ltB_ObjectsInCluster.Items[ltB_ObjectsInCluster.SelectedIndex]));
        }

        private void cmB_Clusters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClusterImBinary currCluster = (ClusterImBinary)cmB_Clusters.Items[cmB_Clusters.SelectedIndex];
            ltB_ObjectsInCluster.Items.Clear();
            for (int i = 0, n = currCluster.Size; i < n; i++)
                ltB_ObjectsInCluster.Items.Add(currCluster.Object(i));
            if (ltB_ObjectsInCluster.Items.Count > 0)
                ltB_ObjectsInCluster.SelectedIndex = 0;
        }

        private void btnCreateSetOfImages_Click(object sender, EventArgs e)
        {
            _setsOfImages.Add((new List<ImBinary>( cLB_Objects.CheckedItems.Cast<ImBinary>())).ToArray());
            _setsOfIndexImages.Add(new List<int>(cLB_Objects.CheckedIndices.Cast<int>()));
            ltB_SetsOfImages.Items.Add("Вибірка" + ltB_SetsOfImages.Items.Count);
        }

        private void btnLoadImages_Click(object sender, EventArgs e)
        {
            if (oFD_Loader.ShowDialog() == DialogResult.OK)
            {
                StreamReader loader = new StreamReader(oFD_Loader.FileName);
                List<string> loadImages = new List<string>();
                try
                {
                    string[] parse = loader.ReadLine().Split(' ');
                    ImBinary loadIm;

                    byte row_cou = Convert.ToByte(parse[0]),
                         col_cou = Convert.ToByte(parse[1]);
                    string key = row_cou + "x" + col_cou;
                    if (!_allImages.ContainsKey(key))
                    {
                        _allImages.Add(key, new List<ImBinary>());
                        cmB_Dimensionality.Items.Add(key);
                    }
                    byte[] prop_s;
                    byte p;
                    bool not_errorInData;
                    while (!loader.EndOfStream)
                    {
                        not_errorInData = true;
                        parse = loader.ReadLine().Split(' ');
                        switch (parse[0][0])
                        {
                            case MARK_MODEL:
                            case MARK_NOISE_IMAGE:
                                prop_s = new byte[parse[1].Length];
                                for (int i = 0; not_errorInData && (i < prop_s.Length); i++)
                                    if ((p = Convert.ToByte(parse[1][i].ToString())) > 1)
                                        not_errorInData = false;
                                    else
                                        prop_s[i] = p;

                                if (not_errorInData)
                                {
                                    loadIm = new ImBinary(prop_s, (parse.Length > 2) ? parse[2] : "", row_cou, col_cou);
                                    _allImages[key].Add(loadIm);                               
                                    if (loadImages.Count < 45)
                                        loadImages.Add(loadIm.ToString());
                                    else
                                        loadImages[44] = "...";                                  
                                }
                                break;                           
                                
                            default:
                                row_cou = Convert.ToByte(parse[0]);
                                col_cou = Convert.ToByte(parse[1]);
                                key = row_cou + "x" + col_cou;
                                if (!_allImages.ContainsKey(key))
                                {
                                    _allImages.Add(key, new List<ImBinary>());
                                    cmB_Dimensionality.Items.Add(key);
                                }
                                break;
                        }
                    }
                }
                catch (OverflowException oE)
                {
                    MessageBox.Show(oE.Message, "OverflowException");
                }
                catch (FormatException fE)
                {
                    MessageBox.Show(fE.Message, "FormatException");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Exception");
                }
                finally
                {
                    loader.Close();
                    string report;
                    if (loadImages.Count > 0)
                    {                        
                        report = "Додані образи:";
                        foreach (string l_Im in loadImages)
                            report += "\n  + " + l_Im;
                    }
                    else report = "Не вдалося завантажити жодного образу.";
                    MessageBox.Show(report, "Звіт завантаження");
                    if (cmB_Dimensionality.SelectedIndex >= 0)
                        cmB_Dimensionality_SelectedIndexChanged(cmB_Dimensionality, new EventArgs());
                    else
                        cmB_Dimensionality.SelectedIndex = 0;
                }
            }
        }

        private void ltB_SetsOfImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> checkedIndices = _setsOfIndexImages[ltB_SetsOfImages.SelectedIndex];
            ImBinary im = _setsOfImages[ltB_SetsOfImages.SelectedIndex][0];
            int d = cmB_Dimensionality.FindStringExact(im.RowCount + "x" + im.ColumnCount);
            if (d == cmB_Dimensionality.SelectedIndex)
                for (int i = 0, n = cLB_Objects.Items.Count; i < n; i++)
                    cLB_Objects.SetItemChecked(i, false);
            else 
                cmB_Dimensionality.SelectedIndex = cmB_Dimensionality.FindStringExact(im.RowCount + "x" + im.ColumnCount);
            
            foreach(int ch_ind in checkedIndices)
                cLB_Objects.SetItemChecked(ch_ind, true);
        }

        private void txB_CountClusters_Validated(object sender, EventArgs e)
        {
            uint K;
            if (uint.TryParse(txB_CountClusters.Text, out K))
                _K = K;
            else
                txB_CountClusters.Text = _K.ToString();
        }

        private void btnClusterize_Click(object sender, EventArgs e)
        {
            if (rdB_HierarchicalAgglomerativeMethod.Checked)
            {                
                if (rdB_SingleLinkage.Checked)
                    _currDendro = ClusterizationImBinary.HierarchicalAgglomerativeMethod(_setsOfImages[ltB_SetsOfImages.SelectedIndex], TypeOfInterclusterDistance.SingleLinkage);
                if (rdB_CompleteLinkage.Checked)
                    _currDendro = ClusterizationImBinary.HierarchicalAgglomerativeMethod(_setsOfImages[ltB_SetsOfImages.SelectedIndex], TypeOfInterclusterDistance.CompleteLinkage);
                if (rdB_AverageLinkage.Checked)
                    _currDendro = ClusterizationImBinary.HierarchicalAgglomerativeMethod(_setsOfImages[ltB_SetsOfImages.SelectedIndex], TypeOfInterclusterDistance.AverageLinkage);
                if (rdB_Median.Checked)
                    _currDendro = ClusterizationImBinary.HierarchicalAgglomerativeMethod(_setsOfImages[ltB_SetsOfImages.SelectedIndex], TypeOfInterclusterDistance.Median);
                if (rdB_Ward.Checked)
                    _currDendro = ClusterizationImBinary.HierarchicalAgglomerativeMethod(_setsOfImages[ltB_SetsOfImages.SelectedIndex], TypeOfInterclusterDistance.Ward);
                chtDendrogram.Series.Clear();
                _seriesCounter = 0;
                _sequenceImInDendro = new List<ImBinary>();
                DrawDendrogram(_currDendro.Root);
                nUD_InterclusterDistance.Maximum = _currDendro.Root.Distance();
                dGV_SequenceObjectsInDendrogram.RowCount = _sequenceImInDendro.Count;
                for (int i = 0, n = _sequenceImInDendro.Count; i < n; i++)
                {
                    dGV_SequenceObjectsInDendrogram.Rows[i].Cells[0].Value = i + 1;
                    dGV_SequenceObjectsInDendrogram.Rows[i].Cells[1].Value = _sequenceImInDendro[i];
                }
                tbC_Main.SelectTab(1);
                tbC_Results.SelectTab(0);
            }
            else
            {
                cmB_Clusters.Items.Clear();
                ClusterSeparationImBinary S = null;
                if (rdB_KmeansByLloyd.Checked)
                {
                    cmB_Clusters.Items.AddRange((S = ClusterizationImBinary.KmeansByLloyd(_setsOfImages[ltB_SetsOfImages.SelectedIndex], _K)).Separation);
                    lblInfo.Text = "К-середніх у варіанті Ллойда";
                }

                if (rdB_KmeansByMacQueen.Checked)
                {
                    cmB_Clusters.Items.AddRange((S = ClusterizationImBinary.KmeansByMacQueen(_setsOfImages[ltB_SetsOfImages.SelectedIndex], _K)).Separation);
                    lblInfo.Text = "К-середніх у варіанті Мак-Кіна";
                }

                if (rdB_FOREL2.Checked)
                {
                    cmB_Clusters.Items.AddRange((S = ClusterizationImBinary.FOREL2(_setsOfImages[ltB_SetsOfImages.SelectedIndex], _K)).Separation);
                    lblInfo.Text = "FOREL-2";
                }

                if (rdB_KRAB.Checked)
                {
                    cmB_Clusters.Items.AddRange((S = ClusterizationImBinary.KRAB(_setsOfImages[ltB_SetsOfImages.SelectedIndex], _K)).Separation);
                    lblInfo.Text = "KRAB";
                }
                
                cmB_Clusters.SelectedIndex = 0;
                ltB_ObjectsInCluster.SelectedIndex = 0;
                lblInfo.Text = "Результат розбиття вибірки \"" + ltB_SetsOfImages.SelectedItem.ToString() + "\" методом " + lblInfo.Text + " на " + this._K.ToString() + " кластерів.";

                //вывести функционалы качества
                //lblFunctionals.Text = "Q'₂(S) = " + S.FunctionalQShtrich2;
                lblFunctionals.Text = "Q₂(S) = " + S.FunctionalQ2;
                lblFunctionals.Text += "\nQ₃(S) = " + S.FunctionalQ3;
                lblFunctionals.Text += "\nQ₄(S) = " + S.FunctionalQ4;
                lblFunctionals.Text += "\nQ₅(S) = " + S.FunctionalQ5;

                tbC_Main.SelectTab(1);
                tbC_Results.SelectTab(1);
            }            
        }

        private double DrawDendrogram(ClusterizationTreeImBinary node)
        {
            System.Windows.Forms.DataVisualization.Charting.Series srs;
            if (node.Size == 1)
            {
                _sequenceImInDendro.Add(node.GetObjects()[0]);
                return _sequenceImInDendro.Count;
            }
            else
            {
                srs = new System.Windows.Forms.DataVisualization.Charting.Series("srs" + _seriesCounter++);
                srs.ChartArea = "ChartArea1";
                srs.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;                
                double x1, x2;
                srs.Points.AddXY(x1 = DrawDendrogram(node.Left), node.Left.Distance());
                srs.Points.AddXY(x1, node.Distance());
                srs.Points.AddXY(x2 = DrawDendrogram(node.Right), node.Distance());
                srs.Points.AddXY(x2, node.Right.Distance());
                chtDendrogram.Series.Add(srs);
                return (x1 + x2) / 2;
            }
        }

        private void rdB_HierarchicalAgglomerativeMethod_CheckedChanged(object sender, EventArgs e)
        {
            lblCountClusters.Visible = txB_CountClusters.Visible = !(grB_TypeDistance.Visible = rdB_HierarchicalAgglomerativeMethod.Checked);
        }

        private void btnChangeLabelCluster_Click(object sender, EventArgs e)
        {
            
            switch (cmB_Clusters.DropDownStyle)
            {
                case ComboBoxStyle.DropDownList:
                    _indexSelectCluster = cmB_Clusters.SelectedIndex;
                    btnChangeLabelCluster.Text = "Продовжити";
                    cmB_Clusters.DropDownStyle = ComboBoxStyle.Simple;
                    break;
                case ComboBoxStyle.Simple:
                    if (MessageBox.Show("Прийняти зміни?", "Зміна мітки кластера", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        (cmB_Clusters.Items[_indexSelectCluster] as ClusterImBinary).Label = cmB_Clusters.Text;                    
                    btnChangeLabelCluster.Text = "Змінити мітку кластера";
                    cmB_Clusters.SelectedIndex = _indexSelectCluster;
                    cmB_Clusters.DropDownStyle = ComboBoxStyle.DropDownList;
                    break;
                default:
                    break;
            }
        }

        private void btnCreateSeparationFromSection_Click(object sender, EventArgs e)
        {
            _lastSeparationFromSection = new List<ClusterImBinary>();
            CreateSeparationFromSection(_currDendro.Root, (int)nUD_InterclusterDistance.Value);
            
            ClusterSeparationImBinary separationFromSection = new ClusterSeparationImBinary(_lastSeparationFromSection[0].Object(0).RowCount, _lastSeparationFromSection[0].Object(0).ColumnCount, (uint)_lastSeparationFromSection.Count);
            for (int i = 0, n = _lastSeparationFromSection.Count; i < n; i++)
                separationFromSection.Separation[i] = _lastSeparationFromSection[i];

            //вывести функционалы качества
            //lblFunctionals.Text = "Q'₂(S) = " + separationFromSection.FunctionalQShtrich2;
            lblFunctionals.Text = "Q₂(S) = " + separationFromSection.FunctionalQ2;
            lblFunctionals.Text += "\nQ₃(S) = " + separationFromSection.FunctionalQ3;
            lblFunctionals.Text += "\nQ₄(S) = " + separationFromSection.FunctionalQ4;
            lblFunctionals.Text += "\nQ₅(S) = " + separationFromSection.FunctionalQ5;

            cmB_Clusters.Items.Clear();
            cmB_Clusters.Items.AddRange(separationFromSection.Separation);
            cmB_Clusters.SelectedIndex = 0;
            ltB_ObjectsInCluster.SelectedIndex = 0;
            lblInfo.Text = "Переріз поточної дендрограми при міжкластерній відстані " + this.nUD_InterclusterDistance.Value;
            
            tbC_Results.SelectTab(1);
        }

        private void CreateSeparationFromSection(ClusterizationTreeImBinary node, int dist)
        {
            if (node.Distance() < dist)            
                _lastSeparationFromSection.Add(new ClusterImBinary(node.GetObjects(), "ClOfSection" + _lastSeparationFromSection.Count));            
            else
            {
                CreateSeparationFromSection(node.Left, dist);
                CreateSeparationFromSection(node.Right, dist);
            }
        }

        private void dGV_SequenceObjectsInDendrogram_CellContentClick(object sender, DataGridViewCellEventArgs e) //?
        {

        }
    }
}
