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
            this.tbC_Main = new System.Windows.Forms.TabControl();
            this.tbP_LearnAndTestImages = new System.Windows.Forms.TabPage();
            this.txB_NumChooseIm = new System.Windows.Forms.TextBox();
            this.lblCursorPosInMatrCoord = new System.Windows.Forms.Label();
            this.lblCurrMatrCoord = new System.Windows.Forms.Label();
            this.btnDeleteIm = new System.Windows.Forms.Button();
            this.btnChangeIm = new System.Windows.Forms.Button();
            this.btnCancelIm = new System.Windows.Forms.Button();
            this.btnAcceptIm = new System.Windows.Forms.Button();
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
            this.dGV_ResultCrossValidation = new System.Windows.Forms.DataGridView();
            this.colDGV_Iteration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сolDGV_PercentCorrectClassific = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txB_CountParts = new System.Windows.Forms.TextBox();
            this.lblCountParts = new System.Windows.Forms.Label();
            this.grB_SettingOfProportion = new System.Windows.Forms.GroupBox();
            this.lblPercentPartition = new System.Windows.Forms.Label();
            this.lblCountIteration = new System.Windows.Forms.Label();
            this.txB_PercentPartition = new System.Windows.Forms.TextBox();
            this.nUD_CountIteration = new System.Windows.Forms.NumericUpDown();
            this.grB_TypePartition = new System.Windows.Forms.GroupBox();
            this.rdB_SpecifiedNumber_ofParts = new System.Windows.Forms.RadioButton();
            this.rdB_SpecifiedProportion = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.grB_CreateClassificator = new System.Windows.Forms.GroupBox();
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
            this.tbP_TestingClassificators = new System.Windows.Forms.TabPage();
            this.tbP_EstimationQualityClassication = new System.Windows.Forms.TabPage();
            this.tbP_Classification = new System.Windows.Forms.TabPage();
            this.oFD_Loader = new System.Windows.Forms.OpenFileDialog();
            this.sFD_Saver = new System.Windows.Forms.SaveFileDialog();
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
            this.grB_UsingLearnData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_DemoLearnIm)).BeginInit();
            this.SuspendLayout();
            // 
            // tbC_Main
            // 
            this.tbC_Main.Controls.Add(this.tbP_LearnAndTestImages);
            this.tbC_Main.Controls.Add(this.tbP_SelectLearnDataAndAddClassificator);
            this.tbC_Main.Controls.Add(this.tbP_TestingClassificators);
            this.tbC_Main.Controls.Add(this.tbP_EstimationQualityClassication);
            this.tbC_Main.Controls.Add(this.tbP_Classification);
            this.tbC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbC_Main.Location = new System.Drawing.Point(0, 0);
            this.tbC_Main.Name = "tbC_Main";
            this.tbC_Main.SelectedIndex = 0;
            this.tbC_Main.Size = new System.Drawing.Size(1020, 541);
            this.tbC_Main.TabIndex = 0;
            // 
            // tbP_LearnAndTestImages
            // 
            this.tbP_LearnAndTestImages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbP_LearnAndTestImages.Controls.Add(this.txB_NumChooseIm);
            this.tbP_LearnAndTestImages.Controls.Add(this.lblCursorPosInMatrCoord);
            this.tbP_LearnAndTestImages.Controls.Add(this.lblCurrMatrCoord);
            this.tbP_LearnAndTestImages.Controls.Add(this.btnDeleteIm);
            this.tbP_LearnAndTestImages.Controls.Add(this.btnChangeIm);
            this.tbP_LearnAndTestImages.Controls.Add(this.btnCancelIm);
            this.tbP_LearnAndTestImages.Controls.Add(this.btnAcceptIm);
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
            this.tbP_LearnAndTestImages.Location = new System.Drawing.Point(4, 22);
            this.tbP_LearnAndTestImages.Name = "tbP_LearnAndTestImages";
            this.tbP_LearnAndTestImages.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_LearnAndTestImages.Size = new System.Drawing.Size(1012, 515);
            this.tbP_LearnAndTestImages.TabIndex = 0;
            this.tbP_LearnAndTestImages.Text = "Навчально-тестові образи";
            // 
            // txB_NumChooseIm
            // 
            this.txB_NumChooseIm.Location = new System.Drawing.Point(907, 15);
            this.txB_NumChooseIm.Name = "txB_NumChooseIm";
            this.txB_NumChooseIm.Size = new System.Drawing.Size(77, 20);
            this.txB_NumChooseIm.TabIndex = 17;
            this.txB_NumChooseIm.Text = "--/0";
            this.txB_NumChooseIm.Enter += new System.EventHandler(this.txB_NumChooseIm_Enter);
            this.txB_NumChooseIm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txB_NumChooseIm_KeyDown);
            this.txB_NumChooseIm.Validated += new System.EventHandler(this.txB_NumChooseIm_Validated);
            // 
            // lblCursorPosInMatrCoord
            // 
            this.lblCursorPosInMatrCoord.AutoSize = true;
            this.lblCursorPosInMatrCoord.Location = new System.Drawing.Point(904, 53);
            this.lblCursorPosInMatrCoord.Name = "lblCursorPosInMatrCoord";
            this.lblCursorPosInMatrCoord.Size = new System.Drawing.Size(25, 13);
            this.lblCursorPosInMatrCoord.TabIndex = 16;
            this.lblCursorPosInMatrCoord.Text = "0; 0";
            this.lblCursorPosInMatrCoord.Visible = false;
            // 
            // lblCurrMatrCoord
            // 
            this.lblCurrMatrCoord.AutoSize = true;
            this.lblCurrMatrCoord.Location = new System.Drawing.Point(783, 53);
            this.lblCurrMatrCoord.Name = "lblCurrMatrCoord";
            this.lblCurrMatrCoord.Size = new System.Drawing.Size(115, 13);
            this.lblCurrMatrCoord.TabIndex = 15;
            this.lblCurrMatrCoord.Text = "Поточні матр. коорд.:";
            this.lblCurrMatrCoord.Visible = false;
            // 
            // btnDeleteIm
            // 
            this.btnDeleteIm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteIm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeleteIm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteIm.Location = new System.Drawing.Point(740, 475);
            this.btnDeleteIm.Name = "btnDeleteIm";
            this.btnDeleteIm.Size = new System.Drawing.Size(244, 23);
            this.btnDeleteIm.TabIndex = 3;
            this.btnDeleteIm.Text = "Видалити";
            this.btnDeleteIm.UseVisualStyleBackColor = false;
            this.btnDeleteIm.Visible = false;
            // 
            // btnChangeIm
            // 
            this.btnChangeIm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangeIm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnChangeIm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeIm.Location = new System.Drawing.Point(484, 475);
            this.btnChangeIm.Name = "btnChangeIm";
            this.btnChangeIm.Size = new System.Drawing.Size(250, 23);
            this.btnChangeIm.TabIndex = 2;
            this.btnChangeIm.Text = "Змінити";
            this.btnChangeIm.UseVisualStyleBackColor = false;
            this.btnChangeIm.Visible = false;
            // 
            // btnCancelIm
            // 
            this.btnCancelIm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelIm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelIm.Location = new System.Drawing.Point(740, 484);
            this.btnCancelIm.Name = "btnCancelIm";
            this.btnCancelIm.Size = new System.Drawing.Size(244, 23);
            this.btnCancelIm.TabIndex = 14;
            this.btnCancelIm.Text = "Скасувати";
            this.btnCancelIm.UseVisualStyleBackColor = false;
            this.btnCancelIm.Visible = false;
            this.btnCancelIm.Click += new System.EventHandler(this.btnCancelIm_Click);
            // 
            // btnAcceptIm
            // 
            this.btnAcceptIm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAcceptIm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcceptIm.Location = new System.Drawing.Point(484, 484);
            this.btnAcceptIm.Name = "btnAcceptIm";
            this.btnAcceptIm.Size = new System.Drawing.Size(250, 23);
            this.btnAcceptIm.TabIndex = 13;
            this.btnAcceptIm.Text = "Підтвердити";
            this.btnAcceptIm.UseVisualStyleBackColor = false;
            this.btnAcceptIm.Visible = false;
            this.btnAcceptIm.Click += new System.EventHandler(this.btnAcceptIm_Click);
            // 
            // nUD_ColCount
            // 
            this.nUD_ColCount.Enabled = false;
            this.nUD_ColCount.Location = new System.Drawing.Point(723, 41);
            this.nUD_ColCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_ColCount.Name = "nUD_ColCount";
            this.nUD_ColCount.Size = new System.Drawing.Size(54, 20);
            this.nUD_ColCount.TabIndex = 12;
            this.nUD_ColCount.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nUD_ColCount.ValueChanged += new System.EventHandler(this.nUD_RowCount_ValueChanged);
            // 
            // lbl_ColCount
            // 
            this.lbl_ColCount.AutoSize = true;
            this.lbl_ColCount.Location = new System.Drawing.Point(695, 43);
            this.lbl_ColCount.Name = "lbl_ColCount";
            this.lbl_ColCount.Size = new System.Drawing.Size(28, 13);
            this.lbl_ColCount.TabIndex = 11;
            this.lbl_ColCount.Text = "cc =";
            // 
            // lbl_RowCount
            // 
            this.lbl_RowCount.AutoSize = true;
            this.lbl_RowCount.Location = new System.Drawing.Point(596, 43);
            this.lbl_RowCount.Name = "lbl_RowCount";
            this.lbl_RowCount.Size = new System.Drawing.Size(25, 13);
            this.lbl_RowCount.TabIndex = 10;
            this.lbl_RowCount.Text = "rc =";
            // 
            // lblParMatrix
            // 
            this.lblParMatrix.AutoSize = true;
            this.lblParMatrix.Location = new System.Drawing.Point(481, 43);
            this.lblParMatrix.Name = "lblParMatrix";
            this.lblParMatrix.Size = new System.Drawing.Size(109, 13);
            this.lblParMatrix.TabIndex = 9;
            this.lblParMatrix.Text = "Параметри матриці:";
            // 
            // nUD_RowCount
            // 
            this.nUD_RowCount.Enabled = false;
            this.nUD_RowCount.Location = new System.Drawing.Point(626, 41);
            this.nUD_RowCount.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUD_RowCount.Name = "nUD_RowCount";
            this.nUD_RowCount.Size = new System.Drawing.Size(54, 20);
            this.nUD_RowCount.TabIndex = 8;
            this.nUD_RowCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUD_RowCount.ValueChanged += new System.EventHandler(this.nUD_RowCount_ValueChanged);
            // 
            // pnl_SaveAndLoad
            // 
            this.pnl_SaveAndLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_SaveAndLoad.Controls.Add(this.chB_CheckAll);
            this.pnl_SaveAndLoad.Controls.Add(this.chB_RandomOrder);
            this.pnl_SaveAndLoad.Controls.Add(this.btnLoadFromFile);
            this.pnl_SaveAndLoad.Controls.Add(this.btnSaveInFile);
            this.pnl_SaveAndLoad.Controls.Add(this.cLB_ListAvalaibleImages);
            this.pnl_SaveAndLoad.Controls.Add(this.lblListAvalaibleImages);
            this.pnl_SaveAndLoad.Location = new System.Drawing.Point(8, 297);
            this.pnl_SaveAndLoad.Name = "pnl_SaveAndLoad";
            this.pnl_SaveAndLoad.Size = new System.Drawing.Size(444, 201);
            this.pnl_SaveAndLoad.TabIndex = 7;
            // 
            // chB_CheckAll
            // 
            this.chB_CheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chB_CheckAll.AutoSize = true;
            this.chB_CheckAll.Location = new System.Drawing.Point(9, 182);
            this.chB_CheckAll.Name = "chB_CheckAll";
            this.chB_CheckAll.Size = new System.Drawing.Size(77, 17);
            this.chB_CheckAll.TabIndex = 5;
            this.chB_CheckAll.Text = "обрати усі";
            this.chB_CheckAll.UseVisualStyleBackColor = true;
            this.chB_CheckAll.CheckedChanged += new System.EventHandler(this.chB_CheckAll_CheckedChanged);
            // 
            // chB_RandomOrder
            // 
            this.chB_RandomOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chB_RandomOrder.Location = new System.Drawing.Point(320, 162);
            this.chB_RandomOrder.Name = "chB_RandomOrder";
            this.chB_RandomOrder.Size = new System.Drawing.Size(118, 32);
            this.chB_RandomOrder.TabIndex = 4;
            this.chB_RandomOrder.Text = "У випадковому порядку";
            this.chB_RandomOrder.UseVisualStyleBackColor = true;
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFromFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLoadFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadFromFile.Location = new System.Drawing.Point(320, 25);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(118, 52);
            this.btnLoadFromFile.TabIndex = 3;
            this.btnLoadFromFile.Text = "Завантажити нові зображення";
            this.btnLoadFromFile.UseVisualStyleBackColor = false;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnSaveInFile
            // 
            this.btnSaveInFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveInFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveInFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveInFile.Location = new System.Drawing.Point(320, 105);
            this.btnSaveInFile.Name = "btnSaveInFile";
            this.btnSaveInFile.Size = new System.Drawing.Size(118, 51);
            this.btnSaveInFile.TabIndex = 2;
            this.btnSaveInFile.Text = "Зберегти обрані зображення у файл";
            this.btnSaveInFile.UseVisualStyleBackColor = false;
            this.btnSaveInFile.Click += new System.EventHandler(this.btnSaveInFile_Click);
            // 
            // cLB_ListAvalaibleImages
            // 
            this.cLB_ListAvalaibleImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cLB_ListAvalaibleImages.CheckOnClick = true;
            this.cLB_ListAvalaibleImages.FormattingEnabled = true;
            this.cLB_ListAvalaibleImages.Location = new System.Drawing.Point(9, 25);
            this.cLB_ListAvalaibleImages.Name = "cLB_ListAvalaibleImages";
            this.cLB_ListAvalaibleImages.Size = new System.Drawing.Size(305, 154);
            this.cLB_ListAvalaibleImages.TabIndex = 1;
            this.cLB_ListAvalaibleImages.ThreeDCheckBoxes = true;
            this.cLB_ListAvalaibleImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cLB_MouseClick);
            this.cLB_ListAvalaibleImages.SelectedIndexChanged += new System.EventHandler(this.cLB_ListAvalaibleImages_SelectedIndexChanged);
            this.cLB_ListAvalaibleImages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cLB_KeyDown);
            this.cLB_ListAvalaibleImages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cLB_KeyUp);
            // 
            // lblListAvalaibleImages
            // 
            this.lblListAvalaibleImages.AutoSize = true;
            this.lblListAvalaibleImages.Location = new System.Drawing.Point(6, 9);
            this.lblListAvalaibleImages.Name = "lblListAvalaibleImages";
            this.lblListAvalaibleImages.Size = new System.Drawing.Size(160, 13);
            this.lblListAvalaibleImages.TabIndex = 0;
            this.lblListAvalaibleImages.Text = "Список доступних зображень:";
            // 
            // grB_AddModel
            // 
            this.grB_AddModel.Controls.Add(this.lblStatusNameModel);
            this.grB_AddModel.Controls.Add(this.lbl_NameTypeModel);
            this.grB_AddModel.Controls.Add(this.btnAddModel);
            this.grB_AddModel.Controls.Add(this.txB_NameTypeModel);
            this.grB_AddModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grB_AddModel.Location = new System.Drawing.Point(8, 15);
            this.grB_AddModel.Name = "grB_AddModel";
            this.grB_AddModel.Size = new System.Drawing.Size(444, 120);
            this.grB_AddModel.TabIndex = 6;
            this.grB_AddModel.TabStop = false;
            this.grB_AddModel.Text = "Додати еталонний образ";
            // 
            // lblStatusNameModel
            // 
            this.lblStatusNameModel.AutoSize = true;
            this.lblStatusNameModel.Location = new System.Drawing.Point(6, 71);
            this.lblStatusNameModel.Name = "lblStatusNameModel";
            this.lblStatusNameModel.Size = new System.Drawing.Size(36, 13);
            this.lblStatusNameModel.TabIndex = 8;
            this.lblStatusNameModel.Text = "lblStat";
            // 
            // lbl_NameTypeModel
            // 
            this.lbl_NameTypeModel.AutoSize = true;
            this.lbl_NameTypeModel.Location = new System.Drawing.Point(6, 32);
            this.lbl_NameTypeModel.Name = "lbl_NameTypeModel";
            this.lbl_NameTypeModel.Size = new System.Drawing.Size(111, 13);
            this.lbl_NameTypeModel.TabIndex = 7;
            this.lbl_NameTypeModel.Text = "Назва типу еталона:";
            // 
            // btnAddModel
            // 
            this.btnAddModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddModel.Location = new System.Drawing.Point(320, 91);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(118, 23);
            this.btnAddModel.TabIndex = 6;
            this.btnAddModel.Text = "Додати";
            this.btnAddModel.UseVisualStyleBackColor = false;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // txB_NameTypeModel
            // 
            this.txB_NameTypeModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txB_NameTypeModel.Location = new System.Drawing.Point(9, 48);
            this.txB_NameTypeModel.Name = "txB_NameTypeModel";
            this.txB_NameTypeModel.Size = new System.Drawing.Size(429, 20);
            this.txB_NameTypeModel.TabIndex = 0;
            this.txB_NameTypeModel.WordWrap = false;
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
            this.grB_CreateNoisyImages.Location = new System.Drawing.Point(8, 157);
            this.grB_CreateNoisyImages.Name = "grB_CreateNoisyImages";
            this.grB_CreateNoisyImages.Size = new System.Drawing.Size(444, 134);
            this.grB_CreateNoisyImages.TabIndex = 5;
            this.grB_CreateNoisyImages.TabStop = false;
            this.grB_CreateNoisyImages.Text = "Створення зашумлених зображень";
            // 
            // lblStatusCreateNoisy
            // 
            this.lblStatusCreateNoisy.AutoSize = true;
            this.lblStatusCreateNoisy.Location = new System.Drawing.Point(6, 105);
            this.lblStatusCreateNoisy.Name = "lblStatusCreateNoisy";
            this.lblStatusCreateNoisy.Size = new System.Drawing.Size(36, 13);
            this.lblStatusCreateNoisy.TabIndex = 12;
            this.lblStatusCreateNoisy.Text = "lblStat\r\n";
            // 
            // lblEpsNoisy
            // 
            this.lblEpsNoisy.AutoSize = true;
            this.lblEpsNoisy.Location = new System.Drawing.Point(6, 73);
            this.lblEpsNoisy.Name = "lblEpsNoisy";
            this.lblEpsNoisy.Size = new System.Drawing.Size(103, 13);
            this.lblEpsNoisy.TabIndex = 11;
            this.lblEpsNoisy.Text = "Поріг зашумлення:";
            // 
            // nUD_EpsNoisy
            // 
            this.nUD_EpsNoisy.DecimalPlaces = 5;
            this.nUD_EpsNoisy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nUD_EpsNoisy.Location = new System.Drawing.Point(115, 71);
            this.nUD_EpsNoisy.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_EpsNoisy.Name = "nUD_EpsNoisy";
            this.nUD_EpsNoisy.Size = new System.Drawing.Size(120, 20);
            this.nUD_EpsNoisy.TabIndex = 10;
            this.nUD_EpsNoisy.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nUD_EpsNoisy.ValueChanged += new System.EventHandler(this.nUD_EpsNoisy_ValueChanged);
            // 
            // nUD_CountNoisy
            // 
            this.nUD_CountNoisy.Location = new System.Drawing.Point(197, 48);
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
            this.nUD_CountNoisy.Size = new System.Drawing.Size(120, 20);
            this.nUD_CountNoisy.TabIndex = 9;
            this.nUD_CountNoisy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCountNoisy
            // 
            this.lblCountNoisy.AutoSize = true;
            this.lblCountNoisy.Location = new System.Drawing.Point(6, 50);
            this.lblCountNoisy.Name = "lblCountNoisy";
            this.lblCountNoisy.Size = new System.Drawing.Size(188, 13);
            this.lblCountNoisy.TabIndex = 8;
            this.lblCountNoisy.Text = "Кількість зашумлених екземплярів:";
            // 
            // cmB_ListOfModels
            // 
            this.cmB_ListOfModels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmB_ListOfModels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmB_ListOfModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_ListOfModels.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmB_ListOfModels.Location = new System.Drawing.Point(133, 23);
            this.cmB_ListOfModels.Name = "cmB_ListOfModels";
            this.cmB_ListOfModels.Size = new System.Drawing.Size(305, 21);
            this.cmB_ListOfModels.TabIndex = 7;
            this.cmB_ListOfModels.SelectedIndexChanged += new System.EventHandler(this.cmB_ListOfModels_SelectedIndexChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(6, 26);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(123, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Еталонне зображення:";
            // 
            // btnCreateNoisyImage
            // 
            this.btnCreateNoisyImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNoisyImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCreateNoisyImage.Enabled = false;
            this.btnCreateNoisyImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNoisyImage.Location = new System.Drawing.Point(320, 105);
            this.btnCreateNoisyImage.Name = "btnCreateNoisyImage";
            this.btnCreateNoisyImage.Size = new System.Drawing.Size(118, 23);
            this.btnCreateNoisyImage.TabIndex = 5;
            this.btnCreateNoisyImage.Text = "Створити ";
            this.btnCreateNoisyImage.UseVisualStyleBackColor = false;
            this.btnCreateNoisyImage.Click += new System.EventHandler(this.btnCreateNoisyImage_Click);
            // 
            // dUD_ListImage
            // 
            this.dUD_ListImage.Location = new System.Drawing.Point(484, 15);
            this.dUD_ListImage.Name = "dUD_ListImage";
            this.dUD_ListImage.ReadOnly = true;
            this.dUD_ListImage.Size = new System.Drawing.Size(414, 20);
            this.dUD_ListImage.TabIndex = 1;
            this.dUD_ListImage.Text = "<доступних образів немає>";
            this.dUD_ListImage.SelectedItemChanged += new System.EventHandler(this.dUD_ListImage_SelectedItemChanged);
            // 
            // pcB_Image
            // 
            this.pcB_Image.BackColor = System.Drawing.Color.White;
            this.pcB_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcB_Image.Enabled = false;
            this.pcB_Image.Location = new System.Drawing.Point(484, 69);
            this.pcB_Image.MaximumSize = new System.Drawing.Size(500, 400);
            this.pcB_Image.MinimumSize = new System.Drawing.Size(100, 100);
            this.pcB_Image.Name = "pcB_Image";
            this.pcB_Image.Size = new System.Drawing.Size(500, 400);
            this.pcB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcB_Image.TabIndex = 0;
            this.pcB_Image.TabStop = false;
            this.pcB_Image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcB_Image_MouseDown);
            this.pcB_Image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcB_Image_MouseMove);
            // 
            // tbP_SelectLearnDataAndAddClassificator
            // 
            this.tbP_SelectLearnDataAndAddClassificator.Controls.Add(this.grB_EstimationQualityClassication);
            this.tbP_SelectLearnDataAndAddClassificator.Controls.Add(this.button1);
            this.tbP_SelectLearnDataAndAddClassificator.Controls.Add(this.grB_CreateClassificator);
            this.tbP_SelectLearnDataAndAddClassificator.Location = new System.Drawing.Point(4, 22);
            this.tbP_SelectLearnDataAndAddClassificator.Name = "tbP_SelectLearnDataAndAddClassificator";
            this.tbP_SelectLearnDataAndAddClassificator.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_SelectLearnDataAndAddClassificator.Size = new System.Drawing.Size(1012, 515);
            this.tbP_SelectLearnDataAndAddClassificator.TabIndex = 1;
            this.tbP_SelectLearnDataAndAddClassificator.Text = "Cтворення нового класифікатора";
            this.tbP_SelectLearnDataAndAddClassificator.UseVisualStyleBackColor = true;
            this.tbP_SelectLearnDataAndAddClassificator.Enter += new System.EventHandler(this.tbP_SelectLearnDataAndAddClassificator_Enter);
            // 
            // grB_EstimationQualityClassication
            // 
            this.grB_EstimationQualityClassication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB_EstimationQualityClassication.Controls.Add(this.dGV_ResultCrossValidation);
            this.grB_EstimationQualityClassication.Controls.Add(this.txB_CountParts);
            this.grB_EstimationQualityClassication.Controls.Add(this.lblCountParts);
            this.grB_EstimationQualityClassication.Controls.Add(this.grB_SettingOfProportion);
            this.grB_EstimationQualityClassication.Controls.Add(this.grB_TypePartition);
            this.grB_EstimationQualityClassication.Location = new System.Drawing.Point(735, 6);
            this.grB_EstimationQualityClassication.Name = "grB_EstimationQualityClassication";
            this.grB_EstimationQualityClassication.Size = new System.Drawing.Size(269, 472);
            this.grB_EstimationQualityClassication.TabIndex = 2;
            this.grB_EstimationQualityClassication.TabStop = false;
            this.grB_EstimationQualityClassication.Text = "Оцінка якості класифікації(результати CV)";
            this.grB_EstimationQualityClassication.Visible = false;
            // 
            // dGV_ResultCrossValidation
            // 
            this.dGV_ResultCrossValidation.AllowUserToAddRows = false;
            this.dGV_ResultCrossValidation.AllowUserToDeleteRows = false;
            this.dGV_ResultCrossValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_ResultCrossValidation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_ResultCrossValidation.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGV_ResultCrossValidation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ResultCrossValidation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDGV_Iteration,
            this.сolDGV_PercentCorrectClassific});
            this.dGV_ResultCrossValidation.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dGV_ResultCrossValidation.Location = new System.Drawing.Point(6, 206);
            this.dGV_ResultCrossValidation.Name = "dGV_ResultCrossValidation";
            this.dGV_ResultCrossValidation.ReadOnly = true;
            this.dGV_ResultCrossValidation.RowHeadersVisible = false;
            this.dGV_ResultCrossValidation.Size = new System.Drawing.Size(257, 226);
            this.dGV_ResultCrossValidation.TabIndex = 8;
            // 
            // colDGV_Iteration
            // 
            this.colDGV_Iteration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDGV_Iteration.FillWeight = 50F;
            this.colDGV_Iteration.HeaderText = "Ітерація";
            this.colDGV_Iteration.Name = "colDGV_Iteration";
            this.colDGV_Iteration.ReadOnly = true;
            this.colDGV_Iteration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // сolDGV_PercentCorrectClassific
            // 
            this.сolDGV_PercentCorrectClassific.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.сolDGV_PercentCorrectClassific.HeaderText = "Відсоток правильно класифікованих";
            this.сolDGV_PercentCorrectClassific.Name = "сolDGV_PercentCorrectClassific";
            this.сolDGV_PercentCorrectClassific.ReadOnly = true;
            this.сolDGV_PercentCorrectClassific.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txB_CountParts
            // 
            this.txB_CountParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txB_CountParts.Location = new System.Drawing.Point(133, 129);
            this.txB_CountParts.Name = "txB_CountParts";
            this.txB_CountParts.Size = new System.Drawing.Size(100, 20);
            this.txB_CountParts.TabIndex = 6;
            this.txB_CountParts.Text = "3";
            this.txB_CountParts.Visible = false;
            this.txB_CountParts.WordWrap = false;
            this.txB_CountParts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txB_CountParts_KeyDown);
            this.txB_CountParts.Validated += new System.EventHandler(this.txB_CountParts_Validated);
            // 
            // lblCountParts
            // 
            this.lblCountParts.AutoSize = true;
            this.lblCountParts.Location = new System.Drawing.Point(9, 132);
            this.lblCountParts.Name = "lblCountParts";
            this.lblCountParts.Size = new System.Drawing.Size(93, 13);
            this.lblCountParts.TabIndex = 7;
            this.lblCountParts.Text = "Кількість частин:";
            this.lblCountParts.Visible = false;
            // 
            // grB_SettingOfProportion
            // 
            this.grB_SettingOfProportion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB_SettingOfProportion.Controls.Add(this.lblPercentPartition);
            this.grB_SettingOfProportion.Controls.Add(this.lblCountIteration);
            this.grB_SettingOfProportion.Controls.Add(this.txB_PercentPartition);
            this.grB_SettingOfProportion.Controls.Add(this.nUD_CountIteration);
            this.grB_SettingOfProportion.Location = new System.Drawing.Point(6, 106);
            this.grB_SettingOfProportion.Name = "grB_SettingOfProportion";
            this.grB_SettingOfProportion.Size = new System.Drawing.Size(257, 83);
            this.grB_SettingOfProportion.TabIndex = 5;
            this.grB_SettingOfProportion.TabStop = false;
            this.grB_SettingOfProportion.Text = "Налаштування пропорційного розбиття";
            // 
            // lblPercentPartition
            // 
            this.lblPercentPartition.AutoSize = true;
            this.lblPercentPartition.Location = new System.Drawing.Point(6, 26);
            this.lblPercentPartition.Name = "lblPercentPartition";
            this.lblPercentPartition.Size = new System.Drawing.Size(130, 13);
            this.lblPercentPartition.TabIndex = 2;
            this.lblPercentPartition.Text = "Доля навчальних даних:";
            // 
            // lblCountIteration
            // 
            this.lblCountIteration.AutoSize = true;
            this.lblCountIteration.Location = new System.Drawing.Point(6, 51);
            this.lblCountIteration.Name = "lblCountIteration";
            this.lblCountIteration.Size = new System.Drawing.Size(112, 13);
            this.lblCountIteration.TabIndex = 4;
            this.lblCountIteration.Text = "Кількість повторень:";
            // 
            // txB_PercentPartition
            // 
            this.txB_PercentPartition.Location = new System.Drawing.Point(158, 23);
            this.txB_PercentPartition.Name = "txB_PercentPartition";
            this.txB_PercentPartition.Size = new System.Drawing.Size(93, 20);
            this.txB_PercentPartition.TabIndex = 1;
            this.txB_PercentPartition.Text = "0,75";
            this.txB_PercentPartition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txB_PercentPartition_KeyDown);
            this.txB_PercentPartition.Validated += new System.EventHandler(this.txB_PercentPartition_Validated);
            // 
            // nUD_CountIteration
            // 
            this.nUD_CountIteration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nUD_CountIteration.Location = new System.Drawing.Point(127, 49);
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
            this.nUD_CountIteration.Size = new System.Drawing.Size(93, 20);
            this.nUD_CountIteration.TabIndex = 3;
            this.nUD_CountIteration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // grB_TypePartition
            // 
            this.grB_TypePartition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB_TypePartition.Controls.Add(this.rdB_SpecifiedNumber_ofParts);
            this.grB_TypePartition.Controls.Add(this.rdB_SpecifiedProportion);
            this.grB_TypePartition.Location = new System.Drawing.Point(6, 22);
            this.grB_TypePartition.Name = "grB_TypePartition";
            this.grB_TypePartition.Size = new System.Drawing.Size(257, 78);
            this.grB_TypePartition.TabIndex = 0;
            this.grB_TypePartition.TabStop = false;
            this.grB_TypePartition.Text = "Тип розбиття";
            // 
            // rdB_SpecifiedNumber_ofParts
            // 
            this.rdB_SpecifiedNumber_ofParts.AutoSize = true;
            this.rdB_SpecifiedNumber_ofParts.Location = new System.Drawing.Point(6, 43);
            this.rdB_SpecifiedNumber_ofParts.Name = "rdB_SpecifiedNumber_ofParts";
            this.rdB_SpecifiedNumber_ofParts.Size = new System.Drawing.Size(146, 17);
            this.rdB_SpecifiedNumber_ofParts.TabIndex = 1;
            this.rdB_SpecifiedNumber_ofParts.Text = "задана кількість частин";
            this.rdB_SpecifiedNumber_ofParts.UseVisualStyleBackColor = true;
            // 
            // rdB_SpecifiedProportion
            // 
            this.rdB_SpecifiedProportion.AutoSize = true;
            this.rdB_SpecifiedProportion.Checked = true;
            this.rdB_SpecifiedProportion.Location = new System.Drawing.Point(6, 20);
            this.rdB_SpecifiedProportion.Name = "rdB_SpecifiedProportion";
            this.rdB_SpecifiedProportion.Size = new System.Drawing.Size(178, 17);
            this.rdB_SpecifiedProportion.TabIndex = 0;
            this.rdB_SpecifiedProportion.TabStop = true;
            this.rdB_SpecifiedProportion.Text = "випадково у заданій пропорції";
            this.rdB_SpecifiedProportion.UseVisualStyleBackColor = true;
            this.rdB_SpecifiedProportion.CheckedChanged += new System.EventHandler(this.rdB_SpecifiedProportion_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(929, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // grB_CreateClassificator
            // 
            this.grB_CreateClassificator.Controls.Add(this.lblCountCheckedImsForLearning);
            this.grB_CreateClassificator.Controls.Add(this.grB_UsingLearnData);
            this.grB_CreateClassificator.Controls.Add(this.pcB_DemoLearnIm);
            this.grB_CreateClassificator.Controls.Add(this.lblStatusCreateClassificator);
            this.grB_CreateClassificator.Controls.Add(this.btnCreateClassificator);
            this.grB_CreateClassificator.Controls.Add(this.cLB_LearnImages);
            this.grB_CreateClassificator.Controls.Add(this.lblDimensionality);
            this.grB_CreateClassificator.Controls.Add(this.cmB_Dimensionalitys);
            this.grB_CreateClassificator.Location = new System.Drawing.Point(8, 6);
            this.grB_CreateClassificator.Name = "grB_CreateClassificator";
            this.grB_CreateClassificator.Size = new System.Drawing.Size(721, 501);
            this.grB_CreateClassificator.TabIndex = 0;
            this.grB_CreateClassificator.TabStop = false;
            this.grB_CreateClassificator.Text = "Створення класифікатора";
            // 
            // lblCountCheckedImsForLearning
            // 
            this.lblCountCheckedImsForLearning.AutoSize = true;
            this.lblCountCheckedImsForLearning.Location = new System.Drawing.Point(3, 342);
            this.lblCountCheckedImsForLearning.Name = "lblCountCheckedImsForLearning";
            this.lblCountCheckedImsForLearning.Size = new System.Drawing.Size(103, 13);
            this.lblCountCheckedImsForLearning.TabIndex = 8;
            this.lblCountCheckedImsForLearning.Text = "count_checked_ims";
            // 
            // grB_UsingLearnData
            // 
            this.grB_UsingLearnData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB_UsingLearnData.Controls.Add(this.rdB_CrossValidation);
            this.grB_UsingLearnData.Controls.Add(this.rdB_AllLearnData);
            this.grB_UsingLearnData.Location = new System.Drawing.Point(9, 371);
            this.grB_UsingLearnData.Name = "grB_UsingLearnData";
            this.grB_UsingLearnData.Size = new System.Drawing.Size(200, 79);
            this.grB_UsingLearnData.TabIndex = 7;
            this.grB_UsingLearnData.TabStop = false;
            this.grB_UsingLearnData.Text = "Використання навчальних даних";
            // 
            // rdB_CrossValidation
            // 
            this.rdB_CrossValidation.AutoSize = true;
            this.rdB_CrossValidation.Location = new System.Drawing.Point(6, 45);
            this.rdB_CrossValidation.Name = "rdB_CrossValidation";
            this.rdB_CrossValidation.Size = new System.Drawing.Size(120, 17);
            this.rdB_CrossValidation.TabIndex = 1;
            this.rdB_CrossValidation.Text = "Cross Validation(CV)";
            this.rdB_CrossValidation.UseVisualStyleBackColor = true;
            this.rdB_CrossValidation.CheckedChanged += new System.EventHandler(this.rdB_CrossValidation_CheckedChanged);
            // 
            // rdB_AllLearnData
            // 
            this.rdB_AllLearnData.AutoSize = true;
            this.rdB_AllLearnData.Checked = true;
            this.rdB_AllLearnData.Location = new System.Drawing.Point(6, 22);
            this.rdB_AllLearnData.Name = "rdB_AllLearnData";
            this.rdB_AllLearnData.Size = new System.Drawing.Size(85, 17);
            this.rdB_AllLearnData.TabIndex = 0;
            this.rdB_AllLearnData.TabStop = true;
            this.rdB_AllLearnData.Text = "Вся вибірка";
            this.rdB_AllLearnData.UseVisualStyleBackColor = true;
            // 
            // pcB_DemoLearnIm
            // 
            this.pcB_DemoLearnIm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcB_DemoLearnIm.BackColor = System.Drawing.Color.White;
            this.pcB_DemoLearnIm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcB_DemoLearnIm.Location = new System.Drawing.Point(215, 19);
            this.pcB_DemoLearnIm.MaximumSize = new System.Drawing.Size(500, 400);
            this.pcB_DemoLearnIm.MinimumSize = new System.Drawing.Size(100, 100);
            this.pcB_DemoLearnIm.Name = "pcB_DemoLearnIm";
            this.pcB_DemoLearnIm.Size = new System.Drawing.Size(500, 400);
            this.pcB_DemoLearnIm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcB_DemoLearnIm.TabIndex = 6;
            this.pcB_DemoLearnIm.TabStop = false;
            // 
            // lblStatusCreateClassificator
            // 
            this.lblStatusCreateClassificator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatusCreateClassificator.AutoSize = true;
            this.lblStatusCreateClassificator.Location = new System.Drawing.Point(6, 482);
            this.lblStatusCreateClassificator.Name = "lblStatusCreateClassificator";
            this.lblStatusCreateClassificator.Size = new System.Drawing.Size(35, 13);
            this.lblStatusCreateClassificator.TabIndex = 5;
            this.lblStatusCreateClassificator.Text = "status";
            // 
            // btnCreateClassificator
            // 
            this.btnCreateClassificator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateClassificator.Location = new System.Drawing.Point(6, 456);
            this.btnCreateClassificator.Name = "btnCreateClassificator";
            this.btnCreateClassificator.Size = new System.Drawing.Size(203, 23);
            this.btnCreateClassificator.TabIndex = 4;
            this.btnCreateClassificator.Text = "Створити";
            this.btnCreateClassificator.UseVisualStyleBackColor = true;
            this.btnCreateClassificator.Click += new System.EventHandler(this.btnCreateClassificator_Click);
            // 
            // cLB_LearnImages
            // 
            this.cLB_LearnImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cLB_LearnImages.CheckOnClick = true;
            this.cLB_LearnImages.FormattingEnabled = true;
            this.cLB_LearnImages.Location = new System.Drawing.Point(6, 65);
            this.cLB_LearnImages.Name = "cLB_LearnImages";
            this.cLB_LearnImages.Size = new System.Drawing.Size(203, 274);
            this.cLB_LearnImages.TabIndex = 3;
            this.cLB_LearnImages.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cLB_LearnImages_ItemCheck);
            this.cLB_LearnImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cLB_MouseClick);
            this.cLB_LearnImages.SelectedIndexChanged += new System.EventHandler(this.cLB_LearnImages_SelectedIndexChanged);
            this.cLB_LearnImages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cLB_KeyDown);
            this.cLB_LearnImages.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cLB_KeyUp);
            // 
            // lblDimensionality
            // 
            this.lblDimensionality.AutoSize = true;
            this.lblDimensionality.Location = new System.Drawing.Point(6, 22);
            this.lblDimensionality.Name = "lblDimensionality";
            this.lblDimensionality.Size = new System.Drawing.Size(70, 13);
            this.lblDimensionality.TabIndex = 2;
            this.lblDimensionality.Text = "Розмірність:";
            // 
            // cmB_Dimensionalitys
            // 
            this.cmB_Dimensionalitys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmB_Dimensionalitys.FormattingEnabled = true;
            this.cmB_Dimensionalitys.Location = new System.Drawing.Point(6, 38);
            this.cmB_Dimensionalitys.Name = "cmB_Dimensionalitys";
            this.cmB_Dimensionalitys.Size = new System.Drawing.Size(203, 21);
            this.cmB_Dimensionalitys.TabIndex = 1;
            this.cmB_Dimensionalitys.SelectedIndexChanged += new System.EventHandler(this.cmB_Dimensionalitys_SelectedIndexChanged);
            // 
            // tbP_TestingClassificators
            // 
            this.tbP_TestingClassificators.Location = new System.Drawing.Point(4, 22);
            this.tbP_TestingClassificators.Name = "tbP_TestingClassificators";
            this.tbP_TestingClassificators.Size = new System.Drawing.Size(1012, 515);
            this.tbP_TestingClassificators.TabIndex = 2;
            this.tbP_TestingClassificators.Text = "Тестування класифікаторів";
            this.tbP_TestingClassificators.UseVisualStyleBackColor = true;
            // 
            // tbP_EstimationQualityClassication
            // 
            this.tbP_EstimationQualityClassication.Location = new System.Drawing.Point(4, 22);
            this.tbP_EstimationQualityClassication.Name = "tbP_EstimationQualityClassication";
            this.tbP_EstimationQualityClassication.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_EstimationQualityClassication.Size = new System.Drawing.Size(1012, 515);
            this.tbP_EstimationQualityClassication.TabIndex = 3;
            this.tbP_EstimationQualityClassication.Text = "Оцінка якості класифікації";
            this.tbP_EstimationQualityClassication.UseVisualStyleBackColor = true;
            // 
            // tbP_Classification
            // 
            this.tbP_Classification.Location = new System.Drawing.Point(4, 22);
            this.tbP_Classification.Name = "tbP_Classification";
            this.tbP_Classification.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_Classification.Size = new System.Drawing.Size(1012, 515);
            this.tbP_Classification.TabIndex = 4;
            this.tbP_Classification.Text = "Класифікація образів";
            this.tbP_Classification.UseVisualStyleBackColor = true;
            // 
            // oFD_Loader
            // 
            this.oFD_Loader.DefaultExt = "txt";
            this.oFD_Loader.Filter = "Текстові файли|*.txt";
            this.oFD_Loader.InitialDirectory = ".";
            this.oFD_Loader.Title = "Оберіть коректний файл з образами";
            // 
            // sFD_Saver
            // 
            this.sFD_Saver.DefaultExt = "txt";
            this.sFD_Saver.Filter = "Текстові файли|*.txt";
            this.sFD_Saver.InitialDirectory = ".";
            this.sFD_Saver.Title = "Оберіть файл для перезапису або вкажіть ім\'я для нового файлу";
            // 
            // frmMashineLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 541);
            this.Controls.Add(this.tbC_Main);
            this.Name = "frmMashineLearning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Класифікація образів";
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
            this.grB_UsingLearnData.ResumeLayout(false);
            this.grB_UsingLearnData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_DemoLearnIm)).EndInit();
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
        private System.Windows.Forms.TabPage tbP_TestingClassificators;
        private System.Windows.Forms.TabPage tbP_EstimationQualityClassication;
        private System.Windows.Forms.TabPage tbP_Classification;
        private System.Windows.Forms.GroupBox grB_CreateClassificator;
        private System.Windows.Forms.CheckedListBox cLB_LearnImages;
        private System.Windows.Forms.Label lblDimensionality;
        private System.Windows.Forms.ComboBox cmB_Dimensionalitys;
        private System.Windows.Forms.Label lblStatusCreateClassificator;
        private System.Windows.Forms.Button btnCreateClassificator;
        private System.Windows.Forms.PictureBox pcB_DemoLearnIm;
        private System.Windows.Forms.Button button1;
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
    }
}

