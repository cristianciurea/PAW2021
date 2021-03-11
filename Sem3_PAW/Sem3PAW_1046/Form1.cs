using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem3PAW_1046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Am facut click pe buton");
        }

        private void metodaMea(object sender, EventArgs e)
        {
            button1.Click -= new EventHandler(button1_Click);
            Console.WriteLine("Am facut click prin metoda mea!");
        }
    }
}
