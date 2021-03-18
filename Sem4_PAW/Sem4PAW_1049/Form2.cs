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

namespace Sem4PAW_1049
{
    public partial class Form2 : Form
    {
        List<Student> lista2;
        public Form2(List<Student> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(tbAfisare.Text);
                sw.Close();
                tbAfisare.Clear();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Student s in lista2)
                tbAfisare.Text += s.ToString() + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                tbAfisare.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
