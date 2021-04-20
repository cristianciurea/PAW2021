using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs9PAW
{
    public partial class Form4 : Form
    {
        string[] nume = { "Gigel", "Dorel", "Ionel" };
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Binding b = new Binding("Text", nume, "");
            comboBox1.DataBindings.Add(b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.DataSource = nume;
            listBox1.DataSource = nume;

            DataTable dt = new DataTable();
            dt.Columns.Add("Nume");
            for (int i = 0; i < nume.Length; i++)
                dt.Rows.Add(nume[i]);

            dataGridView1.DataSource = dt;

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Nume";
        }
    }
}
