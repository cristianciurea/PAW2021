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
using System.Xml;

namespace Sem7PAW_1046
{
    public partial class ListView : Form
    {
        List<Student> lista = new List<Student>();

        public ListView()
        {
            InitializeComponent();
            listView1.Columns.Add("Observatii");
            lista.Add(new Student(100, "Dorel", 9));
            lista.Add(new Student(200, "Ionel", 8));
            incarcaDate();
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            foreach(Student s in lista)
            {
                ListViewItem itm = new ListViewItem(s.Cod.ToString());
                itm.SubItems.Add(s.Nume);
                itm.SubItems.Add(s.Nota.ToString());

                if (s.Nota > 5)
                    itm.SubItems.Add("promovat");
                else
                    itm.SubItems.Add("nepromovat");

                listView1.Items.Add(itm);
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
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

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
                e.Item.BackColor = Color.Red;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(tbCod.Text);
                string nume = tbNume.Text;
                int nota = Convert.ToInt32(tbNota.Text);
                Student s = new Student(cod, nume, nota);
                lista.Add(s);

                ListViewItem itm = new ListViewItem(s.Cod.ToString());
                itm.SubItems.Add(s.Nume);
                itm.SubItems.Add(s.Nota.ToString());

                if (s.Nota > 5)
                    itm.SubItems.Add("promovat");
                else
                    itm.SubItems.Add("nepromovat");

                listView1.Items.Add(itm);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCod.Clear();
                tbNume.Clear();
                tbNota.Clear();
            }
        }

        private void incarcaDate()
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while((linie=sr.ReadLine())!=null)
            {
                try
                {
                    int cod = Convert.ToInt32(linie.Split(',')[0]);
                    string nume = linie.Split(',')[1];
                    int nota = Convert.ToInt32(linie.Split(',')[2]);

                    Student s = new Student(cod, nume, nota);
                    lista.Add(s);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Date incarcate!");
        }

        private void btnTreeView_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Studenti");
            treeView1.Nodes.Add(parinte);

            foreach(Student s in lista)
            {
                TreeNode copil = new TreeNode(s.Cod + "-" + s.Nume + "-" + s.Nota);
                parinte.Nodes.Add(copil);

                TreeNode nepot = new TreeNode();
                if (s.Nota > 5)
                    nepot.Text = "promovat";
                else
                    nepot.Text = "nepromovat";
                copil.Nodes.Add(nepot);
            }
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nodSelectat = treeView1.SelectedNode;
            int cod;
            try
            {
                cod = Convert.ToInt32(nodSelectat.Text.Split('-')[0]);
            }
            catch
            {
                cod = 0;
            }
            foreach (Student s in lista)
                if (s.Cod == cod)
                    textBox1.Text += s.ToString() + Environment.NewLine;
        }

        private void stergeNodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode nodSelectat = treeView1.SelectedNode;
            if (nodSelectat.NextNode != null)
                nodSelectat = treeView1.SelectedNode.NextNode;
            else
                if (nodSelectat.PrevNode != null)
                nodSelectat = treeView1.SelectedNode.PrevNode;
            treeView1.SelectedNode.Remove();
            treeView1.SelectedNode = nodSelectat;
        }

        private void exportaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            foreach(TreeNode nod in treeView1.Nodes)
            {
                writer.WriteStartElement(nod.Text);

                foreach(TreeNode copil in nod.Nodes)
                {
                    writer.WriteStartElement(copil.Text);
                    foreach (TreeNode nepot in copil.Nodes)
                    {
                        writer.WriteStartElement(nepot.Text);

                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }    
                writer.WriteEndElement();
            }
            writer.WriteEndDocument();
            writer.Close();

            string str = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();

            StreamWriter sw = new StreamWriter("export.xml");
            sw.WriteLine(str);
            sw.Close();
            MessageBox.Show("Salvat cu succes!");
        }
    }
}
