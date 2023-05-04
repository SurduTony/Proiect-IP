using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class RestaurantsForm : Form
    {
        public enum Modes {NEW_RESTAURANT,MODIFY };
        public int mode = 0;
        public static int idOras;
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Directory.GetCurrentDirectory() + "\\restaurants.mdf;" + "Integrated Security = True");

        public RestaurantsForm()
        {
            InitializeComponent();
        }

        private void RestaurantsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form? form = MainForm.caretaker?.Undo();
            if (form != null)
            {
                form.Show();
                Dispose();
                this.Close();
            }
        }

        private void RestaurantsForm_Load(object sender, EventArgs e)
        {
            if (MainForm.userManager.CurrentUser != null)
            {
                try
                {
                    //incarcare lista orase
                    if(conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();


                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "select * from Oras";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        comboBoxCity.Items.Add(dt.Rows[i][1]);
                    }


                    cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT r.Nume AS restaurant_nume, r.Adresa AS restaurant_adresa, o.Nume AS oras_nume FROM Restaurant r INNER JOIN Oras o ON r.IdOras = o.IdOras INNER JOIN Administratori_Restaurant ar ON r.IdRestaurant = ar.IdRestaurant INNER JOIN Administrator a ON ar.IdAdministrator = a.IdAdministrator WHERE a.IdAdministrator LIKE ('%" + MainForm.userManager.CurrentUser.Id + "%');";
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    dataGridView.DataSource = dt1;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("Please log in first!");
                Form? form = MainForm.caretaker?.Undo();
                if (form != null)
                {
                    form.Show();
                    Dispose();
                    this.Close();
                }
            }
        }

        private void buttonNewRestaurant_Click(object sender, EventArgs e)
        {
            mode = (int)Modes.NEW_RESTAURANT;
            textBoxAddress.Text = "";
            textBoxMenu.Text = "";
            textBoxName.Text = "";
            comboBoxCity.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(mode == (int)Modes.NEW_RESTAURANT)
            {
                try
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("select IdOras from Oras where nume like ('%" + comboBoxCity.Text.Trim() + "%')", conn);
                    idOras = Convert.ToInt32(cmd.ExecuteScalar());

                    SqlCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandText = "insert into Restaurant(Nume,Adresa,IdOras,Meniu) values (@Nume,@Adresa,@IdOras,@Meniu)";
                    cmd1.Parameters.AddWithValue("@Nume", textBoxName.Text.Trim());
                    cmd1.Parameters.AddWithValue("@Adresa", textBoxAddress.Text.Trim());
                    cmd1.Parameters.AddWithValue("@IdOras", idOras);
                    cmd1.Parameters.AddWithValue("@Meniu", textBoxMenu.Text.Trim());
                    cmd1.ExecuteNonQuery();


                    cmd = new SqlCommand("select IdRestaurant from Restaurant where nume like ('%" + textBoxName.Text.Trim() + "%') and adresa like ('%" + textBoxAddress.Text.Trim() + "%') and IdOras like ('%" + idOras + "%') and Meniu like ('%" + textBoxMenu.Text.Trim() + "%')", conn);
                    int idRestaurant = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd1 = conn.CreateCommand();
                    cmd1.CommandText = "insert into Administratori_Restaurant(IdAdministrator,IdRestaurant) values (@IdAdministrator,@IdRestaurant)";
                    cmd1.Parameters.AddWithValue("@IdAdministrator", MainForm.userManager.CurrentUser.Id);
                    cmd1.Parameters.AddWithValue("@IdRestaurant", idRestaurant);
                    cmd1.ExecuteNonQuery();
                    RestaurantsForm_Shown(sender, EventArgs.Empty);
                    MessageBox.Show("Restaurant added succesfully!");
                }catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void RestaurantsForm_Shown(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT r.Nume AS restaurant_nume, r.Adresa AS restaurant_adresa, o.Nume AS oras_nume FROM Restaurant r INNER JOIN Oras o ON r.IdOras = o.IdOras INNER JOIN Administratori_Restaurant ar ON r.IdRestaurant = ar.IdRestaurant INNER JOIN Administrator a ON ar.IdAdministrator = a.IdAdministrator WHERE a.IdAdministrator LIKE ('%" + MainForm.userManager.CurrentUser.Id + "%');";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView.DataSource = dt1;
        }
    }
}
