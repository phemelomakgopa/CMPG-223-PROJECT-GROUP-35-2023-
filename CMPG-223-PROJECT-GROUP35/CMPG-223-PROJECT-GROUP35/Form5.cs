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

namespace CMPG_223_PROJECT_GROUP35
{
    public partial class FormBookings : Form
    {
        public FormBookings()
        {
            InitializeComponent();
        }
        frmLogIn connection = new frmLogIn();

        string roomPrice;
        string roomType;
        string RoomID;

 
        public void displayBookings()
        {
            try
            {
                connection.conn = new SqlConnection(connection.ConnectionString);
                connection.conn.Open();

                string sql = "SELECT * FROM Bookings";

                connection.comm = new SqlCommand(sql, connection.conn);

                connection.adap = new SqlDataAdapter();
                connection.ds = new DataSet();

                connection.adap.SelectCommand = connection.comm;
                connection.adap.Fill(connection.ds, "Bookings");

                displayCheckin.DataSource = connection.ds;
                displayCheckin.DataMember = "Bookings";

                connection.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! An Error has occured\n" + ex.Message);
            }
        }

        private void getRoomPrice(string type)
        {
            try
            {
                
                connection.conn = new SqlConnection(connection.ConnectionString);

                connection.conn.Open();

                string name = "SELECT * FROM Rooms WHERE Room_Type = '" + type + "'";
                connection.comm = new SqlCommand(name, connection.conn);
                connection.reader = connection.comm.ExecuteReader();

                while (connection.reader.Read())
                {
                    RoomID = connection.reader.GetValue(0).ToString();
                    roomPrice = connection.reader.GetValue(2).ToString();
                }


                connection.conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! An error has occured\n" + ex.Message);
            }

        
        }

        private void displayGuests(string sql)
        {
            try
            {
                connection.conn = new SqlConnection(connection.ConnectionString);
                connection.conn.Open();

                connection.comm = new SqlCommand(sql, connection.conn);

                connection.adap = new SqlDataAdapter();
                connection.ds = new DataSet();

                connection.adap.SelectCommand = connection.comm;
                connection.adap.Fill(connection.ds, "Guests");

                displayGuest.DataSource = connection.ds;
                displayGuest.DataMember = "Guests";

                connection.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! An Error has occured\n" + ex.Message);
            }
        }

        private void txtSearchGuest_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Guests WHERE Cellphone_Number LIKE'%" + txtSearchGuest.Text + "%'";

            displayGuests(sql);
        }

        private void FormBookings_Load(object sender, EventArgs e)
        {
            try
            {
                datePickerCheckIn.Format = DateTimePickerFormat.Custom;
                datePickerCheckIn.CustomFormat = "dd/MM/yyyy";

                dateTimeChckInMan.Format = DateTimePickerFormat.Custom;
                dateTimeChckInMan.CustomFormat = "dd/MM/yyyy";

                dateTimePickerChkOut.Format = DateTimePickerFormat.Custom;
                dateTimePickerChkOut.CustomFormat = "dd/MM/yyyy";

                string sql = "SELECT * FROM Guests";

                displayGuests(sql);
                displayBookings();

                comboTransaction.Items.Add("EFT");
                comboTransaction.Items.Add("CASH");

                connection.conn = new SqlConnection(connection.ConnectionString);

                connection.conn.Open();

                connection.adap = new SqlDataAdapter();
                connection.ds = new DataSet();

                string combo = "SELECT  Room_Type FROM Rooms";
                connection.comm = new SqlCommand(combo, connection.conn);
                connection.adap.SelectCommand = connection.comm;

                connection.adap.Fill(connection.ds, "Room_Type");
                cmbRoomType.DisplayMember = "Room_Type";
                cmbRoomType.ValueMember = "Room_Type";
                cmbRoomType.DataSource = connection.ds.Tables["Rooms"];

                connection.conn.Close();

                lblRecID.Text = connection.getReceptionistID().ToString();

            }
            catch(SqlException ex)
            {
                MessageBox.Show("Oops! An error has occured" + ex.Message);
            }

        }


        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbtnNow.Checked)
                {
                    datePickerCheckIn.Enabled = true;
                    txtCheckTime.Enabled = true;
                    lblDate.Enabled = true;
                    lblTime.Enabled = true;

                    txtCheckTime.Text = "";
                    dateTimeChckInMan.Text = "";

                    txtCheckOutTime.Text = "";
                    dateTimePickerChkOut.Text = "";

                    connection.conn = new SqlConnection(connection.ConnectionString);

                    connection.conn.Open();
                
                    string insert = "INSERT INTO Bookings VALUES (@guestID, @recepID, @roomId, @checkiD, @checkinT, @checkoutD, @checkoutT, @capacity)";
                    connection.comm = new SqlCommand(insert, connection.conn);

                    connection.comm.Parameters.AddWithValue("@guestID", int.Parse(txtGuestId.Text));
                    connection.comm.Parameters.AddWithValue("@recepID", int.Parse(lblRecID.Text));
                    connection.comm.Parameters.AddWithValue("@roomId", int.Parse(RoomID));

                    connection.comm.Parameters.AddWithValue("@checkiD", datePickerCheckIn.Text);
                    connection.comm.Parameters.AddWithValue("@checkinT", txtCheckTime.Text);

                    connection.comm.Parameters.AddWithValue("@checkoutD", dateTimePickerChkOut.Text);
                    connection.comm.Parameters.AddWithValue("@checkoutT", txtCheckOutTime.Text);

                    connection.comm.Parameters.AddWithValue("@capacity",(int)numericUDcap.Value);

                    connection.comm.ExecuteNonQuery();
                


                    //string sqlInsert = $"INSERT INTO Bookings Values('{txtGuestId.Text}', '{lblRecID.Text}', '{int.Parse(RoomID)}', '{datePickerCheckIn.Value.Date}', '{txtCheckTime.Text}', '{}'"


                    connection.conn.Close();

                    MessageBox.Show("A booking is succesfully confirmed.");

                }
                else if (rdbtnAnotherTime.Checked)
                {
                    datePickerCheckIn.Enabled = false;
                    txtCheckTime.Enabled = false;
                    lblDate.Enabled = false;
                    lblTime.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Choose an appointment!");
                }
            
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! There was an erorr..\n" + ex.Message);
            }
        }

        private void btnShowBookingInfo_Click(object sender, EventArgs e)
        {
            try
            {
                connection.conn = new SqlConnection(connection.ConnectionString);

                connection.conn.Open();

                string name = "SELECT * FROM Guests WHERE Guest_ID = '" + txtGuestId.Text + "'";
                connection.comm = new SqlCommand(name, connection.conn);
                connection.reader = connection.comm.ExecuteReader();

                while (connection.reader.Read())
                {
                    lstBookingInfo.Items.Add("The Following Booking Arrangements have been made: " + "\n");
                    lstBookingInfo.Items.Add("BOOKING SUCCESSFULLY MADE FOR: " + connection.reader.GetValue(1).ToString() + " " + connection.reader.GetValue(2).ToString() + "\n");
                    lstBookingInfo.Items.Add("Email Notification with all details has been sent to " + connection.reader.GetValue(3).ToString() + " and an sms to " + connection.reader.GetValue(4).ToString());
                }

                string display = "SELECT * FROM Rooms WHERE Room_ID = '" + lblRoomID.Text + "'";

                connection.comm1 = new SqlCommand(display, connection.conn);
                connection.reader1 = connection.comm.ExecuteReader();

                while (connection.reader1.Read())
                {
                  
                    lstBookingInfo.Items.Add("\nROOM TYPE" + connection.reader1.GetValue(8).ToString()+ "\t" + cmbRoomType.SelectedItem);
                    lstBookingInfo.Items.Add("ROOM PRICE: " + roomPrice);
                   
                }


                if(rdbtnNow.Checked)
                {
                    lstBookingInfo.Items.Add("CHECK IN DATE: " + datePickerCheckIn.Text);
                    lstBookingInfo.Items.Add("CHECK IN TIME AGREED ON: " + txtCheckTime.Text + "\n");
                }
                else
                {
                    lstBookingInfo.Items.Add("CHECK IN DATE: Not Yet Picked");
                    lstBookingInfo.Items.Add("CHECK IN TIME AGREED ON: Not Yet Picked" + "\n");
                }

                connection.conn.Close();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {

                connection.conn = new SqlConnection(connection.ConnectionString);

                connection.conn.Open();

                string update = "UPDATE Bookings SET CheckIn_Date = @date,CheckIn_Time = @time WHERE Booking_ID = @id";
                connection.comm = new SqlCommand(update, connection.conn);
                connection.comm.Parameters.AddWithValue("@id", txtSearchID.Text);
                connection.comm.Parameters.AddWithValue("@date", dateTimeChckInMan.Text);
                connection.comm.Parameters.AddWithValue("@time",txtCheckInTimeMan.Text);
                connection.comm.ExecuteNonQuery();
                connection.conn.Close();

                displayBookings();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckInInfo_Click(object sender, EventArgs e)
        {
            try
            {
                connection.conn = new SqlConnection(connection.ConnectionString);

                connection.conn.Open(); 

                string display = "SELECT FirstName,LastName FROM Guests";
                connection.comm = new SqlCommand(display, connection.conn);
                connection.reader = connection.comm.ExecuteReader();

                while (connection.reader.Read())
                {
                    lstCheckInInfo.Items.Add("The Following Check-in date & Time have been recorded for :"+ "\n");
                    lstCheckInInfo.Items.Add("FIRSTNAME: " + connection.reader.GetValue(1) + "\n");
                    lstCheckInInfo.Items.Add("LASTNAME: " + connection.reader.GetValue(2) + "\n");
                }
                //connection.conn.Close();

                /*if (connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
                }*/
                string checkInDetails = "SELECT CheckIn_Date,CheckIn_Time,Number_of_Guests FROM Bookings";

                connection.comm = new SqlCommand(checkInDetails, connection.conn);
                connection.reader = connection.comm.ExecuteReader();

                while (connection.reader.Read())
                {
                    lstCheckInInfo.Items.Add("Check in Date: " + connection.reader.GetValue(4).ToString() + "\n");
                    lstCheckInInfo.Items.Add("Check in Time: " + connection.reader.GetValue(5).ToString() + "\t" + cmbRoomType.SelectedItem);
                    lstCheckInInfo.Items.Add("Number of guests checked in: " + connection.reader.GetValue(8).ToString() + "\n");
                }

                connection.conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.conn = new SqlConnection(connection.ConnectionString);

                connection.conn.Open();

                string query = "SELECT * FROM Bookings WHERE Booking_ID LIKE'%" + txtSearchID.Text + "%'";
                connection.comm = new SqlCommand(query, connection.conn);
                connection.adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                connection.adap.Fill(ds, "displayBookings");
                displayGuest.DataSource = ds;
                displayGuest.DataMember = "displayBookings";
                connection.conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                connection.conn = new SqlConnection(connection.ConnectionString);

                connection.conn.Open();

                string update = "UPDATE Bookings SET CheckOut_Date = @date,CheckOut_Time = @time WHERE Booking_ID = @id";
                connection.comm = new SqlCommand(update, connection.conn);
                connection.comm.Parameters.AddWithValue("@id", txtSearch.Text);
                connection.comm.Parameters.AddWithValue("@date", dateTimePickerChkOut.Text);
                connection.comm.Parameters.AddWithValue("@time", txtCheckOutTime.Text);
                connection.comm.ExecuteNonQuery();
                connection.conn.Close();


                string transaction = "INSERT INTO Transactions VALUES(@id,@date,@method)";
                connection.comm = new SqlCommand(transaction, connection.conn);
                connection.comm.Parameters.AddWithValue("@id", txtSearch.Text);
                connection.comm.Parameters.AddWithValue("@date", dateTimePickerChkOut.Text);
                connection.comm.Parameters.AddWithValue("@method", comboTransaction.SelectedItem.ToString());
                connection.comm.ExecuteNonQuery();
                connection.conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.conn = new SqlConnection(connection.ConnectionString);

                connection.conn.Open();

                string query = "SELECT * FROM Bookings WHERE Booking_ID LIKE'%" + txtSearch.Text + "%'";
                connection.comm = new SqlCommand(query, connection.conn);
                connection.adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                connection.adap.Fill(ds, "displayBookings");
                displayGuest.DataSource = ds;
                displayGuest.DataMember = "displayBookings";
                connection.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckOutInfo_Click(object sender, EventArgs e)
        {
            try
            {
                connection.conn = new SqlConnection(connection.ConnectionString);

                connection.conn.Open();

                string display = "SELECT FirstName,LastName FROM Guests";
                connection.comm = new SqlCommand(display, connection.conn);
                connection.reader = connection.comm.ExecuteReader();

                while (connection.reader.Read())
                {
                    lstCheckInInfo.Items.Add("The Following Check-out date & Time have been recorded for :" + "\n");
                    lstCheckInInfo.Items.Add("FIRSTNAME: " + connection.reader.GetValue(1) + "\n");
                    lstCheckInInfo.Items.Add("LASTNAME: " + connection.reader.GetValue(2) + "\n");
                }


                string checkInDetails = "SELECT CheckOut_Date,CheckOut_Time,Number_of_Guests FROM Bookings";

                connection.comm = new SqlCommand(checkInDetails, connection.conn);
                connection.reader = connection.comm.ExecuteReader();

                while (connection.reader.Read())
                {
                    lstCheckInInfo.Items.Add("Check out Date: " + connection.reader.GetValue(4).ToString() + "\n");
                    lstCheckInInfo.Items.Add("Check out Time: " + connection.reader.GetValue(5).ToString() + "\t" + cmbRoomType.SelectedItem);
                    lstCheckInInfo.Items.Add("Number of guests checked out: " + connection.reader.GetValue(8).ToString() + "\n");
                }


                string transactionDetails = "SELECT Room_Price FROM Rooms";
                connection.comm = new SqlCommand(transactionDetails, connection.conn);
                connection.reader = connection.comm.ExecuteReader();

                while (connection.reader.Read())
                {
                    lstCheckInInfo.Items.Add("\n\n" +"Total Amount due for hotel stay : R "+ connection.reader.GetValue(2).ToString() + "\n");
                }


                connection.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchGuest_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoomType = cmbRoomType.SelectedItem.ToString();
            getRoomPrice(selectedRoomType);
            lblRoomID.Text = RoomID;

        }
    }
}
