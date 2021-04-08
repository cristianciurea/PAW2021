﻿using System;
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

namespace Sem7PAW_1049
{
    public partial class Form1 : Form
    {
        List<Student> lista = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Situatie");
            incarcaDate();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(/*lista*/);
            frm.MdiParent = this;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("fisier.txt");
            foreach (Student s in lista)
            {
                sw.Write(s.Cod);
                sw.Write(",");
                sw.Write(s.Nume);
                sw.Write(",");
                sw.Write(s.Nota);
                sw.WriteLine();
            }
            sw.Close();
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
            {
                e.Item.BackColor = Color.Red;
                /*tbCod.Text = e.Item.SubItems[0].Text;
                tbNume.Text = e.Item.SubItems[1].Text;
                tbNota.Text = e.Item.SubItems[2].Text;*/
                int cod = Convert.ToInt32(e.Item.SubItems[0].Text);
                foreach(Student s in lista)
                    if (s.Cod==cod)
                    {
                        tbCod.Text = s.Cod.ToString();
                        tbNume.Text = s.Nume;
                        tbNota.Text = s.Nota.ToString();
                    }
            }
        }

        private void incarcaDate()
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
            {
                int cod = Convert.ToInt32(linie.Split(',')[0]);
                string nume = linie.Split(',')[1];
                int nota = Convert.ToInt32(linie.Split(',')[2]);
                Student s = new Student(cod, nume, nota);
                lista.Add(s);
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
                {
                    tbCod.Text = s.Cod.ToString();
                    tbNume.Text = s.Nume;
                    tbNota.Text = s.Nota.ToString();
                }
        }

        private void stergeNodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            foreach(TreeNode parinte in treeView1.Nodes)
            {
                writer.WriteStartElement(parinte.Text);
                foreach (TreeNode copil in parinte.Nodes)
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
            MessageBox.Show("Exportat!");
        }
    }
}
