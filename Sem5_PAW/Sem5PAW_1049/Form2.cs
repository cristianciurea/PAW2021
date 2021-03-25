using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem5PAW_1049
{
    public partial class Form2 : Form
    {
        float procentDobanda = 0.15f;
        float gradIndatorare = 0.7f;

        public Form2()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tbPerioada.Text = (-1 * vScrollBar1.Value).ToString();
        }

        private void tbPerioada_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vScrollBar1.Value = -1 * Convert.ToInt32(tbPerioada.Text);
            }
            catch
            {
                vScrollBar1.Value = -30;
            }
        }

        private void procentDobandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                procentDobanda = 0.14f;
            else
                procentDobanda = 0.15f;
            MessageBox.Show("Procent dobanda: " + procentDobanda);
        }

        private void gradIndatorareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rbCasatorit.Checked == false && rbNecasatorit.Checked == false)
                MessageBox.Show("Selectati stare civila!");
            else
                if (rbCasatorit.Checked)
                    gradIndatorare = 0.5f;
            else
                if (rbNecasatorit.Checked)
                    gradIndatorare = 0.7f;
            MessageBox.Show("Grad indatorare: " + gradIndatorare);
        }
    }
}
