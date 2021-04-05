using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs7PAW
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
            listView1.Columns.Add("Observatii");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*List<Student> lista = new List<Student>();
            lista.Add(new Student(100, "Gigel", 9));
            lista.Add(new Student(200, "Dorel", 10));
            lista.Add(new Student(300, "Ionel", 8));*/
            Student[] vs = new Student[3];
            vs[0] = new Student(100, "Gigel", 9);
            vs[1] = new Student(200, "Dorel", 10);
            vs[2] = new Student(300, "Ionel", 8);
            //foreach (Student s in lista)
            for(int i=0;i<vs.Length;i++)
            {
                ListViewItem itm = new ListViewItem(vs[i].cod.ToString());
                itm.SubItems.Add(vs[i].nume);
                itm.SubItems.Add(vs[i].nota.ToString());
                listView1.Items.Add(itm);
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                    itm.ForeColor = Color.Red;
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
                e.Item.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                    itm.Remove();
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                    itm.Remove();
        }
    }
}
