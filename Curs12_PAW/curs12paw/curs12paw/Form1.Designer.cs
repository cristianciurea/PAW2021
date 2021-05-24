namespace curs12paw
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
            this.ceas1 = new curs12paw.Ceas();
            this.linkLabel1 = new curs12paw.LinkLabel();
            this.listaTari1 = new curs12paw.ListaTari();
            this.login1 = new Login.Login();
            this.SuspendLayout();
            // 
            // ceas1
            // 
            this.ceas1.Location = new System.Drawing.Point(12, 227);
            this.ceas1.Name = "ceas1";
            this.ceas1.Size = new System.Drawing.Size(294, 51);
            this.ceas1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(465, 227);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(152, 45);
            this.linkLabel1.TabIndex = 0;
            // 
            // listaTari1
            // 
            this.listaTari1.Location = new System.Drawing.Point(44, 12);
            this.listaTari1.Name = "listaTari1";
            this.listaTari1.Size = new System.Drawing.Size(281, 55);
            this.listaTari1.TabIndex = 2;
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(197, 46);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(345, 191);
            this.login1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 284);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.listaTari1);
            this.Controls.Add(this.ceas1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LinkLabel linkLabel1;
        private Ceas ceas1;
        private ListaTari listaTari1;
        private Login.Login login1;
    }
}

