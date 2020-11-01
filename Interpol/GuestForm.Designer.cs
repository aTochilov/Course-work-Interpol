using System.Drawing;

namespace Interpol
{
    partial class GuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            this.panelNavGuest = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonTableDead = new System.Windows.Forms.Button();
            this.buttonTableGaveUp = new System.Windows.Forms.Button();
            this.buttonMain = new System.Windows.Forms.Button();
            this.flowLayoutPanelCriminals = new System.Windows.Forms.FlowLayoutPanel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cardfileDataSet = new Interpol.cardfileDataSet();
            this.panelNavGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfileDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavGuest
            // 
            this.panelNavGuest.BackColor = System.Drawing.Color.SlateGray;
            this.panelNavGuest.Controls.Add(this.buttonSearch);
            this.panelNavGuest.Controls.Add(this.buttonBack);
            this.panelNavGuest.Controls.Add(this.buttonTableDead);
            this.panelNavGuest.Controls.Add(this.buttonTableGaveUp);
            this.panelNavGuest.Controls.Add(this.buttonMain);
            this.panelNavGuest.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavGuest.Location = new System.Drawing.Point(0, 0);
            this.panelNavGuest.Name = "panelNavGuest";
            this.panelNavGuest.Size = new System.Drawing.Size(195, 662);
            this.panelNavGuest.TabIndex = 0;
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
            this.buttonBack.Location = new System.Drawing.Point(0, 611);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(195, 51);
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
            // flowLayoutPanelCriminals
            // 
            this.flowLayoutPanelCriminals.AutoScroll = true;
            this.flowLayoutPanelCriminals.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelCriminals.Location = new System.Drawing.Point(195, 0);
            this.flowLayoutPanelCriminals.Name = "flowLayoutPanelCriminals";
            this.flowLayoutPanelCriminals.Size = new System.Drawing.Size(930, 662);
            this.flowLayoutPanelCriminals.TabIndex = 1;
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
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1124, 679);
            this.Controls.Add(this.panelNavGuest);
            this.Controls.Add(this.flowLayoutPanelCriminals);
            this.MinimumSize = new System.Drawing.Size(1140, 650);
            this.Name = "GuestForm";
            this.Text = "Картотека | Доступ: 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuestForm_FormClosing);
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.panelNavGuest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfileDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavGuest;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonTableDead;
        private System.Windows.Forms.Button buttonTableGaveUp;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCriminals;
        private System.Windows.Forms.BindingSource bindingSource1;
        private cardfileDataSet cardfileDataSet;
    }
}