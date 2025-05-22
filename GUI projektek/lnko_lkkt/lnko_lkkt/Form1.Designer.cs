namespace lnko_lkkt
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
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkoSum = new System.Windows.Forms.RadioButton();
            this.lkktSum = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.Button();
            this.eredmeny = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(93, 127);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 20);
            this.number1.TabIndex = 0;
            this.number1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(364, 127);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 20);
            this.number2.TabIndex = 1;
            this.number2.TextChanged += new System.EventHandler(this.num2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Első szám";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Második szám";
            // 
            // lnkoSum
            // 
            this.lnkoSum.AutoSize = true;
            this.lnkoSum.Location = new System.Drawing.Point(156, 197);
            this.lnkoSum.Name = "lnkoSum";
            this.lnkoSum.Size = new System.Drawing.Size(54, 17);
            this.lnkoSum.TabIndex = 4;
            this.lnkoSum.TabStop = true;
            this.lnkoSum.Text = "LNKO";
            this.lnkoSum.UseVisualStyleBackColor = true;
            this.lnkoSum.CheckedChanged += new System.EventHandler(this.lnko_CheckedChanged);
            // 
            // lkktSum
            // 
            this.lkktSum.AutoSize = true;
            this.lkktSum.Location = new System.Drawing.Point(319, 197);
            this.lkktSum.Name = "lkktSum";
            this.lkktSum.Size = new System.Drawing.Size(52, 17);
            this.lkktSum.TabIndex = 5;
            this.lkktSum.TabStop = true;
            this.lkktSum.Text = "LKKT";
            this.lkktSum.UseVisualStyleBackColor = true;
            this.lkktSum.CheckedChanged += new System.EventHandler(this.lkkt_CheckedChanged);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(156, 350);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "OK";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // eredmeny
            // 
            this.eredmeny.Location = new System.Drawing.Point(224, 275);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.ReadOnly = true;
            this.eredmeny.Size = new System.Drawing.Size(100, 20);
            this.eredmeny.TabIndex = 7;
            this.eredmeny.TextChanged += new System.EventHandler(this.eredmeny_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Az eredmény:";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(319, 350);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 9;
            this.exit.Text = "Kilépés";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 411);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eredmeny);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.lkktSum);
            this.Controls.Add(this.lnkoSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton lnkoSum;
        private System.Windows.Forms.RadioButton lkktSum;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox eredmeny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
    }
}

