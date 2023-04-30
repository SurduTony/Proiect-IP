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
    public partial class UserOptionsForm : Form
    {
        public UserOptionsForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccount = new AddAccountForm();
            addAccount.Show();
            if (MainForm.caretaker != null)
            {
                MainForm.caretaker.form = this;
                MainForm.caretaker.Save();
            }
            this.Hide();
        }

        private void UserOptionsForm_FormClosing(object sender, FormClosingEventArgs e)
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
