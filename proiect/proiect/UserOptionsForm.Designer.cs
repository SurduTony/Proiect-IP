namespace proiect
{
    partial class UserOptionsForm
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
            label1 = new Label();
            buttonAdd = new Button();
            buttonModify = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(318, 43);
            label1.Name = "label1";
            label1.Size = new Size(132, 46);
            label1.TabIndex = 0;
            label1.Text = "Optiuni";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(129, 248);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(178, 59);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "adaugare";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            buttonModify.Location = new Point(472, 248);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(178, 59);
            buttonModify.TabIndex = 2;
            buttonModify.Text = "modificare";
            buttonModify.UseVisualStyleBackColor = true;
            // 
            // UserOptionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonModify);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Name = "UserOptionsForm";
            Text = "UserOptionsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAdd;
        private Button buttonModify;
    }
}