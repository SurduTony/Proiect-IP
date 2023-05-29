namespace proiect
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogIn = new Button();
            buttonSearch = new Button();
            buttonAccount = new Button();
            labelUser = new Label();
            buttonLogOut = new Button();
            buttonHelp = new Button();
            SuspendLayout();
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(83, 274);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(157, 69);
            buttonLogIn.TabIndex = 4;
            buttonLogIn.Text = "Log in";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(293, 274);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(156, 69);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += button2_Click;
            // 
            // buttonAccount
            // 
            buttonAccount.Location = new Point(492, 274);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(157, 69);
            buttonAccount.TabIndex = 3;
            buttonAccount.Text = "Add/Create Account\r\nor\r\nManage Restaurants";
            buttonAccount.UseVisualStyleBackColor = true;
            buttonAccount.Click += buttonAccount_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(12, 9);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(472, 20);
            labelUser.TabIndex = 6;
            labelUser.Text = "You are not logged in. Please log in to be able to act as administrator!";
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(83, 274);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(157, 69);
            buttonLogOut.TabIndex = 1;
            buttonLogOut.Text = "Log out";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(664, 388);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(111, 32);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonLogOut);
            Controls.Add(labelUser);
            Controls.Add(buttonAccount);
            Controls.Add(buttonLogIn);
            Controls.Add(buttonSearch);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            VisibleChanged += MainForm_VisibleChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogIn;
        private Button buttonSearch;
        private Button buttonAccount;
        private Label labelUser;
        private Button buttonLogOut;
        private Button buttonHelp;
    }
}