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

namespace Sem6PAW_1048
{
    public partial class Form1 : Form
    {
        ArrayList listaTb = new ArrayList();
        List<Produs> listaProd = new List<Produs>();

        public Form1()
        {
            InitializeComponent();
            listaTb.Add(tbDenumire);
            listaTb.Add(tbPret);
            listaTb.Add(tbCantitate);
            listaTb.Add(tbValoare);
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            int x = ((TextBox)listaTb[0]).Location.X;
            int y = ((TextBox)listaTb[listaTb.Count-1]).Location.Y;
            int dist = ((TextBox)listaTb[1]).Location.X - ((TextBox)listaTb[0]).Location.X;

            for(int i=0;i<4;i++)
            {
                TextBox tbNou = new TextBox();
                tbNou.Location = new Point(x, y + 30);
                x += dist;
                if (i == 1 || i == 2)
                    tbNou.KeyPress += new KeyPressEventHandler(tbPret_KeyPress);
                if (i == 3)
                    tbNou.ReadOnly = true;
                listaTb.Add(tbNou);
                this.Controls.Add(tbNou);
            }
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            float total = 0;
            for(int i=0;i<listaTb.Count;i+=4)
            {
                if (((TextBox)listaTb[i]).Text == "")
                    errorProvider1.SetError((TextBox)listaTb[i], "Introduceti denumire!");
                else
                    if (((TextBox)listaTb[i+1]).Text == "")
                    errorProvider1.SetError((TextBox)listaTb[i+1], "Introduceti pretul!");
                else
                    if (((TextBox)listaTb[i+2]).Text == "")
                    errorProvider1.SetError((TextBox)listaTb[i+2], "Introduceti cantitate!");
                else
                {
                    try
                    {
                        string denumire = ((TextBox)listaTb[i]).Text;
                        float pret = (float)Convert.ToDouble(((TextBox)listaTb[i + 1]).Text);
                        float cantitate = (float)Convert.ToDouble(((TextBox)listaTb[i + 2]).Text);

                        float valoare = pret * cantitate;
                        total += valoare;
                        ((TextBox)listaTb[i + 3]).Text = valoare.ToString();

                        Produs p = new Produs(denumire, pret, cantitate);
                        listaProd.Add(p);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        errorProvider1.Clear();
                    }
                }
            }
            tbTotal.Text = total.ToString();
        }

        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8 || e.KeyChar == ',')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaProd);
            frm.ShowDialog();
        }
    }
}
