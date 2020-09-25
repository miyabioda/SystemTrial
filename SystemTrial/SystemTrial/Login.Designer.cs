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
            this.label1 = new System.Windows.Forms.Label();
            this.username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bt_login = new MaterialSkin.Controls.MaterialFlatButton();
            this.bt_cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign in";
            // 
            // username
            // 
            this.username.Depth = 0;
            this.username.Hint = "";
            this.username.Location = new System.Drawing.Point(49, 146);
            this.username.MouseState = MaterialSkin.MouseState.HOVER;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.Size = new System.Drawing.Size(268, 23);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.UseSystemPasswordChar = false;
            this.username.Enter += new System.EventHandler(this.Username_Enter);
            this.username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "";
            this.password.Location = new System.Drawing.Point(49, 195);
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(268, 23);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.UseSystemPasswordChar = false;
            this.password.Enter += new System.EventHandler(this.Password_Enter);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            this.password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // bt_login
            // 
            this.bt_login.AutoSize = true;
            this.bt_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_login.BackColor = System.Drawing.Color.White;
            this.bt_login.Depth = 0;
            this.bt_login.Location = new System.Drawing.Point(213, 277);
            this.bt_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_login.Name = "bt_login";
            this.bt_login.Primary = false;
            this.bt_login.Size = new System.Drawing.Size(52, 36);
            this.bt_login.TabIndex = 3;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.AutoSize = true;
            this.bt_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_cancel.Depth = 0;
            this.bt_cancel.Location = new System.Drawing.Point(273, 277);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Primary = false;
            this.bt_cancel.Size = new System.Drawing.Size(64, 36);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(46, 221);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 345);
            this.ControlBox = false;
            this.Controls.Add(this.error);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField username;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialFlatButton bt_login;
        private MaterialSkin.Controls.MaterialFlatButton bt_cancel;
        private System.Windows.Forms.Label error;
    }
}

