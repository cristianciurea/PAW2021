using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace Curs11PAW
{
    public partial class Form1 : Form
    {
        string connString;

        public Form1()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = studenti.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM studenti", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "studenti");

            DataTable tabela = ds.Tables["studenti"];
            foreach (DataColumn coloana in tabela.Columns)
                textBox1.Text += coloana.ColumnName + "   ";
            textBox1.Text += Environment.NewLine;
            foreach (DataRow linie in tabela.Rows)
            {
                foreach (object camp in linie.ItemArray)
                    textBox1.Text += camp + "   ";
                textBox1.Text += Environment.NewLine;
            }

            dataGridView1.DataSource = tabela;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM studenti", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "studenti");

            DataTable tabela = ds.Tables["studenti"];

            DataRow[] rows = tabela.Select("forma='ID'", "nume");
            foreach (DataRow linie in rows)
                textBox1.Text += linie["nume"] + "   " + linie["forma"] + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM studenti", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "studenti");

            DataTable tabela = ds.Tables["studenti"];

            DataView dv = new DataView(tabela);
            dv.RowFilter = "forma='ID'";
            dv.Sort = "nume";

            foreach (DataRowView linie in dv)
                textBox1.Text += linie["nume"] + "   " + linie["forma"] + Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM studenti", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "studenti");

            DataTable tabela = ds.Tables["studenti"];

            tabela.Rows[0].BeginEdit();
            tabela.Rows[0].EndEdit();

            //adaptor.UpdateCommand = new OleDbCommand("UPDATE studenti SET forma='ZI'", conexiune);
            adaptor.UpdateCommand = new OleDbCommand("UPDATE studenti SET forma='"+dataGridView1.Rows[0].Cells[4].Value+"'", conexiune);
            adaptor.Update(tabela);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;

            try
            {
                conexiune.Open();
                comanda.CommandText = "CREATE PROCEDURE StudentiVarsta AS SELECT * FROM studenti WHERE varsta=@varsta";
                comanda.ExecuteNonQuery();
                MessageBox.Show("Procedura creata cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;

            try
            {
                conexiune.Open();
                comanda.CommandText = "StudentiVarsta";
                comanda.CommandType = CommandType.StoredProcedure;
                comanda.Parameters.Add("@varsta", OleDbType.Integer).Value = 25;

                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text += reader["nume"] + "   " + reader["varsta"] + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }
    }
}
