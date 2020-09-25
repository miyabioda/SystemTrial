namespace SystemTrial
{
    partial class FileMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileMaintenance));
            this.bt_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.bt_gendercancel = new MetroFramework.Controls.MetroButton();
            this.bt_genderdelete = new MetroFramework.Controls.MetroButton();
            this.bt_genderadd = new MetroFramework.Controls.MetroButton();
            this.gender = new MetroFramework.Controls.MetroTextBox();
            this.genderlistview = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_genderupdate = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.bt_religioncancel = new MetroFramework.Controls.MetroButton();
            this.bt_religiondelete = new MetroFramework.Controls.MetroButton();
            this.religion = new MetroFramework.Controls.MetroTextBox();
            this.religionlistview = new MetroFramework.Controls.MetroListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_religionadd = new MetroFramework.Controls.MetroButton();
            this.bt_religionupdate = new MetroFramework.Controls.MetroButton();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.bt_regioncancel = new MetroFramework.Controls.MetroButton();
            this.bt_regiondelete = new MetroFramework.Controls.MetroButton();
            this.region = new MetroFramework.Controls.MetroTextBox();
            this.regionlistview = new MetroFramework.Controls.MetroListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_regionupdate = new MetroFramework.Controls.MetroButton();
            this.bt_regionadd = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.bt_citycancel = new MetroFramework.Controls.MetroButton();
            this.bt_citydelete = new MetroFramework.Controls.MetroButton();
            this.city = new MetroFramework.Controls.MetroTextBox();
            this.citylistview = new MetroFramework.Controls.MetroListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_cityaddd = new MetroFramework.Controls.MetroButton();
            this.bt_cityupdate = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_close.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Image = ((System.Drawing.Image)(resources.GetObject("bt_close.Image")));
            this.bt_close.Location = new System.Drawing.Point(446, 5);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(36, 38);
            this.bt_close.TabIndex = 33;
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Maintenance";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.bt_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 46);
            this.panel1.TabIndex = 25;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(10, 52);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(482, 325);
            this.metroTabControl1.TabIndex = 26;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.bt_gendercancel);
            this.metroTabPage1.Controls.Add(this.bt_genderdelete);
            this.metroTabPage1.Controls.Add(this.bt_genderadd);
            this.metroTabPage1.Controls.Add(this.gender);
            this.metroTabPage1.Controls.Add(this.genderlistview);
            this.metroTabPage1.Controls.Add(this.bt_genderupdate);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(474, 283);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Gender";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // bt_gendercancel
            // 
            this.bt_gendercancel.Location = new System.Drawing.Point(396, 88);
            this.bt_gendercancel.Name = "bt_gendercancel";
            this.bt_gendercancel.Size = new System.Drawing.Size(75, 23);
            this.bt_gendercancel.TabIndex = 7;
            this.bt_gendercancel.Text = "Cancel";
            this.bt_gendercancel.UseSelectable = true;
            this.bt_gendercancel.Click += new System.EventHandler(this.bt_gendercancel_Click);
            // 
            // bt_genderdelete
            // 
            this.bt_genderdelete.Location = new System.Drawing.Point(396, 117);
            this.bt_genderdelete.Name = "bt_genderdelete";
            this.bt_genderdelete.Size = new System.Drawing.Size(75, 23);
            this.bt_genderdelete.TabIndex = 6;
            this.bt_genderdelete.Text = "Delete";
            this.bt_genderdelete.UseSelectable = true;
            this.bt_genderdelete.Click += new System.EventHandler(this.bt_genderdelete_Click);
            // 
            // bt_genderadd
            // 
            this.bt_genderadd.Location = new System.Drawing.Point(396, 59);
            this.bt_genderadd.Name = "bt_genderadd";
            this.bt_genderadd.Size = new System.Drawing.Size(75, 23);
            this.bt_genderadd.TabIndex = 5;
            this.bt_genderadd.Text = "Add";
            this.bt_genderadd.UseSelectable = true;
            this.bt_genderadd.Click += new System.EventHandler(this.bt_genderadd_Click);
            // 
            // gender
            // 
            // 
            // 
            // 
            this.gender.CustomButton.Image = null;
            this.gender.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.gender.CustomButton.Name = "";
            this.gender.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gender.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gender.CustomButton.TabIndex = 1;
            this.gender.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gender.CustomButton.UseSelectable = true;
            this.gender.CustomButton.Visible = false;
            this.gender.Lines = new string[0];
            this.gender.Location = new System.Drawing.Point(174, 30);
            this.gender.MaxLength = 32767;
            this.gender.Name = "gender";
            this.gender.PasswordChar = '\0';
            this.gender.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gender.SelectedText = "";
            this.gender.SelectionLength = 0;
            this.gender.SelectionStart = 0;
            this.gender.ShortcutsEnabled = true;
            this.gender.Size = new System.Drawing.Size(199, 23);
            this.gender.TabIndex = 4;
            this.gender.UseSelectable = true;
            this.gender.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gender.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // genderlistview
            // 
            this.genderlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.genderlistview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.genderlistview.FullRowSelect = true;
            this.genderlistview.Location = new System.Drawing.Point(3, 59);
            this.genderlistview.Name = "genderlistview";
            this.genderlistview.OwnerDraw = true;
            this.genderlistview.Size = new System.Drawing.Size(370, 221);
            this.genderlistview.TabIndex = 3;
            this.genderlistview.UseCompatibleStateImageBehavior = false;
            this.genderlistview.UseSelectable = true;
            this.genderlistview.View = System.Windows.Forms.View.Details;
            this.genderlistview.DoubleClick += new System.EventHandler(this.genderlistview_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "List";
            this.columnHeader2.Width = 200;
            // 
            // bt_genderupdate
            // 
            this.bt_genderupdate.Location = new System.Drawing.Point(396, 59);
            this.bt_genderupdate.Name = "bt_genderupdate";
            this.bt_genderupdate.Size = new System.Drawing.Size(75, 23);
            this.bt_genderupdate.TabIndex = 8;
            this.bt_genderupdate.Text = "Update";
            this.bt_genderupdate.UseSelectable = true;
            this.bt_genderupdate.Click += new System.EventHandler(this.bt_genderupdate_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.bt_religioncancel);
            this.metroTabPage2.Controls.Add(this.bt_religiondelete);
            this.metroTabPage2.Controls.Add(this.religion);
            this.metroTabPage2.Controls.Add(this.religionlistview);
            this.metroTabPage2.Controls.Add(this.bt_religionadd);
            this.metroTabPage2.Controls.Add(this.bt_religionupdate);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(474, 283);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Religion";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // bt_religioncancel
            // 
            this.bt_religioncancel.Location = new System.Drawing.Point(386, 88);
            this.bt_religioncancel.Name = "bt_religioncancel";
            this.bt_religioncancel.Size = new System.Drawing.Size(75, 23);
            this.bt_religioncancel.TabIndex = 12;
            this.bt_religioncancel.Text = "Cancel";
            this.bt_religioncancel.UseSelectable = true;
            this.bt_religioncancel.Click += new System.EventHandler(this.bt_religioncancel_Click);
            // 
            // bt_religiondelete
            // 
            this.bt_religiondelete.Location = new System.Drawing.Point(386, 117);
            this.bt_religiondelete.Name = "bt_religiondelete";
            this.bt_religiondelete.Size = new System.Drawing.Size(75, 23);
            this.bt_religiondelete.TabIndex = 11;
            this.bt_religiondelete.Text = "Delete";
            this.bt_religiondelete.UseSelectable = true;
            this.bt_religiondelete.Click += new System.EventHandler(this.bt_religondelete_Click);
            // 
            // religion
            // 
            // 
            // 
            // 
            this.religion.CustomButton.Image = null;
            this.religion.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.religion.CustomButton.Name = "";
            this.religion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.religion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.religion.CustomButton.TabIndex = 1;
            this.religion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.religion.CustomButton.UseSelectable = true;
            this.religion.CustomButton.Visible = false;
            this.religion.Lines = new string[0];
            this.religion.Location = new System.Drawing.Point(166, 30);
            this.religion.MaxLength = 32767;
            this.religion.Name = "religion";
            this.religion.PasswordChar = '\0';
            this.religion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.religion.SelectedText = "";
            this.religion.SelectionLength = 0;
            this.religion.SelectionStart = 0;
            this.religion.ShortcutsEnabled = true;
            this.religion.Size = new System.Drawing.Size(199, 23);
            this.religion.TabIndex = 9;
            this.religion.UseSelectable = true;
            this.religion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.religion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // religionlistview
            // 
            this.religionlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.religionlistview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.religionlistview.FullRowSelect = true;
            this.religionlistview.Location = new System.Drawing.Point(3, 59);
            this.religionlistview.Name = "religionlistview";
            this.religionlistview.OwnerDraw = true;
            this.religionlistview.Size = new System.Drawing.Size(362, 197);
            this.religionlistview.TabIndex = 8;
            this.religionlistview.UseCompatibleStateImageBehavior = false;
            this.religionlistview.UseSelectable = true;
            this.religionlistview.View = System.Windows.Forms.View.Details;
            this.religionlistview.DoubleClick += new System.EventHandler(this.religionlistview_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "List";
            this.columnHeader4.Width = 200;
            // 
            // bt_religionadd
            // 
            this.bt_religionadd.Location = new System.Drawing.Point(386, 59);
            this.bt_religionadd.Name = "bt_religionadd";
            this.bt_religionadd.Size = new System.Drawing.Size(75, 23);
            this.bt_religionadd.TabIndex = 10;
            this.bt_religionadd.Text = "Add";
            this.bt_religionadd.UseSelectable = true;
            this.bt_religionadd.Click += new System.EventHandler(this.bt_religionadd_Click);
            // 
            // bt_religionupdate
            // 
            this.bt_religionupdate.Location = new System.Drawing.Point(386, 59);
            this.bt_religionupdate.Name = "bt_religionupdate";
            this.bt_religionupdate.Size = new System.Drawing.Size(75, 23);
            this.bt_religionupdate.TabIndex = 13;
            this.bt_religionupdate.Text = "Update";
            this.bt_religionupdate.UseSelectable = true;
            this.bt_religionupdate.Click += new System.EventHandler(this.bt_religionupdate_Click);
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.bt_regioncancel);
            this.metroTabPage4.Controls.Add(this.bt_regiondelete);
            this.metroTabPage4.Controls.Add(this.region);
            this.metroTabPage4.Controls.Add(this.regionlistview);
            this.metroTabPage4.Controls.Add(this.bt_regionupdate);
            this.metroTabPage4.Controls.Add(this.bt_regionadd);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(474, 283);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Region";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // bt_regioncancel
            // 
            this.bt_regioncancel.Location = new System.Drawing.Point(396, 88);
            this.bt_regioncancel.Name = "bt_regioncancel";
            this.bt_regioncancel.Size = new System.Drawing.Size(75, 23);
            this.bt_regioncancel.TabIndex = 31;
            this.bt_regioncancel.Text = "Cancel";
            this.bt_regioncancel.UseSelectable = true;
            this.bt_regioncancel.Click += new System.EventHandler(this.bt_regioncancel_Click);
            // 
            // bt_regiondelete
            // 
            this.bt_regiondelete.Location = new System.Drawing.Point(396, 117);
            this.bt_regiondelete.Name = "bt_regiondelete";
            this.bt_regiondelete.Size = new System.Drawing.Size(75, 23);
            this.bt_regiondelete.TabIndex = 30;
            this.bt_regiondelete.Text = "Delete";
            this.bt_regiondelete.UseSelectable = true;
            this.bt_regiondelete.Click += new System.EventHandler(this.bt_regiondelete_Click);
            // 
            // region
            // 
            // 
            // 
            // 
            this.region.CustomButton.Image = null;
            this.region.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.region.CustomButton.Name = "";
            this.region.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.region.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.region.CustomButton.TabIndex = 1;
            this.region.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.region.CustomButton.UseSelectable = true;
            this.region.CustomButton.Visible = false;
            this.region.Lines = new string[0];
            this.region.Location = new System.Drawing.Point(167, 30);
            this.region.MaxLength = 32767;
            this.region.Name = "region";
            this.region.PasswordChar = '\0';
            this.region.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.region.SelectedText = "";
            this.region.SelectionLength = 0;
            this.region.SelectionStart = 0;
            this.region.ShortcutsEnabled = true;
            this.region.Size = new System.Drawing.Size(199, 23);
            this.region.TabIndex = 28;
            this.region.UseSelectable = true;
            this.region.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.region.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // regionlistview
            // 
            this.regionlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.regionlistview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.regionlistview.FullRowSelect = true;
            this.regionlistview.Location = new System.Drawing.Point(3, 59);
            this.regionlistview.Name = "regionlistview";
            this.regionlistview.OwnerDraw = true;
            this.regionlistview.Size = new System.Drawing.Size(363, 211);
            this.regionlistview.TabIndex = 27;
            this.regionlistview.UseCompatibleStateImageBehavior = false;
            this.regionlistview.UseSelectable = true;
            this.regionlistview.View = System.Windows.Forms.View.Details;
            this.regionlistview.DoubleClick += new System.EventHandler(this.regionlistview_DoubleClick_1);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "List";
            this.columnHeader6.Width = 200;
            // 
            // bt_regionupdate
            // 
            this.bt_regionupdate.Location = new System.Drawing.Point(396, 59);
            this.bt_regionupdate.Name = "bt_regionupdate";
            this.bt_regionupdate.Size = new System.Drawing.Size(75, 23);
            this.bt_regionupdate.TabIndex = 32;
            this.bt_regionupdate.Text = "Update";
            this.bt_regionupdate.UseSelectable = true;
            this.bt_regionupdate.Click += new System.EventHandler(this.bt_regionupdate_Click);
            // 
            // bt_regionadd
            // 
            this.bt_regionadd.Location = new System.Drawing.Point(396, 59);
            this.bt_regionadd.Name = "bt_regionadd";
            this.bt_regionadd.Size = new System.Drawing.Size(75, 23);
            this.bt_regionadd.TabIndex = 29;
            this.bt_regionadd.Text = "Add";
            this.bt_regionadd.UseSelectable = true;
            this.bt_regionadd.Click += new System.EventHandler(this.bt_regionadd_Click_1);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.bt_citycancel);
            this.metroTabPage3.Controls.Add(this.bt_citydelete);
            this.metroTabPage3.Controls.Add(this.city);
            this.metroTabPage3.Controls.Add(this.citylistview);
            this.metroTabPage3.Controls.Add(this.bt_cityaddd);
            this.metroTabPage3.Controls.Add(this.bt_cityupdate);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(474, 283);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "City";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // bt_citycancel
            // 
            this.bt_citycancel.Location = new System.Drawing.Point(403, 88);
            this.bt_citycancel.Name = "bt_citycancel";
            this.bt_citycancel.Size = new System.Drawing.Size(75, 23);
            this.bt_citycancel.TabIndex = 31;
            this.bt_citycancel.Text = "Cancel";
            this.bt_citycancel.UseSelectable = true;
            this.bt_citycancel.Click += new System.EventHandler(this.bt_citycancel_Click);
            // 
            // bt_citydelete
            // 
            this.bt_citydelete.Location = new System.Drawing.Point(403, 117);
            this.bt_citydelete.Name = "bt_citydelete";
            this.bt_citydelete.Size = new System.Drawing.Size(75, 23);
            this.bt_citydelete.TabIndex = 30;
            this.bt_citydelete.Text = "Delete";
            this.bt_citydelete.UseSelectable = true;
            this.bt_citydelete.Click += new System.EventHandler(this.bt_citydelete_Click);
            // 
            // city
            // 
            // 
            // 
            // 
            this.city.CustomButton.Image = null;
            this.city.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.city.CustomButton.Name = "";
            this.city.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.city.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.city.CustomButton.TabIndex = 1;
            this.city.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.city.CustomButton.UseSelectable = true;
            this.city.CustomButton.Visible = false;
            this.city.Lines = new string[0];
            this.city.Location = new System.Drawing.Point(176, 30);
            this.city.MaxLength = 32767;
            this.city.Name = "city";
            this.city.PasswordChar = '\0';
            this.city.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.city.SelectedText = "";
            this.city.SelectionLength = 0;
            this.city.SelectionStart = 0;
            this.city.ShortcutsEnabled = true;
            this.city.Size = new System.Drawing.Size(199, 23);
            this.city.TabIndex = 28;
            this.city.UseSelectable = true;
            this.city.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.city.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // citylistview
            // 
            this.citylistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.citylistview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.citylistview.FullRowSelect = true;
            this.citylistview.Location = new System.Drawing.Point(3, 59);
            this.citylistview.Name = "citylistview";
            this.citylistview.OwnerDraw = true;
            this.citylistview.Size = new System.Drawing.Size(372, 201);
            this.citylistview.TabIndex = 27;
            this.citylistview.UseCompatibleStateImageBehavior = false;
            this.citylistview.UseSelectable = true;
            this.citylistview.View = System.Windows.Forms.View.Details;
            this.citylistview.DoubleClick += new System.EventHandler(this.citylistview_DoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "No";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "List";
            this.columnHeader8.Width = 200;
            // 
            // bt_cityaddd
            // 
            this.bt_cityaddd.Location = new System.Drawing.Point(403, 59);
            this.bt_cityaddd.Name = "bt_cityaddd";
            this.bt_cityaddd.Size = new System.Drawing.Size(75, 23);
            this.bt_cityaddd.TabIndex = 29;
            this.bt_cityaddd.Text = "Add";
            this.bt_cityaddd.UseSelectable = true;
            this.bt_cityaddd.Click += new System.EventHandler(this.bt_cityaddd_Click);
            // 
            // bt_cityupdate
            // 
            this.bt_cityupdate.Location = new System.Drawing.Point(403, 59);
            this.bt_cityupdate.Name = "bt_cityupdate";
            this.bt_cityupdate.Size = new System.Drawing.Size(75, 23);
            this.bt_cityupdate.TabIndex = 32;
            this.bt_cityupdate.Text = "Update";
            this.bt_cityupdate.UseSelectable = true;
            this.bt_cityupdate.Click += new System.EventHandler(this.bt_cityupdate_Click);
            // 
            // FileMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 414);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroButton bt_gendercancel;
        private MetroFramework.Controls.MetroButton bt_genderdelete;
        private MetroFramework.Controls.MetroButton bt_genderadd;
        private MetroFramework.Controls.MetroTextBox gender;
        private MetroFramework.Controls.MetroListView genderlistview;
        private MetroFramework.Controls.MetroButton bt_religioncancel;
        private MetroFramework.Controls.MetroButton bt_religiondelete;
        private MetroFramework.Controls.MetroTextBox religion;
        private MetroFramework.Controls.MetroListView religionlistview;
        private MetroFramework.Controls.MetroButton bt_religionadd;
        private MetroFramework.Controls.MetroButton bt_regioncancel;
        private MetroFramework.Controls.MetroButton bt_regiondelete;
        private MetroFramework.Controls.MetroButton bt_regionadd;
        private MetroFramework.Controls.MetroTextBox region;
        private MetroFramework.Controls.MetroListView regionlistview;
        private MetroFramework.Controls.MetroButton bt_citycancel;
        private MetroFramework.Controls.MetroButton bt_citydelete;
        private MetroFramework.Controls.MetroButton bt_cityaddd;
        private MetroFramework.Controls.MetroTextBox city;
        private MetroFramework.Controls.MetroListView citylistview;
        private MetroFramework.Controls.MetroButton bt_genderupdate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MetroFramework.Controls.MetroButton bt_religionupdate;
        private MetroFramework.Controls.MetroButton bt_regionupdate;
        private MetroFramework.Controls.MetroButton bt_cityupdate;
    }
}