//Flaminzanu-Mateiuc Marian

using System.Data.SqlClient;

namespace proiect
{
    public partial class AddAccountForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Directory.GetCurrentDirectory() + "\\restaurants.mdf;" + "Integrated Security = True");


        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (MainForm.userManager.userExists(textBoxName.Text, textBoxPassword.Text) == false)
            {
                try
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                    conn.Open();
                    SqlCommand cmd1 = conn.CreateCommand();

                    cmd1.CommandText = "insert into Administrator(Nume,Parola) values (@Nume,@Parola)";
                    cmd1.Parameters.AddWithValue("@Nume", textBoxName.Text.Trim());
                    cmd1.Parameters.AddWithValue("@Parola", textBoxPassword.Text.Trim());
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Account created succesfully!");
                    groupBox2.Visible = true;
                    MainForm.userManager.CurrentUser = new User(textBoxName.Text, textBoxPassword.Text);
                    MainForm.userManager.resetUserList();

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form? form = MainForm.caretaker?.Undo();
            if (form != null)
            {
                form.Show();
                this.Close();
            }
        }

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

        private void buttonRestaurant_Click(object sender, EventArgs e)
        {
            RestaurantsForm userOptions = new RestaurantsForm();
            userOptions.Show();
            MainForm.caretaker = new Caretaker(this);
            MainForm.caretaker.Save();
            this.Hide();
        }
    }
}