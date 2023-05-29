/**********************************
//
//Autor: Sacrieriu Razvan-Marcian
//
//Descriere:Formular ce are ca scop cautarea unui restaurant in baza de date. Astfel,
            se poate cauta un restaurant fie dupa oras selectand din lista unul din orasele disponibile,
            fie dupa numele restaurantului sau chiar dupa meniu. Fiecare metoda de cautare prezinta cate un
            buton separat numite search,searchName respectiv searchMenu.

*/

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
        // Preia dinamic path ul folderului si creeaza conexiunea pentru baza de date (proiectul poate fi situat oriunde)
        public static string currentPath = Directory.GetCurrentDirectory();
        public static string newPath = currentPath.Substring(0, currentPath.IndexOf("bin"));
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + newPath + "restaurants.mdf;" + "Integrated Security = True");


        public string City 
        { 
            set 
            { 
                comboBox1.Text = value; 
            } 
        }

        public bool isDatabaseEmpty
        {
            get
            {
                if (dataGridView1.Rows.Count >= 2)
                    return false;
                return true;
            }
        }

        public void SearchCity()
        {
           
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select r.Nume as \"Restaurant Name\", r.Adresa as \"Restaurant Address\",r.Telefon AS 'Phone Number', r.Meniu from Restaurant r, Oras o where (o.IdOras = r.IdOras and o.Nume LIKE ('%" + comboBox1.Text + "%'))";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }


        public SearchForm()
        {
            InitializeComponent();
        }

        //Datele sunt citite din baza de date si sunt instantiate intr-un obiect de tipul DataTable pentru a fi afisate in search
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
        private void buttonSearchCity_Click(object sender, EventArgs e)
        {
            SearchCity();


        }
        //Cautare dupa nume
        private void buttonSearchName_Click(object sender, EventArgs e)
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

        //Inchidere form de cautare
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
