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
    public partial class FileMaintenance : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Liza;Initial Catalog=db_Systemtrial;Integrated Security=True;Pooling=False");
        SqlDataReader dr;
        public static FileMaintenance instance;
        public String varidgender;
        public String varidreligion;
        public String varidcity;
        public String varidregion;

        public static FileMaintenance getInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new FileMaintenance();
            else
                instance.BringToFront();
            return instance;
        }

        public FileMaintenance()
        {
            InitializeComponent();
            loadgender();
            loadreligion();
            loadregion();
            loadcity();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void clearfield()
        {
            gender.Clear();
            region.Clear();
            city.Clear();
            religion.Clear();
            bt_genderupdate.Hide();
            bt_genderdelete.Hide();
        }


        public void loadgender()
        {
            bt_genderupdate.Hide();
            bt_genderdelete.Hide();
            genderlistview.Items.Clear();
            try
            {
                con.Open();
                String cmdtxt = "select * from tbl_gender order by ID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["Gender"].ToString());
                    genderlistview.Items.Add(item);
                    }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
    
        private void bt_genderadd_Click(object sender, EventArgs e)
        {
            if (gender.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT Into tbl_gender(Gender) values(@Gender)", con);
                cmd.Parameters.AddWithValue("@Gender", gender.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added Successfully");
                clearfield();
                loadgender();
                
            }
            else
            {
                MessageBox.Show("Blank Field");
            }
        }

        private void bt_genderdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from tbl_gender where id =" + varidgender + "", con);
                    dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    clearfield();
                    loadgender();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void genderlistview_DoubleClick(object sender, EventArgs e)
        {
            if (genderlistview.SelectedItems.Count > 0)
            {
                bt_genderupdate.Show();
                bt_genderdelete.Show();
                varidgender= genderlistview.SelectedItems[0].Text;
                ListViewItem item = genderlistview.SelectedItems[0];
                gender.Text = item.SubItems[1].Text;
            }
        }

        private void bt_genderupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update tbl_gender set Gender=@Gender where id=" + varidgender + "", con);
            cmd.Parameters.AddWithValue("@Gender", gender.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
            loadgender();
            clearfield();
        }

        
        public void loadreligion()
        {
            bt_religionupdate.Hide();
            bt_religiondelete.Hide();
            religionlistview.Items.Clear();
            try
            {
                con.Open();
                String cmdtxt = "select * from tbl_religion order by ID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["religion"].ToString());
                    religionlistview.Items.Add(item);
                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void bt_religionadd_Click(object sender, EventArgs e)
        {
            if (religion.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT Into tbl_religion(religion) values(@religion)", con);
                cmd.Parameters.AddWithValue("@religion", religion.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added Successfully");
                clearfield();
                loadreligion();
            }
            else
            {
                MessageBox.Show("Blank Field");
            }
        }

        private void bt_religondelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from tbl_religion where id =" + varidreligion + "", con);
                    dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    clearfield();
                    loadreligion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void religionlistview_DoubleClick(object sender, EventArgs e)
        {
            if (religionlistview.SelectedItems.Count > 0)
            {
                bt_religionupdate.Show();
                bt_religiondelete.Show();
                varidreligion = religionlistview.SelectedItems[0].Text;
                ListViewItem item = religionlistview.SelectedItems[0];
                religion.Text = item.SubItems[1].Text;
            }
        }

        private void bt_religionupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update tbl_religion set religion=@religion where id=" + varidreligion + "", con);
            cmd.Parameters.AddWithValue("@religion", religion.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
            loadreligion();
            clearfield();
        }


        public void loadregion()
        {
            bt_regionupdate.Hide();
            bt_regiondelete.Hide();
            regionlistview.Items.Clear();
            try
            {
                con.Open();
                String cmdtxt = "select * from tbl_region order by ID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["region"].ToString());
                    regionlistview.Items.Add(item);
                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void bt_regionadd_Click_1(object sender, EventArgs e)
        {
            if (region.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT Into tbl_region(region) values(@region)", con);
                cmd.Parameters.AddWithValue("@region", region.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added Successfully");
                clearfield();
                loadregion();
            }
            else
            {
                MessageBox.Show("Blank Field");
            }
        }

        private void bt_regiondelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from tbl_region where id =" + varidregion + "", con);
                    dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    clearfield();
                    loadregion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void regionlistview_DoubleClick_1(object sender, EventArgs e)
        {
            if (regionlistview.SelectedItems.Count > 0)
            {
                bt_regionupdate.Show();
                bt_regiondelete.Show();
                varidregion = regionlistview.SelectedItems[0].Text;
                ListViewItem item = regionlistview.SelectedItems[0];
                region.Text = item.SubItems[1].Text;
            }
        }

        private void bt_regionupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update tbl_region set region=@region where id=" + varidregion + "", con);
            cmd.Parameters.AddWithValue("@region", region.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
            loadregion();
            clearfield();
        }


        public void loadcity()
        {
            bt_cityupdate.Hide();
            bt_citydelete.Hide();
            citylistview.Items.Clear();
            try
            {
                con.Open();
                String cmdtxt = "select * from tbl_city order by ID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());
                    item.SubItems.Add(dr["city"].ToString());
                    citylistview.Items.Add(item);
                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void bt_cityaddd_Click(object sender, EventArgs e)
        {
            if (city.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT Into tbl_city(city) values(@city)", con);
                cmd.Parameters.AddWithValue("@city", city.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added Successfully");
                clearfield();
                loadcity();
            }
            else
            {
                MessageBox.Show("Blank Field");
            }
        }

        private void bt_citydelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from tbl_city where id =" + varidcity + "", con);
                    dr = cmd.ExecuteReader();
                    dr.Close();
                    con.Close();
                    clearfield();
                    loadcity();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void citylistview_DoubleClick(object sender, EventArgs e)
        {
            if (citylistview.SelectedItems.Count > 0)
            {
                bt_cityupdate.Show();
                bt_citydelete.Show();
                varidcity = citylistview.SelectedItems[0].Text;
                ListViewItem item = citylistview.SelectedItems[0];
                city.Text = item.SubItems[1].Text;
            }
        }

        private void bt_cityupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update tbl_city set city=@city where id=" + varidcity + "", con);
            cmd.Parameters.AddWithValue("@city", city.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
            loadcity();
            clearfield();
        }



        private void bt_gendercancel_Click(object sender, EventArgs e)
        {
            clearfield();
        }

        private void bt_religioncancel_Click(object sender, EventArgs e)
        {
            clearfield();
        }

        private void bt_regioncancel_Click(object sender, EventArgs e)
        {
            clearfield();
        }

        private void bt_citycancel_Click(object sender, EventArgs e)
        {
            clearfield();
        }

        
    }
}
