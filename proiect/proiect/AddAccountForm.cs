using System.Data.SqlClient;

namespace proiect
{
    public partial class AddAccountForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\Proiect IP\Proiect-IP\proiect\proiect\restaurants.mdf;Integrated Security = True");

    
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals(textBoxPassword.Text))
            {
                try
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                    conn.Open();
                    SqlCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandText = "insert into Administrator(Nume,Parola) values (@Nume,@Parola)";
                    cmd1.Parameters.AddWithValue("@Nume", textBoxName.Text);
                    cmd1.Parameters.AddWithValue("@Parola", textBoxPassword.Text);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Account created succesfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not create account! Reason: " + ex.Message);
                }
            }
        }
    }
}