namespace LabirintusGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBx = new System.Windows.Forms.ComboBox();
            this.cBy = new System.Windows.Forms.ComboBox();
            this.createLab = new System.Windows.Forms.Button();
            this.saveLab = new System.Windows.Forms.Button();
            this.cBvalue = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Labirintus mérete [sor x oszlop]:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cBx
            // 
            this.cBx.FormattingEnabled = true;
            this.cBx.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cBx.Location = new System.Drawing.Point(213, 10);
            this.cBx.Name = "cBx";
            this.cBx.Size = new System.Drawing.Size(35, 21);
            this.cBx.TabIndex = 1;
            this.cBx.Text = "12";
            this.cBx.UseWaitCursor = true;
            // 
            // cBy
            // 
            this.cBy.FormattingEnabled = true;
            this.cBy.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cBy.Location = new System.Drawing.Point(173, 10);
            this.cBy.Name = "cBy";
            this.cBy.Size = new System.Drawing.Size(34, 21);
            this.cBy.TabIndex = 2;
            this.cBy.Text = "12";
            // 
            // createLab
            // 
            this.createLab.Location = new System.Drawing.Point(16, 41);
            this.createLab.Name = "createLab";
            this.createLab.Size = new System.Drawing.Size(151, 23);
            this.createLab.TabIndex = 3;
            this.createLab.Text = "Induló labirintus létrehozása";
            this.createLab.UseVisualStyleBackColor = true;
            this.createLab.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveLab
            // 
            this.saveLab.Location = new System.Drawing.Point(173, 41);
            this.saveLab.Name = "saveLab";
            this.saveLab.Size = new System.Drawing.Size(104, 23);
            this.saveLab.TabIndex = 4;
            this.saveLab.Text = "Labirintus mentése";
            this.saveLab.UseVisualStyleBackColor = true;
            this.saveLab.Click += new System.EventHandler(this.saveLab_Click);
            // 
            // cBvalue
            // 
            this.cBvalue.FormattingEnabled = true;
            this.cBvalue.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cBvalue.Location = new System.Drawing.Point(283, 41);
            this.cBvalue.Name = "cBvalue";
            this.cBvalue.Size = new System.Drawing.Size(34, 21);
            this.cBvalue.TabIndex = 5;
            this.cBvalue.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 462);
            this.Controls.Add(this.cBvalue);
            this.Controls.Add(this.saveLab);
            this.Controls.Add(this.createLab);
            this.Controls.Add(this.cBy);
            this.Controls.Add(this.cBx);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(426, 501);
            this.MinimumSize = new System.Drawing.Size(426, 501);
            this.Name = "Form1";
            this.Text = "Labirintus készítő";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBx;
        private System.Windows.Forms.ComboBox cBy;
        private System.Windows.Forms.Button createLab;
        private System.Windows.Forms.Button saveLab;
        private System.Windows.Forms.ComboBox cBvalue;
    }
}

