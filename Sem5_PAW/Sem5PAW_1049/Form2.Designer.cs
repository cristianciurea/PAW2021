
namespace Sem5PAW_1049
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
            this.components = new System.ComponentModel.Container();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVenit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPerioada = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rbCasatorit = new System.Windows.Forms.RadioButton();
            this.rbNecasatorit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRata = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procentDobandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradIndatorareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schimbaCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.golesteCasuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAfisare = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSuma
            // 
            this.tbSuma.ContextMenuStrip = this.contextMenuStrip1;
            this.tbSuma.Location = new System.Drawing.Point(112, 74);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(100, 20);
            this.tbSuma.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suma credit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Venit lunar";
            // 
            // tbVenit
            // 
            this.tbVenit.ContextMenuStrip = this.contextMenuStrip1;
            this.tbVenit.Location = new System.Drawing.Point(112, 128);
            this.tbVenit.Name = "tbVenit";
            this.tbVenit.Size = new System.Drawing.Size(100, 20);
            this.tbVenit.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Perioada credit";
            // 
            // tbPerioada
            // 
            this.tbPerioada.ContextMenuStrip = this.contextMenuStrip1;
            this.tbPerioada.Location = new System.Drawing.Point(169, 186);
            this.tbPerioada.Name = "tbPerioada";
            this.tbPerioada.Size = new System.Drawing.Size(43, 20);
            this.tbPerioada.TabIndex = 4;
            this.tbPerioada.TextChanged += new System.EventHandler(this.tbPerioada_TextChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(129, 160);
            this.vScrollBar1.Maximum = 0;
            this.vScrollBar1.Minimum = -30;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 6;
            this.vScrollBar1.Value = -30;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(89, 275);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Angajat banca";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rbCasatorit
            // 
            this.rbCasatorit.AutoSize = true;
            this.rbCasatorit.ForeColor = System.Drawing.Color.White;
            this.rbCasatorit.Location = new System.Drawing.Point(40, 30);
            this.rbCasatorit.Name = "rbCasatorit";
            this.rbCasatorit.Size = new System.Drawing.Size(66, 17);
            this.rbCasatorit.TabIndex = 8;
            this.rbCasatorit.TabStop = true;
            this.rbCasatorit.Text = "Casatorit";
            this.rbCasatorit.UseVisualStyleBackColor = true;
            // 
            // rbNecasatorit
            // 
            this.rbNecasatorit.AutoSize = true;
            this.rbNecasatorit.ForeColor = System.Drawing.Color.White;
            this.rbNecasatorit.Location = new System.Drawing.Point(40, 64);
            this.rbNecasatorit.Name = "rbNecasatorit";
            this.rbNecasatorit.Size = new System.Drawing.Size(79, 17);
            this.rbNecasatorit.TabIndex = 9;
            this.rbNecasatorit.TabStop = true;
            this.rbNecasatorit.Text = "Necasatorit";
            this.rbNecasatorit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCasatorit);
            this.groupBox1.Controls.Add(this.rbNecasatorit);
            this.groupBox1.Location = new System.Drawing.Point(52, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stare civila";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(383, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rata credit";
            // 
            // tbRata
            // 
            this.tbRata.ContextMenuStrip = this.contextMenuStrip1;
            this.tbRata.Location = new System.Drawing.Point(446, 77);
            this.tbRata.Name = "tbRata";
            this.tbRata.ReadOnly = true;
            this.tbRata.Size = new System.Drawing.Size(100, 20);
            this.tbRata.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setariToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setariToolStripMenuItem
            // 
            this.setariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procentDobandaToolStripMenuItem,
            this.gradIndatorareToolStripMenuItem});
            this.setariToolStripMenuItem.Name = "setariToolStripMenuItem";
            this.setariToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.setariToolStripMenuItem.Text = "Setari";
            // 
            // procentDobandaToolStripMenuItem
            // 
            this.procentDobandaToolStripMenuItem.Name = "procentDobandaToolStripMenuItem";
            this.procentDobandaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.procentDobandaToolStripMenuItem.Text = "Procent dobanda";
            this.procentDobandaToolStripMenuItem.Click += new System.EventHandler(this.procentDobandaToolStripMenuItem_Click);
            // 
            // gradIndatorareToolStripMenuItem
            // 
            this.gradIndatorareToolStripMenuItem.Name = "gradIndatorareToolStripMenuItem";
            this.gradIndatorareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gradIndatorareToolStripMenuItem.Text = "Grad indatorare";
            this.gradIndatorareToolStripMenuItem.Click += new System.EventHandler(this.gradIndatorareToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbaCuloareToolStripMenuItem,
            this.golesteCasuteToolStripMenuItem});
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
            // golesteCasuteToolStripMenuItem
            // 
            this.golesteCasuteToolStripMenuItem.Name = "golesteCasuteToolStripMenuItem";
            this.golesteCasuteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.golesteCasuteToolStripMenuItem.Text = "Goleste casuta";
            this.golesteCasuteToolStripMenuItem.Click += new System.EventHandler(this.golesteCasuteToolStripMenuItem_Click);
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(446, 142);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(100, 23);
            this.btnCalcul.TabIndex = 15;
            this.btnCalcul.Text = "CALCULEAZA";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(446, 216);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(100, 23);
            this.btnAfisare.TabIndex = 16;
            this.btnAfisare.Text = "AFISARE";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRata);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPerioada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVenit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVenit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPerioada;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rbCasatorit;
        private System.Windows.Forms.RadioButton rbNecasatorit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRata;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procentDobandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradIndatorareToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem golesteCasuteToolStripMenuItem;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAfisare;
    }
}