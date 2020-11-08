namespace Interpol
{
    partial class Criminal
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLastResidence = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSpecialization = new System.Windows.Forms.Label();
            this.buttonMore = new System.Windows.Forms.Button();
            this.pictureBoxCriminal = new System.Windows.Forms.PictureBox();
            this.labelNickname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCriminal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(170, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(163, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Long long name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(460, 20);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(193, 25);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Long long Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата рождения:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthDate.Location = new System.Drawing.Point(314, 87);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(96, 21);
            this.labelBirthDate.TabIndex = 4;
            this.labelBirthDate.Text = "00/00/0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(420, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Место жительства:";
            // 
            // labelLastResidence
            // 
            this.labelLastResidence.AutoSize = true;
            this.labelLastResidence.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastResidence.Location = new System.Drawing.Point(585, 87);
            this.labelLastResidence.Name = "labelLastResidence";
            this.labelLastResidence.Size = new System.Drawing.Size(82, 21);
            this.labelLastResidence.TabIndex = 6;
            this.labelLastResidence.Text = "residence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(171, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Специализация:";
            // 
            // labelSpecialization
            // 
            this.labelSpecialization.AutoSize = true;
            this.labelSpecialization.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecialization.Location = new System.Drawing.Point(314, 108);
            this.labelSpecialization.Name = "labelSpecialization";
            this.labelSpecialization.Size = new System.Drawing.Size(112, 21);
            this.labelSpecialization.TabIndex = 8;
            this.labelSpecialization.Text = "specialization";
            // 
            // buttonMore
            // 
            this.buttonMore.BackColor = System.Drawing.Color.Azure;
            this.buttonMore.BackgroundImage = global::Interpol.Properties.Resources.arrow_right_01_512;
            this.buttonMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMore.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMore.Location = new System.Drawing.Point(788, 0);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(62, 150);
            this.buttonMore.TabIndex = 9;
            this.buttonMore.UseVisualStyleBackColor = false;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // pictureBoxCriminal
            // 
            this.pictureBoxCriminal.Location = new System.Drawing.Point(21, 19);
            this.pictureBoxCriminal.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxCriminal.Name = "pictureBoxCriminal";
            this.pictureBoxCriminal.Size = new System.Drawing.Size(110, 110);
            this.pictureBoxCriminal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCriminal.TabIndex = 0;
            this.pictureBoxCriminal.TabStop = false;
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNickname.Location = new System.Drawing.Point(171, 54);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(87, 21);
            this.labelNickname.TabIndex = 10;
            this.labelNickname.Text = "Nickname";
            // 
            // Criminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.buttonMore);
            this.Controls.Add(this.labelSpecialization);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLastResidence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxCriminal);
            this.Margin = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.Name = "Criminal";
            this.Size = new System.Drawing.Size(850, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCriminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCriminal;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLastResidence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSpecialization;
        private System.Windows.Forms.Button buttonMore;
        private System.Windows.Forms.Label labelNickname;
    }
}
