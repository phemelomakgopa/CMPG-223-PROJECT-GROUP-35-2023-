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
        
        private void txtSearchGuest_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
                }
                string search = "SELECT * FROM Guests WHERE Cellphone_Number LIKE'%" + txtSearchGuest.Text + "%'";
                connection.comm = new SqlCommand(search, connection.conn);
                connection.adap = new SqlDataAdapter();
                DataSet ds = new DataSet();
                connection.adap.Fill(ds, "searchG");
                displayGuest.DataSource = ds;
                displayGuest.DataMember = "searchG";

                connection.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormBookings_Load(object sender, EventArgs e)
        {
            comboTransaction.Items.Add("EFT");
            comboTransaction.Items.Add("CASH");

            if (connection.conn.State == ConnectionState.Closed)
            {
                connection.conn.Open();
            }

            string combo = "SELECT DISTINCT RoomType FROM Bookings";
            connection.comm = new SqlCommand(combo, connection.conn);
            DataSet ds = new DataSet();
            connection.adap = new SqlDataAdapter();
            connection.adap.Fill(ds, "Rooms");
            cmbRoomType.DisplayMember = "Room_Type";
            cmbRoomType.ValueMember = "Room_Type";
            cmbRoomType.DataSource = ds.Tables["Rooms"];
            connection.conn.Close();

            lstBookingInfo.Items.Clear();
            monthCalendar.SelectionStart = DateTime.Today;
            numericUDcap.Maximum = 6;

        }


        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbtnNow.Checked)
                {
                    gbBookDateTime.Enabled = false;
                    tabControl1.SelectedTab = tabPage2;
                }

                else if (rdbtnAnotherTime.Checked)
                {
                    gbBookDateTime.Enabled = true;
                    if (connection.conn.State == ConnectionState.Closed)
                    {
                        connection.conn.Open();
                    }
                    string insert = "INSERT INTO Bookings VALUES (@guestID, @recepID, @roomId,@checkiD,@checkinT,@checkoutD,@checkoutT,@capacity)";
                    connection.comm = new SqlCommand(insert, connection.conn);
                    connection.comm.Parameters.AddWithValue("@guestID", int.Parse(txtGuestId.Text));
                    connection.comm.Parameters.AddWithValue("@recepID", int.Parse(txtRecep.Text));
                    connection.comm.Parameters.AddWithValue("@roomId", int.Parse(txtRoomID.Text));
                    connection.comm.Parameters.AddWithValue("@checkiD",monthCalendar.MinDate);
                    connection.comm.Parameters.AddWithValue("@checkinT", txtCheckTime.Text);
                    connection.comm.Parameters.AddWithValue("@checkoutD", monthCalendar.MaxDate);
                    connection.comm.Parameters.AddWithValue("@checkoutT", txtCheckTime.Text);
                    connection.comm.Parameters.AddWithValue("@capacity", numericUDcap.Value);

                    connection.comm.ExecuteNonQuery();

                    connection.conn.Close();

                }
                else
                {
                    MessageBox.Show("Choose an appointment");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowBookingInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
                }
                string name = "SELECT * FROM Guests";
                connection.comm = new SqlCommand(name, connection.conn);
                connection.reader = connection.comm.ExecuteReader();

                while (connection.reader.Read())
                {
                    lstBookingInfo.Items.Add("The Following Booking Arrangements have been made: " + "\n");
                    lstBookingInfo.Items.Add("BOOKING SUCCESSFULLY MADE FOR: " + connection.reader.GetValue(1) + "\t" + " last name: " + connection.reader.GetValue(2) + "\n");
                    lstBookingInfo.Items.Add("Email Notification with all details has been sent to " + connection.reader.GetValue(3) + "\t" + " an sms to " + connection.reader.GetValue(4));
                }
                connection.conn.Close();

                if (connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
                }
                string display = "SELECT * FROM Bookings";

                connection.comm = new SqlCommand(display, connection.conn);
                connection.reader = connection.comm.ExecuteReader();

                while (connection.reader.Read())
                {
                    lstBookingInfo.Items.Add("\n" + "BOOKING ID: " + connection.reader.GetValue(0).ToString() + "\n");
                    lstBookingInfo.Items.Add("GUEST ID: " + connection.reader.GetValue(1).ToString() + "\n");
                    lstBookingInfo.Items.Add("GUEST CAPACITY & ROOM TYPE" + connection.reader.GetValue(8).ToString()+ "\t" + cmbRoomType.SelectedItem);
                    lstBookingInfo.Items.Add("CHECK IN DATE: " + connection.reader.GetValue(4).ToString());
                    lstBookingInfo.Items.Add("CHECK IN TIME AGREED ON: " + connection.reader.GetValue(5).ToString()+ "\n");
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
                if(connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
                }

                string update = "UPDATE Bookings SET CheckIn_Date = @date,CheckIn_Time = @time WHERE Booking_ID = @id";
                connection.comm = new SqlCommand(update, connection.conn);
                connection.comm.Parameters.AddWithValue("@id", txtSearchID.Text);
                connection.comm.Parameters.AddWithValue("@date",calendarBooking.SelectionStart);
                connection.comm.Parameters.AddWithValue("@time",txtCheckInTime.Text);
                connection.comm.ExecuteNonQuery();
                connection.conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckInInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if(connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
                }

                string display = "SELECT FirstName,LastName FROM Guests";
                connection.comm = new SqlCommand(display, connection.conn);
                connection.reader = connection.comm.ExecuteReader();

                while (connection.reader.Read())
                {
                    lstCheckInInfo.Items.Add("The Following Check-in date & Time have been recorded for :"+ "\n");
                    lstCheckInInfo.Items.Add("FIRSTNAME: " + connection.reader.GetValue(1) + "\n");
                    lstCheckInInfo.Items.Add("LASTNAME: " + connection.reader.GetValue(2) + "\n");
                }
                connection.conn.Close();

                if (connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
                }
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
                if (connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
                }
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
                if (connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
                }
                string update = "UPDATE Bookings SET CheckOut_Date = @date,CheckOut_Time = @time WHERE Booking_ID = @id";
                connection.comm = new SqlCommand(update, connection.conn);
                connection.comm.Parameters.AddWithValue("@id", txtSearch.Text);
                connection.comm.Parameters.AddWithValue("@date", CalendarMonth.SelectionStart);
                connection.comm.Parameters.AddWithValue("@time", txtCheckOutTime.Text);
                connection.comm.ExecuteNonQuery();
                connection.conn.Close();

                if (connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
                }
                string transaction = "INSERT INTO Transactions VALUES(@id,@date,@method)";
                connection.comm = new SqlCommand(transaction, connection.conn);
                connection.comm.Parameters.AddWithValue("@id", txtSearch.Text);
                connection.comm.Parameters.AddWithValue("@date", CalendarMonth.SelectionStart);
                connection.comm.Parameters.AddWithValue("@method", comboTransaction.SelectedItem);
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
                if (connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
                }
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
                if (connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
                }
                string display = "SELECT FirstName,LastName FROM Guests";
                connection.comm = new SqlCommand(display, connection.conn);
                connection.reader = connection.comm.ExecuteReader();

                while (connection.reader.Read())
                {
                    lstCheckInInfo.Items.Add("The Following Check-out date & Time have been recorded for :" + "\n");
                    lstCheckInInfo.Items.Add("FIRSTNAME: " + connection.reader.GetValue(1) + "\n");
                    lstCheckInInfo.Items.Add("LASTNAME: " + connection.reader.GetValue(2) + "\n");
                }
                connection.conn.Close();

                if (connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
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


                connection.conn.Close();

                if (connection.conn.State == ConnectionState.Closed)
                {
                    connection.conn.Open();
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
    }
}
