using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem4PAW_1049
{
    public partial class Form1 : Form
    {
        List<Student> listaStud = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCod.Text == "")
                errorProvider1.SetError(tbCod, "Va rugam introduceti codul!");
            else
                try
                {
                    int cod = Convert.ToInt32(tbCod.Text);
                    char sex = Convert.ToChar(cbSex.Text);
                    int varsta = Convert.ToInt32(tbVarsta.Text);
                    string nume = tbNume.Text;
                    string[] noteS = tbNote.Text.Split(',');
                    int[] note = new int[noteS.Length];
                    for (int i = 0; i < noteS.Length; i++)
                        note[i] = Convert.ToInt32(noteS[i]);

                    Student s = new Student(cod, sex, varsta, nume, note);
                    MessageBox.Show(s.ToString());
                    listaStud.Add(s);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("sa fie doar cifre!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCod.Text = "";
                    cbSex.Text = "";
                    tbVarsta.Clear();
                    tbNume.Clear();
                    tbNote.Clear();
                }
        }

        private void metodaMea(object sender, EventArgs e)
        {
            button1.Click -= new EventHandler(button1_Click);
            Console.WriteLine("Am facut click prin metoda mea!");
        }

        private void tbCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!=',')
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*foreach (Student s in listaStud)
                tbAfisare.Text += s.ToString() + Environment.NewLine;*/
            Form2 frm = new Form2(listaStud);
            frm.ShowDialog();
        }
    }
}
