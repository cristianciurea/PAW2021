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

namespace Curs7PAW
{
    public partial class Form1 : Form
    {
        ArrayList listaAbonati = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            listaAbonati.Add(new Abonat(100, "Gigel"));
            listaAbonati.Add(new Abonat(200, "Dorel"));
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaAbonati);
            frm.MdiParent = this;
            frm.Show();
        }

        private void vizualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(listaAbonati);
            frm.MdiParent = this;
            frm.Show();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void orizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
