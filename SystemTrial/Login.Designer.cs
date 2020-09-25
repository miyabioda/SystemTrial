namespace SystemTrial
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.bt_close = new MaterialSkin.Controls.MaterialFlatButton();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bt_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(71)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(44, 297);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 5;
            // 
            // bt_close
            // 
            this.bt_close.AutoSize = true;
            this.bt_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_close.Depth = 0;
            this.bt_close.Location = new System.Drawing.Point(0, 0);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_close.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_close.Name = "bt_close";
            this.bt_close.Primary = false;
            this.bt_close.Size = new System.Drawing.Size(8, 36);
            this.bt_close.TabIndex = 35;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(307, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 36);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username.HintForeColor = System.Drawing.Color.Empty;
            this.username.HintText = "";
            this.username.isPassword = false;
            this.username.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.username.LineIdleColor = System.Drawing.Color.Gray;
            this.username.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.username.LineThickness = 3;
            this.username.Location = new System.Drawing.Point(34, 197);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(268, 44);
            this.username.TabIndex = 38;
            this.username.Text = "Username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.Enter += new System.EventHandler(this.username_Enter_1);
            this.username.Leave += new System.EventHandler(this.username_Leave_1);
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.LightGreen;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(34, 249);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(268, 44);
            this.password.TabIndex = 39;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.Enter += new System.EventHandler(this.password_Enter_1);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // bt_login
            // 
            this.bt_login.ActiveBorderThickness = 1;
            this.bt_login.ActiveCornerRadius = 20;
            this.bt_login.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.bt_login.ActiveForecolor = System.Drawing.Color.White;
            this.bt_login.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.bt_login.BackColor = System.Drawing.SystemColors.Control;
            this.bt_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_login.BackgroundImage")));
            this.bt_login.ButtonText = "Login";
            this.bt_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.Gray;
            this.bt_login.IdleBorderThickness = 1;
            this.bt_login.IdleCornerRadius = 20;
            this.bt_login.IdleFillColor = System.Drawing.Color.White;
            this.bt_login.IdleForecolor = System.Drawing.Color.Teal;
            this.bt_login.IdleLineColor = System.Drawing.Color.Teal;
            this.bt_login.Location = new System.Drawing.Point(179, 315);
            this.bt_login.Margin = new System.Windows.Forms.Padding(5);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(123, 41);
            this.bt_login.TabIndex = 40;
            this.bt_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(71)))), ((int)(((byte)(122)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 11);
            this.panel1.TabIndex = 44;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 408);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

         }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error;
        private MaterialSkin.Controls.MaterialFlatButton bt_close;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuThinButton2 bt_login;
        private System.Windows.Forms.Panel panel1;
    }
}

