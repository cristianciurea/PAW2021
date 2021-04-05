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
using System.IO;

namespace Curs7PAW
{
    public partial class TreeView : Form
    {
        ArrayList lista = new ArrayList();

        public TreeView()
        {
            InitializeComponent();
            initializareLista();
            initalizareTree();
        }

        public void initializareLista()
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
        }

        public void initalizareTree()
        {
            TreeNode parinte = new TreeNode("Studenti");
            treeView1.Nodes.Add(parinte);

            foreach(Student s in lista)
            {
                TreeNode copil = new TreeNode(s.cod + "-" + s.nume + "-" + s.nota);
                parinte.Nodes.Add(copil);

                TreeNode nepot = new TreeNode();
                if (s.nota >= 9)
                    nepot.Text = "excelent";
                else
                    nepot.Text = "bunicel";
                copil.Nodes.Add(nepot);
            }
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.Nodes.Count>0)
            {
                TreeNode nodSelectat = treeView1.SelectedNode;
                if(nodSelectat.Parent!=null)
                {
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
                        if (s.cod == cod)
                            textBox1.Text += s.ToString() + Environment.NewLine;
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(treeView1.Nodes.Count>0)
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
        }

        private void reincarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initalizareTree();
        }
    }
}
