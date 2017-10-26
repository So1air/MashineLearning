namespace MashineLearning.Clusterization
{
    partial class frmMashineLearning
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbC_Main = new System.Windows.Forms.TabControl();
            this.tbP_Prep_a_Launch_Clusterization = new System.Windows.Forms.TabPage();
            this.pnlSampling = new System.Windows.Forms.Panel();
            this.pcB_ViewImages = new System.Windows.Forms.PictureBox();
            this.lblViewImages = new System.Windows.Forms.Label();
            this.lblDimensionality = new System.Windows.Forms.Label();
            this.btnCreateSetOfImages = new System.Windows.Forms.Button();
            this.btnLoadImages = new System.Windows.Forms.Button();
            this.cLB_Objects = new System.Windows.Forms.CheckedListBox();
            this.cmB_Dimensionality = new System.Windows.Forms.ComboBox();
            this.grB_ClusterizationSettings = new System.Windows.Forms.GroupBox();
            this.txB_CountClusters = new System.Windows.Forms.TextBox();
            this.lblCountClusters = new System.Windows.Forms.Label();
            this.btnClusterize = new System.Windows.Forms.Button();
            this.lblSetOfImages = new System.Windows.Forms.Label();
            this.ltB_SetsOfImages = new System.Windows.Forms.ListBox();
            this.grB_TypeDistance = new System.Windows.Forms.GroupBox();
            this.rdB_Ward = new System.Windows.Forms.RadioButton();
            this.rdB_Median = new System.Windows.Forms.RadioButton();
            this.rdB_AverageLinkage = new System.Windows.Forms.RadioButton();
            this.rdB_CompleteLinkage = new System.Windows.Forms.RadioButton();
            this.rdB_SingleLinkage = new System.Windows.Forms.RadioButton();
            this.grB_MethodsClusterization = new System.Windows.Forms.GroupBox();
            this.rdB_KRAB = new System.Windows.Forms.RadioButton();
            this.rdB_FOREL2 = new System.Windows.Forms.RadioButton();
            this.rdB_KmeansByMacQueen = new System.Windows.Forms.RadioButton();
            this.rdB_KmeansByLloyd = new System.Windows.Forms.RadioButton();
            this.rdB_HierarchicalAgglomerativeMethod = new System.Windows.Forms.RadioButton();
            this.tbP_ResultsClusterization = new System.Windows.Forms.TabPage();
            this.tbC_Results = new System.Windows.Forms.TabControl();
            this.tbP_Dendrogram = new System.Windows.Forms.TabPage();
            this.chtDendrogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbP_Predetermined_number_of_clusters = new System.Windows.Forms.TabPage();
            this.lblFunctionals = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblViewObject = new System.Windows.Forms.Label();
            this.pcB_ViewObject = new System.Windows.Forms.PictureBox();
            this.ltB_ObjectsInCluster = new System.Windows.Forms.ListBox();
            this.btnChangeLabelCluster = new System.Windows.Forms.Button();
            this.lblCluster = new System.Windows.Forms.Label();
            this.cmB_Clusters = new System.Windows.Forms.ComboBox();
            this.oFD_Loader = new System.Windows.Forms.OpenFileDialog();
            this.tbC_Main.SuspendLayout();
            this.tbP_Prep_a_Launch_Clusterization.SuspendLayout();
            this.pnlSampling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_ViewImages)).BeginInit();
            this.grB_ClusterizationSettings.SuspendLayout();
            this.grB_TypeDistance.SuspendLayout();
            this.grB_MethodsClusterization.SuspendLayout();
            this.tbP_ResultsClusterization.SuspendLayout();
            this.tbC_Results.SuspendLayout();
            this.tbP_Dendrogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDendrogram)).BeginInit();
            this.tbP_Predetermined_number_of_clusters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_ViewObject)).BeginInit();
            this.SuspendLayout();
            // 
            // tbC_Main
            // 
            this.tbC_Main.Controls.Add(this.tbP_Prep_a_Launch_Clusterization);
            this.tbC_Main.Controls.Add(this.tbP_ResultsClusterization);
            this.tbC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbC_Main.Location = new System.Drawing.Point(0, 0);
            this.tbC_Main.Name = "tbC_Main";
            this.tbC_Main.SelectedIndex = 0;
            this.tbC_Main.Size = new System.Drawing.Size(1170, 540);
            this.tbC_Main.TabIndex = 0;
            // 
            // tbP_Prep_a_Launch_Clusterization
            // 
            this.tbP_Prep_a_Launch_Clusterization.Controls.Add(this.pnlSampling);
            this.tbP_Prep_a_Launch_Clusterization.Controls.Add(this.grB_ClusterizationSettings);
            this.tbP_Prep_a_Launch_Clusterization.Location = new System.Drawing.Point(4, 22);
            this.tbP_Prep_a_Launch_Clusterization.Name = "tbP_Prep_a_Launch_Clusterization";
            this.tbP_Prep_a_Launch_Clusterization.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_Prep_a_Launch_Clusterization.Size = new System.Drawing.Size(1162, 514);
            this.tbP_Prep_a_Launch_Clusterization.TabIndex = 0;
            this.tbP_Prep_a_Launch_Clusterization.Text = "Підготовка та запуск кластеризації";
            this.tbP_Prep_a_Launch_Clusterization.UseVisualStyleBackColor = true;
            // 
            // pnlSampling
            // 
            this.pnlSampling.Controls.Add(this.pcB_ViewImages);
            this.pnlSampling.Controls.Add(this.lblViewImages);
            this.pnlSampling.Controls.Add(this.lblDimensionality);
            this.pnlSampling.Controls.Add(this.btnCreateSetOfImages);
            this.pnlSampling.Controls.Add(this.btnLoadImages);
            this.pnlSampling.Controls.Add(this.cLB_Objects);
            this.pnlSampling.Controls.Add(this.cmB_Dimensionality);
            this.pnlSampling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSampling.Location = new System.Drawing.Point(3, 3);
            this.pnlSampling.Name = "pnlSampling";
            this.pnlSampling.Size = new System.Drawing.Size(816, 508);
            this.pnlSampling.TabIndex = 0;
            // 
            // pcB_ViewImages
            // 
            this.pcB_ViewImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcB_ViewImages.Location = new System.Drawing.Point(282, 34);
            this.pcB_ViewImages.MaximumSize = new System.Drawing.Size(400, 400);
            this.pcB_ViewImages.Name = "pcB_ViewImages";
            this.pcB_ViewImages.Size = new System.Drawing.Size(400, 400);
            this.pcB_ViewImages.TabIndex = 6;
            this.pcB_ViewImages.TabStop = false;
            // 
            // lblViewImages
            // 
            this.lblViewImages.AutoSize = true;
            this.lblViewImages.Location = new System.Drawing.Point(279, 14);
            this.lblViewImages.Name = "lblViewImages";
            this.lblViewImages.Size = new System.Drawing.Size(118, 13);
            this.lblViewImages.TabIndex = 5;
            this.lblViewImages.Text = "Попередній перегляд:";
            // 
            // lblDimensionality
            // 
            this.lblDimensionality.AutoSize = true;
            this.lblDimensionality.Location = new System.Drawing.Point(20, 14);
            this.lblDimensionality.Name = "lblDimensionality";
            this.lblDimensionality.Size = new System.Drawing.Size(70, 13);
            this.lblDimensionality.TabIndex = 4;
            this.lblDimensionality.Text = "Розмірність:";
            // 
            // btnCreateSetOfImages
            // 
            this.btnCreateSetOfImages.Location = new System.Drawing.Point(23, 449);
            this.btnCreateSetOfImages.Name = "btnCreateSetOfImages";
            this.btnCreateSetOfImages.Size = new System.Drawing.Size(235, 23);
            this.btnCreateSetOfImages.TabIndex = 3;
            this.btnCreateSetOfImages.Text = "Сформувати вибірку";
            this.btnCreateSetOfImages.UseVisualStyleBackColor = true;
            this.btnCreateSetOfImages.Click += new System.EventHandler(this.btnCreateSetOfImages_Click);
            // 
            // btnLoadImages
            // 
            this.btnLoadImages.Location = new System.Drawing.Point(282, 449);
            this.btnLoadImages.Name = "btnLoadImages";
            this.btnLoadImages.Size = new System.Drawing.Size(155, 23);
            this.btnLoadImages.TabIndex = 2;
            this.btnLoadImages.Text = "Завантажити нові образи";
            this.btnLoadImages.UseVisualStyleBackColor = true;
            this.btnLoadImages.Click += new System.EventHandler(this.btnLoadImages_Click);
            // 
            // cLB_Objects
            // 
            this.cLB_Objects.FormattingEnabled = true;
            this.cLB_Objects.Location = new System.Drawing.Point(23, 57);
            this.cLB_Objects.Name = "cLB_Objects";
            this.cLB_Objects.Size = new System.Drawing.Size(235, 364);
            this.cLB_Objects.TabIndex = 1;
            this.cLB_Objects.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cLB_Objects_MouseClick);
            this.cLB_Objects.SelectedIndexChanged += new System.EventHandler(this.cLB_Objects_SelectedIndexChanged);
            this.cLB_Objects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cLB_Objects_KeyDown);
            this.cLB_Objects.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cLB_Objects_KeyUp);
            // 
            // cmB_Dimensionality
            // 
            this.cmB_Dimensionality.FormattingEnabled = true;
            this.cmB_Dimensionality.Location = new System.Drawing.Point(23, 30);
            this.cmB_Dimensionality.Name = "cmB_Dimensionality";
            this.cmB_Dimensionality.Size = new System.Drawing.Size(235, 21);
            this.cmB_Dimensionality.TabIndex = 0;
            this.cmB_Dimensionality.SelectedIndexChanged += new System.EventHandler(this.cmB_Dimensionality_SelectedIndexChanged);
            // 
            // grB_ClusterizationSettings
            // 
            this.grB_ClusterizationSettings.Controls.Add(this.txB_CountClusters);
            this.grB_ClusterizationSettings.Controls.Add(this.lblCountClusters);
            this.grB_ClusterizationSettings.Controls.Add(this.btnClusterize);
            this.grB_ClusterizationSettings.Controls.Add(this.lblSetOfImages);
            this.grB_ClusterizationSettings.Controls.Add(this.ltB_SetsOfImages);
            this.grB_ClusterizationSettings.Controls.Add(this.grB_TypeDistance);
            this.grB_ClusterizationSettings.Controls.Add(this.grB_MethodsClusterization);
            this.grB_ClusterizationSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.grB_ClusterizationSettings.Location = new System.Drawing.Point(819, 3);
            this.grB_ClusterizationSettings.Name = "grB_ClusterizationSettings";
            this.grB_ClusterizationSettings.Size = new System.Drawing.Size(340, 508);
            this.grB_ClusterizationSettings.TabIndex = 1;
            this.grB_ClusterizationSettings.TabStop = false;
            this.grB_ClusterizationSettings.Text = "Установки кластеризації";
            // 
            // txB_CountClusters
            // 
            this.txB_CountClusters.Location = new System.Drawing.Point(234, 238);
            this.txB_CountClusters.Name = "txB_CountClusters";
            this.txB_CountClusters.Size = new System.Drawing.Size(100, 20);
            this.txB_CountClusters.TabIndex = 9;
            this.txB_CountClusters.Text = "10";
            this.txB_CountClusters.Visible = false;
            this.txB_CountClusters.Validated += new System.EventHandler(this.txB_CountClusters_Validated);
            // 
            // lblCountClusters
            // 
            this.lblCountClusters.AutoSize = true;
            this.lblCountClusters.Location = new System.Drawing.Point(10, 238);
            this.lblCountClusters.Name = "lblCountClusters";
            this.lblCountClusters.Size = new System.Drawing.Size(108, 13);
            this.lblCountClusters.TabIndex = 8;
            this.lblCountClusters.Text = "Кількість кластерів:";
            this.lblCountClusters.Visible = false;
            // 
            // btnClusterize
            // 
            this.btnClusterize.Location = new System.Drawing.Point(12, 449);
            this.btnClusterize.Name = "btnClusterize";
            this.btnClusterize.Size = new System.Drawing.Size(322, 23);
            this.btnClusterize.TabIndex = 7;
            this.btnClusterize.Text = "Кластеризувати";
            this.btnClusterize.UseVisualStyleBackColor = true;
            this.btnClusterize.Click += new System.EventHandler(this.btnClusterize_Click);
            // 
            // lblSetOfImages
            // 
            this.lblSetOfImages.AutoSize = true;
            this.lblSetOfImages.Location = new System.Drawing.Point(9, 16);
            this.lblSetOfImages.Name = "lblSetOfImages";
            this.lblSetOfImages.Size = new System.Drawing.Size(49, 13);
            this.lblSetOfImages.TabIndex = 6;
            this.lblSetOfImages.Text = "Вибірка:";
            // 
            // ltB_SetsOfImages
            // 
            this.ltB_SetsOfImages.FormattingEnabled = true;
            this.ltB_SetsOfImages.Location = new System.Drawing.Point(12, 30);
            this.ltB_SetsOfImages.Name = "ltB_SetsOfImages";
            this.ltB_SetsOfImages.Size = new System.Drawing.Size(322, 69);
            this.ltB_SetsOfImages.TabIndex = 2;
            this.ltB_SetsOfImages.SelectedIndexChanged += new System.EventHandler(this.ltB_SetsOfImages_SelectedIndexChanged);
            // 
            // grB_TypeDistance
            // 
            this.grB_TypeDistance.Controls.Add(this.rdB_Ward);
            this.grB_TypeDistance.Controls.Add(this.rdB_Median);
            this.grB_TypeDistance.Controls.Add(this.rdB_AverageLinkage);
            this.grB_TypeDistance.Controls.Add(this.rdB_CompleteLinkage);
            this.grB_TypeDistance.Controls.Add(this.rdB_SingleLinkage);
            this.grB_TypeDistance.Location = new System.Drawing.Point(13, 266);
            this.grB_TypeDistance.Name = "grB_TypeDistance";
            this.grB_TypeDistance.Size = new System.Drawing.Size(322, 113);
            this.grB_TypeDistance.TabIndex = 1;
            this.grB_TypeDistance.TabStop = false;
            this.grB_TypeDistance.Text = "Тип відстані між кластерами";
            // 
            // rdB_Ward
            // 
            this.rdB_Ward.AutoSize = true;
            this.rdB_Ward.Location = new System.Drawing.Point(6, 87);
            this.rdB_Ward.Name = "rdB_Ward";
            this.rdB_Ward.Size = new System.Drawing.Size(57, 17);
            this.rdB_Ward.TabIndex = 4;
            this.rdB_Ward.Text = "Уорда";
            this.rdB_Ward.UseVisualStyleBackColor = true;
            // 
            // rdB_Median
            // 
            this.rdB_Median.AutoSize = true;
            this.rdB_Median.Location = new System.Drawing.Point(6, 70);
            this.rdB_Median.Name = "rdB_Median";
            this.rdB_Median.Size = new System.Drawing.Size(71, 17);
            this.rdB_Median.TabIndex = 3;
            this.rdB_Median.Text = "медіанна";
            this.rdB_Median.UseVisualStyleBackColor = true;
            // 
            // rdB_AverageLinkage
            // 
            this.rdB_AverageLinkage.AutoSize = true;
            this.rdB_AverageLinkage.Location = new System.Drawing.Point(6, 53);
            this.rdB_AverageLinkage.Name = "rdB_AverageLinkage";
            this.rdB_AverageLinkage.Size = new System.Drawing.Size(114, 17);
            this.rdB_AverageLinkage.TabIndex = 2;
            this.rdB_AverageLinkage.Text = "середня зважена";
            this.rdB_AverageLinkage.UseVisualStyleBackColor = true;
            // 
            // rdB_CompleteLinkage
            // 
            this.rdB_CompleteLinkage.AutoSize = true;
            this.rdB_CompleteLinkage.Checked = true;
            this.rdB_CompleteLinkage.Location = new System.Drawing.Point(6, 36);
            this.rdB_CompleteLinkage.Name = "rdB_CompleteLinkage";
            this.rdB_CompleteLinkage.Size = new System.Drawing.Size(148, 17);
            this.rdB_CompleteLinkage.TabIndex = 1;
            this.rdB_CompleteLinkage.TabStop = true;
            this.rdB_CompleteLinkage.Text = "найвіддаленішого сусіда";
            this.rdB_CompleteLinkage.UseVisualStyleBackColor = true;
            // 
            // rdB_SingleLinkage
            // 
            this.rdB_SingleLinkage.AutoSize = true;
            this.rdB_SingleLinkage.Location = new System.Drawing.Point(6, 19);
            this.rdB_SingleLinkage.Name = "rdB_SingleLinkage";
            this.rdB_SingleLinkage.Size = new System.Drawing.Size(125, 17);
            this.rdB_SingleLinkage.TabIndex = 0;
            this.rdB_SingleLinkage.Text = "найближчого сусіда";
            this.rdB_SingleLinkage.UseVisualStyleBackColor = true;
            // 
            // grB_MethodsClusterization
            // 
            this.grB_MethodsClusterization.Controls.Add(this.rdB_KRAB);
            this.grB_MethodsClusterization.Controls.Add(this.rdB_FOREL2);
            this.grB_MethodsClusterization.Controls.Add(this.rdB_KmeansByMacQueen);
            this.grB_MethodsClusterization.Controls.Add(this.rdB_KmeansByLloyd);
            this.grB_MethodsClusterization.Controls.Add(this.rdB_HierarchicalAgglomerativeMethod);
            this.grB_MethodsClusterization.Location = new System.Drawing.Point(12, 105);
            this.grB_MethodsClusterization.Name = "grB_MethodsClusterization";
            this.grB_MethodsClusterization.Size = new System.Drawing.Size(322, 120);
            this.grB_MethodsClusterization.TabIndex = 0;
            this.grB_MethodsClusterization.TabStop = false;
            this.grB_MethodsClusterization.Text = "Метод кластеризації";
            // 
            // rdB_KRAB
            // 
            this.rdB_KRAB.AutoSize = true;
            this.rdB_KRAB.Enabled = false;
            this.rdB_KRAB.Location = new System.Drawing.Point(21, 91);
            this.rdB_KRAB.Name = "rdB_KRAB";
            this.rdB_KRAB.Size = new System.Drawing.Size(143, 17);
            this.rdB_KRAB.TabIndex = 5;
            this.rdB_KRAB.Text = "KRAB(не реалізований)";
            this.rdB_KRAB.UseVisualStyleBackColor = true;
            // 
            // rdB_FOREL2
            // 
            this.rdB_FOREL2.AutoSize = true;
            this.rdB_FOREL2.Enabled = false;
            this.rdB_FOREL2.Location = new System.Drawing.Point(21, 73);
            this.rdB_FOREL2.Name = "rdB_FOREL2";
            this.rdB_FOREL2.Size = new System.Drawing.Size(141, 17);
            this.rdB_FOREL2.TabIndex = 4;
            this.rdB_FOREL2.Text = "FOREL 2(має помилку)";
            this.rdB_FOREL2.UseVisualStyleBackColor = true;
            // 
            // rdB_KmeansByMacQueen
            // 
            this.rdB_KmeansByMacQueen.AutoSize = true;
            this.rdB_KmeansByMacQueen.Location = new System.Drawing.Point(21, 55);
            this.rdB_KmeansByMacQueen.Name = "rdB_KmeansByMacQueen";
            this.rdB_KmeansByMacQueen.Size = new System.Drawing.Size(126, 17);
            this.rdB_KmeansByMacQueen.TabIndex = 3;
            this.rdB_KmeansByMacQueen.Text = "К-середніх Мак-Кіна";
            this.rdB_KmeansByMacQueen.UseVisualStyleBackColor = true;
            // 
            // rdB_KmeansByLloyd
            // 
            this.rdB_KmeansByLloyd.AutoSize = true;
            this.rdB_KmeansByLloyd.Location = new System.Drawing.Point(21, 37);
            this.rdB_KmeansByLloyd.Name = "rdB_KmeansByLloyd";
            this.rdB_KmeansByLloyd.Size = new System.Drawing.Size(119, 17);
            this.rdB_KmeansByLloyd.TabIndex = 2;
            this.rdB_KmeansByLloyd.Text = "К-середніх Ллойда";
            this.rdB_KmeansByLloyd.UseVisualStyleBackColor = true;
            // 
            // rdB_HierarchicalAgglomerativeMethod
            // 
            this.rdB_HierarchicalAgglomerativeMethod.AutoSize = true;
            this.rdB_HierarchicalAgglomerativeMethod.Checked = true;
            this.rdB_HierarchicalAgglomerativeMethod.Location = new System.Drawing.Point(21, 19);
            this.rdB_HierarchicalAgglomerativeMethod.Name = "rdB_HierarchicalAgglomerativeMethod";
            this.rdB_HierarchicalAgglomerativeMethod.Size = new System.Drawing.Size(169, 17);
            this.rdB_HierarchicalAgglomerativeMethod.TabIndex = 1;
            this.rdB_HierarchicalAgglomerativeMethod.TabStop = true;
            this.rdB_HierarchicalAgglomerativeMethod.Text = "Ієрархічний агломеративний";
            this.rdB_HierarchicalAgglomerativeMethod.UseVisualStyleBackColor = true;
            this.rdB_HierarchicalAgglomerativeMethod.CheckedChanged += new System.EventHandler(this.rdB_HierarchicalAgglomerativeMethod_CheckedChanged);
            // 
            // tbP_ResultsClusterization
            // 
            this.tbP_ResultsClusterization.Controls.Add(this.tbC_Results);
            this.tbP_ResultsClusterization.Location = new System.Drawing.Point(4, 22);
            this.tbP_ResultsClusterization.Name = "tbP_ResultsClusterization";
            this.tbP_ResultsClusterization.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_ResultsClusterization.Size = new System.Drawing.Size(1162, 514);
            this.tbP_ResultsClusterization.TabIndex = 1;
            this.tbP_ResultsClusterization.Text = "Результати кластеризації";
            this.tbP_ResultsClusterization.UseVisualStyleBackColor = true;
            // 
            // tbC_Results
            // 
            this.tbC_Results.Controls.Add(this.tbP_Dendrogram);
            this.tbC_Results.Controls.Add(this.tbP_Predetermined_number_of_clusters);
            this.tbC_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbC_Results.Location = new System.Drawing.Point(3, 3);
            this.tbC_Results.Name = "tbC_Results";
            this.tbC_Results.SelectedIndex = 0;
            this.tbC_Results.Size = new System.Drawing.Size(1156, 508);
            this.tbC_Results.TabIndex = 0;
            // 
            // tbP_Dendrogram
            // 
            this.tbP_Dendrogram.Controls.Add(this.chtDendrogram);
            this.tbP_Dendrogram.Location = new System.Drawing.Point(4, 22);
            this.tbP_Dendrogram.Name = "tbP_Dendrogram";
            this.tbP_Dendrogram.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_Dendrogram.Size = new System.Drawing.Size(1148, 482);
            this.tbP_Dendrogram.TabIndex = 0;
            this.tbP_Dendrogram.Text = "Дендрогама";
            this.tbP_Dendrogram.UseVisualStyleBackColor = true;
            // 
            // chtDendrogram
            // 
            this.chtDendrogram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.Size = 0.5F;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.Size = 0.5F;
            chartArea1.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.Name = "ChartArea1";
            this.chtDendrogram.ChartAreas.Add(chartArea1);
            this.chtDendrogram.Location = new System.Drawing.Point(6, 6);
            this.chtDendrogram.Name = "chtDendrogram";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "srs";
            this.chtDendrogram.Series.Add(series1);
            this.chtDendrogram.Size = new System.Drawing.Size(975, 470);
            this.chtDendrogram.TabIndex = 0;
            // 
            // tbP_Predetermined_number_of_clusters
            // 
            this.tbP_Predetermined_number_of_clusters.Controls.Add(this.lblFunctionals);
            this.tbP_Predetermined_number_of_clusters.Controls.Add(this.lblInfo);
            this.tbP_Predetermined_number_of_clusters.Controls.Add(this.lblViewObject);
            this.tbP_Predetermined_number_of_clusters.Controls.Add(this.pcB_ViewObject);
            this.tbP_Predetermined_number_of_clusters.Controls.Add(this.ltB_ObjectsInCluster);
            this.tbP_Predetermined_number_of_clusters.Controls.Add(this.btnChangeLabelCluster);
            this.tbP_Predetermined_number_of_clusters.Controls.Add(this.lblCluster);
            this.tbP_Predetermined_number_of_clusters.Controls.Add(this.cmB_Clusters);
            this.tbP_Predetermined_number_of_clusters.Location = new System.Drawing.Point(4, 22);
            this.tbP_Predetermined_number_of_clusters.Name = "tbP_Predetermined_number_of_clusters";
            this.tbP_Predetermined_number_of_clusters.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_Predetermined_number_of_clusters.Size = new System.Drawing.Size(1148, 482);
            this.tbP_Predetermined_number_of_clusters.TabIndex = 1;
            this.tbP_Predetermined_number_of_clusters.Text = "Результати розбиття на визначену кількість кластерів";
            this.tbP_Predetermined_number_of_clusters.UseVisualStyleBackColor = true;
            // 
            // lblFunctionals
            // 
            this.lblFunctionals.AutoSize = true;
            this.lblFunctionals.Location = new System.Drawing.Point(539, 74);
            this.lblFunctionals.Name = "lblFunctionals";
            this.lblFunctionals.Size = new System.Drawing.Size(35, 13);
            this.lblFunctionals.TabIndex = 7;
            this.lblFunctionals.Text = "label7";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(17, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "label6";
            // 
            // lblViewObject
            // 
            this.lblViewObject.AutoSize = true;
            this.lblViewObject.Location = new System.Drawing.Point(191, 58);
            this.lblViewObject.Name = "lblViewObject";
            this.lblViewObject.Size = new System.Drawing.Size(99, 13);
            this.lblViewObject.TabIndex = 5;
            this.lblViewObject.Text = "Перегляд об\'єкта:";
            // 
            // pcB_ViewObject
            // 
            this.pcB_ViewObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcB_ViewObject.Location = new System.Drawing.Point(194, 74);
            this.pcB_ViewObject.MaximumSize = new System.Drawing.Size(300, 300);
            this.pcB_ViewObject.Name = "pcB_ViewObject";
            this.pcB_ViewObject.Size = new System.Drawing.Size(300, 300);
            this.pcB_ViewObject.TabIndex = 4;
            this.pcB_ViewObject.TabStop = false;
            // 
            // ltB_ObjectsInCluster
            // 
            this.ltB_ObjectsInCluster.FormattingEnabled = true;
            this.ltB_ObjectsInCluster.Location = new System.Drawing.Point(20, 129);
            this.ltB_ObjectsInCluster.Name = "ltB_ObjectsInCluster";
            this.ltB_ObjectsInCluster.Size = new System.Drawing.Size(153, 316);
            this.ltB_ObjectsInCluster.TabIndex = 3;
            this.ltB_ObjectsInCluster.SelectedIndexChanged += new System.EventHandler(this.ltB_ObjectsInCluster_SelectedIndexChanged);
            // 
            // btnChangeLabelCluster
            // 
            this.btnChangeLabelCluster.Location = new System.Drawing.Point(20, 98);
            this.btnChangeLabelCluster.Name = "btnChangeLabelCluster";
            this.btnChangeLabelCluster.Size = new System.Drawing.Size(153, 23);
            this.btnChangeLabelCluster.TabIndex = 2;
            this.btnChangeLabelCluster.Text = "Змінити мітку кластера";
            this.btnChangeLabelCluster.UseVisualStyleBackColor = true;
            this.btnChangeLabelCluster.Click += new System.EventHandler(this.btnChangeLabelCluster_Click);
            // 
            // lblCluster
            // 
            this.lblCluster.AutoSize = true;
            this.lblCluster.Location = new System.Drawing.Point(17, 58);
            this.lblCluster.Name = "lblCluster";
            this.lblCluster.Size = new System.Drawing.Size(52, 13);
            this.lblCluster.TabIndex = 1;
            this.lblCluster.Text = "Кластер:";
            // 
            // cmB_Clusters
            // 
            this.cmB_Clusters.FormattingEnabled = true;
            this.cmB_Clusters.Location = new System.Drawing.Point(20, 74);
            this.cmB_Clusters.Name = "cmB_Clusters";
            this.cmB_Clusters.Size = new System.Drawing.Size(153, 21);
            this.cmB_Clusters.TabIndex = 0;
            this.cmB_Clusters.SelectedIndexChanged += new System.EventHandler(this.cmB_Clusters_SelectedIndexChanged);
            // 
            // oFD_Loader
            // 
            this.oFD_Loader.DefaultExt = "txt";
            this.oFD_Loader.Filter = "Текстові файли|*.txt";
            this.oFD_Loader.InitialDirectory = ".";
            this.oFD_Loader.Title = "Оберіть коректний файл з образами";
            // 
            // frmMashineLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 540);
            this.Controls.Add(this.tbC_Main);
            this.Name = "frmMashineLearning";
            this.Text = "Кластеризація символів";
            this.tbC_Main.ResumeLayout(false);
            this.tbP_Prep_a_Launch_Clusterization.ResumeLayout(false);
            this.pnlSampling.ResumeLayout(false);
            this.pnlSampling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_ViewImages)).EndInit();
            this.grB_ClusterizationSettings.ResumeLayout(false);
            this.grB_ClusterizationSettings.PerformLayout();
            this.grB_TypeDistance.ResumeLayout(false);
            this.grB_TypeDistance.PerformLayout();
            this.grB_MethodsClusterization.ResumeLayout(false);
            this.grB_MethodsClusterization.PerformLayout();
            this.tbP_ResultsClusterization.ResumeLayout(false);
            this.tbC_Results.ResumeLayout(false);
            this.tbP_Dendrogram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtDendrogram)).EndInit();
            this.tbP_Predetermined_number_of_clusters.ResumeLayout(false);
            this.tbP_Predetermined_number_of_clusters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_ViewObject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbC_Main;
        private System.Windows.Forms.TabPage tbP_Prep_a_Launch_Clusterization;
        private System.Windows.Forms.Panel pnlSampling;
        private System.Windows.Forms.PictureBox pcB_ViewImages;
        private System.Windows.Forms.Label lblViewImages;
        private System.Windows.Forms.Label lblDimensionality;
        private System.Windows.Forms.Button btnCreateSetOfImages;
        private System.Windows.Forms.Button btnLoadImages;
        private System.Windows.Forms.CheckedListBox cLB_Objects;
        private System.Windows.Forms.ComboBox cmB_Dimensionality;
        private System.Windows.Forms.GroupBox grB_ClusterizationSettings;
        private System.Windows.Forms.Button btnClusterize;
        private System.Windows.Forms.Label lblSetOfImages;
        private System.Windows.Forms.ListBox ltB_SetsOfImages;
        private System.Windows.Forms.GroupBox grB_TypeDistance;
        private System.Windows.Forms.GroupBox grB_MethodsClusterization;
        private System.Windows.Forms.TabPage tbP_ResultsClusterization;
        private System.Windows.Forms.TabControl tbC_Results;
        private System.Windows.Forms.TabPage tbP_Dendrogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDendrogram;
        private System.Windows.Forms.TabPage tbP_Predetermined_number_of_clusters;
        private System.Windows.Forms.Label lblFunctionals;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblViewObject;
        private System.Windows.Forms.PictureBox pcB_ViewObject;
        private System.Windows.Forms.ListBox ltB_ObjectsInCluster;
        private System.Windows.Forms.Button btnChangeLabelCluster;
        private System.Windows.Forms.Label lblCluster;
        private System.Windows.Forms.ComboBox cmB_Clusters;
        private System.Windows.Forms.TextBox txB_CountClusters;
        private System.Windows.Forms.Label lblCountClusters;
        private System.Windows.Forms.RadioButton rdB_SingleLinkage;
        private System.Windows.Forms.RadioButton rdB_Ward;
        private System.Windows.Forms.RadioButton rdB_Median;
        private System.Windows.Forms.RadioButton rdB_AverageLinkage;
        private System.Windows.Forms.RadioButton rdB_CompleteLinkage;
        private System.Windows.Forms.RadioButton rdB_KRAB;
        private System.Windows.Forms.RadioButton rdB_FOREL2;
        private System.Windows.Forms.RadioButton rdB_KmeansByMacQueen;
        private System.Windows.Forms.RadioButton rdB_KmeansByLloyd;
        private System.Windows.Forms.RadioButton rdB_HierarchicalAgglomerativeMethod;
        private System.Windows.Forms.OpenFileDialog oFD_Loader;

    }
}

