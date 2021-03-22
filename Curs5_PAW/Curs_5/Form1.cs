using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Curs_5
{
    public partial class Form1 : Form
    {
        ArrayList listaPct;
        bool mouseApasat;
        Graphics context;
        Bitmap img;


        public Form1()
        {
            InitializeComponent();
            listaPct = new ArrayList();
            //context = this.CreateGraphics();
            //img = new Bitmap(this.Width, this.Height);
            img = new Bitmap(panel1.Width, panel1.Height);
            context = Graphics.FromImage(img);
            hScrollBar1.Visible = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                listaPct.Add(p);
                mouseApasat = true;
                label1.Text = "Form1_MouseDown";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                listaPct.Add(p);
                Pen creion = new Pen(this.ForeColor);
                creion.Width = hScrollBar1.Value;
                if(mouseApasat==true)
                {
                    context.DrawLine(creion, (Point)listaPct[listaPct.Count - 2], (Point)listaPct[listaPct.Count - 1]);
                    label1.Text = "Form1_MouseMove";
                    //Invalidate();
                    panel1.Invalidate();
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseApasat = false;
                label1.Text = "Form1_MouseUp";
            }
        }

        private void schimbaGrosimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hScrollBar1.Visible = true;
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                this.ForeColor = dlg.Color;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void salvare(Control c, string denumire)
        {
            Graphics g = c.CreateGraphics();
            Bitmap bmp = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(bmp, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y,
                c.Width, c.Height));
            bmp.Save(denumire);
            bmp.Dispose();
        }

        private void salvareImagineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvare(panel1, "desen.bmp");
            MessageBox.Show("S-a salvat!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }
    }
}
