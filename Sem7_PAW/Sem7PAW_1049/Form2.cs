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

namespace Sem7PAW_1049
{
    public partial class Form2 : Form
    {
        public Form2(/*List<Student> lista*/)
        {
            InitializeComponent();
            /*foreach (Student s in lista)
                cbStudenti.Items.Add(s.Cod + "-" + s.Nume + "-" + s.Nota);*/
            incarcaDate();
        }


        private void incarcaDate()
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while((linie=sr.ReadLine())!=null)
            {
                cbStudenti.Items.Add(linie);
            }
            sr.Close();
        }
    }

}
