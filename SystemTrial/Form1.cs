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
using System.Globalization;

namespace SystemTrial
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Liza;Initial Catalog=db_Systemtrial;Integrated Security=True;Pooling=False");
        SqlDataReader dr;
        String identity;
        String checkin;
        String dc;
        Decimal rrate;
        String status1="Occupied";
        String status2 = "Vacant";
        String status3 = "Check-out";
        String vartransid=String.Empty;
        String varroomno = String.Empty;


        public Form1()
        {
            InitializeComponent();
            hide();
            load();
        }

        public void load()
        {
            loadgender();
            loadcity();
            loadclientview();
            loadcheckin();
            loaddc();
            loadtransac();
        }

        public void hide()
        {
            search_customer.Hide();
            customerlistview.Hide();
            delete.Hide();
            cancel.Hide();
        }

        public void clear()
        {
            custID.Text = "C0000";
            fname.Clear();
            lname.Clear();
            number.Clear();
            email.Clear();
            street.Clear();
            town.Clear();
            city.SelectedItem=null;
            tFname.Clear();
            tLname.Clear();
            customerid.Text = "C0000";
            guestno.SelectedItem = null;
            roomtype.SelectedItem = null;
            roomno.SelectedItem = null;
            roomrate.Clear();
            nodays.Clear(); 
            discount.SelectedItem = null;
            dcrate.Clear();
            ttl.Clear();
            payment.Clear();
            change.Text = "Php";
            transacID.Text = "000000000";
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void save_cust_Click(object sender, EventArgs e)
        {
            if (fname.Text != "" || lname.Text != "" ||  number.Text != ""|| email.Text != "" || street.Text != "" || (town.Text == "" || city.Text != "") ||
                (town.Text != "" || city.Text == ""))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT Into customer(Fname, Lname,  Gender, Number, Email, Street, Town, City) " +
                    "values(@Fname, @Lname, @Gender, @Number, @Email, @Street, @Town, @City)", con);
                cmd.Parameters.AddWithValue("@Fname", fname.Text);
                cmd.Parameters.AddWithValue("@Lname", lname.Text);
                cmd.Parameters.AddWithValue("@Gender", gender.Text);
                cmd.Parameters.AddWithValue("@Number", number.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@Street", street.Text);
                cmd.Parameters.AddWithValue("@Town", town.Text);
                cmd.Parameters.AddWithValue("@City", city.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Added Successfully");
                load();
                clear();
            }
            else
            {
                MessageBox.Show("Please Complete All Fields");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            customerlistview.Show();
            search_customer.Show();
            delete.Show();
            cancel.Show();
        }

        public void loadclientview()
        {
            try
            {
                con.Open();
                String cmdtxt = "select * from customer order by ID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["CustomerID"].ToString());
                        item.SubItems.Add(dr["Fname"].ToString());
                        item.SubItems.Add(dr["Lname"].ToString());
                        item.SubItems.Add(dr["Gender"].ToString());
                        item.SubItems.Add(dr["Number"].ToString());
                        item.SubItems.Add(dr["Email"].ToString());
                        item.SubItems.Add(dr["Street"].ToString());
                        item.SubItems.Add(dr["Town"].ToString());
                        item.SubItems.Add(dr["City"].ToString());
                        customerlistview.Items.Add(item);
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

        private void clientlistview_DoubleClick(object sender, EventArgs e)
        {
            identity = customerlistview.SelectedItems[0].Text;
            ListViewItem item = customerlistview.SelectedItems[0];
            custID.Text = item.SubItems[0].Text;
            fname.Text = item.SubItems[1].Text;
            lname.Text = item.SubItems[2].Text;
            gender.Text = item.SubItems[3].Text;
            number.Text = item.SubItems[4].Text;
            email.Text = item.SubItems[5].Text;
            street.Text = item.SubItems[6].Text;
            town.Text = item.SubItems[7].Text;
            city.Text = item.SubItems[8].Text;
        }

        private void loadgender()
        {
            gender.Items.Clear();
            gender.Text = "";
            try
            {
                con.Open();
                String cmdtxt = "select * from gender order by Id";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    gender.Items.Add(dr["Gender"].ToString());
                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                con.Close();
            }
        }

        private void loadcity()
        {
            city.Items.Clear();
            city.Text = "";
            try
            {
                con.Open();
                String cmdtxt = "select * from city order by Id";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    city.Items.Add(dr["City"].ToString());
                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                con.Close();
            }
        }

        public void loadcheckin()
        {
            checkinlistview.Items.Clear();
            try
            {
                con.Open();
                String cmdtxt = "select * from customer order by ID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["CustomerID"].ToString());
                        item.SubItems.Add(dr["Fname"].ToString());
                        item.SubItems.Add(dr["Lname"].ToString());
                        checkinlistview.Items.Add(item);
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
        
        private void checkinlistview_DoubleClick(object sender, EventArgs e)
        {
            checkin = checkinlistview.SelectedItems[0].Text;
            ListViewItem item = checkinlistview.SelectedItems[0];
            customerid.Text = item.SubItems[0].Text;
            tFname.Text = item.SubItems[1].Text;
            tLname.Text = item.SubItems[2].Text;
            loadguess();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            clear();
            hide();
        }

        private void search_customer_TextChanged(object sender, EventArgs e)
        {
            customerlistview.Items.Clear();
            try
            {
                con.Open();
                String cmdtxt = "select * from customer where CustomerID like '%" + search_customer.Text + "%' or Fname like '%" + search_customer.Text +
                    "%' or LName like '%" + search_customer.Text + "%'";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["CustomerID"].ToString());
                        item.SubItems.Add(dr["Fname"].ToString());
                        item.SubItems.Add(dr["Lname"].ToString());
                        item.SubItems.Add(dr["Gender"].ToString());
                        item.SubItems.Add(dr["Number"].ToString());
                        item.SubItems.Add(dr["Email"].ToString());
                        item.SubItems.Add(dr["Street"].ToString());
                        item.SubItems.Add(dr["Town"].ToString());
                        item.SubItems.Add(dr["City"].ToString());
                        customerlistview.Items.Add(item);
                    }
                }
                dr.Close();
                con.Close();

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message.ToString());
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all fields?", "Clear", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clear();
                hide();
            }
        }

        public void loadguess()
        {
            guestno.Items.Clear();
            guestno.Text = "";
            try
            {
                con.Open();
                String cmdtxt = "select distinct GuestNo from hotelroom ";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    guestno.Items.Add(dr["GuestNo"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                con.Close();
            }
        }

        public void loadroomprice()
        {
            try
            {
                con.Open();
                String cmdtxt = "select distinct Prize from hotelroom where RoomNo ='" + roomno.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    roomrate.Text=(dr["Floor"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                con.Close();
            }
        }

        private void guestno_TextChanged(object sender, EventArgs e)
        {
            roomtype.Items.Clear();
            roomtype.Text = "";
            try
            {
                con.Open();
                String cmdtxt = "select distinct RoomType from hotelroom where GuestNo ='" + guestno.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    roomtype.Items.Add(dr["RoomType"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message.ToString());
                con.Close();
            }
        }

        private void roomtype_TextChanged(object sender, EventArgs e)
        {
            roomno.Items.Clear();
            roomno.Text = "";
            try
            {
                con.Open();
                String cmdtxt = "select distinct RoomNo from hotelroom where RoomType ='" + roomtype.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    roomno.Items.Add(dr["RoomNo"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message.ToString());
                con.Close();
            }
        }

        public void loaddc()
        {
            discount.Items.Clear();
            discount.Text = "";
            try
            {
                con.Open();
                String cmdtxt = "select * from discount order by Id";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    discount.Items.Add(dr["DiscountType"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message.ToString());
                con.Close();
            }
        }

        private void discount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String cmdtxt = "select DiscountRate from discount where DiscountType='"+discount+"'";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dc = dr["DiscountType"].ToString();
                }
                dr.Close();
                con.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message.ToString());
                con.Close();
            }
        }

        private void roomno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String cmdtxt = "select Prize from hotelroom where RoomType ='" + roomtype.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    roomrate.Text = dr["Prize"].ToString();
                }
                dr.Close();
                con.Close();
                transacID.Text=""+DateTime.Today.ToString("yyyyMMdd") + DateTime.Now.ToString("HHmmss");
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message.ToString());
                con.Close();
            }
        }

        private void discount_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String cmdtxt = "select DiscountRate from discount where DiscountType='" + discount.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dcrate.Text =(dr["DiscountRate"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message.ToString());
                con.Close();
            }
            Decimal price = Decimal.Parse(roomrate.Text);
            Decimal days = Decimal.Parse(nodays.Text);
            Decimal rate = Decimal.Parse(dcrate.Text);

            Decimal deposit = 500;
            Decimal total = (price * days) - ((price * days) * (rate / 100))+deposit;
            ttl.Text = total.ToString();
            rrate = rate;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (payment.Text != "")
            {
                Decimal chng = Decimal.Parse(payment.Text) - Decimal.Parse(ttl.Text); ;
                if (chng < 0)
                {
                    MessageBox.Show("Invalid Amount!");
                    payment.Text = "";
                }
                else
                {
                    change.Text = chng.ToString();
                    Submit.Show();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Payment");
            }
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string status = String.Empty;
            if (rb_check.Checked == true)
            {
                status = "Check-In";
            }
            else if (rb_res.Checked == true)
            {
                status = "Reserved";
            }

            if (tFname.Text != "" || tLname.Text != "" || guestno.Text != "" || roomtype.Text != "" || roomno.Text != "" ||
                nodays.Text != "" || guestno.Text != "" || discount.Text!="" || payment.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT Into transac(TransactionID, CustomerID,  Fname, Lname, gueststatus, EntryDate, RoomType, RoomNo, DaysNo, DiscountType, Total, Payment, change) " +
                    "values(@TransactionID, @CustomerID,  @Fname, @Lname, @gueststatus, @EntryDate, @RoomType, @RoomNo, @DaysNo, @DiscountType, @Total, @Payment, @change)", con);
                cmd.Parameters.AddWithValue("@TransactionID", transacID.Text);
                cmd.Parameters.AddWithValue("@CustomerID", customerid.Text);
                cmd.Parameters.AddWithValue("@Fname", tFname.Text);
                cmd.Parameters.AddWithValue("@Lname", tLname.Text);
                cmd.Parameters.AddWithValue("@gueststatus", status);
                cmd.Parameters.AddWithValue("@EntryDate", entrydate.Text);
                cmd.Parameters.AddWithValue("@RoomType", roomtype.Text);
                cmd.Parameters.AddWithValue("@RoomType", roomno.Text);
                cmd.Parameters.AddWithValue("@DaysNo", nodays.Text);
                cmd.Parameters.AddWithValue("@DiscountType", discount.Text);
                cmd.Parameters.AddWithValue("@Total", ttl.Text);
                cmd.Parameters.AddWithValue("@Payment", payment.Text);
                cmd.Parameters.AddWithValue("@Change", change.Text);
                cmd.ExecuteNonQuery();

                string query = "Update hotelroom set Status=@stats where RoomNo='"+roomno.Text+"'";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@stats", status1);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Record Added Successfully");
                load();
                clear();
            }
            else
            {
                MessageBox.Show("Please Complete All Fields");
            }
        }

        public void loadtransac()
        {
            transaclistview.Items.Clear();
            try
            {
                con.Open();
                String cmdtxt = "select * from transac order by TransactionID";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["TransactionID"].ToString());
                        item.SubItems.Add(dr["CustomerID"].ToString());
                        item.SubItems.Add(dr["Fname"].ToString());
                        item.SubItems.Add(dr["Lname"].ToString());
                        item.SubItems.Add(dr["gueststatus"].ToString());
                        item.SubItems.Add(dr["EntryDate"].ToString());
                        item.SubItems.Add(dr["RoomType"].ToString());
                        item.SubItems.Add(dr["DaysNo"].ToString());
                        item.SubItems.Add(dr["DiscountType"].ToString());
                        item.SubItems.Add(dr["Total"].ToString());
                        item.SubItems.Add(dr["Payment"].ToString());
                        item.SubItems.Add(dr["change"].ToString());
                        transaclistview.Items.Add(item);
                    }
                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                con.Close();
            }
        }

        private void transacsearch_TextChanged(object sender, EventArgs e)
        {
            transaclistview.Items.Clear();
            try
            {
                con.Open();
                String cmdtxt = "select * from transac where " +
                    "TransactionID like '%" + transacsearch.Text + 
                    "%' or Fname like '%" + transacsearch.Text +
                    "%' or LName like '%" + transacsearch.Text + 
                    "%' or CustomerID like '%" + transacsearch.Text + "%'";
                SqlCommand cmd = new SqlCommand(cmdtxt, con);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["TransactionID"].ToString());
                        item.SubItems.Add(dr["CustomerID"].ToString());
                        item.SubItems.Add(dr["Fname"].ToString());
                        item.SubItems.Add(dr["Lname"].ToString());
                        item.SubItems.Add(dr["gueststatus"].ToString());
                        item.SubItems.Add(dr["EntryDate"].ToString());
                        item.SubItems.Add(dr["RoomType"].ToString());
                        item.SubItems.Add(dr["RoomNo"].ToString());
                        item.SubItems.Add(dr["DaysNo"].ToString());
                        item.SubItems.Add(dr["DiscounType"].ToString());
                        item.SubItems.Add(dr["Total"].ToString());
                        item.SubItems.Add(dr["Payment"].ToString());
                        item.SubItems.Add(dr["change"].ToString());
                        transaclistview.Items.Add(item);
                    }
                }
                dr.Close();
                con.Close();

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message.ToString());
                con.Close();
            }
        }

        private void transaclistview_SelectedIndexChanged(object sender, EventArgs e)
        {
            vartransid = this.transaclistview.SelectedItems[0].Text;
            varroomno = this.transaclistview.SelectedItems[7].Text;
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            if (vartransid != String.Empty || varroomno!=String.Empty)
            {
                try
                {
                    con.Open();
                    string query = "Update transac set queststatus=@stats where TransactionID='" + vartransid + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@stats", status3);
                    cmd.ExecuteNonQuery();
                    String query2 = "Update hotelroom set Status=@stats where RoomNo='" + varroomno + "'";
                    con.Close();
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message.ToString());
                    con.Close();
                }
            }
        }
    }
}
