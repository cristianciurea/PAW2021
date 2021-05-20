
namespace Sem10PAW_1046
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
            this.dataOra1 = new Sem10PAW_1046.DataOra();
            this.userControl11 = new ListaTari_1046.UserControl1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(237, 69);
            this.tbNume.Margin = new System.Windows.Forms.Padding(4);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(132, 22);
            this.tbNume.TabIndex = 1;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(237, 129);
            this.tbVarsta.Margin = new System.Windows.Forms.Padding(4);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(132, 22);
            this.tbVarsta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Varsta";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(237, 191);
            this.tbNota.Margin = new System.Windows.Forms.Padding(4);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(132, 22);
            this.tbNota.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(127, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(127, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Forma";
            // 
            // cbForma
            // 
            this.cbForma.FormattingEnabled = true;
            this.cbForma.Items.AddRange(new object[] {
            "ZI",
            "ID"});
            this.cbForma.Location = new System.Drawing.Point(237, 252);
            this.cbForma.Margin = new System.Windows.Forms.Padding(4);
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new System.Drawing.Size(132, 24);
            this.cbForma.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataOra1
            // 
            this.dataOra1.Location = new System.Drawing.Point(80, 439);
            this.dataOra1.Name = "dataOra1";
            this.dataOra1.Size = new System.Drawing.Size(388, 67);
            this.dataOra1.TabIndex = 9;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(103, 531);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(344, 65);
            this.userControl11.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(567, 632);
            this.Controls.Add(this.userControl11);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private ListaTari_1046.UserControl1 userControl11;
    }
}