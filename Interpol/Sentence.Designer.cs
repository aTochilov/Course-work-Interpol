namespace Interpol
{
    partial class Sentence
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelSentenceCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCrime = new System.Windows.Forms.TextBox();
            this.textBoxTerm = new System.Windows.Forms.TextBox();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.richTextBoxNotation = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerSentence = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRelease = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cardfileDataSet = new Interpol.cardfileDataSet();
            this.sentenceTableAdapter = new Interpol.cardfileDataSetTableAdapters.SentenceTableAdapter();
            this.comboBoxCrimes = new System.Windows.Forms.ComboBox();
            this.crimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crimesTableAdapter = new Interpol.cardfileDataSetTableAdapters.CrimesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfileDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSentenceCode
            // 
            this.labelSentenceCode.AutoSize = true;
            this.labelSentenceCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSentenceCode.Location = new System.Drawing.Point(5, 5);
            this.labelSentenceCode.Name = "labelSentenceCode";
            this.labelSentenceCode.Size = new System.Drawing.Size(30, 16);
            this.labelSentenceCode.TabIndex = 0;
            this.labelSentenceCode.Text = "Код";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Преступление:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(56, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Срок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Описание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(421, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата приговора:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(398, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата освобождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(372, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Примечания:";
            // 
            // textBoxCrime
            // 
            this.textBoxCrime.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCrime.Location = new System.Drawing.Point(100, 35);
            this.textBoxCrime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCrime.Name = "textBoxCrime";
            this.textBoxCrime.Size = new System.Drawing.Size(266, 21);
            this.textBoxCrime.TabIndex = 7;
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTerm.Location = new System.Drawing.Point(100, 66);
            this.textBoxTerm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.Size = new System.Drawing.Size(266, 21);
            this.textBoxTerm.TabIndex = 8;
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(100, 101);
            this.richTextBoxDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(266, 117);
            this.richTextBoxDesc.TabIndex = 9;
            this.richTextBoxDesc.Text = "";
            // 
            // richTextBoxNotation
            // 
            this.richTextBoxNotation.Location = new System.Drawing.Point(459, 102);
            this.richTextBoxNotation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxNotation.Name = "richTextBoxNotation";
            this.richTextBoxNotation.Size = new System.Drawing.Size(266, 117);
            this.richTextBoxNotation.TabIndex = 10;
            this.richTextBoxNotation.Text = "";
            // 
            // dateTimePickerSentence
            // 
            this.dateTimePickerSentence.Location = new System.Drawing.Point(525, 37);
            this.dateTimePickerSentence.Name = "dateTimePickerSentence";
            this.dateTimePickerSentence.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerSentence.TabIndex = 11;
            // 
            // dateTimePickerRelease
            // 
            this.dateTimePickerRelease.Location = new System.Drawing.Point(525, 69);
            this.dateTimePickerRelease.Name = "dateTimePickerRelease";
            this.dateTimePickerRelease.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerRelease.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Location = new System.Drawing.Point(649, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.cardfileDataSet;
            this.bindingSource1.Position = 0;
            // 
            // cardfileDataSet
            // 
            this.cardfileDataSet.DataSetName = "cardfileDataSet";
            this.cardfileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sentenceTableAdapter
            // 
            this.sentenceTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxCrimes
            // 
            this.comboBoxCrimes.DataSource = this.crimesBindingSource;
            this.comboBoxCrimes.DisplayMember = "Crime_type";
            this.comboBoxCrimes.FormattingEnabled = true;
            this.comboBoxCrimes.Location = new System.Drawing.Point(100, 35);
            this.comboBoxCrimes.Name = "comboBoxCrimes";
            this.comboBoxCrimes.Size = new System.Drawing.Size(266, 24);
            this.comboBoxCrimes.TabIndex = 14;
            this.comboBoxCrimes.ValueMember = "Crime_code";
            this.comboBoxCrimes.Visible = false;
            // 
            // crimesBindingSource
            // 
            this.crimesBindingSource.DataMember = "Crimes";
            this.crimesBindingSource.DataSource = this.bindingSource1;
            // 
            // crimesTableAdapter
            // 
            this.crimesTableAdapter.ClearBeforeFill = true;
            // 
            // Sentence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.comboBoxCrimes);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerRelease);
            this.Controls.Add(this.dateTimePickerSentence);
            this.Controls.Add(this.richTextBoxNotation);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.textBoxTerm);
            this.Controls.Add(this.textBoxCrime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSentenceCode);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "Sentence";
            this.Size = new System.Drawing.Size(732, 230);
            this.Load += new System.EventHandler(this.Sentence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfileDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSentenceCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCrime;
        private System.Windows.Forms.TextBox textBoxTerm;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.RichTextBox richTextBoxNotation;
        private System.Windows.Forms.DateTimePicker dateTimePickerSentence;
        private System.Windows.Forms.DateTimePicker dateTimePickerRelease;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource bindingSource1;
        private cardfileDataSet cardfileDataSet;
        private cardfileDataSetTableAdapters.SentenceTableAdapter sentenceTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxCrimes;
        private System.Windows.Forms.BindingSource crimesBindingSource;
        private cardfileDataSetTableAdapters.CrimesTableAdapter crimesTableAdapter;
    }
}
