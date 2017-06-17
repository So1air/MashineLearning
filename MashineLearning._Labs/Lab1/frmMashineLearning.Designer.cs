namespace MashineLearning.Classification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMashineLearning));
            this.tbC_Main = new System.Windows.Forms.TabControl();
            this.tbP_LearnAndTestImages = new System.Windows.Forms.TabPage();
            this.btnCancelIm = new System.Windows.Forms.Button();
            this.btnAcceptIm = new System.Windows.Forms.Button();
            this.txB_NumChooseIm = new System.Windows.Forms.TextBox();
            this.lblCursorPosInMatrCoord = new System.Windows.Forms.Label();
            this.lblCurrMatrCoord = new System.Windows.Forms.Label();
            this.btnDeleteIm = new System.Windows.Forms.Button();
            this.btnChangeIm = new System.Windows.Forms.Button();
            this.nUD_ColCount = new System.Windows.Forms.NumericUpDown();
            this.lbl_ColCount = new System.Windows.Forms.Label();
            this.lbl_RowCount = new System.Windows.Forms.Label();
            this.lblParMatrix = new System.Windows.Forms.Label();
            this.nUD_RowCount = new System.Windows.Forms.NumericUpDown();
            this.pnl_SaveAndLoad = new System.Windows.Forms.Panel();
            this.chB_CheckAll = new System.Windows.Forms.CheckBox();
            this.chB_RandomOrder = new System.Windows.Forms.CheckBox();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnSaveInFile = new System.Windows.Forms.Button();
            this.cLB_ListAvalaibleImages = new System.Windows.Forms.CheckedListBox();
            this.lblListAvalaibleImages = new System.Windows.Forms.Label();
            this.grB_AddModel = new System.Windows.Forms.GroupBox();
            this.lblStatusNameModel = new System.Windows.Forms.Label();
            this.lbl_NameTypeModel = new System.Windows.Forms.Label();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.txB_NameTypeModel = new System.Windows.Forms.TextBox();
            this.grB_CreateNoisyImages = new System.Windows.Forms.GroupBox();
            this.lblStatusCreateNoisy = new System.Windows.Forms.Label();
            this.lblEpsNoisy = new System.Windows.Forms.Label();
            this.nUD_EpsNoisy = new System.Windows.Forms.NumericUpDown();
            this.nUD_CountNoisy = new System.Windows.Forms.NumericUpDown();
            this.lblCountNoisy = new System.Windows.Forms.Label();
            this.cmB_ListOfModels = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.btnCreateNoisyImage = new System.Windows.Forms.Button();
            this.dUD_ListImage = new System.Windows.Forms.DomainUpDown();
            this.pcB_Image = new System.Windows.Forms.PictureBox();
            this.tbP_SelectLearnDataAndAddClassificator = new System.Windows.Forms.TabPage();
            this.grB_EstimationQualityClassication = new System.Windows.Forms.GroupBox();
            this.lblMaxEstim = new System.Windows.Forms.Label();
            this.txB_CountParts = new System.Windows.Forms.TextBox();
            this.dGV_ResultCrossValidation = new System.Windows.Forms.DataGridView();
            this.colDGV_Iteration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сolDGV_PercentCorrectClassific = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCountParts = new System.Windows.Forms.Label();
            this.grB_SettingOfProportion = new System.Windows.Forms.GroupBox();
            this.lblPercentPartition = new System.Windows.Forms.Label();
            this.lblCountIteration = new System.Windows.Forms.Label();
            this.txB_PercentPartition = new System.Windows.Forms.TextBox();
            this.nUD_CountIteration = new System.Windows.Forms.NumericUpDown();
            this.grB_TypePartition = new System.Windows.Forms.GroupBox();
            this.rdB_SpecifiedNumber_ofParts = new System.Windows.Forms.RadioButton();
            this.rdB_SpecifiedProportion = new System.Windows.Forms.RadioButton();
            this.grB_CreateClassificator = new System.Windows.Forms.GroupBox();
            this.grB_CritSelectProperty = new System.Windows.Forms.GroupBox();
            this.rdB_C4_5 = new System.Windows.Forms.RadioButton();
            this.rdB_CART = new System.Windows.Forms.RadioButton();
            this.lblCountCheckedImsForLearning = new System.Windows.Forms.Label();
            this.grB_UsingLearnData = new System.Windows.Forms.GroupBox();
            this.rdB_CrossValidation = new System.Windows.Forms.RadioButton();
            this.rdB_AllLearnData = new System.Windows.Forms.RadioButton();
            this.pcB_DemoLearnIm = new System.Windows.Forms.PictureBox();
            this.lblStatusCreateClassificator = new System.Windows.Forms.Label();
            this.btnCreateClassificator = new System.Windows.Forms.Button();
            this.cLB_LearnImages = new System.Windows.Forms.CheckedListBox();
            this.lblDimensionality = new System.Windows.Forms.Label();
            this.cmB_Dimensionalitys = new System.Windows.Forms.ComboBox();
            this.tbP_Classification = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcB_DemoIm = new System.Windows.Forms.PictureBox();
            this.oFD_Loader = new System.Windows.Forms.OpenFileDialog();
            this.sFD_Saver = new System.Windows.Forms.SaveFileDialog();
            this.tbP_OutputTree = new System.Windows.Forms.TabPage();
            this.rTB_OutputTree = new System.Windows.Forms.RichTextBox();
            this.tbC_Main.SuspendLayout();
            this.tbP_LearnAndTestImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_ColCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_RowCount)).BeginInit();
            this.pnl_SaveAndLoad.SuspendLayout();
            this.grB_AddModel.SuspendLayout();
            this.grB_CreateNoisyImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_EpsNoisy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountNoisy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_Image)).BeginInit();
            this.tbP_SelectLearnDataAndAddClassificator.SuspendLayout();
            this.grB_EstimationQualityClassication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ResultCrossValidation)).BeginInit();
            this.grB_SettingOfProportion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountIteration)).BeginInit();
            this.grB_TypePartition.SuspendLayout();
            this.grB_CreateClassificator.SuspendLayout();
            this.grB_CritSelectProperty.SuspendLayout();
            this.grB_UsingLearnData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_DemoLearnIm)).BeginInit();
            this.tbP_Classification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_DemoIm)).BeginInit();
            this.tbP_OutputTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbC_Main
            // 
            this.tbC_Main.Controls.Add(this.tbP_LearnAndTestImages);
            this.tbC_Main.Controls.Add(this.tbP_SelectLearnDataAndAddClassificator);
            this.tbC_Main.Controls.Add(this.tbP_Classification);
            this.tbC_Main.Controls.Add(this.tbP_OutputTree);
            resources.ApplyResources(this.tbC_Main, "tbC_Main");
            this.tbC_Main.Name = "tbC_Main";
            this.tbC_Main.SelectedIndex = 0;
            // 
            // tbP_LearnAndTestImages
            // 
            this.tbP_LearnAndTestImages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbP_LearnAndTestImages.Controls.Add(this.btnCancelIm);
            this.tbP_LearnAndTestImages.Controls.Add(this.btnAcceptIm);
            this.tbP_LearnAndTestImages.Controls.Add(this.txB_NumChooseIm);
            this.tbP_LearnAndTestImages.Controls.Add(this.lblCursorPosInMatrCoord);
            this.tbP_LearnAndTestImages.Controls.Add(this.lblCurrMatrCoord);
            this.tbP_LearnAndTestImages.Controls.Add(this.btnDeleteIm);
            this.tbP_LearnAndTestImages.Controls.Add(this.btnChangeIm);
            this.tbP_LearnAndTestImages.Controls.Add(this.nUD_ColCount);
            this.tbP_LearnAndTestImages.Controls.Add(this.lbl_ColCount);
            this.tbP_LearnAndTestImages.Controls.Add(this.lbl_RowCount);
            this.tbP_LearnAndTestImages.Controls.Add(this.lblParMatrix);
            this.tbP_LearnAndTestImages.Controls.Add(this.nUD_RowCount);
            this.tbP_LearnAndTestImages.Controls.Add(this.pnl_SaveAndLoad);
            this.tbP_LearnAndTestImages.Controls.Add(this.grB_AddModel);
            this.tbP_LearnAndTestImages.Controls.Add(this.grB_CreateNoisyImages);
            this.tbP_LearnAndTestImages.Controls.Add(this.dUD_ListImage);
            this.tbP_LearnAndTestImages.Controls.Add(this.pcB_Image);
            resources.ApplyResources(this.tbP_LearnAndTestImages, "tbP_LearnAndTestImages");
            this.tbP_LearnAndTestImages.Name = "tbP_LearnAndTestImages";
            // 
            // btnCancelIm
            // 
            resources.ApplyResources(this.btnCancelIm, "btnCancelIm");
            this.btnCancelIm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelIm.Name = "btnCancelIm";
            this.btnCancelIm.UseVisualStyleBackColor = false;
            this.btnCancelIm.Click += new System.EventHandler(this.btnCancelIm_Click);
            // 
            // btnAcceptIm
            // 
            resources.ApplyResources(this.btnAcceptIm, "btnAcceptIm");
            this.btnAcceptIm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAcceptIm.Name = "btnAcceptIm";
            this.btnAcceptIm.UseVisualStyleBackColor = false;
            this.btnAcceptIm.Click += new System.EventHandler(this.btnAcceptIm_Click);
            // 
            // txB_NumChooseIm
            // 
            resources.ApplyResources(this.txB_NumChooseIm, "txB_NumChooseIm");
            this.txB_NumChooseIm.Name = "txB_NumChooseIm";
            this.txB_NumChooseIm.Enter += new System.EventHandler(this.txB_NumChooseIm_Enter);
            this.txB_NumChooseIm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txB_NumChooseIm_KeyDown);
            this.txB_NumChooseIm.Validated += new System.EventHandler(this.txB_NumChooseIm_Validated);
            // 
            // lblCursorPosInMatrCoord
            // 
            resources.ApplyResources(this.lblCursorPosInMatrCoord, "lblCursorPosInMatrCoord");
            this.lblCursorPosInMatrCoord.Name = "lblCursorPosInMatrCoord";
            // 
            // lblCurrMatrCoord
            // 
            resources.ApplyResources(this.lblCurrMatrCoord, "lblCurrMatrCoord");
            this.lblCurrMatrCoord.Name = "lblCurrMatrCoord";
            // 
            // btnDeleteIm
            // 
            resources.ApplyResources(this.btnDeleteIm, "btnDeleteIm");
            this.btnDeleteIm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteIm.Name = "btnDeleteIm";
            this.btnDeleteIm.UseVisualStyleBackColor = false;
            // 
            // btnChangeIm
            // 
            resources.ApplyResources(this.btnChangeIm, "btnChangeIm");
            this.btnChangeIm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChangeIm.Name = "btnChangeIm";
            this.btnChangeIm.UseVisualStyleBackColor = false;
            // 
            // nUD_ColCount
            // 
            resources.ApplyResources(this.nUD_ColCount, "nUD_ColCount");
            this.nUD_ColCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_ColCount.Name = "nUD_ColCount";
            this.nUD_ColCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUD_ColCount.ValueChanged += new System.EventHandler(this.nUD_RowCount_ValueChanged);
            // 
            // lbl_ColCount
            // 
            resources.ApplyResources(this.lbl_ColCount, "lbl_ColCount");
            this.lbl_ColCount.Name = "lbl_ColCount";
            // 
            // lbl_RowCount
            // 
            resources.ApplyResources(this.lbl_RowCount, "lbl_RowCount");
            this.lbl_RowCount.Name = "lbl_RowCount";
            // 
            // lblParMatrix
            // 
            resources.ApplyResources(this.lblParMatrix, "lblParMatrix");
            this.lblParMatrix.Name = "lblParMatrix";
            // 
            // nUD_RowCount
            // 
            resources.ApplyResources(this.nUD_RowCount, "nUD_RowCount");
            this.nUD_RowCount.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUD_RowCount.Name = "nUD_RowCount";
            this.nUD_RowCount.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nUD_RowCount.ValueChanged += new System.EventHandler(this.nUD_RowCount_ValueChanged);
            // 
            // pnl_SaveAndLoad
            // 
            resources.ApplyResources(this.pnl_SaveAndLoad, "pnl_SaveAndLoad");
            this.pnl_SaveAndLoad.Controls.Add(this.chB_CheckAll);
            this.pnl_SaveAndLoad.Controls.Add(this.chB_RandomOrder);
            this.pnl_SaveAndLoad.Controls.Add(this.btnLoadFromFile);
            this.pnl_SaveAndLoad.Controls.Add(this.btnSaveInFile);
            this.pnl_SaveAndLoad.Controls.Add(this.cLB_ListAvalaibleImages);
            this.pnl_SaveAndLoad.Controls.Add(this.lblListAvalaibleImages);
            this.pnl_SaveAndLoad.Name = "pnl_SaveAndLoad";
            // 
            // chB_CheckAll
            // 
            resources.ApplyResources(this.chB_CheckAll, "chB_CheckAll");
            this.chB_CheckAll.Name = "chB_CheckAll";
            this.chB_CheckAll.UseVisualStyleBackColor = true;
            this.chB_CheckAll.CheckedChanged += new System.EventHandler(this.chB_CheckAll_CheckedChanged);
            // 
            // chB_RandomOrder
            // 
            resources.ApplyResources(this.chB_RandomOrder, "chB_RandomOrder");
            this.chB_RandomOrder.Name = "chB_RandomOrder";
            this.chB_RandomOrder.UseVisualStyleBackColor = true;
            // 
            // btnLoadFromFile
            // 
            resources.ApplyResources(this.btnLoadFromFile, "btnLoadFromFile");
            this.btnLoadFromFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.UseVisualStyleBackColor = false;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnSaveInFile
            // 
            resources.ApplyResources(this.btnSaveInFile, "btnSaveInFile");
            this.btnSaveInFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveInFile.Name = "btnSaveInFile";
            this.btnSaveInFile.UseVisualStyleBackColor = false;
            this.btnSaveInFile.Click += new System.EventHandler(this.btnSaveInFile_Click);
            // 
            // cLB_ListAvalaibleImages
            // 
            resources.ApplyResources(this.cLB_ListAvalaibleImages, "cLB_ListAvalaibleImages");
            this.cLB_ListAvalaibleImages.CheckOnClick = true;
            this.cLB_ListAvalaibleImages.FormattingEnabled = true;
            this.cLB_ListAvalaibleImages.Name = "cLB_ListAvalaibleImages";
            this.cLB_ListAvalaibleImages.ThreeDCheckBoxes = true;
            this.cLB_ListAvalaibleImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cLB_MouseClick);
            this.cLB_ListAvalaibleImages.SelectedIndexChanged += new System.EventHandler(this.cLB_ListAvalaibleImages_SelectedIndexChanged);
            this.cLB_ListAvalaibleImages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cLB_KeyDown);
            this.cLB_ListAvalaibleImages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cLB_KeyUp);
            // 
            // lblListAvalaibleImages
            // 
            resources.ApplyResources(this.lblListAvalaibleImages, "lblListAvalaibleImages");
            this.lblListAvalaibleImages.Name = "lblListAvalaibleImages";
            // 
            // grB_AddModel
            // 
            this.grB_AddModel.Controls.Add(this.lblStatusNameModel);
            this.grB_AddModel.Controls.Add(this.lbl_NameTypeModel);
            this.grB_AddModel.Controls.Add(this.btnAddModel);
            this.grB_AddModel.Controls.Add(this.txB_NameTypeModel);
            this.grB_AddModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.grB_AddModel, "grB_AddModel");
            this.grB_AddModel.Name = "grB_AddModel";
            this.grB_AddModel.TabStop = false;
            // 
            // lblStatusNameModel
            // 
            resources.ApplyResources(this.lblStatusNameModel, "lblStatusNameModel");
            this.lblStatusNameModel.Name = "lblStatusNameModel";
            // 
            // lbl_NameTypeModel
            // 
            resources.ApplyResources(this.lbl_NameTypeModel, "lbl_NameTypeModel");
            this.lbl_NameTypeModel.Name = "lbl_NameTypeModel";
            // 
            // btnAddModel
            // 
            resources.ApplyResources(this.btnAddModel, "btnAddModel");
            this.btnAddModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.UseVisualStyleBackColor = false;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // txB_NameTypeModel
            // 
            resources.ApplyResources(this.txB_NameTypeModel, "txB_NameTypeModel");
            this.txB_NameTypeModel.Name = "txB_NameTypeModel";
            // 
            // grB_CreateNoisyImages
            // 
            this.grB_CreateNoisyImages.Controls.Add(this.lblStatusCreateNoisy);
            this.grB_CreateNoisyImages.Controls.Add(this.lblEpsNoisy);
            this.grB_CreateNoisyImages.Controls.Add(this.nUD_EpsNoisy);
            this.grB_CreateNoisyImages.Controls.Add(this.nUD_CountNoisy);
            this.grB_CreateNoisyImages.Controls.Add(this.lblCountNoisy);
            this.grB_CreateNoisyImages.Controls.Add(this.cmB_ListOfModels);
            this.grB_CreateNoisyImages.Controls.Add(this.lblModel);
            this.grB_CreateNoisyImages.Controls.Add(this.btnCreateNoisyImage);
            this.grB_CreateNoisyImages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.grB_CreateNoisyImages, "grB_CreateNoisyImages");
            this.grB_CreateNoisyImages.Name = "grB_CreateNoisyImages";
            this.grB_CreateNoisyImages.TabStop = false;
            // 
            // lblStatusCreateNoisy
            // 
            resources.ApplyResources(this.lblStatusCreateNoisy, "lblStatusCreateNoisy");
            this.lblStatusCreateNoisy.Name = "lblStatusCreateNoisy";
            // 
            // lblEpsNoisy
            // 
            resources.ApplyResources(this.lblEpsNoisy, "lblEpsNoisy");
            this.lblEpsNoisy.Name = "lblEpsNoisy";
            // 
            // nUD_EpsNoisy
            // 
            this.nUD_EpsNoisy.DecimalPlaces = 5;
            this.nUD_EpsNoisy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            resources.ApplyResources(this.nUD_EpsNoisy, "nUD_EpsNoisy");
            this.nUD_EpsNoisy.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_EpsNoisy.Name = "nUD_EpsNoisy";
            this.nUD_EpsNoisy.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nUD_EpsNoisy.ValueChanged += new System.EventHandler(this.nUD_EpsNoisy_ValueChanged);
            // 
            // nUD_CountNoisy
            // 
            resources.ApplyResources(this.nUD_CountNoisy, "nUD_CountNoisy");
            this.nUD_CountNoisy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_CountNoisy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_CountNoisy.Name = "nUD_CountNoisy";
            this.nUD_CountNoisy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCountNoisy
            // 
            resources.ApplyResources(this.lblCountNoisy, "lblCountNoisy");
            this.lblCountNoisy.Name = "lblCountNoisy";
            // 
            // cmB_ListOfModels
            // 
            resources.ApplyResources(this.cmB_ListOfModels, "cmB_ListOfModels");
            this.cmB_ListOfModels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmB_ListOfModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_ListOfModels.Name = "cmB_ListOfModels";
            this.cmB_ListOfModels.SelectedIndexChanged += new System.EventHandler(this.cmB_ListOfModels_SelectedIndexChanged);
            // 
            // lblModel
            // 
            resources.ApplyResources(this.lblModel, "lblModel");
            this.lblModel.Name = "lblModel";
            // 
            // btnCreateNoisyImage
            // 
            resources.ApplyResources(this.btnCreateNoisyImage, "btnCreateNoisyImage");
            this.btnCreateNoisyImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCreateNoisyImage.Name = "btnCreateNoisyImage";
            this.btnCreateNoisyImage.UseVisualStyleBackColor = false;
            this.btnCreateNoisyImage.Click += new System.EventHandler(this.btnCreateNoisyImage_Click);
            // 
            // dUD_ListImage
            // 
            resources.ApplyResources(this.dUD_ListImage, "dUD_ListImage");
            this.dUD_ListImage.Name = "dUD_ListImage";
            this.dUD_ListImage.ReadOnly = true;
            this.dUD_ListImage.SelectedItemChanged += new System.EventHandler(this.dUD_ListImage_SelectedItemChanged);
            // 
            // pcB_Image
            // 
            this.pcB_Image.BackColor = System.Drawing.Color.White;
            this.pcB_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pcB_Image, "pcB_Image");
            this.pcB_Image.Name = "pcB_Image";
            this.pcB_Image.TabStop = false;
            this.pcB_Image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcB_Image_MouseDown);
            this.pcB_Image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcB_Image_MouseMove);
            // 
            // tbP_SelectLearnDataAndAddClassificator
            // 
            this.tbP_SelectLearnDataAndAddClassificator.Controls.Add(this.grB_EstimationQualityClassication);
            this.tbP_SelectLearnDataAndAddClassificator.Controls.Add(this.grB_CreateClassificator);
            resources.ApplyResources(this.tbP_SelectLearnDataAndAddClassificator, "tbP_SelectLearnDataAndAddClassificator");
            this.tbP_SelectLearnDataAndAddClassificator.Name = "tbP_SelectLearnDataAndAddClassificator";
            this.tbP_SelectLearnDataAndAddClassificator.UseVisualStyleBackColor = true;
            this.tbP_SelectLearnDataAndAddClassificator.Enter += new System.EventHandler(this.tbP_SelectLearnDataAndAddClassificator_Enter);
            // 
            // grB_EstimationQualityClassication
            // 
            resources.ApplyResources(this.grB_EstimationQualityClassication, "grB_EstimationQualityClassication");
            this.grB_EstimationQualityClassication.Controls.Add(this.lblMaxEstim);
            this.grB_EstimationQualityClassication.Controls.Add(this.txB_CountParts);
            this.grB_EstimationQualityClassication.Controls.Add(this.dGV_ResultCrossValidation);
            this.grB_EstimationQualityClassication.Controls.Add(this.lblCountParts);
            this.grB_EstimationQualityClassication.Controls.Add(this.grB_SettingOfProportion);
            this.grB_EstimationQualityClassication.Controls.Add(this.grB_TypePartition);
            this.grB_EstimationQualityClassication.Name = "grB_EstimationQualityClassication";
            this.grB_EstimationQualityClassication.TabStop = false;
            // 
            // lblMaxEstim
            // 
            resources.ApplyResources(this.lblMaxEstim, "lblMaxEstim");
            this.lblMaxEstim.Name = "lblMaxEstim";
            // 
            // txB_CountParts
            // 
            resources.ApplyResources(this.txB_CountParts, "txB_CountParts");
            this.txB_CountParts.Name = "txB_CountParts";
            this.txB_CountParts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txB_CountParts_KeyDown);
            this.txB_CountParts.Validated += new System.EventHandler(this.txB_CountParts_Validated);
            // 
            // dGV_ResultCrossValidation
            // 
            this.dGV_ResultCrossValidation.AllowUserToAddRows = false;
            this.dGV_ResultCrossValidation.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dGV_ResultCrossValidation, "dGV_ResultCrossValidation");
            this.dGV_ResultCrossValidation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_ResultCrossValidation.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_ResultCrossValidation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ResultCrossValidation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDGV_Iteration,
            this.сolDGV_PercentCorrectClassific});
            this.dGV_ResultCrossValidation.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dGV_ResultCrossValidation.Name = "dGV_ResultCrossValidation";
            this.dGV_ResultCrossValidation.ReadOnly = true;
            this.dGV_ResultCrossValidation.RowHeadersVisible = false;
            // 
            // colDGV_Iteration
            // 
            this.colDGV_Iteration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDGV_Iteration.FillWeight = 50F;
            resources.ApplyResources(this.colDGV_Iteration, "colDGV_Iteration");
            this.colDGV_Iteration.Name = "colDGV_Iteration";
            this.colDGV_Iteration.ReadOnly = true;
            this.colDGV_Iteration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // сolDGV_PercentCorrectClassific
            // 
            this.сolDGV_PercentCorrectClassific.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.сolDGV_PercentCorrectClassific, "сolDGV_PercentCorrectClassific");
            this.сolDGV_PercentCorrectClassific.Name = "сolDGV_PercentCorrectClassific";
            this.сolDGV_PercentCorrectClassific.ReadOnly = true;
            this.сolDGV_PercentCorrectClassific.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblCountParts
            // 
            resources.ApplyResources(this.lblCountParts, "lblCountParts");
            this.lblCountParts.Name = "lblCountParts";
            // 
            // grB_SettingOfProportion
            // 
            resources.ApplyResources(this.grB_SettingOfProportion, "grB_SettingOfProportion");
            this.grB_SettingOfProportion.Controls.Add(this.lblPercentPartition);
            this.grB_SettingOfProportion.Controls.Add(this.lblCountIteration);
            this.grB_SettingOfProportion.Controls.Add(this.txB_PercentPartition);
            this.grB_SettingOfProportion.Controls.Add(this.nUD_CountIteration);
            this.grB_SettingOfProportion.Name = "grB_SettingOfProportion";
            this.grB_SettingOfProportion.TabStop = false;
            // 
            // lblPercentPartition
            // 
            resources.ApplyResources(this.lblPercentPartition, "lblPercentPartition");
            this.lblPercentPartition.Name = "lblPercentPartition";
            // 
            // lblCountIteration
            // 
            resources.ApplyResources(this.lblCountIteration, "lblCountIteration");
            this.lblCountIteration.Name = "lblCountIteration";
            // 
            // txB_PercentPartition
            // 
            resources.ApplyResources(this.txB_PercentPartition, "txB_PercentPartition");
            this.txB_PercentPartition.Name = "txB_PercentPartition";
            this.txB_PercentPartition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txB_PercentPartition_KeyDown);
            this.txB_PercentPartition.Validated += new System.EventHandler(this.txB_PercentPartition_Validated);
            // 
            // nUD_CountIteration
            // 
            resources.ApplyResources(this.nUD_CountIteration, "nUD_CountIteration");
            this.nUD_CountIteration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUD_CountIteration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_CountIteration.Name = "nUD_CountIteration";
            this.nUD_CountIteration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // grB_TypePartition
            // 
            resources.ApplyResources(this.grB_TypePartition, "grB_TypePartition");
            this.grB_TypePartition.Controls.Add(this.rdB_SpecifiedNumber_ofParts);
            this.grB_TypePartition.Controls.Add(this.rdB_SpecifiedProportion);
            this.grB_TypePartition.Name = "grB_TypePartition";
            this.grB_TypePartition.TabStop = false;
            // 
            // rdB_SpecifiedNumber_ofParts
            // 
            resources.ApplyResources(this.rdB_SpecifiedNumber_ofParts, "rdB_SpecifiedNumber_ofParts");
            this.rdB_SpecifiedNumber_ofParts.Name = "rdB_SpecifiedNumber_ofParts";
            this.rdB_SpecifiedNumber_ofParts.UseVisualStyleBackColor = true;
            // 
            // rdB_SpecifiedProportion
            // 
            resources.ApplyResources(this.rdB_SpecifiedProportion, "rdB_SpecifiedProportion");
            this.rdB_SpecifiedProportion.Checked = true;
            this.rdB_SpecifiedProportion.Name = "rdB_SpecifiedProportion";
            this.rdB_SpecifiedProportion.TabStop = true;
            this.rdB_SpecifiedProportion.UseVisualStyleBackColor = true;
            this.rdB_SpecifiedProportion.CheckedChanged += new System.EventHandler(this.rdB_SpecifiedProportion_CheckedChanged);
            // 
            // grB_CreateClassificator
            // 
            resources.ApplyResources(this.grB_CreateClassificator, "grB_CreateClassificator");
            this.grB_CreateClassificator.Controls.Add(this.grB_CritSelectProperty);
            this.grB_CreateClassificator.Controls.Add(this.lblCountCheckedImsForLearning);
            this.grB_CreateClassificator.Controls.Add(this.grB_UsingLearnData);
            this.grB_CreateClassificator.Controls.Add(this.pcB_DemoLearnIm);
            this.grB_CreateClassificator.Controls.Add(this.lblStatusCreateClassificator);
            this.grB_CreateClassificator.Controls.Add(this.btnCreateClassificator);
            this.grB_CreateClassificator.Controls.Add(this.cLB_LearnImages);
            this.grB_CreateClassificator.Controls.Add(this.lblDimensionality);
            this.grB_CreateClassificator.Controls.Add(this.cmB_Dimensionalitys);
            this.grB_CreateClassificator.Name = "grB_CreateClassificator";
            this.grB_CreateClassificator.TabStop = false;
            // 
            // grB_CritSelectProperty
            // 
            resources.ApplyResources(this.grB_CritSelectProperty, "grB_CritSelectProperty");
            this.grB_CritSelectProperty.Controls.Add(this.rdB_C4_5);
            this.grB_CritSelectProperty.Controls.Add(this.rdB_CART);
            this.grB_CritSelectProperty.Name = "grB_CritSelectProperty";
            this.grB_CritSelectProperty.TabStop = false;
            // 
            // rdB_C4_5
            // 
            resources.ApplyResources(this.rdB_C4_5, "rdB_C4_5");
            this.rdB_C4_5.Name = "rdB_C4_5";
            this.rdB_C4_5.UseVisualStyleBackColor = true;
            // 
            // rdB_CART
            // 
            resources.ApplyResources(this.rdB_CART, "rdB_CART");
            this.rdB_CART.Checked = true;
            this.rdB_CART.Name = "rdB_CART";
            this.rdB_CART.TabStop = true;
            this.rdB_CART.UseVisualStyleBackColor = true;
            this.rdB_CART.CheckedChanged += new System.EventHandler(this.rdB_CART_CheckedChanged);
            // 
            // lblCountCheckedImsForLearning
            // 
            resources.ApplyResources(this.lblCountCheckedImsForLearning, "lblCountCheckedImsForLearning");
            this.lblCountCheckedImsForLearning.Name = "lblCountCheckedImsForLearning";
            // 
            // grB_UsingLearnData
            // 
            resources.ApplyResources(this.grB_UsingLearnData, "grB_UsingLearnData");
            this.grB_UsingLearnData.Controls.Add(this.rdB_CrossValidation);
            this.grB_UsingLearnData.Controls.Add(this.rdB_AllLearnData);
            this.grB_UsingLearnData.Name = "grB_UsingLearnData";
            this.grB_UsingLearnData.TabStop = false;
            // 
            // rdB_CrossValidation
            // 
            resources.ApplyResources(this.rdB_CrossValidation, "rdB_CrossValidation");
            this.rdB_CrossValidation.Name = "rdB_CrossValidation";
            this.rdB_CrossValidation.UseVisualStyleBackColor = true;
            this.rdB_CrossValidation.CheckedChanged += new System.EventHandler(this.rdB_CrossValidation_CheckedChanged);
            // 
            // rdB_AllLearnData
            // 
            resources.ApplyResources(this.rdB_AllLearnData, "rdB_AllLearnData");
            this.rdB_AllLearnData.Checked = true;
            this.rdB_AllLearnData.Name = "rdB_AllLearnData";
            this.rdB_AllLearnData.TabStop = true;
            this.rdB_AllLearnData.UseVisualStyleBackColor = true;
            // 
            // pcB_DemoLearnIm
            // 
            resources.ApplyResources(this.pcB_DemoLearnIm, "pcB_DemoLearnIm");
            this.pcB_DemoLearnIm.BackColor = System.Drawing.Color.White;
            this.pcB_DemoLearnIm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcB_DemoLearnIm.Name = "pcB_DemoLearnIm";
            this.pcB_DemoLearnIm.TabStop = false;
            // 
            // lblStatusCreateClassificator
            // 
            resources.ApplyResources(this.lblStatusCreateClassificator, "lblStatusCreateClassificator");
            this.lblStatusCreateClassificator.Name = "lblStatusCreateClassificator";
            // 
            // btnCreateClassificator
            // 
            resources.ApplyResources(this.btnCreateClassificator, "btnCreateClassificator");
            this.btnCreateClassificator.Name = "btnCreateClassificator";
            this.btnCreateClassificator.UseVisualStyleBackColor = true;
            this.btnCreateClassificator.Click += new System.EventHandler(this.btnCreateClassificator_Click);
            // 
            // cLB_LearnImages
            // 
            resources.ApplyResources(this.cLB_LearnImages, "cLB_LearnImages");
            this.cLB_LearnImages.CheckOnClick = true;
            this.cLB_LearnImages.FormattingEnabled = true;
            this.cLB_LearnImages.Name = "cLB_LearnImages";
            this.cLB_LearnImages.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cLB_LearnImages_ItemCheck);
            this.cLB_LearnImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cLB_MouseClick);
            this.cLB_LearnImages.SelectedIndexChanged += new System.EventHandler(this.cLB_LearnImages_SelectedIndexChanged);
            this.cLB_LearnImages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cLB_KeyDown);
            this.cLB_LearnImages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cLB_KeyUp);
            // 
            // lblDimensionality
            // 
            resources.ApplyResources(this.lblDimensionality, "lblDimensionality");
            this.lblDimensionality.Name = "lblDimensionality";
            // 
            // cmB_Dimensionalitys
            // 
            resources.ApplyResources(this.cmB_Dimensionalitys, "cmB_Dimensionalitys");
            this.cmB_Dimensionalitys.FormattingEnabled = true;
            this.cmB_Dimensionalitys.Name = "cmB_Dimensionalitys";
            this.cmB_Dimensionalitys.SelectedIndexChanged += new System.EventHandler(this.cmB_Dimensionalitys_SelectedIndexChanged);
            // 
            // tbP_Classification
            // 
            this.tbP_Classification.Controls.Add(this.groupBox3);
            this.tbP_Classification.Controls.Add(this.groupBox2);
            this.tbP_Classification.Controls.Add(this.groupBox1);
            this.tbP_Classification.Controls.Add(this.pcB_DemoIm);
            resources.ApplyResources(this.tbP_Classification, "tbP_Classification");
            this.tbP_Classification.Name = "tbP_Classification";
            this.tbP_Classification.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pcB_DemoIm
            // 
            this.pcB_DemoIm.BackColor = System.Drawing.Color.White;
            this.pcB_DemoIm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pcB_DemoIm, "pcB_DemoIm");
            this.pcB_DemoIm.Name = "pcB_DemoIm";
            this.pcB_DemoIm.TabStop = false;
            // 
            // oFD_Loader
            // 
            this.oFD_Loader.DefaultExt = "txt";
            resources.ApplyResources(this.oFD_Loader, "oFD_Loader");
            this.oFD_Loader.InitialDirectory = ".";
            // 
            // sFD_Saver
            // 
            this.sFD_Saver.DefaultExt = "txt";
            resources.ApplyResources(this.sFD_Saver, "sFD_Saver");
            this.sFD_Saver.InitialDirectory = ".";
            // 
            // tbP_OutputTree
            // 
            this.tbP_OutputTree.Controls.Add(this.rTB_OutputTree);
            resources.ApplyResources(this.tbP_OutputTree, "tbP_OutputTree");
            this.tbP_OutputTree.Name = "tbP_OutputTree";
            this.tbP_OutputTree.UseVisualStyleBackColor = true;
            // 
            // rTB_OutputTree
            // 
            this.rTB_OutputTree.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.rTB_OutputTree, "rTB_OutputTree");
            this.rTB_OutputTree.ForeColor = System.Drawing.Color.Black;
            this.rTB_OutputTree.Name = "rTB_OutputTree";
            this.rTB_OutputTree.ReadOnly = true;
            // 
            // frmMashineLearning
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbC_Main);
            this.MaximizeBox = false;
            this.Name = "frmMashineLearning";
            this.tbC_Main.ResumeLayout(false);
            this.tbP_LearnAndTestImages.ResumeLayout(false);
            this.tbP_LearnAndTestImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_ColCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_RowCount)).EndInit();
            this.pnl_SaveAndLoad.ResumeLayout(false);
            this.pnl_SaveAndLoad.PerformLayout();
            this.grB_AddModel.ResumeLayout(false);
            this.grB_AddModel.PerformLayout();
            this.grB_CreateNoisyImages.ResumeLayout(false);
            this.grB_CreateNoisyImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_EpsNoisy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountNoisy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_Image)).EndInit();
            this.tbP_SelectLearnDataAndAddClassificator.ResumeLayout(false);
            this.grB_EstimationQualityClassication.ResumeLayout(false);
            this.grB_EstimationQualityClassication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ResultCrossValidation)).EndInit();
            this.grB_SettingOfProportion.ResumeLayout(false);
            this.grB_SettingOfProportion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountIteration)).EndInit();
            this.grB_TypePartition.ResumeLayout(false);
            this.grB_TypePartition.PerformLayout();
            this.grB_CreateClassificator.ResumeLayout(false);
            this.grB_CreateClassificator.PerformLayout();
            this.grB_CritSelectProperty.ResumeLayout(false);
            this.grB_CritSelectProperty.PerformLayout();
            this.grB_UsingLearnData.ResumeLayout(false);
            this.grB_UsingLearnData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_DemoLearnIm)).EndInit();
            this.tbP_Classification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcB_DemoIm)).EndInit();
            this.tbP_OutputTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbC_Main;
        private System.Windows.Forms.TabPage tbP_LearnAndTestImages;
        private System.Windows.Forms.GroupBox grB_CreateNoisyImages;
        private System.Windows.Forms.NumericUpDown nUD_CountNoisy;
        private System.Windows.Forms.Label lblCountNoisy;
        private System.Windows.Forms.ComboBox cmB_ListOfModels;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Button btnCreateNoisyImage;
        private System.Windows.Forms.Button btnDeleteIm;
        private System.Windows.Forms.Button btnChangeIm;
        private System.Windows.Forms.DomainUpDown dUD_ListImage;
        private System.Windows.Forms.PictureBox pcB_Image;
        private System.Windows.Forms.Label lblEpsNoisy;
        private System.Windows.Forms.NumericUpDown nUD_EpsNoisy;
        private System.Windows.Forms.GroupBox grB_AddModel;
        private System.Windows.Forms.Label lbl_NameTypeModel;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.TextBox txB_NameTypeModel;
        private System.Windows.Forms.Panel pnl_SaveAndLoad;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnSaveInFile;
        private System.Windows.Forms.CheckedListBox cLB_ListAvalaibleImages;
        private System.Windows.Forms.Label lblListAvalaibleImages;
        private System.Windows.Forms.NumericUpDown nUD_RowCount;
        private System.Windows.Forms.Label lbl_RowCount;
        private System.Windows.Forms.Label lblParMatrix;
        private System.Windows.Forms.NumericUpDown nUD_ColCount;
        private System.Windows.Forms.Label lbl_ColCount;
        private System.Windows.Forms.Label lblStatusNameModel;
        private System.Windows.Forms.Label lblStatusCreateNoisy;
        private System.Windows.Forms.OpenFileDialog oFD_Loader;
        private System.Windows.Forms.SaveFileDialog sFD_Saver;
        private System.Windows.Forms.Button btnCancelIm;
        private System.Windows.Forms.Button btnAcceptIm;
        private System.Windows.Forms.Label lblCursorPosInMatrCoord;
        private System.Windows.Forms.Label lblCurrMatrCoord;
        private System.Windows.Forms.CheckBox chB_RandomOrder;
        private System.Windows.Forms.TabPage tbP_SelectLearnDataAndAddClassificator;
        private System.Windows.Forms.TextBox txB_NumChooseIm;
        private System.Windows.Forms.CheckBox chB_CheckAll;
        private System.Windows.Forms.TabPage tbP_Classification;
        private System.Windows.Forms.GroupBox grB_CreateClassificator;
        private System.Windows.Forms.CheckedListBox cLB_LearnImages;
        private System.Windows.Forms.Label lblDimensionality;
        private System.Windows.Forms.ComboBox cmB_Dimensionalitys;
        private System.Windows.Forms.Label lblStatusCreateClassificator;
        private System.Windows.Forms.Button btnCreateClassificator;
        private System.Windows.Forms.PictureBox pcB_DemoLearnIm;
        private System.Windows.Forms.GroupBox grB_UsingLearnData;
        private System.Windows.Forms.GroupBox grB_EstimationQualityClassication;
        private System.Windows.Forms.DataGridView dGV_ResultCrossValidation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDGV_Iteration;
        private System.Windows.Forms.DataGridViewTextBoxColumn сolDGV_PercentCorrectClassific;
        private System.Windows.Forms.Label lblCountParts;
        private System.Windows.Forms.GroupBox grB_SettingOfProportion;
        private System.Windows.Forms.Label lblPercentPartition;
        private System.Windows.Forms.TextBox txB_CountParts;
        private System.Windows.Forms.Label lblCountIteration;
        private System.Windows.Forms.TextBox txB_PercentPartition;
        private System.Windows.Forms.NumericUpDown nUD_CountIteration;
        private System.Windows.Forms.GroupBox grB_TypePartition;
        private System.Windows.Forms.RadioButton rdB_SpecifiedNumber_ofParts;
        private System.Windows.Forms.RadioButton rdB_SpecifiedProportion;
        private System.Windows.Forms.RadioButton rdB_CrossValidation;
        private System.Windows.Forms.RadioButton rdB_AllLearnData;
        private System.Windows.Forms.Label lblCountCheckedImsForLearning;
        private System.Windows.Forms.GroupBox grB_CritSelectProperty;
        private System.Windows.Forms.RadioButton rdB_C4_5;
        private System.Windows.Forms.RadioButton rdB_CART;
        private System.Windows.Forms.PictureBox pcB_DemoIm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaxEstim;
        private System.Windows.Forms.TabPage tbP_OutputTree;
        private System.Windows.Forms.RichTextBox rTB_OutputTree;
    }
}

