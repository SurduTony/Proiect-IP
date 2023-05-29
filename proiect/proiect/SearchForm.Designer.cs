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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonSearchCity = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearchMenu = new System.Windows.Forms.Button();
            this.textBoxMenu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSearchName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(11, 23);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(103, 20);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Search by city:";
            // 
            // buttonSearchCity
            // 
            this.buttonSearchCity.Location = new System.Drawing.Point(169, 52);
            this.buttonSearchCity.Name = "buttonSearchCity";
            this.buttonSearchCity.Size = new System.Drawing.Size(94, 29);
            this.buttonSearchCity.TabIndex = 2;
            this.buttonSearchCity.Text = "Search";
            this.buttonSearchCity.UseVisualStyleBackColor = true;
            this.buttonSearchCity.Click += new System.EventHandler(this.buttonSearchCity_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearchMenu);
            this.groupBoxSearch.Controls.Add(this.textBoxMenu);
            this.groupBoxSearch.Controls.Add(this.label2);
            this.groupBoxSearch.Controls.Add(this.textBoxName);
            this.groupBoxSearch.Controls.Add(this.buttonSearchName);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Controls.Add(this.labelSearch);
            this.groupBoxSearch.Controls.Add(this.buttonSearchCity);
            this.groupBoxSearch.Controls.Add(this.comboBox1);
            this.groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(1141, 595);
            this.groupBoxSearch.TabIndex = 3;
            this.groupBoxSearch.TabStop = false;
            // 
            // buttonSearchMenu
            // 
            this.buttonSearchMenu.Location = new System.Drawing.Point(986, 56);
            this.buttonSearchMenu.Name = "buttonSearchMenu";
            this.buttonSearchMenu.Size = new System.Drawing.Size(97, 28);
            this.buttonSearchMenu.TabIndex = 8;
            this.buttonSearchMenu.Text = "Search";
            this.buttonSearchMenu.UseVisualStyleBackColor = true;
            this.buttonSearchMenu.Click += new System.EventHandler(this.buttonSearchMenu_Click);
            // 
            // textBoxMenu
            // 
            this.textBoxMenu.Location = new System.Drawing.Point(834, 56);
            this.textBoxMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMenu.Name = "textBoxMenu";
            this.textBoxMenu.Size = new System.Drawing.Size(145, 27);
            this.textBoxMenu.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(834, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search by menu:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(450, 53);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(122, 27);
            this.textBoxName.TabIndex = 5;
            // 
            // buttonSearchName
            // 
            this.buttonSearchName.Location = new System.Drawing.Point(579, 52);
            this.buttonSearchName.Name = "buttonSearchName";
            this.buttonSearchName.Size = new System.Drawing.Size(97, 28);
            this.buttonSearchName.TabIndex = 4;
            this.buttonSearchName.Text = "Search";
            this.buttonSearchName.UseVisualStyleBackColor = true;
            this.buttonSearchName.Click += new System.EventHandler(this.buttonSearchName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 327);
            this.dataGridView1.TabIndex = 4;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 595);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxSearch);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox1;
        private Label labelSearch;
        private Button buttonSearchCity;
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