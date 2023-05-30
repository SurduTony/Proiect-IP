/**********************************
//
//Autor: Flaminzanu-Mateiuc Marian
//
//Descriere: Formular prin intermediul căruia se pot crea/modifica restaurante sau săli.
            Acesta este împărțit în două secțiuni: în stânga se află restaurantele, în dreapta, sălile.
            Ambele secțiuni au 3 butoane: New Restaurant/Room, Modify (...) și Save.
            Când opțiunea New (...) este activată, la apăsarea butonului Save se va crea o intrare nouă în baza de date
            Când opțiunea Modify (...) este activată, pe interfață se va încărca intrarea selectată
                din baza de date, iar la apăsarea butonului Save se va modifica intrarea selectată.

*/


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
        //Id-uri pentru restaurant, sală și oraș
        public static int roomID = -1;
        public static int restaurantID = -1;
        public static int idOras;

        public enum Modes { NEW_ENTITY, MODIFY };

        //implicit, opțiunea bifată este de a crea un nou restaurant/sală
        public int modeRestaurant = 0;
        public int modeRoom = 0;


        //șir de conectare la baza de date
        public static string currentPath = Directory.GetCurrentDirectory();
        public static string newPath = currentPath.Substring(0, currentPath.IndexOf("bin"));
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + newPath + "restaurants.mdf;" + "Integrated Security = True");
        public static DataTable dt1 = new DataTable();
        public RestaurantsForm()
        {
            InitializeComponent();

        }
        //revenire la form-ul anterior
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

            //verificare dacă utilizatorul este autentificat
            if (MainForm.userManager.CurrentUser != null)
            {
                try
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();
                    buttonNewRestaurant.BackColor = Color.LawnGreen;
                    buttonNewRoom.BackColor = Color.LawnGreen;

                    //încărcare listă orașe în ComboBox
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "select * from Oras";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        comboBoxCity.Items.Add(dt.Rows[i][1]);
                    }

                    //populare tabel restaurante
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT r.Nume AS \"Restaurant name\", r.Adresa AS \"Restaurant address\",r.Meniu, o.Nume AS \"City\", r.Telefon AS \"Phone Number\" FROM Restaurant r INNER JOIN Oras o ON r.IdOras = o.IdOras INNER JOIN Administratori_Restaurant ar ON r.IdRestaurant = ar.IdRestaurant INNER JOIN Administrator a ON ar.IdAdministrator = a.IdAdministrator WHERE a.IdAdministrator LIKE ('%" + MainForm.userManager.CurrentUser.Id + "%');";
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    dataGridViewRestaurants.DataSource = dt1;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                //revenire la form-ul anterior dacă utilizatorul nu este logat
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
            //resetare câmpuri când se dorește crearea unui restaurnat nou
            modeRestaurant = (int)Modes.NEW_ENTITY;
            textBoxAddress.Text = "";
            textBoxMenu.Text = "";
            textBoxName.Text = "";
            comboBoxCity.Text = "";
            textBoxPhone.Text = "";
            buttonNewRestaurant.BackColor = Color.LawnGreen;
            buttonModifyRestaurant.BackColor = SystemColors.Control;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //verificare opțiune
            if (modeRestaurant == (int)Modes.NEW_ENTITY)
            {
                //când se crează un restaurant nou
                try
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();

                    //selectare IdOras
                    SqlCommand cmd = new SqlCommand("select IdOras from Oras where nume like ('%" + comboBoxCity.Text.Trim() + "%')", conn);
                    idOras = Convert.ToInt32(cmd.ExecuteScalar());


                    //adăugare restaurant
                    SqlCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandText = "insert into Restaurant(Nume,Adresa,IdOras,Meniu,Telefon) values (@Nume,@Adresa,@IdOras,@Meniu,@Telefon)";
                    cmd1.Parameters.AddWithValue("@Nume", textBoxName.Text.Trim());
                    cmd1.Parameters.AddWithValue("@Adresa", textBoxAddress.Text.Trim());
                    cmd1.Parameters.AddWithValue("@IdOras", idOras);
                    cmd1.Parameters.AddWithValue("@Meniu", textBoxMenu.Text.Trim());
                    cmd1.Parameters.AddWithValue("@Telefon", textBoxPhone.Text.Trim());
                    cmd1.ExecuteNonQuery();

                    //selectare idRestaurant creat mai sus
                    cmd = new SqlCommand("select IdRestaurant from Restaurant where nume like ('%" + textBoxName.Text.Trim() + "%') and adresa like ('%" + textBoxAddress.Text.Trim() + "%') and IdOras like ('%" + idOras + "%') and Meniu like ('%" + textBoxMenu.Text.Trim() + "%')", conn);
                    int idRestaurant = Convert.ToInt32(cmd.ExecuteScalar());


                    //adăugare legătură dintre administrator și restaurant
                    cmd1 = conn.CreateCommand();
                    cmd1.CommandText = "insert into Administratori_Restaurant(IdAdministrator,IdRestaurant) values (@IdAdministrator,@IdRestaurant)";
                    cmd1.Parameters.AddWithValue("@IdAdministrator", MainForm.userManager.CurrentUser.Id);
                    cmd1.Parameters.AddWithValue("@IdRestaurant", idRestaurant);
                    cmd1.ExecuteNonQuery();
                    RestaurantsForm_Shown(sender, EventArgs.Empty);
                    MessageBox.Show("Restaurant added succesfully!");

                } catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {

                //când se modifică un restaurant
                try
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();

                    //selectare IdOras si IdRestaurant pentru restaurantul selectat
                    SqlCommand cmd = new SqlCommand("select IdOras from Oras where nume like ('%" + comboBoxCity.Text.Trim() + "%')", conn);
                    idOras = Convert.ToInt32(cmd.ExecuteScalar());


                    //actualizare restaurant
                    SqlCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandText = "UPDATE Restaurant SET Nume = @Nume, Adresa = @Adresa, IdOras = @IdOras, Meniu = @Meniu, Telefon = @Telefon WHERE IdRestaurant = @IdRestaurant";
                    cmd1.Parameters.AddWithValue("@Nume", textBoxName.Text.Trim());
                    cmd1.Parameters.AddWithValue("@Adresa", textBoxAddress.Text.Trim());
                    cmd1.Parameters.AddWithValue("@IdOras", idOras);
                    cmd1.Parameters.AddWithValue("@Meniu", textBoxMenu.Text.Trim());
                    cmd1.Parameters.AddWithValue("@IdRestaurant", restaurantID);
                    cmd1.Parameters.AddWithValue("@Telefon", textBoxPhone.Text.Trim());

                    //refresh interfață pentru a reflecta modificările
                    RestaurantsForm_Shown(sender, EventArgs.Empty);
                    cmd1.ExecuteNonQuery();


                    RestaurantsForm_Shown(sender, EventArgs.Empty);
                    MessageBox.Show("Restaurant modified succesfully!");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        //metodă folosită pentru a actualiza tabelele
        private void RestaurantsForm_Shown(object sender, EventArgs e)
        {
            groupBoxTables.Enabled = false;
            dataGridViewRooms.Enabled = false;
            SqlCommand cmd = conn.CreateCommand();

            //populare tabel săli
            cmd.CommandText = "SELECT s.IdSala, s.Mese, s.Facilitati from Sala s, Restaurant r WHERE r.IdRestaurant LIKE ('%" + restaurantID + "%') and r.IdRestaurant = s.IdRestaurant;";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridViewRooms.DataSource = dt1;
            dataGridViewRooms.Columns[0].Visible = false;


            //populare tabel restaurante
            cmd.CommandText = "SELECT r.IdRestaurant as ID, r.Nume AS \"Restaurant name\", r.Adresa AS \"Restaurant address\", r.Meniu,o.Nume AS City, r.Telefon AS \"Phone Number\" FROM Restaurant r INNER JOIN Oras o ON r.IdOras = o.IdOras INNER JOIN Administratori_Restaurant ar ON r.IdRestaurant = ar.IdRestaurant INNER JOIN Administrator a ON ar.IdAdministrator = a.IdAdministrator WHERE a.IdAdministrator LIKE ('%" + MainForm.userManager.CurrentUser.Id + "%');";
            da1 = new SqlDataAdapter(cmd);
            dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridViewRestaurants.DataSource = dt1;
            dataGridViewRestaurants.Columns[0].Visible = false;

        }


        private void buttonNewRoom_Click(object sender, EventArgs e)
        {
            //resetare câmpuri când se dorește crearea unei săli noi
            modeRoom = (int)Modes.NEW_ENTITY;
            textBoxFacilities.Text = "";
            textBoxTables.Text = "";
            buttonNewRoom.BackColor = Color.LawnGreen;
            buttonModifyRoom.BackColor = SystemColors.Control;
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            //salvare sală
            if (modeRoom == (int)Modes.NEW_ENTITY)
            {
                //mod sală nouă
                int.TryParse(textBoxTables.Text, out int tablesCount);
                if (tablesCount > 0)
                {
                    try
                    {
                        string facilities = textBoxFacilities.Text.Trim();

                        //adăugare în tabelă
                        SqlCommand cmd1 = conn.CreateCommand();
                        cmd1 = conn.CreateCommand();
                        cmd1.CommandText = "insert into Sala(IdRestaurant,Mese,Facilitati) values (@IdRestaurant,@Mese,@Facilitati)";
                        cmd1.Parameters.AddWithValue("@IdRestaurant", restaurantID);
                        cmd1.Parameters.AddWithValue("@Mese", tablesCount);
                        cmd1.Parameters.AddWithValue("@Facilitati", facilities);
                        cmd1.ExecuteNonQuery();

                        //refresh interfață
                        RestaurantsForm_Shown(sender, EventArgs.Empty);
                        MessageBox.Show("Room added succesfully!");
                        groupBoxTables.Enabled = true;
                        dataGridViewRooms.Enabled = true;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            else
            {
                //modificare sală
                try
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();

                   //actualizare informații
                    SqlCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandText = "UPDATE Sala SET Mese = @Mese, Facilitati = @Facilitati WHERE IdRestaurant = @IdRestaurant and IdSala = @IdSala";
                    cmd1.Parameters.AddWithValue("@Mese", textBoxTables.Text);
                    cmd1.Parameters.AddWithValue("@Facilitati", textBoxFacilities.Text);
                    cmd1.Parameters.AddWithValue("@IdRestaurant", restaurantID);
                    cmd1.Parameters.AddWithValue("@IdSala", roomID);

                    cmd1.ExecuteNonQuery();

                    //refresh interfață
                    RestaurantsForm_Shown(sender, EventArgs.Empty);
                    MessageBox.Show("Restaurant modified succesfully!");
                    groupBoxTables.Enabled = true;
                    dataGridViewRooms.Enabled = true;

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void buttonModifyRestaurant_Click(object sender, EventArgs e)
        {
            //selectare mod modificare restaurant
            modeRestaurant = (int)Modes.MODIFY;
            buttonModifyRestaurant.BackColor = Color.LawnGreen;
            buttonNewRestaurant.BackColor = SystemColors.Control;
        }

        private void buttonModifyRoom_Click(object sender, EventArgs e)
        {
            //selectare mod modificare sală
            modeRoom = (int)Modes.MODIFY;
            buttonModifyRoom.BackColor = Color.LawnGreen;
            buttonNewRoom.BackColor = SystemColors.Control;
        }

        private void dataGridViewRestaurants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selectarea unui restaurant din tabel

            groupBoxTables.Visible = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dt1.Rows.Count)
            {

                try
                {

                    //populare câmpuri de pe interfață
                    int.TryParse(dataGridViewRestaurants.Rows[e.RowIndex].Cells[0].Value.ToString(), out restaurantID);
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT s.IdSala, s.Mese, s.Facilitati from Sala s, Restaurant r WHERE r.IdRestaurant LIKE ('%" + restaurantID + "%') and r.IdRestaurant = s.IdRestaurant;";
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dataGridViewRooms.DataSource = dt2;
                    groupBoxTables.Enabled = true;
                    dataGridViewRooms.Enabled = true; 
                    if (modeRestaurant == (int)Modes.MODIFY)
                    {
                        textBoxName.Text = dataGridViewRestaurants.Rows[e.RowIndex].Cells[1].Value.ToString();
                        textBoxAddress.Text = dataGridViewRestaurants.Rows[e.RowIndex].Cells[2].Value.ToString();
                        comboBoxCity.Text = dataGridViewRestaurants.Rows[e.RowIndex].Cells[4].Value.ToString();
                        textBoxMenu.Text = dataGridViewRestaurants.Rows[e.RowIndex].Cells[3].Value.ToString();
                        textBoxPhone.Text = dataGridViewRestaurants.Rows[e.RowIndex].Cells[5].Value.ToString();

                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    


        private void dataGridViewRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selectarea unei săli din tabel
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dt1.Rows.Count)
            {

                try
                {
                    int.TryParse(dataGridViewRooms.Rows[e.RowIndex].Cells[0].Value.ToString(), out roomID);
                    
                    if (modeRoom == (int)Modes.MODIFY)
                    {
                        //populare câmpuri de pe interfață
                        textBoxTables.Text = dataGridViewRooms.Rows[e.RowIndex].Cells[1].Value.ToString();
                        textBoxFacilities.Text = dataGridViewRooms.Rows[e.RowIndex].Cells[2].Value.ToString();

                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
