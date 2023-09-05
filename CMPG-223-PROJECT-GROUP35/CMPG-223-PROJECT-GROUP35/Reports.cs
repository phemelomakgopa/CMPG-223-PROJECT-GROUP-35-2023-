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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        // Creating a public form instance
        frmLogIn frmLogIn = new frmLogIn();

        public void displayReceiptionists()
        {
            try
            {
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);
                frmLogIn.conn.Open();
                string sql = "SELECT * FROM Receptionists";
                frmLogIn.comm = new SqlCommand(sql, frmLogIn.conn);
                frmLogIn.reader = frmLogIn.comm.ExecuteReader();

                while (frmLogIn.reader.Read())
                {
                    //Reports report = new Reports();
                    lstReport.Items.Add("FIRST NAMES: " + frmLogIn.reader.GetValue(1) + "\n");
                    lstReport.Items.Add("LAST NAMES : " + frmLogIn.reader.GetValue(2) + "\n");
                    lstReport.Items.Add("EMAIL_ADD  : " + frmLogIn.reader.GetValue(3) + "\n");
                    lstReport.Items.Add("CELL NUMS  : " + frmLogIn.reader.GetValue(4) + "\n");
                }
                frmLogIn.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayTransaction()
        {

            try
            {
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);
                frmLogIn.conn.Open();
                string sql = "SELECT * FROM Transactions";
                frmLogIn.comm = new SqlCommand(sql, frmLogIn.conn);
                frmLogIn.reader = frmLogIn.comm.ExecuteReader();

                while (frmLogIn.reader.Read())
                {
                    //Reports report = new Reports();
                    lstReport.Items.Add("BOOKING_ID   : " + frmLogIn.reader.GetValue(1) + "\n");
                    lstReport.Items.Add("TRANS DATE   : " + frmLogIn.reader.GetValue(2) + "\n");
                    lstReport.Items.Add("TRANS METHOD : " + frmLogIn.reader.GetValue(3) + "\n");
                }
                frmLogIn.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            lstReport.Items.Add("WELCOME Mr MOGALE TO THE REPORT FORM");
            viewReceptionistReport.Focus();

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Application.Exit();           // Closing system            
        }

        private void viewReceptionistReport_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
            lstReport.Items.Add("The following receiptionists were on duty for this booking report:" + "\n");
            displayReceiptionists();
            lstReport.Items.Add("\n" + "\n" + "For any system inquiries, contact details shown above");
        }

        private void viewTransactions_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
            lstReport.Items.Add("THE FOLLOWING TRANSACTIONS WERE RECORDED");
            displayTransaction();
        }

        public void displayGuests()
        {

            try
            {
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);
                frmLogIn.conn.Open();
                string sql = "SELECT * FROM Guests";
                frmLogIn.comm = new SqlCommand(sql, frmLogIn.conn);
                frmLogIn.reader = frmLogIn.comm.ExecuteReader();

                while (frmLogIn.reader.Read())
                {
                    //Reports report = new Reports();
                    lstReport.Items.Add("FIRST NAMES: " + frmLogIn.reader.GetValue(1) + "\n");
                    lstReport.Items.Add("LAST NAMES : " + frmLogIn.reader.GetValue(2) + "\n");
                    lstReport.Items.Add("EMAIL_ADD  : " + frmLogIn.reader.GetValue(3) + "\n");
                    lstReport.Items.Add("CELL NUMS  : " + frmLogIn.reader.GetValue(4) + "\n");
                }
                frmLogIn.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewGuests_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
            lstReport.Items.Add("HERE ARE OUR GUESTS WHO BOOKED THUS FAR: " + "\n");
            displayGuests();
        }

        public void displayBookings()
        {

            try
            {
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);
                frmLogIn.conn.Open();
                string sql = "SELECT * FROM Bookings";
                frmLogIn.comm = new SqlCommand(sql, frmLogIn.conn);
                frmLogIn.reader = frmLogIn.comm.ExecuteReader();

                while (frmLogIn.reader.Read())
                {
                    //Reports report = new Reports();
                    lstReport.Items.Add("RECEP-ID              : " + frmLogIn.reader.GetValue(2) + "\n");
                    lstReport.Items.Add("GUEST_ID              : " + frmLogIn.reader.GetValue(1) + "\n");
                    lstReport.Items.Add("ROOM_ID               : " + frmLogIn.reader.GetValue(3) + "\n");
                    lstReport.Items.Add("CHECKIN_DATE          : " + frmLogIn.reader.GetValue(4) + "\n");
                    lstReport.Items.Add("CHECKIN_TIME          : " + frmLogIn.reader.GetValue(5) + "\n");
                    lstReport.Items.Add("CHECKOUT_DATE         : " + frmLogIn.reader.GetValue(6) + "\n");
                    lstReport.Items.Add("CHECKOUT_TIME         : " + frmLogIn.reader.GetValue(7) + "\n");
                    lstReport.Items.Add("NUMBER OF GUESTS      : " + frmLogIn.reader.GetValue(8) + "\n");

                }
                frmLogIn.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewBookings_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
            lstReport.Items.Add("BOOKINGS MADE, CHECK IN AND CHECK OUT DETAILS: "+"\n");
            displayBookings();
        }

        public void displayRooms()
        {
            try
            {
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);
                frmLogIn.conn.Open();
                string sql = "SELECT * FROM Rooms";
                frmLogIn.comm = new SqlCommand(sql, frmLogIn.conn);
                frmLogIn.reader = frmLogIn.comm.ExecuteReader();

                while (frmLogIn.reader.Read())
                {
                    //Reports report = new Reports();
                    lstReport.Items.Add("ROOM TYPE    : " + frmLogIn.reader.GetValue(1) + "\n");
                    lstReport.Items.Add("ROOM PRICE   : " + frmLogIn.reader.GetValue(2) + "\n");
                    lstReport.Items.Add("CAPACITY     : " + frmLogIn.reader.GetValue(3) + "\n");
                    lstReport.Items.Add("DESCRIPTION  : " + frmLogIn.reader.GetValue(4) + "\n");
                }
                frmLogIn.conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void viewRooms_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
            lstReport.Items.Add("ROOM BOOKINGS WERE AS FOLLOWS :"+"\n");
            displayRooms();
        }
    }
}
