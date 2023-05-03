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

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // extrage date din textbox
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (userManager != null && userManager.userExists(username, password))
            {
                if (MainForm.userManager.getUser(username, password) != null)
                    MainForm.userManager.CurrentUser = MainForm.userManager.getUser(username, password);
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
                MessageBox.Show("The user doesn't exist. Please try again!");
                textBoxPassword.Text = "";
                textBoxUsername.Text = "";
            }
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
    }
}
