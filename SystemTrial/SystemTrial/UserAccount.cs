using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SystemTrial
{
    public partial class UserAccount : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Liza;Initial Catalog=db_Systemtrial;Integrated Security=True;Pooling=False");
        SqlDataReader dr;

        private static UserAccount instance;
        public string varid;
        public static UserAccount getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new UserAccount();
            else
                instance.BringToFront();
            return instance;
        }

        public UserAccount()
        {
            InitializeComponent();
            bt_update.Hide();
            loadlistview();
            username.Focus();
        }

        private void ClearField()
        {
            username.Clear();
            password.Clear();
            confirmpwd.Clear();
            bt_update.Hide();
        }

        public void loadlistview()
        {
            metroListView1.Items.Clear();
            try
            {
                con.Open();
                String cmdtxt = "select * from user_login order by ID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["Id"].ToString());
                        item.SubItems.Add(dr["Username"].ToString());
                        item.SubItems.Add(dr["Password"].ToString());
                        metroListView1.Items.Add(item);
                    }
                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void confirmpwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_add.PerformClick();
            }
        }
              
        private void bt_add_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "" && confirmpwd.Text != "")
            {
                if (password.Text == confirmpwd.Text)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT Into user_login(Username, Password) values(@Username, @Password)", con);
                    cmd.Parameters.AddWithValue("@Username", username.Text);
                    cmd.Parameters.AddWithValue("@Password", password.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ClearField();
                    loadlistview();
                    MessageBox.Show("Record Added Successfully");
                }
                else
                {
                    error.Text = "password and confirm password do not match";
                    password.Clear();
                    confirmpwd.Clear();
                    password.Focus();
                }
            }
            else
            {
                error.Text = "Please complete all fields";
                username.Focus();
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update user_login set Username=@Username,Password=@Password where Id="+varid+"", con);
            cmd.Parameters.AddWithValue("@Username", username.Text);
            cmd.Parameters.AddWithValue("@Password", password.Text);
            cmd.ExecuteNonQuery();
            ClearField();
            con.Close();
            loadlistview();
            MessageBox.Show("Record Updated Successfully");
        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_update.Show();
            if (metroListView1.SelectedItems.Count > 0)
            {
                varid = metroListView1.SelectedItems[0].Text;
                ListViewItem item = metroListView1.SelectedItems[0];
                username.Text = item.SubItems[1].Text;
                password.Text = item.SubItems[2].Text;
            }
        }

        private void metroListView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from user_login where id =" + varid + "", con);
                    dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    loadlistview();
                    ClearField();
                }
                else
                    //dr.Close();
                    //con.Close();
                    loadlistview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
                
    }
}
