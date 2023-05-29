/**********************************
//
//Autor: Surdu Tony-Stefanel
//
//Descriere: Formular prin intermediul căruia se pot conecta utilizatorii la 
               conturile proprii
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

namespace proiect
{
    public partial class LoginForm : Form
    {
        UserManager? userManager = MainForm.userManager;
        public static int loggedIn = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form? form = MainForm.caretaker?.Undo();
            if (form != null)
            {
                form.Show();
                Dispose();
                this.Close();
            }
        }

        public string Username
        {
            get { return textBoxUsername.Text.Trim(); }
            set { textBoxUsername.Text = value; }
        }

        public string Password
        {
            get { return textBoxPassword.Text.Trim(); }
            set { textBoxPassword.Text = value; }
        }

        public int LoggedIn
        {
            get { return loggedIn; }
        }

        public void Login()
        {
            // extrage date din textbox
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (userManager != null && userManager.userExists(username, password))
            {
                if (MainForm.userManager.getUser(username, password) != null)
                    MainForm.userManager.CurrentUser = MainForm.userManager.getUser(username, password);
                loggedIn = 1;
                Form? form = MainForm.caretaker?.Undo();
                if (form != null)
                {
                    form.Show();
                    Dispose();
                    this.Close();
                }
            }
            else
            {

                loggedIn = 0;   
                MessageBox.Show("The user doesn't exist. Please try again!");
                textBoxPassword.Text = "";
                textBoxUsername.Text = "";
            }
        }
    }
}
