namespace Interpol
{
    partial class EditCriminal
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelNickname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxGaveUp = new System.Windows.Forms.CheckBox();
            this.checkBoxIsDead = new System.Windows.Forms.CheckBox();
            this.groupBoxDeath = new System.Windows.Forms.GroupBox();
            this.textBoxDeathCircs = new System.Windows.Forms.TextBox();
            this.textBoxDeathPlace = new System.Windows.Forms.TextBox();
            this.dateTimePickerDeath = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.textBoxBirthPlace = new System.Windows.Forms.TextBox();
            this.textBoxCitizenship = new System.Windows.Forms.TextBox();
            this.textBoxSpec = new System.Windows.Forms.TextBox();
            this.textBoxHair = new System.Windows.Forms.TextBox();
            this.textBoxEyes = new System.Windows.Forms.TextBox();
            this.textBoxLang = new System.Windows.Forms.TextBox();
            this.textBoxResidence = new System.Windows.Forms.TextBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardfileDataSet = new Interpol.cardfileDataSet();
            this.groupsTableAdapter = new Interpol.cardfileDataSetTableAdapters.GroupsTableAdapter();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.buttonFileSearch = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.flowLayoutPanelSentences = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxDeath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfileDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(181, 8);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(151, 33);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(78, 19);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Фамилия:";
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNickname.Location = new System.Drawing.Point(163, 58);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(63, 19);
            this.labelNickname.TabIndex = 12;
            this.labelNickname.Text = "Кличка:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(110, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата рождения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(99, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Место рождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(124, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Гражданство:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(108, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Специализация:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(180, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Рост:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(160, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Волосы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(174, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Глаза:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(113, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Знание языков:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(18, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Последнее место жительства:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(125, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Группировка:";
            // 
            // checkBoxGaveUp
            // 
            this.checkBoxGaveUp.AutoSize = true;
            this.checkBoxGaveUp.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxGaveUp.Location = new System.Drawing.Point(227, 324);
            this.checkBoxGaveUp.Name = "checkBoxGaveUp";
            this.checkBoxGaveUp.Size = new System.Drawing.Size(105, 25);
            this.checkBoxGaveUp.TabIndex = 26;
            this.checkBoxGaveUp.Text = "\"Завязал\"";
            this.checkBoxGaveUp.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsDead
            // 
            this.checkBoxIsDead.AutoSize = true;
            this.checkBoxIsDead.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIsDead.Location = new System.Drawing.Point(227, 349);
            this.checkBoxIsDead.Name = "checkBoxIsDead";
            this.checkBoxIsDead.Size = new System.Drawing.Size(80, 25);
            this.checkBoxIsDead.TabIndex = 27;
            this.checkBoxIsDead.Text = "Мертв";
            this.checkBoxIsDead.UseVisualStyleBackColor = true;
            this.checkBoxIsDead.CheckedChanged += new System.EventHandler(this.checkBoxIsDead_CheckedChanged);
            // 
            // groupBoxDeath
            // 
            this.groupBoxDeath.Controls.Add(this.textBoxDeathCircs);
            this.groupBoxDeath.Controls.Add(this.textBoxDeathPlace);
            this.groupBoxDeath.Controls.Add(this.dateTimePickerDeath);
            this.groupBoxDeath.Controls.Add(this.label13);
            this.groupBoxDeath.Controls.Add(this.label12);
            this.groupBoxDeath.Controls.Add(this.label11);
            this.groupBoxDeath.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDeath.Location = new System.Drawing.Point(12, 381);
            this.groupBoxDeath.Name = "groupBoxDeath";
            this.groupBoxDeath.Size = new System.Drawing.Size(484, 112);
            this.groupBoxDeath.TabIndex = 28;
            this.groupBoxDeath.TabStop = false;
            this.groupBoxDeath.Text = "Смерть";
            this.groupBoxDeath.Visible = false;
            // 
            // textBoxDeathCircs
            // 
            this.textBoxDeathCircs.Location = new System.Drawing.Point(150, 81);
            this.textBoxDeathCircs.Name = "textBoxDeathCircs";
            this.textBoxDeathCircs.Size = new System.Drawing.Size(269, 24);
            this.textBoxDeathCircs.TabIndex = 45;
            // 
            // textBoxDeathPlace
            // 
            this.textBoxDeathPlace.Location = new System.Drawing.Point(137, 51);
            this.textBoxDeathPlace.Name = "textBoxDeathPlace";
            this.textBoxDeathPlace.Size = new System.Drawing.Size(269, 24);
            this.textBoxDeathPlace.TabIndex = 44;
            // 
            // dateTimePickerDeath
            // 
            this.dateTimePickerDeath.Location = new System.Drawing.Point(124, 21);
            this.dateTimePickerDeath.Name = "dateTimePickerDeath";
            this.dateTimePickerDeath.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerDeath.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Обстоятельства:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "Место смерти:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Дата смерти:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(227, 9);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(269, 24);
            this.textBoxName.TabIndex = 30;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(227, 33);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(269, 24);
            this.textBoxSurname.TabIndex = 31;
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNickname.Location = new System.Drawing.Point(227, 57);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(269, 24);
            this.textBoxNickname.TabIndex = 32;
            // 
            // textBoxBirthPlace
            // 
            this.textBoxBirthPlace.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBirthPlace.Location = new System.Drawing.Point(227, 105);
            this.textBoxBirthPlace.Name = "textBoxBirthPlace";
            this.textBoxBirthPlace.Size = new System.Drawing.Size(269, 24);
            this.textBoxBirthPlace.TabIndex = 34;
            // 
            // textBoxCitizenship
            // 
            this.textBoxCitizenship.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCitizenship.Location = new System.Drawing.Point(227, 129);
            this.textBoxCitizenship.Name = "textBoxCitizenship";
            this.textBoxCitizenship.Size = new System.Drawing.Size(269, 24);
            this.textBoxCitizenship.TabIndex = 35;
            // 
            // textBoxSpec
            // 
            this.textBoxSpec.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpec.Location = new System.Drawing.Point(227, 153);
            this.textBoxSpec.Name = "textBoxSpec";
            this.textBoxSpec.Size = new System.Drawing.Size(269, 24);
            this.textBoxSpec.TabIndex = 36;
            // 
            // textBoxHair
            // 
            this.textBoxHair.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHair.Location = new System.Drawing.Point(227, 201);
            this.textBoxHair.Name = "textBoxHair";
            this.textBoxHair.Size = new System.Drawing.Size(269, 24);
            this.textBoxHair.TabIndex = 38;
            // 
            // textBoxEyes
            // 
            this.textBoxEyes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEyes.Location = new System.Drawing.Point(227, 225);
            this.textBoxEyes.Name = "textBoxEyes";
            this.textBoxEyes.Size = new System.Drawing.Size(269, 24);
            this.textBoxEyes.TabIndex = 39;
            // 
            // textBoxLang
            // 
            this.textBoxLang.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLang.Location = new System.Drawing.Point(227, 249);
            this.textBoxLang.Name = "textBoxLang";
            this.textBoxLang.Size = new System.Drawing.Size(269, 24);
            this.textBoxLang.TabIndex = 40;
            // 
            // textBoxResidence
            // 
            this.textBoxResidence.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResidence.Location = new System.Drawing.Point(227, 273);
            this.textBoxResidence.Name = "textBoxResidence";
            this.textBoxResidence.Size = new System.Drawing.Size(269, 24);
            this.textBoxResidence.TabIndex = 41;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DataSource = this.groupsBindingSource;
            this.comboBoxGroup.DisplayMember = "Group_name";
            this.comboBoxGroup.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(227, 297);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(120, 27);
            this.comboBoxGroup.TabIndex = 42;
            this.comboBoxGroup.ValueMember = "Group_code";
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
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirth.Location = new System.Drawing.Point(227, 81);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerBirth.TabIndex = 43;
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownHeight.Location = new System.Drawing.Point(227, 177);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(120, 24);
            this.numericUpDownHeight.TabIndex = 44;
            // 
            // buttonFileSearch
            // 
            this.buttonFileSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFileSearch.Location = new System.Drawing.Point(421, 498);
            this.buttonFileSearch.Name = "buttonFileSearch";
            this.buttonFileSearch.Size = new System.Drawing.Size(75, 32);
            this.buttonFileSearch.TabIndex = 45;
            this.buttonFileSearch.Text = "Обзор";
            this.buttonFileSearch.UseVisualStyleBackColor = true;
            this.buttonFileSearch.Click += new System.EventHandler(this.buttonFileSearch_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 505);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 19);
            this.label14.TabIndex = 46;
            this.label14.Text = "Добавить фото:";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(128, 502);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(287, 24);
            this.textBoxFilePath.TabIndex = 46;
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(12, 539);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 32);
            this.buttonSave.TabIndex = 47;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // flowLayoutPanelSentences
            // 
            this.flowLayoutPanelSentences.AutoScroll = true;
            this.flowLayoutPanelSentences.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelSentences.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelSentences.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanelSentences.Location = new System.Drawing.Point(502, 0);
            this.flowLayoutPanelSentences.Name = "flowLayoutPanelSentences";
            this.flowLayoutPanelSentences.Size = new System.Drawing.Size(772, 583);
            this.flowLayoutPanelSentences.TabIndex = 48;
            // 
            // EditCriminal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1274, 583);
            this.Controls.Add(this.flowLayoutPanelSentences);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonFileSearch);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.textBoxResidence);
            this.Controls.Add(this.textBoxLang);
            this.Controls.Add(this.textBoxEyes);
            this.Controls.Add(this.textBoxHair);
            this.Controls.Add(this.checkBoxIsDead);
            this.Controls.Add(this.textBoxSpec);
            this.Controls.Add(this.textBoxCitizenship);
            this.Controls.Add(this.textBoxBirthPlace);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.groupBoxDeath);
            this.Controls.Add(this.checkBoxGaveUp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "EditCriminal";
            this.Text = "Редактировать";
            this.Load += new System.EventHandler(this.EditCriminal_Load);
            this.groupBoxDeath.ResumeLayout(false);
            this.groupBoxDeath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfileDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxGaveUp;
        private System.Windows.Forms.CheckBox checkBoxIsDead;
        private System.Windows.Forms.GroupBox groupBoxDeath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.TextBox textBoxBirthPlace;
        private System.Windows.Forms.TextBox textBoxCitizenship;
        private System.Windows.Forms.TextBox textBoxSpec;
        private System.Windows.Forms.TextBox textBoxHair;
        private System.Windows.Forms.TextBox textBoxEyes;
        private System.Windows.Forms.TextBox textBoxLang;
        private System.Windows.Forms.TextBox textBoxResidence;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private cardfileDataSet cardfileDataSet;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private cardfileDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.TextBox textBoxDeathCircs;
        private System.Windows.Forms.TextBox textBoxDeathPlace;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeath;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Button buttonFileSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSentences;
    }
}