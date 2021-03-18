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
using System.Runtime.Serialization.Formatters.Binary;

namespace Sem4PAW_1046
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
            foreach (Student s in lista2)
                tbAfisare.Text += s.ToString() + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Filter = "(*.txt)|*.txt";
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                sw.WriteLine(tbAfisare.Text);
                sw.Close();
                tbAfisare.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                tbAfisare.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            //bf.Serialize(fs, tbAfisare.Text);
            bf.Serialize(fs, lista2);
            fs.Close();
            tbAfisare.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            //tbAfisare.Text = (string)bf.Deserialize(fs);
            List<Student> lista3 = (List<Student>)bf.Deserialize(fs);
            foreach (Student s in lista3)
                tbAfisare.Text += s.ToString() + Environment.NewLine;
            fs.Close();
        }
    }
}
