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
using System.CodeDom.Compiler;
using System.Collections;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Xml.Linq;

namespace proiect
{
    //Sacrieriu Razvan-Marcian
    public partial class SearchForm : Form
    {
        public static string currentPath = Directory.GetCurrentDirectory();
        public static string newPath = currentPath.Substring(0, currentPath.IndexOf("bin"));
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + newPath + "restaurants.mdf;" + "Integrated Security = True");

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
        //Cautare dupa oras
        private void buttonSearch_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select r.Nume as \"Restaurant Name\", r.Adresa as \"Restaurant Address\",r.Telefon AS 'Phone Number', r.Meniu from Restaurant r, Oras o where (o.IdOras = r.IdOras and o.Nume LIKE ('%" + comboBox1.Text + "%'))";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


        }
        //Cautare dupa nume
        private void buttonSearchName_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT r.Nume AS \"Restaurant Name\", r.Adresa AS \"Restaurant Address\", r.Telefon AS 'Phone Number', r.Meniu " +
                              "FROM Restaurant r " +
                              "INNER JOIN Oras o ON r.IdOras = o.IdOras " +
                              "WHERE r.Nume LIKE @NameQuery";

            cmd.Parameters.AddWithValue("@NameQuery", "%" + textBoxName.Text + "%");

            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
        //Cautare dupa meniu
        private void buttonSearchMenu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT r.Nume AS \"Restaurant Name\", r.Adresa AS \"Restaurant Address\", r.Telefon AS 'Phone Number', r.Meniu " +
                              "FROM Restaurant r " +
                              "INNER JOIN Oras o ON r.IdOras = o.IdOras " +
                              "WHERE r.Meniu LIKE @MenuQuery";

            cmd.Parameters.AddWithValue("@MenuQuery", "%" + textBoxMenu.Text + "%");

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
    }
}
