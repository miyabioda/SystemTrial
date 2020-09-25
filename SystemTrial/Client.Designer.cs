namespace SystemTrial
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Fname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lb_id = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.Dob = new MetroFramework.Controls.MetroDateTime();
            this.Gender = new MetroFramework.Controls.MetroComboBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.Ms = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.Lname = new MetroFramework.Controls.MetroTextBox();
            this.Mname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.Age = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.Religion = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.cel = new System.Windows.Forms.MaskedTextBox();
            this.Region = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.Town = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.Street = new MetroFramework.Controls.MetroTextBox();
            this.City = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bt_add = new MetroFramework.Controls.MetroButton();
            this.bt_cancel = new MetroFramework.Controls.MetroButton();
            this.bt_delete = new MetroFramework.Controls.MetroButton();
            this.errormsg = new System.Windows.Forms.Label();
            this.userlevel = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.bt_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 46);
            this.panel1.TabIndex = 11;
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_close.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Image = ((System.Drawing.Image)(resources.GetObject("bt_close.Image")));
            this.bt_close.Location = new System.Drawing.Point(756, 7);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(36, 38);
            this.bt_close.TabIndex = 32;
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client";
            // 
            // Fname
            // 
            // 
            // 
            // 
            this.Fname.CustomButton.Image = null;
            this.Fname.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.Fname.CustomButton.Name = "";
            this.Fname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Fname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Fname.CustomButton.TabIndex = 1;
            this.Fname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Fname.CustomButton.UseSelectable = true;
            this.Fname.CustomButton.Visible = false;
            this.Fname.Lines = new string[0];
            this.Fname.Location = new System.Drawing.Point(0, 88);
            this.Fname.MaxLength = 32767;
            this.Fname.Name = "Fname";
            this.Fname.PasswordChar = '\0';
            this.Fname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Fname.SelectedText = "";
            this.Fname.SelectionLength = 0;
            this.Fname.SelectionStart = 0;
            this.Fname.ShortcutsEnabled = true;
            this.Fname.Size = new System.Drawing.Size(188, 23);
            this.Fname.TabIndex = 13;
            this.Fname.UseSelectable = true;
            this.Fname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Fname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Fname.Enter += new System.EventHandler(this.Fname_Enter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-4, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "First Name";
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(392, 151);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(396, 365);
            this.metroListView1.TabIndex = 15;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Age";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Address";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telephone / Cellphone";
            this.columnHeader5.Width = 100;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 179);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Date of Birth";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 243);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Gender";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(0, 18);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(21, 19);
            this.lb_id.TabIndex = 20;
            this.lb_id.Text = "ID";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(27, 18);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(83, 23);
            this.metroTextBox2.TabIndex = 21;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Dob
            // 
            this.Dob.Location = new System.Drawing.Point(0, 201);
            this.Dob.MinimumSize = new System.Drawing.Size(0, 29);
            this.Dob.Name = "Dob";
            this.Dob.Size = new System.Drawing.Size(136, 29);
            this.Dob.TabIndex = 22;
            this.Dob.Leave += new System.EventHandler(this.Dob_Leave);
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.ItemHeight = 23;
            this.Gender.Location = new System.Drawing.Point(0, 265);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(136, 29);
            this.Gender.TabIndex = 23;
            this.Gender.UseSelectable = true;
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 58);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(340, 409);
            this.metroTabControl1.TabIndex = 30;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.Ms);
            this.metroTabPage1.Controls.Add(this.metroLabel13);
            this.metroTabPage1.Controls.Add(this.metroLabel12);
            this.metroTabPage1.Controls.Add(this.Lname);
            this.metroTabPage1.Controls.Add(this.Mname);
            this.metroTabPage1.Controls.Add(this.metroLabel11);
            this.metroTabPage1.Controls.Add(this.Age);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.Religion);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.lb_id);
            this.metroTabPage1.Controls.Add(this.metroTextBox2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.Fname);
            this.metroTabPage1.Controls.Add(this.Gender);
            this.metroTabPage1.Controls.Add(this.Dob);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(332, 367);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Personal Information";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // Ms
            // 
            this.Ms.FormattingEnabled = true;
            this.Ms.ItemHeight = 23;
            this.Ms.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Windowed",
            "Divorced",
            "Separated"});
            this.Ms.Location = new System.Drawing.Point(1, 332);
            this.Ms.Name = "Ms";
            this.Ms.Size = new System.Drawing.Size(135, 29);
            this.Ms.TabIndex = 37;
            this.Ms.UseSelectable = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(1, 310);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(88, 19);
            this.metroLabel13.TabIndex = 36;
            this.metroLabel13.Text = "Marital Status";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(1, 115);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(71, 19);
            this.metroLabel12.TabIndex = 35;
            this.metroLabel12.Text = "Last Name";
            // 
            // Lname
            // 
            // 
            // 
            // 
            this.Lname.CustomButton.Image = null;
            this.Lname.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.Lname.CustomButton.Name = "";
            this.Lname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Lname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Lname.CustomButton.TabIndex = 1;
            this.Lname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Lname.CustomButton.UseSelectable = true;
            this.Lname.CustomButton.Visible = false;
            this.Lname.Lines = new string[0];
            this.Lname.Location = new System.Drawing.Point(1, 137);
            this.Lname.MaxLength = 32767;
            this.Lname.Name = "Lname";
            this.Lname.PasswordChar = '\0';
            this.Lname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Lname.SelectedText = "";
            this.Lname.SelectionLength = 0;
            this.Lname.SelectionStart = 0;
            this.Lname.ShortcutsEnabled = true;
            this.Lname.Size = new System.Drawing.Size(188, 23);
            this.Lname.TabIndex = 34;
            this.Lname.UseSelectable = true;
            this.Lname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Mname
            // 
            // 
            // 
            // 
            this.Mname.CustomButton.Image = null;
            this.Mname.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.Mname.CustomButton.Name = "";
            this.Mname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Mname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Mname.CustomButton.TabIndex = 1;
            this.Mname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Mname.CustomButton.UseSelectable = true;
            this.Mname.CustomButton.Visible = false;
            this.Mname.Lines = new string[0];
            this.Mname.Location = new System.Drawing.Point(196, 88);
            this.Mname.MaxLength = 32767;
            this.Mname.Name = "Mname";
            this.Mname.PasswordChar = '\0';
            this.Mname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Mname.SelectedText = "";
            this.Mname.SelectionLength = 0;
            this.Mname.SelectionStart = 0;
            this.Mname.ShortcutsEnabled = true;
            this.Mname.Size = new System.Drawing.Size(123, 23);
            this.Mname.TabIndex = 33;
            this.Mname.UseSelectable = true;
            this.Mname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Mname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(196, 66);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(64, 19);
            this.metroLabel11.TabIndex = 32;
            this.metroLabel11.Text = "MI Name";
            // 
            // Age
            // 
            this.Age.BackColor = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.Age.CustomButton.Image = null;
            this.Age.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.Age.CustomButton.Name = "";
            this.Age.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Age.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Age.CustomButton.TabIndex = 1;
            this.Age.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Age.CustomButton.UseSelectable = true;
            this.Age.CustomButton.Visible = false;
            this.Age.Lines = new string[0];
            this.Age.Location = new System.Drawing.Point(174, 201);
            this.Age.MaxLength = 32767;
            this.Age.Name = "Age";
            this.Age.PasswordChar = '\0';
            this.Age.ReadOnly = true;
            this.Age.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Age.SelectedText = "";
            this.Age.SelectionLength = 0;
            this.Age.SelectionStart = 0;
            this.Age.ShortcutsEnabled = true;
            this.Age.Size = new System.Drawing.Size(64, 23);
            this.Age.TabIndex = 31;
            this.Age.UseSelectable = true;
            this.Age.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Age.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(174, 179);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(33, 19);
            this.metroLabel9.TabIndex = 30;
            this.metroLabel9.Text = "Age";
            // 
            // Religion
            // 
            this.Religion.FormattingEnabled = true;
            this.Religion.ItemHeight = 23;
            this.Religion.Location = new System.Drawing.Point(174, 265);
            this.Religion.Name = "Religion";
            this.Religion.Size = new System.Drawing.Size(145, 29);
            this.Religion.TabIndex = 29;
            this.Religion.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(174, 243);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "Religion";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.cel);
            this.metroTabPage2.Controls.Add(this.Region);
            this.metroTabPage2.Controls.Add(this.metroLabel14);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.Town);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.Street);
            this.metroTabPage2.Controls.Add(this.City);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(332, 367);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Contact Information";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // cel
            // 
            this.cel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cel.Location = new System.Drawing.Point(0, 303);
            this.cel.Mask = "0000-000-0000";
            this.cel.Name = "cel";
            this.cel.Size = new System.Drawing.Size(158, 26);
            this.cel.TabIndex = 33;
            // 
            // Region
            // 
            this.Region.FormattingEnabled = true;
            this.Region.ItemHeight = 23;
            this.Region.Location = new System.Drawing.Point(0, 233);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(326, 29);
            this.Region.TabIndex = 32;
            this.Region.UseSelectable = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(1, 211);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(50, 19);
            this.metroLabel14.TabIndex = 31;
            this.metroLabel14.Text = "Region";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(-4, 81);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(90, 19);
            this.metroLabel10.TabIndex = 30;
            this.metroLabel10.Text = "Town / Village";
            // 
            // Town
            // 
            // 
            // 
            // 
            this.Town.CustomButton.Image = null;
            this.Town.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.Town.CustomButton.Name = "";
            this.Town.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Town.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Town.CustomButton.TabIndex = 1;
            this.Town.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Town.CustomButton.UseSelectable = true;
            this.Town.CustomButton.Visible = false;
            this.Town.Lines = new string[0];
            this.Town.Location = new System.Drawing.Point(1, 103);
            this.Town.MaxLength = 32767;
            this.Town.Name = "Town";
            this.Town.PasswordChar = '\0';
            this.Town.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Town.SelectedText = "";
            this.Town.SelectionLength = 0;
            this.Town.SelectionStart = 0;
            this.Town.ShortcutsEnabled = true;
            this.Town.Size = new System.Drawing.Size(326, 29);
            this.Town.TabIndex = 29;
            this.Town.UseSelectable = true;
            this.Town.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Town.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(0, 18);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(194, 19);
            this.metroLabel8.TabIndex = 28;
            this.metroLabel8.Text = "House no / Building no / Street ";
            // 
            // Street
            // 
            // 
            // 
            // 
            this.Street.CustomButton.Image = null;
            this.Street.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.Street.CustomButton.Name = "";
            this.Street.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Street.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Street.CustomButton.TabIndex = 1;
            this.Street.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Street.CustomButton.UseSelectable = true;
            this.Street.CustomButton.Visible = false;
            this.Street.Lines = new string[0];
            this.Street.Location = new System.Drawing.Point(1, 40);
            this.Street.MaxLength = 32767;
            this.Street.Name = "Street";
            this.Street.PasswordChar = '\0';
            this.Street.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Street.SelectedText = "";
            this.Street.SelectionLength = 0;
            this.Street.SelectionStart = 0;
            this.Street.ShortcutsEnabled = true;
            this.Street.Size = new System.Drawing.Size(326, 29);
            this.Street.TabIndex = 26;
            this.Street.UseSelectable = true;
            this.Street.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Street.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // City
            // 
            this.City.FormattingEnabled = true;
            this.City.ItemHeight = 23;
            this.City.Location = new System.Drawing.Point(1, 166);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(326, 29);
            this.City.TabIndex = 24;
            this.City.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 144);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "City";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(-4, 281);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(162, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Telephone / Cellphone no:";
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(392, 102);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(396, 42);
            this.bunifuTextbox1.TabIndex = 31;
            this.bunifuTextbox1.text = "";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(17, 508);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(93, 33);
            this.bt_add.TabIndex = 33;
            this.bt_add.Text = "Add";
            this.bt_add.UseSelectable = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(137, 508);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(93, 33);
            this.bt_cancel.TabIndex = 34;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseSelectable = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(254, 508);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(93, 33);
            this.bt_delete.TabIndex = 36;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseSelectable = true;
            // 
            // errormsg
            // 
            this.errormsg.AutoSize = true;
            this.errormsg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormsg.ForeColor = System.Drawing.Color.Red;
            this.errormsg.Location = new System.Drawing.Point(17, 470);
            this.errormsg.Name = "errormsg";
            this.errormsg.Size = new System.Drawing.Size(0, 13);
            this.errormsg.TabIndex = 37;
            // 
            // userlevel
            // 
            this.userlevel.AutoSize = true;
            this.userlevel.Location = new System.Drawing.Point(590, 58);
            this.userlevel.Name = "userlevel";
            this.userlevel.Size = new System.Drawing.Size(80, 19);
            this.userlevel.TabIndex = 38;
            this.userlevel.Text = "You login as";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.userlevel);
            this.Controls.Add(this.errormsg);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox Fname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroListView metroListView1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lb_id;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroDateTime Dob;
        private MetroFramework.Controls.MetroComboBox Gender;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroComboBox Religion;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox City;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox Street;
        private MetroFramework.Controls.MetroComboBox Ms;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox Lname;
        private MetroFramework.Controls.MetroTextBox Mname;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox Age;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox Town;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private MetroFramework.Controls.MetroComboBox Region;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroButton bt_add;
        private MetroFramework.Controls.MetroButton bt_cancel;
        private MetroFramework.Controls.MetroButton bt_delete;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label errormsg;
        private MetroFramework.Controls.MetroLabel userlevel;
        private System.Windows.Forms.MaskedTextBox cel;
    }
}