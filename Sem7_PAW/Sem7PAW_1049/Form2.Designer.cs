
namespace Sem7PAW_1049
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
            this.cbStudenti = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbStudenti
            // 
            this.cbStudenti.FormattingEnabled = true;
            this.cbStudenti.Location = new System.Drawing.Point(145, 75);
            this.cbStudenti.Name = "cbStudenti";
            this.cbStudenti.Size = new System.Drawing.Size(121, 21);
            this.cbStudenti.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(806, 253);
            this.Controls.Add(this.cbStudenti);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStudenti;
    }
}