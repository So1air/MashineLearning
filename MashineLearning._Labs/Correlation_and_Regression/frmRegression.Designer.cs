namespace Correlation_and_Regression
{
    partial class frmRegression
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtScatterPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dGV_Data = new System.Windows.Forms.DataGridView();
            this.clnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_RestoreRegression = new System.Windows.Forms.DataGridView();
            this.dGV_CorrelationCoefficients = new System.Windows.Forms.DataGridView();
            this.clnValueCoef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatCoef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantileCoef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сlnSignifCoef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAljfaForRestoration = new System.Windows.Forms.Label();
            this.txB_AljfaForRestoration = new System.Windows.Forms.TextBox();
            this.btnRestoreLinearRegression = new System.Windows.Forms.Button();
            this.grB_CorrelationCoefficients = new System.Windows.Forms.GroupBox();
            this.btnReCalcCoefs = new System.Windows.Forms.Button();
            this.lblInfoForAljfaForCoefs = new System.Windows.Forms.Label();
            this.txB_AljfaForCoefs = new System.Windows.Forms.TextBox();
            this.lblAljfaForCoefs = new System.Windows.Forms.Label();
            this.grB_RestorationRegression = new System.Windows.Forms.GroupBox();
            this.lblInfoAboutRestoreRegression = new System.Windows.Forms.Label();
            this.btnRestorePolinomRegression = new System.Windows.Forms.Button();
            this.txB_y = new System.Windows.Forms.TextBox();
            this.txB_x = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.rdB_ScatterPlot = new System.Windows.Forms.RadioButton();
            this.rdB_ResidualPlot = new System.Windows.Forms.RadioButton();
            this.chtResidualPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.oFD_LoaderDataSet = new System.Windows.Forms.OpenFileDialog();
            this.txB_CurrFile = new System.Windows.Forms.TextBox();
            this.lblCurrFile = new System.Windows.Forms.Label();
            this.cmB_HorizAxesResidualPlot = new System.Windows.Forms.ComboBox();
            this.lblHorizAxesResidualPlot = new System.Windows.Forms.Label();
            this.cmB_Degree = new System.Windows.Forms.ComboBox();
            this.cln_a0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_a1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_a2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_a3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_a4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_a5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_a6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_a7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDegree = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtScatterPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_RestoreRegression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CorrelationCoefficients)).BeginInit();
            this.grB_CorrelationCoefficients.SuspendLayout();
            this.grB_RestorationRegression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtResidualPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // chtScatterPlot
            // 
            this.chtScatterPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea3.AxisX.MinorGrid.Enabled = true;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.MinorTickMark.Enabled = true;
            chartArea3.AxisX.MinorTickMark.Size = 0.5F;
            chartArea3.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea3.AxisX.Title = "x";
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea3.AxisY.MinorGrid.Enabled = true;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.MinorTickMark.Enabled = true;
            chartArea3.AxisY.MinorTickMark.Size = 0.5F;
            chartArea3.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea3.AxisY.Title = "y";
            chartArea3.Name = "ChartArea1";
            this.chtScatterPlot.ChartAreas.Add(chartArea3);
            this.chtScatterPlot.Location = new System.Drawing.Point(234, 9);
            this.chtScatterPlot.Margin = new System.Windows.Forms.Padding(0);
            this.chtScatterPlot.Name = "chtScatterPlot";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series9.Color = System.Drawing.Color.Green;
            series9.Name = "srsData";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series10.Name = "srsFuncRegression";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Color = System.Drawing.Color.Red;
            series11.Name = "srsBottomFR";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Color = System.Drawing.Color.Red;
            series12.Name = "srsTopFR";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Color = System.Drawing.Color.Blue;
            series13.Name = "srsLowBoundForecastValues";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Color = System.Drawing.Color.Blue;
            series14.Name = "srsHighBoundForecastValues";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series15.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series15.Name = "srsSelectedPoint";
            this.chtScatterPlot.Series.Add(series9);
            this.chtScatterPlot.Series.Add(series10);
            this.chtScatterPlot.Series.Add(series11);
            this.chtScatterPlot.Series.Add(series12);
            this.chtScatterPlot.Series.Add(series13);
            this.chtScatterPlot.Series.Add(series14);
            this.chtScatterPlot.Series.Add(series15);
            this.chtScatterPlot.Size = new System.Drawing.Size(688, 371);
            this.chtScatterPlot.TabIndex = 0;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(12, 12);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(219, 23);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Завантажити дані з файлу";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dGV_Data
            // 
            this.dGV_Data.AllowUserToAddRows = false;
            this.dGV_Data.AllowUserToDeleteRows = false;
            this.dGV_Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dGV_Data.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnX,
            this.clnY});
            this.dGV_Data.Location = new System.Drawing.Point(12, 41);
            this.dGV_Data.MultiSelect = false;
            this.dGV_Data.Name = "dGV_Data";
            this.dGV_Data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGV_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Data.Size = new System.Drawing.Size(219, 296);
            this.dGV_Data.TabIndex = 2;
            this.dGV_Data.SelectionChanged += new System.EventHandler(this.dGV_Data_SelectionChanged);
            // 
            // clnX
            // 
            this.clnX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnX.HeaderText = "x";
            this.clnX.Name = "clnX";
            this.clnX.ReadOnly = true;
            this.clnX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnX.Width = 18;
            // 
            // clnY
            // 
            this.clnY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnY.HeaderText = "y";
            this.clnY.Name = "clnY";
            this.clnY.ReadOnly = true;
            this.clnY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnY.Width = 18;
            // 
            // dGV_RestoreRegression
            // 
            this.dGV_RestoreRegression.AllowUserToAddRows = false;
            this.dGV_RestoreRegression.AllowUserToDeleteRows = false;
            this.dGV_RestoreRegression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_RestoreRegression.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGV_RestoreRegression.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_RestoreRegression.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_a0,
            this.cln_a1,
            this.cln_a2,
            this.cln_a3,
            this.cln_a4,
            this.cln_a5,
            this.cln_a6,
            this.cln_a7});
            this.dGV_RestoreRegression.Location = new System.Drawing.Point(6, 247);
            this.dGV_RestoreRegression.Name = "dGV_RestoreRegression";
            this.dGV_RestoreRegression.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGV_RestoreRegression.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGV_RestoreRegression.Size = new System.Drawing.Size(243, 158);
            this.dGV_RestoreRegression.TabIndex = 3;
            // 
            // dGV_CorrelationCoefficients
            // 
            this.dGV_CorrelationCoefficients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_CorrelationCoefficients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_CorrelationCoefficients.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGV_CorrelationCoefficients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_CorrelationCoefficients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnValueCoef,
            this.clnStatCoef,
            this.clnQuantileCoef,
            this.сlnSignifCoef,
            this.clnInterval});
            this.dGV_CorrelationCoefficients.Location = new System.Drawing.Point(6, 42);
            this.dGV_CorrelationCoefficients.Name = "dGV_CorrelationCoefficients";
            this.dGV_CorrelationCoefficients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGV_CorrelationCoefficients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGV_CorrelationCoefficients.Size = new System.Drawing.Size(898, 113);
            this.dGV_CorrelationCoefficients.TabIndex = 4;
            // 
            // clnValueCoef
            // 
            this.clnValueCoef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnValueCoef.HeaderText = "Значення";
            this.clnValueCoef.Name = "clnValueCoef";
            this.clnValueCoef.ReadOnly = true;
            this.clnValueCoef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnStatCoef
            // 
            this.clnStatCoef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnStatCoef.HeaderText = "Статистика";
            this.clnStatCoef.Name = "clnStatCoef";
            this.clnStatCoef.ReadOnly = true;
            this.clnStatCoef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnQuantileCoef
            // 
            this.clnQuantileCoef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnQuantileCoef.HeaderText = "Квантиль";
            this.clnQuantileCoef.Name = "clnQuantileCoef";
            this.clnQuantileCoef.ReadOnly = true;
            this.clnQuantileCoef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // сlnSignifCoef
            // 
            this.сlnSignifCoef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.сlnSignifCoef.FillWeight = 50F;
            this.сlnSignifCoef.HeaderText = "Значущість";
            this.сlnSignifCoef.Name = "сlnSignifCoef";
            this.сlnSignifCoef.ReadOnly = true;
            this.сlnSignifCoef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnInterval
            // 
            this.clnInterval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnInterval.FillWeight = 200F;
            this.clnInterval.HeaderText = "Дов. інтервал";
            this.clnInterval.Name = "clnInterval";
            this.clnInterval.ReadOnly = true;
            this.clnInterval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblAljfaForRestoration
            // 
            this.lblAljfaForRestoration.AutoSize = true;
            this.lblAljfaForRestoration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAljfaForRestoration.Location = new System.Drawing.Point(111, 20);
            this.lblAljfaForRestoration.Name = "lblAljfaForRestoration";
            this.lblAljfaForRestoration.Size = new System.Drawing.Size(32, 17);
            this.lblAljfaForRestoration.TabIndex = 5;
            this.lblAljfaForRestoration.Text = "α = ";
            // 
            // txB_AljfaForRestoration
            // 
            this.txB_AljfaForRestoration.Location = new System.Drawing.Point(149, 19);
            this.txB_AljfaForRestoration.Name = "txB_AljfaForRestoration";
            this.txB_AljfaForRestoration.Size = new System.Drawing.Size(100, 20);
            this.txB_AljfaForRestoration.TabIndex = 6;
            this.txB_AljfaForRestoration.Text = "0,0500";
            this.txB_AljfaForRestoration.Validated += new System.EventHandler(this.txB_AljfaForRestoration_Validated);
            // 
            // btnRestoreLinearRegression
            // 
            this.btnRestoreLinearRegression.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestoreLinearRegression.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestoreLinearRegression.Location = new System.Drawing.Point(6, 45);
            this.btnRestoreLinearRegression.Name = "btnRestoreLinearRegression";
            this.btnRestoreLinearRegression.Size = new System.Drawing.Size(243, 28);
            this.btnRestoreLinearRegression.TabIndex = 7;
            this.btnRestoreLinearRegression.Text = "Відновити ŷ(x) = â₀ + â₁x";
            this.btnRestoreLinearRegression.UseVisualStyleBackColor = true;
            this.btnRestoreLinearRegression.Click += new System.EventHandler(this.btnRestoreLinearRegression_Click);
            // 
            // grB_CorrelationCoefficients
            // 
            this.grB_CorrelationCoefficients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB_CorrelationCoefficients.Controls.Add(this.btnReCalcCoefs);
            this.grB_CorrelationCoefficients.Controls.Add(this.lblInfoForAljfaForCoefs);
            this.grB_CorrelationCoefficients.Controls.Add(this.txB_AljfaForCoefs);
            this.grB_CorrelationCoefficients.Controls.Add(this.lblAljfaForCoefs);
            this.grB_CorrelationCoefficients.Controls.Add(this.dGV_CorrelationCoefficients);
            this.grB_CorrelationCoefficients.Location = new System.Drawing.Point(12, 386);
            this.grB_CorrelationCoefficients.Name = "grB_CorrelationCoefficients";
            this.grB_CorrelationCoefficients.Size = new System.Drawing.Size(910, 161);
            this.grB_CorrelationCoefficients.TabIndex = 8;
            this.grB_CorrelationCoefficients.TabStop = false;
            this.grB_CorrelationCoefficients.Text = "Коефіцієнти кореляції";
            this.grB_CorrelationCoefficients.Visible = false;
            // 
            // btnReCalcCoefs
            // 
            this.btnReCalcCoefs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReCalcCoefs.Location = new System.Drawing.Point(613, 13);
            this.btnReCalcCoefs.Name = "btnReCalcCoefs";
            this.btnReCalcCoefs.Size = new System.Drawing.Size(153, 23);
            this.btnReCalcCoefs.TabIndex = 10;
            this.btnReCalcCoefs.Text = "Перерахувати для";
            this.btnReCalcCoefs.UseVisualStyleBackColor = true;
            this.btnReCalcCoefs.Click += new System.EventHandler(this.btnReCalcCoefs_Click);
            // 
            // lblInfoForAljfaForCoefs
            // 
            this.lblInfoForAljfaForCoefs.AutoSize = true;
            this.lblInfoForAljfaForCoefs.Location = new System.Drawing.Point(6, 18);
            this.lblInfoForAljfaForCoefs.Name = "lblInfoForAljfaForCoefs";
            this.lblInfoForAljfaForCoefs.Size = new System.Drawing.Size(16, 13);
            this.lblInfoForAljfaForCoefs.TabIndex = 9;
            this.lblInfoForAljfaForCoefs.Text = "...";
            // 
            // txB_AljfaForCoefs
            // 
            this.txB_AljfaForCoefs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txB_AljfaForCoefs.Location = new System.Drawing.Point(804, 15);
            this.txB_AljfaForCoefs.Name = "txB_AljfaForCoefs";
            this.txB_AljfaForCoefs.Size = new System.Drawing.Size(100, 20);
            this.txB_AljfaForCoefs.TabIndex = 8;
            this.txB_AljfaForCoefs.Text = "0,0500";
            this.txB_AljfaForCoefs.Validated += new System.EventHandler(this.txB_AljfaForCoefs_Validated);
            // 
            // lblAljfaForCoefs
            // 
            this.lblAljfaForCoefs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAljfaForCoefs.AutoSize = true;
            this.lblAljfaForCoefs.Location = new System.Drawing.Point(772, 18);
            this.lblAljfaForCoefs.Name = "lblAljfaForCoefs";
            this.lblAljfaForCoefs.Size = new System.Drawing.Size(26, 13);
            this.lblAljfaForCoefs.TabIndex = 7;
            this.lblAljfaForCoefs.Text = "α = ";
            // 
            // grB_RestorationRegression
            // 
            this.grB_RestorationRegression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB_RestorationRegression.Controls.Add(this.lblDegree);
            this.grB_RestorationRegression.Controls.Add(this.cmB_Degree);
            this.grB_RestorationRegression.Controls.Add(this.lblInfoAboutRestoreRegression);
            this.grB_RestorationRegression.Controls.Add(this.btnRestorePolinomRegression);
            this.grB_RestorationRegression.Controls.Add(this.txB_y);
            this.grB_RestorationRegression.Controls.Add(this.txB_x);
            this.grB_RestorationRegression.Controls.Add(this.lbl2);
            this.grB_RestorationRegression.Controls.Add(this.lbl1);
            this.grB_RestorationRegression.Controls.Add(this.lblAljfaForRestoration);
            this.grB_RestorationRegression.Controls.Add(this.txB_AljfaForRestoration);
            this.grB_RestorationRegression.Controls.Add(this.dGV_RestoreRegression);
            this.grB_RestorationRegression.Controls.Add(this.btnRestoreLinearRegression);
            this.grB_RestorationRegression.Location = new System.Drawing.Point(936, 112);
            this.grB_RestorationRegression.Name = "grB_RestorationRegression";
            this.grB_RestorationRegression.Size = new System.Drawing.Size(255, 435);
            this.grB_RestorationRegression.TabIndex = 9;
            this.grB_RestorationRegression.TabStop = false;
            this.grB_RestorationRegression.Text = "Відновлення регресії";
            this.grB_RestorationRegression.Visible = false;
            // 
            // lblInfoAboutRestoreRegression
            // 
            this.lblInfoAboutRestoreRegression.AutoSize = true;
            this.lblInfoAboutRestoreRegression.Location = new System.Drawing.Point(6, 142);
            this.lblInfoAboutRestoreRegression.MaximumSize = new System.Drawing.Size(245, 0);
            this.lblInfoAboutRestoreRegression.Name = "lblInfoAboutRestoreRegression";
            this.lblInfoAboutRestoreRegression.Size = new System.Drawing.Size(16, 13);
            this.lblInfoAboutRestoreRegression.TabIndex = 13;
            this.lblInfoAboutRestoreRegression.Text = "...";
            // 
            // btnRestorePolinomRegression
            // 
            this.btnRestorePolinomRegression.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestorePolinomRegression.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestorePolinomRegression.Location = new System.Drawing.Point(6, 79);
            this.btnRestorePolinomRegression.Name = "btnRestorePolinomRegression";
            this.btnRestorePolinomRegression.Size = new System.Drawing.Size(243, 28);
            this.btnRestorePolinomRegression.TabIndex = 12;
            this.btnRestorePolinomRegression.Text = "Відновити ŷ(x)=â₀+â₁x+...+ âᵢxⁱ";
            this.btnRestorePolinomRegression.UseVisualStyleBackColor = true;
            this.btnRestorePolinomRegression.Click += new System.EventHandler(this.btnRestorePolinomRegression_Click);
            // 
            // txB_y
            // 
            this.txB_y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txB_y.Location = new System.Drawing.Point(127, 407);
            this.txB_y.Name = "txB_y";
            this.txB_y.ReadOnly = true;
            this.txB_y.Size = new System.Drawing.Size(83, 20);
            this.txB_y.TabIndex = 11;
            this.txB_y.Visible = false;
            // 
            // txB_x
            // 
            this.txB_x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txB_x.Location = new System.Drawing.Point(30, 407);
            this.txB_x.Name = "txB_x";
            this.txB_x.Size = new System.Drawing.Size(69, 20);
            this.txB_x.TabIndex = 10;
            this.txB_x.Visible = false;
            this.txB_x.Validated += new System.EventHandler(this.txB_x_Validated);
            // 
            // lbl2
            // 
            this.lbl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.Location = new System.Drawing.Point(96, 408);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(29, 17);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = " ) =";
            this.lbl2.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(6, 408);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(24, 17);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = " ŷ(";
            this.lbl1.Visible = false;
            // 
            // rdB_ScatterPlot
            // 
            this.rdB_ScatterPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdB_ScatterPlot.AutoSize = true;
            this.rdB_ScatterPlot.Checked = true;
            this.rdB_ScatterPlot.Location = new System.Drawing.Point(936, 18);
            this.rdB_ScatterPlot.Name = "rdB_ScatterPlot";
            this.rdB_ScatterPlot.Size = new System.Drawing.Size(115, 17);
            this.rdB_ScatterPlot.TabIndex = 10;
            this.rdB_ScatterPlot.TabStop = true;
            this.rdB_ScatterPlot.Text = "Кореляційне поле";
            this.rdB_ScatterPlot.UseVisualStyleBackColor = true;
            this.rdB_ScatterPlot.CheckedChanged += new System.EventHandler(this.rdB_ScatterPlot_CheckedChanged);
            // 
            // rdB_ResidualPlot
            // 
            this.rdB_ResidualPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdB_ResidualPlot.AutoSize = true;
            this.rdB_ResidualPlot.Enabled = false;
            this.rdB_ResidualPlot.Location = new System.Drawing.Point(936, 41);
            this.rdB_ResidualPlot.Name = "rdB_ResidualPlot";
            this.rdB_ResidualPlot.Size = new System.Drawing.Size(232, 17);
            this.rdB_ResidualPlot.TabIndex = 11;
            this.rdB_ResidualPlot.Text = "Діагностична діаграма(графік залишків) ";
            this.rdB_ResidualPlot.UseVisualStyleBackColor = true;
            this.rdB_ResidualPlot.CheckedChanged += new System.EventHandler(this.rdB_ResidualPlot_CheckedChanged);
            // 
            // chtResidualPlot
            // 
            this.chtResidualPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea4.AxisX.MinorGrid.Enabled = true;
            chartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisX.MinorTickMark.Enabled = true;
            chartArea4.AxisX.MinorTickMark.Size = 0.5F;
            chartArea4.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea4.AxisY.MinorGrid.Enabled = true;
            chartArea4.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.MinorTickMark.Enabled = true;
            chartArea4.AxisY.MinorTickMark.Size = 0.5F;
            chartArea4.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea4.AxisY.Title = "ε";
            chartArea4.Name = "ChartArea1";
            this.chtResidualPlot.ChartAreas.Add(chartArea4);
            this.chtResidualPlot.Location = new System.Drawing.Point(234, 9);
            this.chtResidualPlot.Margin = new System.Windows.Forms.Padding(0);
            this.chtResidualPlot.Name = "chtResidualPlot";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series16.Color = System.Drawing.Color.Black;
            series16.Name = "srsResiduals";
            this.chtResidualPlot.Series.Add(series16);
            this.chtResidualPlot.Size = new System.Drawing.Size(688, 371);
            this.chtResidualPlot.TabIndex = 12;
            this.chtResidualPlot.Visible = false;
            // 
            // oFD_LoaderDataSet
            // 
            this.oFD_LoaderDataSet.DefaultExt = "txt";
            this.oFD_LoaderDataSet.Filter = "Текстові файли|*.txt";
            this.oFD_LoaderDataSet.InitialDirectory = ".";
            this.oFD_LoaderDataSet.Title = "Оберіть файл";
            // 
            // txB_CurrFile
            // 
            this.txB_CurrFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txB_CurrFile.Location = new System.Drawing.Point(12, 359);
            this.txB_CurrFile.Name = "txB_CurrFile";
            this.txB_CurrFile.ReadOnly = true;
            this.txB_CurrFile.Size = new System.Drawing.Size(219, 20);
            this.txB_CurrFile.TabIndex = 11;
            // 
            // lblCurrFile
            // 
            this.lblCurrFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrFile.AutoSize = true;
            this.lblCurrFile.Location = new System.Drawing.Point(9, 343);
            this.lblCurrFile.Name = "lblCurrFile";
            this.lblCurrFile.Size = new System.Drawing.Size(87, 13);
            this.lblCurrFile.TabIndex = 13;
            this.lblCurrFile.Text = "Поточний файл:";
            // 
            // cmB_HorizAxesResidualPlot
            // 
            this.cmB_HorizAxesResidualPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmB_HorizAxesResidualPlot.DisplayMember = "1";
            this.cmB_HorizAxesResidualPlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_HorizAxesResidualPlot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmB_HorizAxesResidualPlot.FormattingEnabled = true;
            this.cmB_HorizAxesResidualPlot.Items.AddRange(new object[] {
            "прогнозоване значення ŷ = f(x; Â)",
            "значення x-показника",
            "номер спостереження (час) "});
            this.cmB_HorizAxesResidualPlot.Location = new System.Drawing.Point(958, 77);
            this.cmB_HorizAxesResidualPlot.Name = "cmB_HorizAxesResidualPlot";
            this.cmB_HorizAxesResidualPlot.Size = new System.Drawing.Size(210, 21);
            this.cmB_HorizAxesResidualPlot.TabIndex = 14;
            this.cmB_HorizAxesResidualPlot.Visible = false;
            this.cmB_HorizAxesResidualPlot.SelectedIndexChanged += new System.EventHandler(this.cmB_HorizAxesResidualPlot_SelectedIndexChanged);
            // 
            // lblHorizAxesResidualPlot
            // 
            this.lblHorizAxesResidualPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorizAxesResidualPlot.AutoSize = true;
            this.lblHorizAxesResidualPlot.Location = new System.Drawing.Point(955, 61);
            this.lblHorizAxesResidualPlot.Name = "lblHorizAxesResidualPlot";
            this.lblHorizAxesResidualPlot.Size = new System.Drawing.Size(110, 13);
            this.lblHorizAxesResidualPlot.TabIndex = 15;
            this.lblHorizAxesResidualPlot.Text = "Горизонтальна вісь:";
            this.lblHorizAxesResidualPlot.Visible = false;
            // 
            // cmB_Degree
            // 
            this.cmB_Degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_Degree.FormattingEnabled = true;
            this.cmB_Degree.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmB_Degree.Location = new System.Drawing.Point(169, 113);
            this.cmB_Degree.Name = "cmB_Degree";
            this.cmB_Degree.Size = new System.Drawing.Size(80, 21);
            this.cmB_Degree.TabIndex = 14;
            this.cmB_Degree.SelectedIndexChanged += new System.EventHandler(this.cmB_Degree_SelectedIndexChanged);
            // 
            // cln_a0
            // 
            this.cln_a0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cln_a0.HeaderText = "â₀";
            this.cln_a0.Name = "cln_a0";
            this.cln_a0.ReadOnly = true;
            this.cln_a0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cln_a0.Width = 23;
            // 
            // cln_a1
            // 
            this.cln_a1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cln_a1.HeaderText = "â₁";
            this.cln_a1.Name = "cln_a1";
            this.cln_a1.ReadOnly = true;
            this.cln_a1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cln_a1.Width = 23;
            // 
            // cln_a2
            // 
            this.cln_a2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cln_a2.HeaderText = "â₂";
            this.cln_a2.Name = "cln_a2";
            this.cln_a2.ReadOnly = true;
            this.cln_a2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cln_a2.Visible = false;
            this.cln_a2.Width = 23;
            // 
            // cln_a3
            // 
            this.cln_a3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cln_a3.HeaderText = "â₃";
            this.cln_a3.Name = "cln_a3";
            this.cln_a3.ReadOnly = true;
            this.cln_a3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cln_a3.Width = 23;
            // 
            // cln_a4
            // 
            this.cln_a4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cln_a4.HeaderText = "â₄";
            this.cln_a4.Name = "cln_a4";
            this.cln_a4.ReadOnly = true;
            this.cln_a4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cln_a4.Width = 23;
            // 
            // cln_a5
            // 
            this.cln_a5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cln_a5.HeaderText = "â₅";
            this.cln_a5.Name = "cln_a5";
            this.cln_a5.ReadOnly = true;
            this.cln_a5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cln_a5.Width = 23;
            // 
            // cln_a6
            // 
            this.cln_a6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cln_a6.HeaderText = "â₆";
            this.cln_a6.Name = "cln_a6";
            this.cln_a6.ReadOnly = true;
            this.cln_a6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cln_a6.Width = 23;
            // 
            // cln_a7
            // 
            this.cln_a7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cln_a7.HeaderText = "â₇";
            this.cln_a7.Name = "cln_a7";
            this.cln_a7.ReadOnly = true;
            this.cln_a7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cln_a7.Width = 23;
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(142, 116);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(21, 13);
            this.lblDegree.TabIndex = 15;
            this.lblDegree.Text = "i = ";
            // 
            // frmRegression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 559);
            this.Controls.Add(this.lblHorizAxesResidualPlot);
            this.Controls.Add(this.cmB_HorizAxesResidualPlot);
            this.Controls.Add(this.lblCurrFile);
            this.Controls.Add(this.txB_CurrFile);
            this.Controls.Add(this.rdB_ResidualPlot);
            this.Controls.Add(this.rdB_ScatterPlot);
            this.Controls.Add(this.grB_RestorationRegression);
            this.Controls.Add(this.grB_CorrelationCoefficients);
            this.Controls.Add(this.dGV_Data);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.chtScatterPlot);
            this.Controls.Add(this.chtResidualPlot);
            this.Name = "frmRegression";
            this.Text = "Визначення кореляції. Відновлення одновимірної регресії";
            this.Load += new System.EventHandler(this.frmRegression_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtScatterPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_RestoreRegression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CorrelationCoefficients)).EndInit();
            this.grB_CorrelationCoefficients.ResumeLayout(false);
            this.grB_CorrelationCoefficients.PerformLayout();
            this.grB_RestorationRegression.ResumeLayout(false);
            this.grB_RestorationRegression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtResidualPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtScatterPlot;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dGV_Data;
        private System.Windows.Forms.DataGridView dGV_RestoreRegression;
        private System.Windows.Forms.DataGridView dGV_CorrelationCoefficients;
        private System.Windows.Forms.Label lblAljfaForRestoration;
        private System.Windows.Forms.TextBox txB_AljfaForRestoration;
        private System.Windows.Forms.Button btnRestoreLinearRegression;
        private System.Windows.Forms.GroupBox grB_CorrelationCoefficients;
        private System.Windows.Forms.TextBox txB_AljfaForCoefs;
        private System.Windows.Forms.Label lblAljfaForCoefs;
        private System.Windows.Forms.GroupBox grB_RestorationRegression;
        private System.Windows.Forms.RadioButton rdB_ScatterPlot;
        private System.Windows.Forms.RadioButton rdB_ResidualPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtResidualPlot;
        private System.Windows.Forms.TextBox txB_y;
        private System.Windows.Forms.TextBox txB_x;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValueCoef;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatCoef;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantileCoef;
        private System.Windows.Forms.DataGridViewTextBoxColumn сlnSignifCoef;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnInterval;
        private System.Windows.Forms.Button btnRestorePolinomRegression;
        private System.Windows.Forms.Button btnReCalcCoefs;
        private System.Windows.Forms.Label lblInfoForAljfaForCoefs;
        private System.Windows.Forms.OpenFileDialog oFD_LoaderDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnY;
        private System.Windows.Forms.TextBox txB_CurrFile;
        private System.Windows.Forms.Label lblCurrFile;
        private System.Windows.Forms.Label lblInfoAboutRestoreRegression;
        private System.Windows.Forms.ComboBox cmB_HorizAxesResidualPlot;
        private System.Windows.Forms.Label lblHorizAxesResidualPlot;
        private System.Windows.Forms.ComboBox cmB_Degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_a0;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_a1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_a2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_a3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_a4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_a5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_a6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_a7;
        private System.Windows.Forms.Label lblDegree;
    }
}

