﻿
namespace Sem10PAW_1048
{
    partial class Form2
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbForma = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataOra1 = new Sem10PAW_1048.DataOra();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(153, 47);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 1;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(153, 101);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(100, 20);
            this.tbVarsta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Varsta";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(153, 153);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(100, 20);
            this.tbNota.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Forma";
            // 
            // cbForma
            // 
            this.cbForma.FormattingEnabled = true;
            this.cbForma.Items.AddRange(new object[] {
            "ZI",
            "ID"});
            this.cbForma.Location = new System.Drawing.Point(153, 205);
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new System.Drawing.Size(100, 21);
            this.cbForma.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataOra1
            // 
            this.dataOra1.Location = new System.Drawing.Point(86, 354);
            this.dataOra1.Name = "dataOra1";
            this.dataOra1.Size = new System.Drawing.Size(217, 49);
            this.dataOra1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(387, 426);
            this.Controls.Add(this.dataOra1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbForma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbForma;
        private System.Windows.Forms.Button button1;
        private DataOra dataOra1;
    }
}