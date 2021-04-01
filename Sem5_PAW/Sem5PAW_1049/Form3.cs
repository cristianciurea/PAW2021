using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem5PAW_1049
{
    public partial class Form3 : Form
    {
        public Form3(List<Credit> lista)
        {
            InitializeComponent();
            foreach (Credit c in lista)
                tbAfisare.Text += c.ToString() + Environment.NewLine;
        }
    }
}
