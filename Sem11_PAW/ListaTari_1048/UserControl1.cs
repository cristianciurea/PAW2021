using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace ListaTari_1048
{
    public partial class ListaTari: UserControl
    {
        public ListaTari()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while ((linie = sr.ReadLine()) != null)
                comboBox1.Items.Add(linie);
            sr.Close();
        }
    }
}
