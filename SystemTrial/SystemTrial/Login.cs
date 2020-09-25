using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace SystemTrial
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Liza;Initial Catalog=db_Systemtrial;Integrated Security=True;Pooling=False");
        Thread th;
        static int attempt = 3;

        public Login()
        {
            InitializeComponent();
        }

        private void openmainform()
        {
            Application.Run(new Main());

        }

        private void Username_Enter(object sender, EventArgs e)
        {
            error.Text = "";
            if (username.Text == "Username")
            {
                username.Text = "";
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = "";
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.UseSystemPasswordChar = true;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_login.PerformClick();
            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "" && username.Text!="Username" && password.Text!="Password")
            {
                if (attempt == 0)
                {
                    MessageBox.Show("ALL 3 ATTEMPTS HAVE FAILED - CONTACT ADMIN");
                    Dispose();
                }

                else
                {
                    String cmdtxt = "select count (*) as cnt from user_login where username=@Username and password=@Password";
                    SqlCommand cmd = new SqlCommand(cmdtxt, con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Username", username.Text);
                    cmd.Parameters.AddWithValue("@Password", password.Text);
                    con.Open();

                    if (cmd.ExecuteScalar().ToString() == "1")
                    {
                        MessageBox.Show("Login sucessfully!");
                        this.Close();
                        th = new Thread(openmainform);
                        th.Start();
                    }

                    else
                    {
                        error.Text=("Incorrect Username or Password! \nYou have only " + Convert.ToString(attempt) + " attempt left to try");
                        --attempt;
                        username.Text="Username";
                        password.UseSystemPasswordChar = false;
                        password.Text = "Password";
                        username.Focus();
                    }
                    con.Close();
                }
            }
            else
            {
               error.Text=("You haven't entered username or password!");
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
    }
}
