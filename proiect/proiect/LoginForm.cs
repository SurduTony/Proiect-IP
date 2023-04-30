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
        UserManager userManager;

        public LoginForm()
        {
            userManager = new UserManager();
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // extrage date din textbox
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (userManager.userExists(username, password))
            {
                // schimba in form-ul cu optiuni
                OptionsForm optionsForm = new OptionsForm();
                optionsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("datele sunt gresite");
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
