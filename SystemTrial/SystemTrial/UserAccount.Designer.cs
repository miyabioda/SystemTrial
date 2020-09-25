namespace SystemTrial
{
    partial class UserAccount
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
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.confirmpwd = new MetroFramework.Controls.MetroTextBox();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_add = new MetroFramework.Controls.MetroButton();
            this.error = new System.Windows.Forms.Label();
            this.bt_update = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // username
            // 
            // 
            // 
            // 
            this.username.CustomButton.Image = null;
            this.username.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.username.CustomButton.Name = "";
            this.username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username.CustomButton.TabIndex = 1;
            this.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username.CustomButton.UseSelectable = true;
            this.username.CustomButton.Visible = false;
            this.username.Lines = new string[0];
            this.username.Location = new System.Drawing.Point(139, 33);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.ShortcutsEnabled = true;
            this.username.Size = new System.Drawing.Size(184, 23);
            this.username.TabIndex = 0;
            this.username.UseSelectable = true;
            this.username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Username: ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Password:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(122, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Confirm Password: ";
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(139, 68);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(184, 23);
            this.password.TabIndex = 4;
            this.password.UseSelectable = true;
            this.password.UseSystemPasswordChar = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // confirmpwd
            // 
            // 
            // 
            // 
            this.confirmpwd.CustomButton.Image = null;
            this.confirmpwd.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.confirmpwd.CustomButton.Name = "";
            this.confirmpwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.confirmpwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmpwd.CustomButton.TabIndex = 1;
            this.confirmpwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmpwd.CustomButton.UseSelectable = true;
            this.confirmpwd.CustomButton.Visible = false;
            this.confirmpwd.Lines = new string[0];
            this.confirmpwd.Location = new System.Drawing.Point(139, 105);
            this.confirmpwd.MaxLength = 32767;
            this.confirmpwd.Name = "confirmpwd";
            this.confirmpwd.PasswordChar = '●';
            this.confirmpwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmpwd.SelectedText = "";
            this.confirmpwd.SelectionLength = 0;
            this.confirmpwd.SelectionStart = 0;
            this.confirmpwd.ShortcutsEnabled = true;
            this.confirmpwd.Size = new System.Drawing.Size(184, 23);
            this.confirmpwd.TabIndex = 5;
            this.confirmpwd.UseSelectable = true;
            this.confirmpwd.UseSystemPasswordChar = true;
            this.confirmpwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirmpwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.confirmpwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmpwd_KeyDown);
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.GridLines = true;
            this.metroListView1.Location = new System.Drawing.Point(23, 210);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(300, 148);
            this.metroListView1.TabIndex = 6;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            this.metroListView1.SelectedIndexChanged += new System.EventHandler(this.metroListView1_SelectedIndexChanged);
            this.metroListView1.DoubleClick += new System.EventHandler(this.metroListView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Password";
            this.columnHeader3.Width = 150;
            // 
            // bt_add
            // 
            this.bt_add.Highlight = true;
            this.bt_add.Location = new System.Drawing.Point(248, 164);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 7;
            this.bt_add.Text = "Add";
            this.bt_add.UseSelectable = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(137, 131);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 12);
            this.error.TabIndex = 8;
            this.error.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(248, 164);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 9;
            this.bt_update.Text = "Update";
            this.bt_update.UseSelectable = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 386);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.error);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.confirmpwd);
            this.Controls.Add(this.password);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.username);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox username;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroTextBox confirmpwd;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroButton bt_add;
        private System.Windows.Forms.Label error;
        private MetroFramework.Controls.MetroButton bt_update;
    }
}