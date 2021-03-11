using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem3PAW_1048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click pe buton");
        }

        private void metodaMea(object sender, EventArgs e)
        {
            button1.Click -= new EventHandler(button1_Click);
            Console.WriteLine("Click pe buton prin metoda mea");
        }
    }
}
