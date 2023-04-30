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
    public partial class MainForm : Form
    {
        public static Caretaker? caretaker;
        bool closingPending = false;

        public MainForm()
        {
            
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            caretaker = new Caretaker(this);
            caretaker.Save();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
            caretaker = new Caretaker(this);
            caretaker.Save();
            this.Hide();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            UserOptionsForm userOptions = new UserOptionsForm();
            userOptions.Show();
            caretaker = new Caretaker(this);
            caretaker.Save();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
