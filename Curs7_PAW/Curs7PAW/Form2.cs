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
    public partial class Form2 : Form
    {
        ArrayList lista2;
        public Form2(ArrayList lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Abonat a = new Abonat(Convert.ToInt32(tbCod.Text), tbNume.Text);
                lista2.Add(a);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCod.Clear();
                tbNume.Clear();
            }
        }
    }
}
