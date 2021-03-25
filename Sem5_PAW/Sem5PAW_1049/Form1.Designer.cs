
namespace Sem5PAW_1049
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
            this.tbData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEUR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUSD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGBP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbXAU = new System.Windows.Forms.TextBox();
            this.btnParsare = new System.Windows.Forms.Button();
            this.btnGenerare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(142, 59);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 20);
            this.tbData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data curs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curs EUR";
            // 
            // tbEUR
            // 
            this.tbEUR.Location = new System.Drawing.Point(142, 108);
            this.tbEUR.Name = "tbEUR";
            this.tbEUR.Size = new System.Drawing.Size(100, 20);
            this.tbEUR.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Curs USD";
            // 
            // tbUSD
            // 
            this.tbUSD.Location = new System.Drawing.Point(142, 157);
            this.tbUSD.Name = "tbUSD";
            this.tbUSD.Size = new System.Drawing.Size(100, 20);
            this.tbUSD.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Curs GBP";
            // 
            // tbGBP
            // 
            this.tbGBP.Location = new System.Drawing.Point(142, 206);
            this.tbGBP.Name = "tbGBP";
            this.tbGBP.Size = new System.Drawing.Size(100, 20);
            this.tbGBP.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(79, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Curs XAU";
            // 
            // tbXAU
            // 
            this.tbXAU.Location = new System.Drawing.Point(142, 254);
            this.tbXAU.Name = "tbXAU";
            this.tbXAU.Size = new System.Drawing.Size(100, 20);
            this.tbXAU.TabIndex = 8;
            // 
            // btnParsare
            // 
            this.btnParsare.Location = new System.Drawing.Point(82, 314);
            this.btnParsare.Name = "btnParsare";
            this.btnParsare.Size = new System.Drawing.Size(160, 23);
            this.btnParsare.TabIndex = 10;
            this.btnParsare.Text = "PARSARE";
            this.btnParsare.UseVisualStyleBackColor = true;
            this.btnParsare.Click += new System.EventHandler(this.btnParsare_Click);
            // 
            // btnGenerare
            // 
            this.btnGenerare.Location = new System.Drawing.Point(289, 314);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(149, 23);
            this.btnGenerare.TabIndex = 11;
            this.btnGenerare.Text = "GENERARE";
            this.btnGenerare.UseVisualStyleBackColor = true;
            this.btnGenerare.Click += new System.EventHandler(this.btnGenerare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerare);
            this.Controls.Add(this.btnParsare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbXAU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGBP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUSD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEUR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEUR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUSD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGBP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbXAU;
        private System.Windows.Forms.Button btnParsare;
        private System.Windows.Forms.Button btnGenerare;
    }
}

