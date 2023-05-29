/**********************************
//
//Autor: Flaminzanu-Mateiuc Marian
//
//Descriere: Formular prin intermediul căruia se pot crea utilizatori noi.
            Constă în 3 controale de tip textBox în care se introduc numele de utilizator, parola și confirmarea acesteia.
            Se verifică la apăsarea butonului de adăugare dacaă există deja un utilizator cu același nume.
            Dacă nu, se creează utilizatorul nou, aplicația setează ca user activ contul nou creat și se revine la form-ul anterior.
*/



using System.Data.SqlClient;

namespace proiect
{
    public partial class AddAccountForm : Form
    {
        public static string currentPath = Directory.GetCurrentDirectory();
        public static string newPath = currentPath.Substring(0, currentPath.IndexOf("bin"));
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + newPath + "restaurants.mdf;" + "Integrated Security = True");


        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificare existență user

                if (MainForm.userManager.userExists(textBoxName.Text, textBoxPassword.Text) == false)
                {
                    try
                    {
                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();
                        conn.Open();

                        //validare preliminară a câmpurilor

                        if (textBoxName.Text != "" && textBoxName.Text != " " && textBoxPassword.Text.Equals(textBoxConfirm.Text))
                        {
                            SqlCommand cmd1 = conn.CreateCommand();

                            //Adăugare user în baza de date

                            cmd1.CommandText = "insert into Administrator(Nume,Parola) values (@Nume,@Parola)";
                            cmd1.Parameters.AddWithValue("@Nume", textBoxName.Text);
                            cmd1.Parameters.AddWithValue("@Parola", textBoxPassword.Text);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Account created succesfully!");


                            //Adăugare user în lista de useri
                            cmd1.CommandText = "select IdAdministrator from Administrator where Nume like ('%" + textBoxName.Text + "%') and Parola like ('%" + textBoxPassword.Text + "%')";
                            int idAdministrator = Convert.ToInt32(cmd1.ExecuteScalar());

                            
                            MainForm.userManager.CurrentUser = new User(idAdministrator,textBoxName.Text, textBoxPassword.Text);
                            MainForm.userManager.resetUserList();

                            //Ieșire din meniul curent
                            Form? form = MainForm.caretaker?.Undo();
                            if (form != null)
                            {
                                form.Show();
                                this.Dispose();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid request! Please try again!");
                            textBoxConfirm.Text = "";
                            textBoxName.Text = "";
                            textBoxPassword.Text = "";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not create account! Reason: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("This user already exists. Try another username or password.");
                    textBoxPassword.Text = "";
                    textBoxName.Text = "";
                    textBoxConfirm.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Form? form = MainForm.caretaker?.Undo();
                if (form != null)
                {
                    form.Show();
                    this.Dispose();
                    this.Close();
                }
            }
        }

        //Revenire la meniul anterior 

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form? form = MainForm.caretaker?.Undo();
            if (form != null)
            {
                form.Show();
                this.Close();
            }
        }

        //Revenire la meniul anterior 

        private void AddAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form? form = MainForm.caretaker?.Undo();
            if (form != null)
            {
                form.Show();
                this.Dispose();
                this.Close();
            }
        } 

    }
}