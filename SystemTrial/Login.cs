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
        
        DataTable dt = new DataTable();
        public string type;
        Thread admin;
        Thread user;
        static int attempt = 3;

        public Login()
        {
            InitializeComponent();
        }

        private void openAdmin()
        {
            Application.Run(new Admin());
        }

        private void openForm1()
        {
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void username_Enter_1(object sender, EventArgs e)
        {
            error.Text = "";
            if (username.Text == "Username")
            {
                username.Text = "";
            }
        }

        private void username_Leave_1(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = "";
            }
        }

        private void password_Enter_1(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password";
            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "" && username.Text != "Username" && password.Text != "Password")
            {
                if (attempt == 0)
                {
                    MessageBox.Show("ALL 3 ATTEMPTS HAVE FAILED - CONTACT ADMIN or TECH SUPPORT");
                    Dispose();
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select Type from useraccount where Username = '" + username.Text + "' and Password = '" + password.Text + "'", con);
                    con.Open();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        error.Text = "";
                        type = dt.Rows[0][0].ToString().Trim();
                        if (type == "Admin")
                        {
                            MessageBox.Show("Login sucessfully \nWelcome " + type + "!");
                            this.Close();
                            admin = new Thread(openAdmin);
                            admin.Start();
                        }
                        else
                        {
                            MessageBox.Show("Login sucessfully \nWelcome " + type + "!");
                            this.Close();
                            user = new Thread(openForm1);
                            user.Start();
                        }
                        
                    }
                    else
                    {
                        error.Text = ("Incorrect LOGIN! \nYou have only " + Convert.ToString(attempt) + " attempt left to try");
                        --attempt;
                        username.Text = "Username";
                        password.Text = "Password";
                        con.Close();
                    }
                }
            }
            else
            {
                error.Text = ("You haven't entered username or password!");
            }
        }
    }
}
