namespace proiect
{
    partial class RestaurantsForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxMenu = new System.Windows.Forms.TextBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.buttonNewRestaurant = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxRestaurant = new System.Windows.Forms.GroupBox();
            this.dataGridViewRestaurants = new System.Windows.Forms.DataGridView();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonModifyRestaurant = new System.Windows.Forms.Button();
            this.groupBoxTables = new System.Windows.Forms.GroupBox();
            this.buttonModifyRoom = new System.Windows.Forms.Button();
            this.textBoxFacilities = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTables = new System.Windows.Forms.Label();
            this.textBoxTables = new System.Windows.Forms.TextBox();
            this.buttonSaveRoom = new System.Windows.Forms.Button();
            this.buttonNewRoom = new System.Windows.Forms.Button();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.groupBoxRestaurant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurants)).BeginInit();
            this.groupBoxTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(11, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(11, 79);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(65, 20);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(11, 129);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(37, 20);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "City:";
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(11, 178);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(49, 20);
            this.labelMenu.TabIndex = 4;
            this.labelMenu.Text = "Menu:";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(82, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(384, 27);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(82, 79);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(384, 27);
            this.textBoxAddress.TabIndex = 6;
            // 
            // textBoxMenu
            // 
            this.textBoxMenu.Location = new System.Drawing.Point(84, 169);
            this.textBoxMenu.Multiline = true;
            this.textBoxMenu.Name = "textBoxMenu";
            this.textBoxMenu.Size = new System.Drawing.Size(384, 135);
            this.textBoxMenu.TabIndex = 7;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(82, 126);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(157, 28);
            this.comboBoxCity.TabIndex = 8;
            // 
            // buttonNewRestaurant
            // 
            this.buttonNewRestaurant.Location = new System.Drawing.Point(472, 15);
            this.buttonNewRestaurant.Name = "buttonNewRestaurant";
            this.buttonNewRestaurant.Size = new System.Drawing.Size(141, 51);
            this.buttonNewRestaurant.TabIndex = 9;
            this.buttonNewRestaurant.Text = "New Restaurant";
            this.buttonNewRestaurant.UseVisualStyleBackColor = true;
            this.buttonNewRestaurant.Click += new System.EventHandler(this.buttonNewRestaurant_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(474, 317);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(141, 51);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxRestaurant
            // 
            this.groupBoxRestaurant.Controls.Add(this.dataGridViewRestaurants);
            this.groupBoxRestaurant.Controls.Add(this.labelPhone);
            this.groupBoxRestaurant.Controls.Add(this.textBoxPhone);
            this.groupBoxRestaurant.Controls.Add(this.buttonModifyRestaurant);
            this.groupBoxRestaurant.Controls.Add(this.buttonSave);
            this.groupBoxRestaurant.Controls.Add(this.labelName);
            this.groupBoxRestaurant.Controls.Add(this.buttonNewRestaurant);
            this.groupBoxRestaurant.Controls.Add(this.labelAddress);
            this.groupBoxRestaurant.Controls.Add(this.comboBoxCity);
            this.groupBoxRestaurant.Controls.Add(this.labelCity);
            this.groupBoxRestaurant.Controls.Add(this.textBoxMenu);
            this.groupBoxRestaurant.Controls.Add(this.labelMenu);
            this.groupBoxRestaurant.Controls.Add(this.textBoxAddress);
            this.groupBoxRestaurant.Controls.Add(this.textBoxName);
            this.groupBoxRestaurant.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxRestaurant.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRestaurant.Name = "groupBoxRestaurant";
            this.groupBoxRestaurant.Size = new System.Drawing.Size(656, 738);
            this.groupBoxRestaurant.TabIndex = 11;
            this.groupBoxRestaurant.TabStop = false;
            // 
            // dataGridViewRestaurants
            // 
            this.dataGridViewRestaurants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRestaurants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewRestaurants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestaurants.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewRestaurants.Location = new System.Drawing.Point(3, 374);
            this.dataGridViewRestaurants.Name = "dataGridViewRestaurants";
            this.dataGridViewRestaurants.ReadOnly = true;
            this.dataGridViewRestaurants.RowHeadersWidth = 51;
            this.dataGridViewRestaurants.RowTemplate.Height = 29;
            this.dataGridViewRestaurants.Size = new System.Drawing.Size(650, 361);
            this.dataGridViewRestaurants.TabIndex = 14;
            this.dataGridViewRestaurants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRestaurants_CellClick);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(11, 332);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(53, 20);
            this.labelPhone.TabIndex = 12;
            this.labelPhone.Text = "Phone:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(82, 332);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(384, 27);
            this.textBoxPhone.TabIndex = 13;
            // 
            // buttonModifyRestaurant
            // 
            this.buttonModifyRestaurant.Location = new System.Drawing.Point(474, 79);
            this.buttonModifyRestaurant.Name = "buttonModifyRestaurant";
            this.buttonModifyRestaurant.Size = new System.Drawing.Size(141, 51);
            this.buttonModifyRestaurant.TabIndex = 11;
            this.buttonModifyRestaurant.Text = "Modify\r\nRestaurant";
            this.buttonModifyRestaurant.UseVisualStyleBackColor = true;
            this.buttonModifyRestaurant.Click += new System.EventHandler(this.buttonModifyRestaurant_Click);
            // 
            // groupBoxTables
            // 
            this.groupBoxTables.Controls.Add(this.buttonModifyRoom);
            this.groupBoxTables.Controls.Add(this.textBoxFacilities);
            this.groupBoxTables.Controls.Add(this.label2);
            this.groupBoxTables.Controls.Add(this.labelTables);
            this.groupBoxTables.Controls.Add(this.textBoxTables);
            this.groupBoxTables.Controls.Add(this.buttonSaveRoom);
            this.groupBoxTables.Controls.Add(this.buttonNewRoom);
            this.groupBoxTables.Controls.Add(this.dataGridViewRooms);
            this.groupBoxTables.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxTables.Location = new System.Drawing.Point(659, 0);
            this.groupBoxTables.Name = "groupBoxTables";
            this.groupBoxTables.Size = new System.Drawing.Size(601, 738);
            this.groupBoxTables.TabIndex = 12;
            this.groupBoxTables.TabStop = false;
            // 
            // buttonModifyRoom
            // 
            this.buttonModifyRoom.Location = new System.Drawing.Point(448, 79);
            this.buttonModifyRoom.Name = "buttonModifyRoom";
            this.buttonModifyRoom.Size = new System.Drawing.Size(141, 51);
            this.buttonModifyRoom.TabIndex = 17;
            this.buttonModifyRoom.Text = "Modify\r\nRoom";
            this.buttonModifyRoom.UseVisualStyleBackColor = true;
            this.buttonModifyRoom.Click += new System.EventHandler(this.buttonModifyRoom_Click);
            // 
            // textBoxFacilities
            // 
            this.textBoxFacilities.Location = new System.Drawing.Point(88, 77);
            this.textBoxFacilities.Multiline = true;
            this.textBoxFacilities.Name = "textBoxFacilities";
            this.textBoxFacilities.Size = new System.Drawing.Size(331, 174);
            this.textBoxFacilities.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Facilities:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTables
            // 
            this.labelTables.AutoSize = true;
            this.labelTables.Location = new System.Drawing.Point(15, 42);
            this.labelTables.Name = "labelTables";
            this.labelTables.Size = new System.Drawing.Size(53, 20);
            this.labelTables.TabIndex = 13;
            this.labelTables.Text = "Tables:";
            this.labelTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTables
            // 
            this.textBoxTables.Location = new System.Drawing.Point(88, 39);
            this.textBoxTables.Name = "textBoxTables";
            this.textBoxTables.Size = new System.Drawing.Size(86, 27);
            this.textBoxTables.TabIndex = 14;
            // 
            // buttonSaveRoom
            // 
            this.buttonSaveRoom.Location = new System.Drawing.Point(448, 308);
            this.buttonSaveRoom.Name = "buttonSaveRoom";
            this.buttonSaveRoom.Size = new System.Drawing.Size(141, 51);
            this.buttonSaveRoom.TabIndex = 12;
            this.buttonSaveRoom.Text = "Save";
            this.buttonSaveRoom.UseVisualStyleBackColor = true;
            this.buttonSaveRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonNewRoom
            // 
            this.buttonNewRoom.Location = new System.Drawing.Point(448, 15);
            this.buttonNewRoom.Name = "buttonNewRoom";
            this.buttonNewRoom.Size = new System.Drawing.Size(141, 51);
            this.buttonNewRoom.TabIndex = 11;
            this.buttonNewRoom.Text = "New Room";
            this.buttonNewRoom.UseVisualStyleBackColor = true;
            this.buttonNewRoom.Click += new System.EventHandler(this.buttonNewRoom_Click);
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewRooms.Location = new System.Drawing.Point(3, 374);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 29;
            this.dataGridViewRooms.Size = new System.Drawing.Size(595, 361);
            this.dataGridViewRooms.TabIndex = 0;
            this.dataGridViewRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellClick);
            // 
            // RestaurantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 738);
            this.Controls.Add(this.groupBoxTables);
            this.Controls.Add(this.groupBoxRestaurant);
            this.Name = "RestaurantsForm";
            this.Text = "Restaurant Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RestaurantsForm_FormClosing);
            this.Load += new System.EventHandler(this.RestaurantsForm_Load);
            this.Shown += new System.EventHandler(this.RestaurantsForm_Shown);
            this.groupBoxRestaurant.ResumeLayout(false);
            this.groupBoxRestaurant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurants)).EndInit();
            this.groupBoxTables.ResumeLayout(false);
            this.groupBoxTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label labelName;
        private Label labelAddress;
        private Label labelCity;
        private Label labelMenu;
        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private TextBox textBoxMenu;
        private ComboBox comboBoxCity;
        private Button buttonNewRestaurant;
        private Button buttonSave;
        private GroupBox groupBoxRestaurant;
        private GroupBox groupBoxTables;
        private DataGridView dataGridViewRooms;
        private TextBox textBoxFacilities;
        private Label label2;
        private Label labelTables;
        private TextBox textBoxTables;
        private Button buttonSaveRoom;
        private Button buttonNewRoom;
        private Button buttonModifyRestaurant;
        private Button buttonModifyRoom;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private DataGridView dataGridViewRestaurants;
    }
}