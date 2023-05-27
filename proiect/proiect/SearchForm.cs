using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proiect
{
    //Sacrieriu Razvan-Marcian
    public partial class SearchForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename="+Directory.GetCurrentDirectory()+"\\restaurants.mdf;"+"Integrated Security = True");

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Oras";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][1]);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select r.Nume as \"Restaurant Name\", r.Adresa as \"Restaurant Address\", r.Meniu from Restaurant r, Oras o where (o.IdOras = r.IdOras and o.Nume LIKE ('%" + comboBox1.Text + "%'))";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            

        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form? form = MainForm.caretaker?.Undo();
            if (form != null)
            {
                form.Show();
                Dispose();
                this.Close();
            }
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
        }

        //TODO: Fa sa apara si telefonul in tabel (modifica query ul)
        //Cautare dupa meniu sau nume (sa gasesti un cuvant in baza de date, gen Pizza in 'Peste, Paste, Pizza, Prajituri' )
    }
}
