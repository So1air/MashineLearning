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
            this.tbP_CreateImages = new System.Windows.Forms.TabPage();
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
            this.oFD_Loader = new System.Windows.Forms.OpenFileDialog();
            this.sFD_Saver = new System.Windows.Forms.SaveFileDialog();
            this.tbC_Main.SuspendLayout();
            this.tbP_CreateImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_ColCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_RowCount)).BeginInit();
            this.pnl_SaveAndLoad.SuspendLayout();
            this.grB_AddModel.SuspendLayout();
            this.grB_CreateNoisyImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_EpsNoisy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountNoisy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // tbC_Main
            // 
            this.tbC_Main.Controls.Add(this.tbP_CreateImages);
            this.tbC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbC_Main.Location = new System.Drawing.Point(0, 0);
            this.tbC_Main.Name = "tbC_Main";
            this.tbC_Main.SelectedIndex = 0;
            this.tbC_Main.Size = new System.Drawing.Size(1020, 541);
            this.tbC_Main.TabIndex = 0;
            // 
            // tbP_CreateImages
            // 
            this.tbP_CreateImages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbP_CreateImages.Controls.Add(this.lblCursorPosInMatrCoord);
            this.tbP_CreateImages.Controls.Add(this.lblCurrMatrCoord);
            this.tbP_CreateImages.Controls.Add(this.btnDeleteIm);
            this.tbP_CreateImages.Controls.Add(this.btnChangeIm);
            this.tbP_CreateImages.Controls.Add(this.btnCancelIm);
            this.tbP_CreateImages.Controls.Add(this.btnAcceptIm);
            this.tbP_CreateImages.Controls.Add(this.nUD_ColCount);
            this.tbP_CreateImages.Controls.Add(this.lbl_ColCount);
            this.tbP_CreateImages.Controls.Add(this.lbl_RowCount);
            this.tbP_CreateImages.Controls.Add(this.lblParMatrix);
            this.tbP_CreateImages.Controls.Add(this.nUD_RowCount);
            this.tbP_CreateImages.Controls.Add(this.pnl_SaveAndLoad);
            this.tbP_CreateImages.Controls.Add(this.grB_AddModel);
            this.tbP_CreateImages.Controls.Add(this.grB_CreateNoisyImages);
            this.tbP_CreateImages.Controls.Add(this.dUD_ListImage);
            this.tbP_CreateImages.Controls.Add(this.pcB_Image);
            this.tbP_CreateImages.Location = new System.Drawing.Point(4, 22);
            this.tbP_CreateImages.Name = "tbP_CreateImages";
            this.tbP_CreateImages.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_CreateImages.Size = new System.Drawing.Size(1012, 515);
            this.tbP_CreateImages.TabIndex = 0;
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
            this.cLB_ListAvalaibleImages.Size = new System.Drawing.Size(305, 169);
            this.cLB_ListAvalaibleImages.TabIndex = 1;
            this.cLB_ListAvalaibleImages.ThreeDCheckBoxes = true;
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
            this.dUD_ListImage.Size = new System.Drawing.Size(500, 20);
            this.dUD_ListImage.TabIndex = 1;
            this.dUD_ListImage.Text = "<список пустий>";
            this.dUD_ListImage.SelectedItemChanged += new System.EventHandler(this.dUD_ListImage_SelectedItemChanged);
            // 
            // pcB_Image
            // 
            this.pcB_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tbP_CreateImages.ResumeLayout(false);
            this.tbP_CreateImages.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbC_Main;
        private System.Windows.Forms.TabPage tbP_CreateImages;
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
    }
}

