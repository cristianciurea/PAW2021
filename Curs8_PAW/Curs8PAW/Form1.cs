using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Curs8PAW
{
    public partial class Form1 : Form
    {
        Graphics gr;
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            //gr = this.CreateGraphics();
            //bmp = new Bitmap(this.Width, this.Height);
            bmp = new Bitmap(panel1.Width, panel1.Height);
            gr = Graphics.FromImage(bmp);
        }

        private void dreptunghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            gr.DrawRectangle(pen, rec);
            gr.DrawString("Dreptunghi", this.Font, new SolidBrush(Color.Black), new Point(40, 40));
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void elipsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            gr.DrawEllipse(pen, rec);
            gr.DrawString("Elipsa", new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold),
                new SolidBrush(Color.Blue), new Point(40, 60));
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void linieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 3);
            gr.DrawLine(pen, new Point(40, 40), new Point(100, 100));
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void placintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            gr.DrawPie(pen, rec, 150, 300);
            gr.DrawString("Placinta", new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold),
                new SolidBrush(Color.Black), new Point(40, 80));
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void umpleDreptunghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brush br = new SolidBrush(Color.Azure);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            gr.FillRectangle(br, rec);
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void umplePlacintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brush br = new SolidBrush(Color.Yellow);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            gr.FillEllipse(br, rec);
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void umplePlacintaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Brush br = new SolidBrush(Color.Pink);
            Rectangle rec = new Rectangle(40, 40, 300, 150);
            gr.FillPie(br, rec, 150, 300);
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void save(Control c, string denumire)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y,
                c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(denumire);
            img.Dispose();
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save(this, "poza.bmp");
            save(panel1, "poza.bmp");
            MessageBox.Show("Salvat!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void pd_print(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(e.PageBounds.X, e.PageBounds.Y, e.PageBounds.Width, e.PageBounds.Height);
            Pen pen = new Pen(Color.Blue, 3);
            g.DrawRectangle(pen, rec);
            Brush br = new SolidBrush(Color.Red);
            g.FillEllipse(br, rec);
            g.DrawString("Paste fericit!", new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold), new SolidBrush(Color.White),
                new PointF((e.PageBounds.Width - 200) / 2, e.PageBounds.Height / 2));
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.pd_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
    }
}
