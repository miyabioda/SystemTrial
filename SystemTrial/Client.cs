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
    public partial class Client : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Liza;Initial Catalog=db_Systemtrial;Integrated Security=True;Pooling=False");
        SqlDataReader dr;
        private static Client instance;

        public Client()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            loadlistview();
            loadcity();
            loadregion();
            loadreligion();
            loadgender();
            metroTabPage1.Show();
        }

        public void clearfield()
        {
            Fname.Clear();
            Mname.Clear();
            Dob.Value = DateTime.Now;
            Lname.Clear();
            Gender.Text = "";
            Religion.Text = "";
            Ms.Text = "";
            Street.Clear();
            Town.Clear();
            City.Text = "";
            Region.Text = "";
            cel.Clear();

        }

        public static Client getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new Client();
            else
                instance.BringToFront();
            return instance;
        }

        private void bt_close_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (Fname.Text != "" && Mname.Text != "" && Age.Text != "" && Gender.Text != "" && Religion.Text != ""
                && Ms.Text != "" && Street.Text != "" && Town.Text != "" && City.Text != "" && Region.Text != ""
                && cel.Text != "")
            {
                String name = Lname + "," + Fname + "," + Mname + ".";
                String address = Street + "," + Town + "," + City + "," + Region + ", Philippines";
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT Into useraccount(Name, Age, Gender, Religion, MaritalStatus, Address, Cellphone) " +
                    "values(@Name, @Age, @Gender, @Religion,@Marital Status, @Address, @Cellphone)", con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", Age.Text);
                cmd.Parameters.AddWithValue("@Gender", Gender.Text);
                cmd.Parameters.AddWithValue("@Religion", Religion.Text);
                cmd.Parameters.AddWithValue("@MaritalStatus", Ms.Text);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Cellphone", cel.Text); 
                cmd.ExecuteNonQuery();
                con.Close();
                clearfield();
                MessageBox.Show("Record Added Successfully");
            }
            else
            {
                errormsg.Text=("Please Complete all Fields");
            }
        }

        private void Fname_Enter(object sender, EventArgs e)
        {
            errormsg.Text=(" ");
        }

        private void Dob_Leave(object sender, EventArgs e)
        {
            if (Dob.Text==DateTime.Now.ToString())
            {
                Age.Text = "";
            }
            else
            {
                int age = DateTime.Today.Year - Dob.Value.Year;
                if (DateTime.Now.DayOfYear < Dob.Value.DayOfYear)
                {
                    age--;
                }
                Age.Text = age.ToString();

            }
            
        }

        private void loadlistview()
        {
            bt_delete.Hide();
            metroListView1.Items.Clear();
            try
            {
                con.Open();
                String cmdtxt = "select * from Client order by ID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["ClientID"].ToString());
                        item.SubItems.Add(dr["Name"].ToString());
                        item.SubItems.Add(dr["Age"].ToString());
                        item.SubItems.Add(dr["Gender"].ToString());
                        item.SubItems.Add(dr["Religion"].ToString());
                        item.SubItems.Add(dr["Marital Status"].ToString());
                        item.SubItems.Add(dr["Address"].ToString());
                        item.SubItems.Add(dr["Tel/Cel"].ToString());
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

        private void loadcity()
        {
            City.Items.Clear();
            City.Text = "";
            try
            {
                con.Open();
                String cmdtxt = "select * from tbl_city order by ID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    City.Items.Add(dr["City"].ToString());
                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void loadregion()
        {
            Region.Items.Clear();
            Region.Text = "";
            try
            {
                con.Open();
                String cmdtxt = "select * from tbl_region order by ID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Region.Items.Add(dr["Region"].ToString());
                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void loadreligion()
        {
            Religion.Items.Clear();
            Religion.Text = "";
            try
            {
                con.Open();
                String cmdtxt = "select * from tbl_religion order by ID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Religion.Items.Add(dr["Religion"].ToString());
                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void loadgender()
        {
            Gender.Items.Clear();
            Gender.Text = "";
            try
            {
                con.Open();
                String cmdtxt = "select * from tbl_gender order by ID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Gender.Items.Add(dr["Gender"].ToString());
                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            clearfield();
        }

        private void Gender_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
