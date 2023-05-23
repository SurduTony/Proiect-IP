﻿namespace proiect
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
            this.dataGridViewRestaurants = new System.Windows.Forms.DataGridView();
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
            this.groupBoxTables = new System.Windows.Forms.GroupBox();
            this.textBoxFacilities = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTables = new System.Windows.Forms.Label();
            this.textBoxTables = new System.Windows.Forms.TextBox();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonNewRoom = new System.Windows.Forms.Button();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurants)).BeginInit();
            this.groupBoxRestaurant.SuspendLayout();
            this.groupBoxTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRestaurants
            // 
            this.dataGridViewRestaurants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRestaurants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewRestaurants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestaurants.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewRestaurants.Location = new System.Drawing.Point(3, 328);
            this.dataGridViewRestaurants.Name = "dataGridViewRestaurants";
            this.dataGridViewRestaurants.ReadOnly = true;
            this.dataGridViewRestaurants.RowHeadersWidth = 51;
            this.dataGridViewRestaurants.RowTemplate.Height = 29;
            this.dataGridViewRestaurants.Size = new System.Drawing.Size(653, 407);
            this.dataGridViewRestaurants.TabIndex = 0;
            this.dataGridViewRestaurants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
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
            this.buttonNewRestaurant.Location = new System.Drawing.Point(472, 55);
            this.buttonNewRestaurant.Name = "buttonNewRestaurant";
            this.buttonNewRestaurant.Size = new System.Drawing.Size(141, 51);
            this.buttonNewRestaurant.TabIndex = 9;
            this.buttonNewRestaurant.Text = "New Restaurant";
            this.buttonNewRestaurant.UseVisualStyleBackColor = true;
            this.buttonNewRestaurant.Click += new System.EventHandler(this.buttonNewRestaurant_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(474, 253);
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
            this.groupBoxRestaurant.Size = new System.Drawing.Size(659, 738);
            this.groupBoxRestaurant.TabIndex = 11;
            this.groupBoxRestaurant.TabStop = false;
            // 
            // groupBoxTables
            // 
            this.groupBoxTables.Controls.Add(this.textBoxFacilities);
            this.groupBoxTables.Controls.Add(this.label2);
            this.groupBoxTables.Controls.Add(this.labelTables);
            this.groupBoxTables.Controls.Add(this.textBoxTables);
            this.groupBoxTables.Controls.Add(this.buttonAddRoom);
            this.groupBoxTables.Controls.Add(this.buttonNewRoom);
            this.groupBoxTables.Controls.Add(this.dataGridViewRooms);
            this.groupBoxTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTables.Location = new System.Drawing.Point(659, 0);
            this.groupBoxTables.Name = "groupBoxTables";
            this.groupBoxTables.Size = new System.Drawing.Size(601, 738);
            this.groupBoxTables.TabIndex = 12;
            this.groupBoxTables.TabStop = false;
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
            // buttonAddRoom
            // 
            this.buttonAddRoom.Location = new System.Drawing.Point(450, 253);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(141, 51);
            this.buttonAddRoom.TabIndex = 12;
            this.buttonAddRoom.Text = "Add Room";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonNewRoom
            // 
            this.buttonNewRoom.Location = new System.Drawing.Point(448, 55);
            this.buttonNewRoom.Name = "buttonNewRoom";
            this.buttonNewRoom.Size = new System.Drawing.Size(141, 51);
            this.buttonNewRoom.TabIndex = 11;
            this.buttonNewRoom.Text = "New Room";
            this.buttonNewRoom.UseVisualStyleBackColor = true;
            this.buttonNewRoom.Click += new System.EventHandler(this.buttonNewRoom_Click);
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(3, 328);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 29;
            this.dataGridViewRooms.Size = new System.Drawing.Size(595, 407);
            this.dataGridViewRooms.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestaurants)).EndInit();
            this.groupBoxRestaurant.ResumeLayout(false);
            this.groupBoxRestaurant.PerformLayout();
            this.groupBoxTables.ResumeLayout(false);
            this.groupBoxTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewRestaurants;
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
        private Button buttonAddRoom;
        private Button buttonNewRoom;
    }
}