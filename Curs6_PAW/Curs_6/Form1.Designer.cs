
namespace Curs_6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTbNume = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripCbSex = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTbCnp = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTbNota = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schimbaCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaCuloareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.toolStripTbNume,
            this.toolStripCbSex,
            this.toolStripTbCnp,
            this.toolStripTbNota});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // toolStripTbNume
            // 
            this.toolStripTbNume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTbNume.Name = "toolStripTbNume";
            this.toolStripTbNume.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripCbSex
            // 
            this.toolStripCbSex.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.toolStripCbSex.Name = "toolStripCbSex";
            this.toolStripCbSex.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripTbCnp
            // 
            this.toolStripTbCnp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTbCnp.Name = "toolStripTbCnp";
            this.toolStripTbCnp.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripTbNota
            // 
            this.toolStripTbNota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTbNota.Name = "toolStripTbNota";
            this.toolStripTbNota.Size = new System.Drawing.Size(100, 23);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbaCuloareToolStripMenuItem,
            this.schimbaCuloareToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 48);
            // 
            // schimbaCuloareToolStripMenuItem
            // 
            this.schimbaCuloareToolStripMenuItem.Name = "schimbaCuloareToolStripMenuItem";
            this.schimbaCuloareToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.schimbaCuloareToolStripMenuItem.Text = "Schimba culoare";
            this.schimbaCuloareToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareToolStripMenuItem_Click);
            // 
            // schimbaCuloareToolStripMenuItem1
            // 
            this.schimbaCuloareToolStripMenuItem1.Name = "schimbaCuloareToolStripMenuItem1";
            this.schimbaCuloareToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.schimbaCuloareToolStripMenuItem1.Text = "Schimba font";
            this.schimbaCuloareToolStripMenuItem1.Click += new System.EventHandler(this.schimbaCuloareToolStripMenuItem1_Click);
            // 
            // tbNota
            // 
            this.tbNota.CausesValidation = false;
            this.tbNota.ContextMenuStrip = this.contextMenuStrip1;
            this.tbNota.Location = new System.Drawing.Point(468, 319);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(100, 20);
            this.tbNota.TabIndex = 2;
            this.tbNota.Validating += new System.ComponentModel.CancelEventHandler(this.tbNota_Validating);
            this.tbNota.Validated += new System.EventHandler(this.tbNota_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nota";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1095, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 22);
            this.toolStripButton1.Text = "Creare student";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1095, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(978, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nume";
            // 
            // tbNume
            // 
            this.tbNume.ContextMenuStrip = this.contextMenuStrip1;
            this.tbNume.Location = new System.Drawing.Point(468, 137);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CNP";
            // 
            // tbCNP
            // 
            this.tbCNP.ContextMenuStrip = this.contextMenuStrip1;
            this.tbCNP.Location = new System.Drawing.Point(468, 187);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(100, 20);
            this.tbCNP.TabIndex = 9;
            this.tbCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNP_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sex";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cbSex.Location = new System.Drawing.Point(468, 256);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 21);
            this.cbSex.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 528);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTbNume;
        private System.Windows.Forms.ToolStripComboBox toolStripCbSex;
        private System.Windows.Forms.ToolStripTextBox toolStripTbCnp;
        private System.Windows.Forms.ToolStripTextBox toolStripTbNota;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareToolStripMenuItem1;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

