namespace RealEstateGUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAgents = new System.Windows.Forms.Label();
            this.btnSellers = new System.Windows.Forms.Button();
            this.listBoxSellers = new System.Windows.Forms.ListBox();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.lblSellerPhone = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.listBoxCoordinates = new System.Windows.Forms.ListBox();
            this.btnHirdetések = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.lblAgents, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSellers, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.listBoxSellers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSellerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSellerPhone, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.listBoxCoordinates, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnHirdetések, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAgents
            // 
            this.lblAgents.AutoSize = true;
            this.lblAgents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAgents.Location = new System.Drawing.Point(3, 0);
            this.lblAgents.Name = "lblAgents";
            this.lblAgents.Size = new System.Drawing.Size(288, 56);
            this.lblAgents.TabIndex = 0;
            this.lblAgents.Text = "Ügynökök";
            this.lblAgents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSellers
            // 
            this.btnSellers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSellers.Location = new System.Drawing.Point(3, 507);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(288, 51);
            this.btnSellers.TabIndex = 1;
            this.btnSellers.Text = "Aktív ügynökök";
            this.btnSellers.UseVisualStyleBackColor = false;
            this.btnSellers.Click += new System.EventHandler(this.btnSellers_Click);
            // 
            // listBoxSellers
            // 
            this.listBoxSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSellers.FormattingEnabled = true;
            this.listBoxSellers.Location = new System.Drawing.Point(3, 59);
            this.listBoxSellers.Name = "listBoxSellers";
            this.tableLayoutPanel1.SetRowSpan(this.listBoxSellers, 4);
            this.listBoxSellers.Size = new System.Drawing.Size(288, 442);
            this.listBoxSellers.TabIndex = 2;
            this.listBoxSellers.SelectedIndexChanged += new System.EventHandler(this.listBoxSellers_SelectedIndexChanged);
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblSellerName, 2);
            this.lblSellerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSellerName.Location = new System.Drawing.Point(297, 0);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(83, 56);
            this.lblSellerName.TabIndex = 3;
            this.lblSellerName.Text = "Eladó neve:";
            this.lblSellerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSellerPhone
            // 
            this.lblSellerPhone.AutoSize = true;
            this.lblSellerPhone.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSellerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSellerPhone.Location = new System.Drawing.Point(297, 56);
            this.lblSellerPhone.Name = "lblSellerPhone";
            this.lblSellerPhone.Size = new System.Drawing.Size(140, 56);
            this.lblSellerPhone.TabIndex = 4;
            this.lblSellerPhone.Text = "Eladó telefonszáma: ";
            this.lblSellerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCount.Location = new System.Drawing.Point(297, 168);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(134, 56);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Hirdetések száma: -";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxCoordinates
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listBoxCoordinates, 2);
            this.listBoxCoordinates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCoordinates.FormattingEnabled = true;
            this.listBoxCoordinates.Location = new System.Drawing.Point(297, 227);
            this.listBoxCoordinates.Name = "listBoxCoordinates";
            this.tableLayoutPanel1.SetRowSpan(this.listBoxCoordinates, 2);
            this.listBoxCoordinates.Size = new System.Drawing.Size(584, 331);
            this.listBoxCoordinates.TabIndex = 6;
            // 
            // btnHirdetések
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnHirdetések, 2);
            this.btnHirdetések.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHirdetések.Enabled = false;
            this.btnHirdetések.Location = new System.Drawing.Point(297, 115);
            this.btnHirdetések.Name = "btnHirdetések";
            this.btnHirdetések.Size = new System.Drawing.Size(584, 50);
            this.btnHirdetések.TabIndex = 7;
            this.btnHirdetések.Text = "Hirdetések betöltése";
            this.btnHirdetések.UseVisualStyleBackColor = true;
            this.btnHirdetések.Click += new System.EventHandler(this.btnHirdetések_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "Form1";
            this.Text = "Ingatlanok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Out);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAgents;
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.ListBox listBoxSellers;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.Label lblSellerPhone;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ListBox listBoxCoordinates;
        private System.Windows.Forms.Button btnHirdetések;
    }
}

