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
        string RoomID;

 
        public void displayBookings(string sql)
        {
            try
            {
                connection.conn = new SqlConnection(connection.ConnectionString);
                connection.conn.Open();


                connection.comm = new SqlCommand(sql, connection.conn);

                connection.adap = new SqlDataAdapter();
                connection.ds = new DataSet();

                connection.adap.SelectCommand = connection.comm;
                connection.adap.Fill(connection.ds, "Bookings");

                displayCheckin.DataSource = connection.ds;
                displayCheckin.DataMember = "Bookings";

                dataGridViewBookings.DataSource = connection.ds;
                dataGridViewBookings.DataMember = "Bookings";

                connection.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! An Error has occured\n" + ex.Message);
            }
        }

        private void getRoomID(string type)
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
                string sqlBookings = "SELECT * FROM Bookings";

                displayGuests(sql);
                displayBookings(sqlBookings);

                comboTransaction.Items.Add("EFT");
                comboTransaction.Items.Add("CASH");

                connection.getReceptionistID();
                txtReceptionistID.Text = connection.recID;

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
                // Declaring variables to store the needed attributes
                int guestID = int.Parse(txtGuestId.Text);
                int roomID = int.Parse(RoomID);
                int.Parse(txtReceptionistID.Text);

                string checkInDate = datePickerCheckIn.Value.ToString();
                string checkInTime = txtCheckTime.Text;
                string checkOutDate = ""; //dateTimePickerChkOut.Value.ToString();
                string checkOutTime = ""; //txtCheckOutTime.Text;
                int numOfGuests = cmbRoomType.SelectedIndex + 1;

                connection.conn = new SqlConnection(connection.ConnectionString);
                connection.conn.Open();

                string sqlInsert = $"INSERT INTO Bookings VALUES ({guestID}, {int.Parse(txtReceptionistID.Text)}, {roomID}, '{checkInDate}', '{checkInTime}', '{checkOutDate}', '{checkOutTime}', '{numOfGuests}')";

                connection.comm = new SqlCommand(sqlInsert, connection.conn);
                connection.adap = new SqlDataAdapter();
                connection.adap.InsertCommand = connection.comm;
                connection.adap.InsertCommand.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Booking successfully confirmed!");

                string sql = "SELECT * FROM Bookings";

                displayBookings(sql);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! An error has occured!\n" + ex.Message);
            }
        }

        
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                //
                string checkInDate = dateTimeChckInMan.Value.ToString();
                string checkInTime = txtCheckInTimeMan.Text;

                connection.conn = new SqlConnection(connection.ConnectionString);

                connection.conn.Open();

                string update = "UPDATE Bookings SET CheckIn_Date = @date,CheckIn_Time = @time WHERE Booking_ID = @id";
                connection.comm = new SqlCommand(update, connection.conn);
                connection.comm.Parameters.AddWithValue("@id", txtBookingID.Text);
                connection.comm.Parameters.AddWithValue("@date", dateTimeChckInMan.Value.ToString());
                connection.comm.Parameters.AddWithValue("@time",txtCheckInTimeMan.Text);
                connection.comm.ExecuteNonQuery();
                connection.conn.Close();

                MessageBox.Show("Guest succesfully checked in!");

                string sql = "SELECT * FROM Bookings";

                displayBookings(sql);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Bookings WHERE Booking_ID LIKE'%" + txtBookingID.Text + "%'";

            displayBookings(query);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                string transactionDate = dateTimePickerChkOut.Value.ToString();
                connection.conn = new SqlConnection(connection.ConnectionString);

                connection.conn.Open();

                string update = "UPDATE Bookings SET CheckOut_Date = @date,CheckOut_Time = @time WHERE Booking_ID = @id";
                connection.comm = new SqlCommand(update, connection.conn);
                connection.comm.Parameters.AddWithValue("@id", txtSearch.Text);
                connection.comm.Parameters.AddWithValue("@date", dateTimePickerChkOut.Value.ToString());
                connection.comm.Parameters.AddWithValue("@time", txtCheckOutTime.Text);
                connection.comm.ExecuteNonQuery();
                connection.conn.Close();

                //
                string sql = "SELECT * FROM Bookings";
                displayBookings(sql);

                connection.conn.Open();

                string transaction = "INSERT INTO Transactions VALUES(@id,@date,@method)";
                connection.comm = new SqlCommand(transaction, connection.conn);
                connection.comm.Parameters.AddWithValue("@id", txtSearch.Text);
                connection.comm.Parameters.AddWithValue("@date", transactionDate);
                connection.comm.Parameters.AddWithValue("@method", comboTransaction.SelectedItem.ToString());
                connection.comm.ExecuteNonQuery();
                connection.conn.Close();

                MessageBox.Show("Done!");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Oops! An error has occurred \n" + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Bookings WHERE Booking_ID LIKE'%" + txtSearch.Text + "%'";
            displayBookings(query);
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
            getRoomID(selectedRoomType);
            txtRoomID.Text = RoomID;

        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(cancelBookingID.Text))
                {
                    MessageBox.Show("Please enter booking ID");
                }
                else
                {
                    connection.conn.Open();

                    string cancelBooking = "DELETE FROM Bookings WHERE Booking_ID = '" + cancelBookingID.Text + "'";

                    connection.comm = new SqlCommand(cancelBooking, connection.conn);
                    connection.adap = new SqlDataAdapter();
                    connection.adap.DeleteCommand = connection.comm;
                    connection.adap.DeleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Booking cancelled successfully.");

                    string sql = "SELECT * FROM Bookings";

                    displayBookings(sql);
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! There was an error...\n" + ex.Message);
            }
        }

        private void rdbtnNow_CheckedChanged(object sender, EventArgs e)
        {
           if(rdbtnNow.Checked)
            {
                datePickerCheckIn.Enabled = true;
                txtCheckTime.Enabled = true;
                lblDate.Enabled = true;
                lblTime.Enabled = true;
            }
           else
            {
                datePickerCheckIn.Enabled = false;
                txtCheckTime.Enabled = false;
                lblDate.Enabled = false;
                lblTime.Enabled = false;
            }
        }

        private void rdbtnAnotherTime_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtnAnotherTime.Checked)
            {
                datePickerCheckIn.Enabled = false;
                txtCheckTime.Enabled = false;
                lblDate.Enabled = false;
                lblTime.Enabled = false;
            }
            else
            {
                datePickerCheckIn.Enabled = true;
                txtCheckTime.Enabled = true;
                lblDate.Enabled = true;
                lblTime.Enabled = true;
            }
        }
    }
}
