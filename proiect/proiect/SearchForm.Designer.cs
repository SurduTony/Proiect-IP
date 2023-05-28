namespace proiect
{
    partial class SearchForm
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
            comboBox1 = new ComboBox();
            labelSearch = new Label();
            buttonSearch = new Button();
            groupBoxSearch = new GroupBox();
            buttonSearchMenu = new Button();
            textBoxMenu = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            buttonSearchName = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 40);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 0;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(10, 17);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(83, 15);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "Search by city:";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(148, 39);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(82, 22);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(buttonSearchMenu);
            groupBoxSearch.Controls.Add(textBoxMenu);
            groupBoxSearch.Controls.Add(label2);
            groupBoxSearch.Controls.Add(textBoxName);
            groupBoxSearch.Controls.Add(buttonSearchName);
            groupBoxSearch.Controls.Add(label1);
            groupBoxSearch.Controls.Add(labelSearch);
            groupBoxSearch.Controls.Add(buttonSearch);
            groupBoxSearch.Controls.Add(comboBox1);
            groupBoxSearch.Dock = DockStyle.Fill;
            groupBoxSearch.Location = new Point(0, 0);
            groupBoxSearch.Margin = new Padding(3, 2, 3, 2);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Padding = new Padding(3, 2, 3, 2);
            groupBoxSearch.Size = new Size(998, 446);
            groupBoxSearch.TabIndex = 3;
            groupBoxSearch.TabStop = false;
            // 
            // buttonSearchMenu
            // 
            buttonSearchMenu.Location = new Point(863, 42);
            buttonSearchMenu.Margin = new Padding(3, 2, 3, 2);
            buttonSearchMenu.Name = "buttonSearchMenu";
            buttonSearchMenu.Size = new Size(85, 21);
            buttonSearchMenu.TabIndex = 8;
            buttonSearchMenu.Text = "Search";
            buttonSearchMenu.UseVisualStyleBackColor = true;
            buttonSearchMenu.Click += buttonSearchMenu_Click;
            // 
            // textBoxMenu
            // 
            textBoxMenu.Location = new Point(730, 42);
            textBoxMenu.Name = "textBoxMenu";
            textBoxMenu.Size = new Size(127, 23);
            textBoxMenu.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(730, 17);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 6;
            label2.Text = "Search by menu:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(394, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(107, 23);
            textBoxName.TabIndex = 5;
            // 
            // buttonSearchName
            // 
            buttonSearchName.Location = new Point(507, 39);
            buttonSearchName.Margin = new Padding(3, 2, 3, 2);
            buttonSearchName.Name = "buttonSearchName";
            buttonSearchName.Size = new Size(85, 21);
            buttonSearchName.TabIndex = 4;
            buttonSearchName.Text = "Search";
            buttonSearchName.UseVisualStyleBackColor = true;
            buttonSearchName.Click += buttonSearchName_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 17);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 3;
            label1.Text = "Search by name:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 201);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(998, 245);
            dataGridView1.TabIndex = 4;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 446);
            Controls.Add(dataGridView1);
            Controls.Add(groupBoxSearch);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchForm";
            Text = "SearchForm";
            FormClosing += SearchForm_FormClosing;
            Load += SearchForm_Load;
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Label labelSearch;
        private Button buttonSearch;
        private GroupBox groupBoxSearch;
        private DataGridView dataGridView1;
        private Button buttonSearchMenu;
        private TextBox textBoxMenu;
        private Label label2;
        private TextBox textBoxName;
        private Button buttonSearchName;
        private Label label1;
    }
}