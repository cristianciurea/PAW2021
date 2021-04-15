using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Sem8PAW_1049
{
    public partial class Form1 : Form
    {
        Graphics g;

        double[] vect = new double[20];
        int nrElem = 0;
        bool vb = false;

        const int marg = 10;

        Color culoare = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics(); //1
            /*g = Graphics.FromHwnd(this.Handle); //2
            Bitmap img = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(img); //3*/
        }

        private void dreptunghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 300);
            g.DrawRectangle(pen, rec);
            Brush br = new SolidBrush(Color.AliceBlue);
            g.FillRectangle(br, rec);
        }

        private void elipsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 300);
            g.DrawEllipse(pen, rec);
            Brush br = new SolidBrush(Color.Pink);
            g.FillEllipse(br, rec);
        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while((linie = sr.ReadLine())!=null)
            {
                vect[nrElem] = Convert.ToDouble(linie);
                nrElem++;
                vb = true;
            }
            sr.Close();
            MessageBox.Show("Date incarcate!");
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Graphics gr = e.Graphics; //4
                Rectangle rec = new Rectangle(this.ClientRectangle.X+marg, this.ClientRectangle.Y+4*marg,
                    this.ClientRectangle.Width-2*marg, this.ClientRectangle.Height-5*marg);
                Pen pen = new Pen(Color.Red, 3);
                gr.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush brush = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for(int i=0;i<nrElem;i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                       (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                       (int)latime,
                       (int)(vect[i] / vMax * rec.Height));
                    //gr.FillRectangle(brush, recs[i]);
                    //gr.FillEllipse(brush, recs[i]);
                    gr.DrawString(vect[i].ToString(), font, brush,
                        new Point(recs[i].Location.X, recs[i].Location.Y - font.Height));
                }
                gr.FillRectangles(brush, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime/2), recs[i].Location.Y),
                        new Point((int)(recs[i+1].Location.X + latime/2), recs[i+1].Location.Y));
            }
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                culoare = dlg.Color;
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                font = dlg.Font;
            //this.Invalidate();
            panel1.Invalidate();
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
            //save(this, "grafic.bmp");
            save(panel1, "grafic.bmp");
            MessageBox.Show("Salvat!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Graphics gr = e.Graphics; //4
                Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg, panel1.ClientRectangle.Y + 4 * marg,
                    panel1.ClientRectangle.Width - 2 * marg, panel1.ClientRectangle.Height - 5 * marg);
                Pen pen = new Pen(Color.Red, 3);
                gr.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush brush = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                       (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                       (int)latime,
                       (int)(vect[i] / vMax * rec.Height));
                    //gr.FillRectangle(brush, recs[i]);
                    //gr.FillEllipse(brush, recs[i]);
                    gr.DrawString(vect[i].ToString(), font, brush,
                        new Point(recs[i].Location.X, recs[i].Location.Y - font.Height));
                }
                gr.FillRectangles(brush, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), recs[i].Location.Y),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), recs[i + 1].Location.Y));
            }
        }

        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            if (vb == true)
            {
                Graphics gr = e.Graphics; //4
                Brush brush = new SolidBrush(culoare);

                gr.DrawString("Lista studentilor bursieri: ", font, brush,
                       new Point(e.PageBounds.X + 100, e.PageBounds.Y + 50 - font.Height));

                gr.DrawString("Gigel - media 10", font, brush,
                       new Point(e.PageBounds.X + 100, e.PageBounds.Y + 150 - font.Height));


                /* Rectangle rec = new Rectangle(e.PageBounds.X + marg, e.PageBounds.Y + 4 * marg,
                     e.PageBounds.Width - 2 * marg, e.PageBounds.Height - 5 * marg);
                 Pen pen = new Pen(Color.Red, 3);
                 gr.DrawRectangle(pen, rec);

                 double latime = rec.Width / nrElem / 3;
                 double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                 double vMax = vect.Max();

                 Brush brush = new SolidBrush(culoare);

                 Rectangle[] recs = new Rectangle[nrElem];
                 for (int i = 0; i < nrElem; i++)
                 {
                     recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rec.Height));
                     //gr.FillRectangle(brush, recs[i]);
                     //gr.FillEllipse(brush, recs[i]);
                     gr.DrawString(vect[i].ToString(), font, brush,
                         new Point(recs[i].Location.X, recs[i].Location.Y - font.Height));
                 }
                 gr.FillRectangles(brush, recs);

                 for (int i = 0; i < nrElem - 1; i++)
                     gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), recs[i].Location.Y),
                         new Point((int)(recs[i + 1].Location.X + latime / 2), recs[i + 1].Location.Y));*/
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
    }
}
