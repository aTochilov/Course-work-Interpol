namespace Interpol
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panelNavAdmin = new System.Windows.Forms.Panel();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonMore = new System.Windows.Forms.Button();
            this.panelMore = new System.Windows.Forms.Panel();
            this.buttonAddCriminal = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonTableDead = new System.Windows.Forms.Button();
            this.buttonTableGaveUp = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAddCriminal = new System.Windows.Forms.Panel();
            this.groupBoxDeath = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDeathPlace = new System.Windows.Forms.TextBox();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.textBoxDeathCircs = new System.Windows.Forms.TextBox();
            this.textBoxDeathDate = new System.Windows.Forms.TextBox();
            this.checkBoxDead = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardfileDataSet = new Interpol.cardfileDataSet();
            this.buttonInsertCriminal = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.buttonUploadPhoto = new System.Windows.Forms.Button();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.checkBoxGaveUp = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.textBoxSpec = new System.Windows.Forms.TextBox();
            this.textBoxLang = new System.Windows.Forms.TextBox();
            this.textBoxHair = new System.Windows.Forms.TextBox();
            this.textBoxEyes = new System.Windows.Forms.TextBox();
            this.textBoxCitizenship = new System.Windows.Forms.TextBox();
            this.textBoxBirthPlace = new System.Windows.Forms.TextBox();
            this.textBoxResidence = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupsTableAdapter = new Interpol.cardfileDataSetTableAdapters.GroupsTableAdapter();
            this.groupsCriminalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criminalsTableAdapter = new Interpol.cardfileDataSetTableAdapters.CriminalsTableAdapter();
            this.groupsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelNavAdmin.SuspendLayout();
            this.panelMore.SuspendLayout();
            this.panelAddCriminal.SuspendLayout();
            this.groupBoxDeath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfileDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsCriminalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavAdmin
            // 
            this.panelNavAdmin.BackColor = System.Drawing.Color.SlateGray;
            this.panelNavAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNavAdmin.Controls.Add(this.buttonGroups);
            this.panelNavAdmin.Controls.Add(this.buttonMore);
            this.panelNavAdmin.Controls.Add(this.panelMore);
            this.panelNavAdmin.Controls.Add(this.buttonSearch);
            this.panelNavAdmin.Controls.Add(this.buttonBack);
            this.panelNavAdmin.Controls.Add(this.buttonTableDead);
            this.panelNavAdmin.Controls.Add(this.buttonTableGaveUp);
            this.panelNavAdmin.Controls.Add(this.buttonMain);
            this.panelNavAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelNavAdmin.Name = "panelNavAdmin";
            this.panelNavAdmin.Size = new System.Drawing.Size(195, 661);
            this.panelNavAdmin.TabIndex = 2;
            // 
            // buttonGroups
            // 
            this.buttonGroups.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroups.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGroups.Location = new System.Drawing.Point(-3, 228);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(195, 51);
            this.buttonGroups.TabIndex = 8;
            this.buttonGroups.Text = "Группировки";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonMore
            // 
            this.buttonMore.BackgroundImage = global::Interpol.Properties.Resources.arrow_down01_512;
            this.buttonMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMore.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMore.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMore.Location = new System.Drawing.Point(0, 285);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(195, 25);
            this.buttonMore.TabIndex = 7;
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // panelMore
            // 
            this.panelMore.Controls.Add(this.buttonAddCriminal);
            this.panelMore.Controls.Add(this.buttonAddUser);
            this.panelMore.Location = new System.Drawing.Point(0, 310);
            this.panelMore.Name = "panelMore";
            this.panelMore.Size = new System.Drawing.Size(195, 244);
            this.panelMore.TabIndex = 6;
            this.panelMore.Visible = false;
            // 
            // buttonAddCriminal
            // 
            this.buttonAddCriminal.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAddCriminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCriminal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCriminal.Location = new System.Drawing.Point(-2, 52);
            this.buttonAddCriminal.Name = "buttonAddCriminal";
            this.buttonAddCriminal.Size = new System.Drawing.Size(195, 51);
            this.buttonAddCriminal.TabIndex = 8;
            this.buttonAddCriminal.Text = "Добавить преступника";
            this.buttonAddCriminal.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.Location = new System.Drawing.Point(-3, 0);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(195, 51);
            this.buttonAddUser.TabIndex = 7;
            this.buttonAddUser.Text = "Добавить пользователя";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(0, 57);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(195, 51);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.Location = new System.Drawing.Point(0, 606);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(191, 51);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Выйти";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonTableDead
            // 
            this.buttonTableDead.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonTableDead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTableDead.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTableDead.Location = new System.Drawing.Point(0, 171);
            this.buttonTableDead.Name = "buttonTableDead";
            this.buttonTableDead.Size = new System.Drawing.Size(195, 51);
            this.buttonTableDead.TabIndex = 2;
            this.buttonTableDead.Text = "Умершие";
            this.buttonTableDead.UseVisualStyleBackColor = true;
            this.buttonTableDead.Click += new System.EventHandler(this.buttonTableDead_Click);
            // 
            // buttonTableGaveUp
            // 
            this.buttonTableGaveUp.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonTableGaveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTableGaveUp.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTableGaveUp.Location = new System.Drawing.Point(0, 114);
            this.buttonTableGaveUp.Name = "buttonTableGaveUp";
            this.buttonTableGaveUp.Size = new System.Drawing.Size(195, 51);
            this.buttonTableGaveUp.TabIndex = 1;
            this.buttonTableGaveUp.Text = "Завязавшие";
            this.buttonTableGaveUp.UseVisualStyleBackColor = true;
            this.buttonTableGaveUp.Click += new System.EventHandler(this.buttonTableGaveUp_Click);
            // 
            // buttonMain
            // 
            this.buttonMain.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMain.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMain.Location = new System.Drawing.Point(0, 0);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(195, 51);
            this.buttonMain.TabIndex = 0;
            this.buttonMain.Text = "Главная";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(195, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(439, 661);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // panelAddCriminal
            // 
            this.panelAddCriminal.BackColor = System.Drawing.Color.SlateGray;
            this.panelAddCriminal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAddCriminal.Controls.Add(this.groupBoxDeath);
            this.panelAddCriminal.Controls.Add(this.checkBoxDead);
            this.panelAddCriminal.Controls.Add(this.label18);
            this.panelAddCriminal.Controls.Add(this.numericUpDownHeight);
            this.panelAddCriminal.Controls.Add(this.monthCalendar1);
            this.panelAddCriminal.Controls.Add(this.comboBoxGroups);
            this.panelAddCriminal.Controls.Add(this.buttonInsertCriminal);
            this.panelAddCriminal.Controls.Add(this.labelFilePath);
            this.panelAddCriminal.Controls.Add(this.buttonUploadPhoto);
            this.panelAddCriminal.Controls.Add(this.dateTimePickerBirth);
            this.panelAddCriminal.Controls.Add(this.checkBoxGaveUp);
            this.panelAddCriminal.Controls.Add(this.textBoxName);
            this.panelAddCriminal.Controls.Add(this.textBoxSurname);
            this.panelAddCriminal.Controls.Add(this.textBoxNickname);
            this.panelAddCriminal.Controls.Add(this.textBoxSpec);
            this.panelAddCriminal.Controls.Add(this.textBoxLang);
            this.panelAddCriminal.Controls.Add(this.textBoxHair);
            this.panelAddCriminal.Controls.Add(this.textBoxEyes);
            this.panelAddCriminal.Controls.Add(this.textBoxCitizenship);
            this.panelAddCriminal.Controls.Add(this.textBoxBirthPlace);
            this.panelAddCriminal.Controls.Add(this.textBoxResidence);
            this.panelAddCriminal.Controls.Add(this.label17);
            this.panelAddCriminal.Controls.Add(this.label16);
            this.panelAddCriminal.Controls.Add(this.label15);
            this.panelAddCriminal.Controls.Add(this.label14);
            this.panelAddCriminal.Controls.Add(this.label10);
            this.panelAddCriminal.Controls.Add(this.label9);
            this.panelAddCriminal.Controls.Add(this.label8);
            this.panelAddCriminal.Controls.Add(this.label7);
            this.panelAddCriminal.Controls.Add(this.label6);
            this.panelAddCriminal.Controls.Add(this.label5);
            this.panelAddCriminal.Controls.Add(this.label4);
            this.panelAddCriminal.Controls.Add(this.label3);
            this.panelAddCriminal.Controls.Add(this.label2);
            this.panelAddCriminal.Controls.Add(this.label1);
            this.panelAddCriminal.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAddCriminal.Location = new System.Drawing.Point(634, 0);
            this.panelAddCriminal.Name = "panelAddCriminal";
            this.panelAddCriminal.Size = new System.Drawing.Size(500, 661);
            this.panelAddCriminal.TabIndex = 4;
            this.panelAddCriminal.Visible = false;
            // 
            // groupBoxDeath
            // 
            this.groupBoxDeath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDeath.Controls.Add(this.label13);
            this.groupBoxDeath.Controls.Add(this.label11);
            this.groupBoxDeath.Controls.Add(this.label12);
            this.groupBoxDeath.Controls.Add(this.textBoxDeathPlace);
            this.groupBoxDeath.Controls.Add(this.buttonCalendar);
            this.groupBoxDeath.Controls.Add(this.textBoxDeathCircs);
            this.groupBoxDeath.Controls.Add(this.textBoxDeathDate);
            this.groupBoxDeath.Location = new System.Drawing.Point(12, 434);
            this.groupBoxDeath.Name = "groupBoxDeath";
            this.groupBoxDeath.Size = new System.Drawing.Size(474, 137);
            this.groupBoxDeath.TabIndex = 48;
            this.groupBoxDeath.TabStop = false;
            this.groupBoxDeath.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(47, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "Дата смерти:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(7, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Обстоятельства смерти:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(36, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Место смерти:";
            // 
            // textBoxDeathPlace
            // 
            this.textBoxDeathPlace.Location = new System.Drawing.Point(145, 50);
            this.textBoxDeathPlace.Name = "textBoxDeathPlace";
            this.textBoxDeathPlace.Size = new System.Drawing.Size(282, 20);
            this.textBoxDeathPlace.TabIndex = 26;
            this.textBoxDeathPlace.Text = "0";
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalendar.Location = new System.Drawing.Point(352, 18);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(75, 23);
            this.buttonCalendar.TabIndex = 44;
            this.buttonCalendar.Text = "Выбрать";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // textBoxDeathCircs
            // 
            this.textBoxDeathCircs.Location = new System.Drawing.Point(178, 80);
            this.textBoxDeathCircs.Name = "textBoxDeathCircs";
            this.textBoxDeathCircs.Size = new System.Drawing.Size(282, 20);
            this.textBoxDeathCircs.TabIndex = 27;
            this.textBoxDeathCircs.Text = "0";
            // 
            // textBoxDeathDate
            // 
            this.textBoxDeathDate.Location = new System.Drawing.Point(145, 19);
            this.textBoxDeathDate.Name = "textBoxDeathDate";
            this.textBoxDeathDate.Size = new System.Drawing.Size(200, 20);
            this.textBoxDeathDate.TabIndex = 42;
            this.textBoxDeathDate.Text = "0";
            // 
            // checkBoxDead
            // 
            this.checkBoxDead.AutoSize = true;
            this.checkBoxDead.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDead.Location = new System.Drawing.Point(291, 414);
            this.checkBoxDead.Name = "checkBoxDead";
            this.checkBoxDead.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDead.TabIndex = 47;
            this.checkBoxDead.UseVisualStyleBackColor = true;
            this.checkBoxDead.CheckedChanged += new System.EventHandler(this.checkBoxDead_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(234, 409);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 19);
            this.label18.TabIndex = 46;
            this.label18.Text = "Мертв:";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(153, 320);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHeight.TabIndex = 45;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(322, 266);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 43;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.DataSource = this.groupsBindingSource;
            this.comboBoxGroups.DisplayMember = "Group_name";
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(153, 379);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(282, 21);
            this.comboBoxGroups.TabIndex = 41;
            this.comboBoxGroups.ValueMember = "Group_code";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.cardfileDataSet;
            // 
            // cardfileDataSet
            // 
            this.cardfileDataSet.DataSetName = "cardfileDataSet";
            this.cardfileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonInsertCriminal
            // 
            this.buttonInsertCriminal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsertCriminal.Location = new System.Drawing.Point(176, 606);
            this.buttonInsertCriminal.Name = "buttonInsertCriminal";
            this.buttonInsertCriminal.Size = new System.Drawing.Size(147, 39);
            this.buttonInsertCriminal.TabIndex = 40;
            this.buttonInsertCriminal.Text = "Сохранить";
            this.buttonInsertCriminal.UseVisualStyleBackColor = true;
            this.buttonInsertCriminal.Click += new System.EventHandler(this.buttonInsertCriminal_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilePath.Location = new System.Drawing.Point(157, 579);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(183, 19);
            this.labelFilePath.TabIndex = 39;
            this.labelFilePath.Text = "*Выбранный путь к файлу*";
            // 
            // buttonUploadPhoto
            // 
            this.buttonUploadPhoto.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUploadPhoto.Location = new System.Drawing.Point(27, 579);
            this.buttonUploadPhoto.Name = "buttonUploadPhoto";
            this.buttonUploadPhoto.Size = new System.Drawing.Size(128, 23);
            this.buttonUploadPhoto.TabIndex = 38;
            this.buttonUploadPhoto.Text = "Загрузить фото";
            this.buttonUploadPhoto.UseVisualStyleBackColor = true;
            this.buttonUploadPhoto.Click += new System.EventHandler(this.buttonUploadPhoto_Click);
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirth.Location = new System.Drawing.Point(153, 138);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerBirth.TabIndex = 36;
            // 
            // checkBoxGaveUp
            // 
            this.checkBoxGaveUp.AutoSize = true;
            this.checkBoxGaveUp.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxGaveUp.Location = new System.Drawing.Point(153, 414);
            this.checkBoxGaveUp.Name = "checkBoxGaveUp";
            this.checkBoxGaveUp.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGaveUp.TabIndex = 33;
            this.checkBoxGaveUp.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(153, 17);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(282, 20);
            this.textBoxName.TabIndex = 31;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(153, 47);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(282, 20);
            this.textBoxSurname.TabIndex = 30;
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Location = new System.Drawing.Point(153, 77);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(282, 20);
            this.textBoxNickname.TabIndex = 29;
            // 
            // textBoxSpec
            // 
            this.textBoxSpec.Location = new System.Drawing.Point(153, 108);
            this.textBoxSpec.Name = "textBoxSpec";
            this.textBoxSpec.Size = new System.Drawing.Size(282, 20);
            this.textBoxSpec.TabIndex = 28;
            // 
            // textBoxLang
            // 
            this.textBoxLang.Location = new System.Drawing.Point(153, 349);
            this.textBoxLang.Name = "textBoxLang";
            this.textBoxLang.Size = new System.Drawing.Size(282, 20);
            this.textBoxLang.TabIndex = 23;
            // 
            // textBoxHair
            // 
            this.textBoxHair.Location = new System.Drawing.Point(153, 289);
            this.textBoxHair.Name = "textBoxHair";
            this.textBoxHair.Size = new System.Drawing.Size(282, 20);
            this.textBoxHair.TabIndex = 21;
            // 
            // textBoxEyes
            // 
            this.textBoxEyes.Location = new System.Drawing.Point(153, 258);
            this.textBoxEyes.Name = "textBoxEyes";
            this.textBoxEyes.Size = new System.Drawing.Size(282, 20);
            this.textBoxEyes.TabIndex = 20;
            // 
            // textBoxCitizenship
            // 
            this.textBoxCitizenship.Location = new System.Drawing.Point(153, 227);
            this.textBoxCitizenship.Name = "textBoxCitizenship";
            this.textBoxCitizenship.Size = new System.Drawing.Size(282, 20);
            this.textBoxCitizenship.TabIndex = 19;
            // 
            // textBoxBirthPlace
            // 
            this.textBoxBirthPlace.Location = new System.Drawing.Point(153, 167);
            this.textBoxBirthPlace.Name = "textBoxBirthPlace";
            this.textBoxBirthPlace.Size = new System.Drawing.Size(282, 20);
            this.textBoxBirthPlace.TabIndex = 18;
            // 
            // textBoxResidence
            // 
            this.textBoxResidence.Location = new System.Drawing.Point(153, 197);
            this.textBoxResidence.Name = "textBoxResidence";
            this.textBoxResidence.Size = new System.Drawing.Size(282, 20);
            this.textBoxResidence.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(106, 318);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 19);
            this.label17.TabIndex = 16;
            this.label17.Text = "Рост:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(39, 348);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 19);
            this.label16.TabIndex = 15;
            this.label16.Text = "Знание языков:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(84, 409);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 19);
            this.label15.TabIndex = 14;
            this.label15.Text = "Завязал:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(51, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "Группировка:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(89, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Кличка:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(24, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Специализация:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(24, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Дата рождения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Место рождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Место жительства:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(50, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Гражданство:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(100, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Глаза:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(86, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Волосы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // groupsCriminalsBindingSource
            // 
            this.groupsCriminalsBindingSource.DataMember = "GroupsCriminals";
            this.groupsCriminalsBindingSource.DataSource = this.groupsBindingSource;
            // 
            // criminalsTableAdapter
            // 
            this.criminalsTableAdapter.ClearBeforeFill = true;
            // 
            // groupsBindingSource1
            // 
            this.groupsBindingSource1.DataMember = "Groups";
            this.groupsBindingSource1.DataSource = this.cardfileDataSet;
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panelAddCriminal);
            this.Controls.Add(this.panelNavAdmin);
            this.MaximumSize = new System.Drawing.Size(1150, 700);
            this.MinimumSize = new System.Drawing.Size(1150, 700);
            this.Name = "AdminForm";
            this.Text = "Картотека | Доступ: 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelNavAdmin.ResumeLayout(false);
            this.panelMore.ResumeLayout(false);
            this.panelAddCriminal.ResumeLayout(false);
            this.panelAddCriminal.PerformLayout();
            this.groupBoxDeath.ResumeLayout(false);
            this.groupBoxDeath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfileDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsCriminalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNavAdmin;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonTableDead;
        private System.Windows.Forms.Button buttonTableGaveUp;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button buttonMore;
        private System.Windows.Forms.Panel panelMore;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Panel panelAddCriminal;
        private System.Windows.Forms.CheckBox checkBoxGaveUp;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.TextBox textBoxSpec;
        private System.Windows.Forms.TextBox textBoxDeathCircs;
        private System.Windows.Forms.TextBox textBoxDeathPlace;
        private System.Windows.Forms.TextBox textBoxLang;
        private System.Windows.Forms.TextBox textBoxHair;
        private System.Windows.Forms.TextBox textBoxEyes;
        private System.Windows.Forms.TextBox textBoxCitizenship;
        private System.Windows.Forms.TextBox textBoxBirthPlace;
        private System.Windows.Forms.TextBox textBoxResidence;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Button buttonInsertCriminal;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Button buttonUploadPhoto;
        private cardfileDataSet cardfileDataSet;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private cardfileDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.BindingSource groupsCriminalsBindingSource;
        private cardfileDataSetTableAdapters.CriminalsTableAdapter criminalsTableAdapter;
        private System.Windows.Forms.BindingSource groupsBindingSource1;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxDeathDate;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.GroupBox groupBoxDeath;
        private System.Windows.Forms.CheckBox checkBoxDead;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonAddCriminal;
    }
}