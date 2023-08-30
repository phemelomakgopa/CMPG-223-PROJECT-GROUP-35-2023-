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

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        string conStr = "";

        private void Reports_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);
                
                conn.Open();

                string output = "";
                string sql = "SELECT * FROM Transactions";

                cmd = new SqlCommand(sql, conn);         // Create a command, setting the SQL string as well as the connection
                reader = cmd.ExecuteReader();         // Use the DataReader to read the records as selected in the SQL in the command object above

                // Printing headings in the listbox
                lstbxReports.Items.Add("ID" + "\t" + "BookingID" + "\t\t" + "Transaction Date" + "\t\t" + "Transaction Method");
                lstbxReports.Items.Add("-----------------------------------------------------------------------------------------------------------------");

                // Looping through the data set
                while (reader.Read()) 
                {
                    output = reader.GetValue(0) + " \t " + reader.GetValue(1) + " \t\t " + reader.GetValue(2) + " \t\t " + reader.GetValue(3) + "\n";
                    // Adding the transaction data to the listBox
                     lstbxReports.Items.Add(output);
                }

                // Closing the connection to the database
                conn.Close();
            }
            catch(SqlException ex)
            {
                // Displaying an error message to the user
                MessageBox.Show("Oops! An error has occured!\n" + ex.Message);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // Creating the login form instance
            frmLogIn frm1 = new frmLogIn();

            this.Close();           // Closing the reports form
            frm1.Show();            // Showing the login form

        }

        private void btnShowBookings_Click(object sender, EventArgs e)
        {
            try
            {      
                // Opening the connection
                conn.Open();

                // Declaring string variables
                string output = "";
                string sql = "SELECT * FROM Bookings";

                // Clearing the listbox
                lstbxReports.Items.Clear();

                cmd = new SqlCommand(sql, conn);         // Create a command, setting the SQL string as well as the connection
                reader = cmd.ExecuteReader();            // Use the DataReader to read the records as selected in the SQL in the command object above

                // Printing headings in the listbox
                lstbxReports.Items.Add("ID" + "\t" + "GuestID" + "\t" + "Recept.ID" + "\t" + "RoomID" + "\t\t" + "Check-In Date" + "\t\t" + "Check-In Time" + "\t\t" + "Check-Out Date" + "\t\t" + "Check-Out Time" + "\t\t" + "Num of Guests");
                lstbxReports.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                // Looping through the data set
                while (reader.Read())
                {
                    output = reader.GetValue(0) + " \t " + reader.GetValue(1) + " \t\t " + reader.GetValue(2) + " \t\t " + reader.GetValue(3) + " \t\t " + reader.GetValue(4) + " \t\t " + reader.GetValue(5) + " \t\t " + reader.GetValue(6) + " \t\t " + reader.GetValue(7) + " \t\t " + reader.GetValue(8) + "\n";
                    // Adding the transaction data to the listBox
                    lstbxReports.Items.Add(output);
                }

                // Closing the connection to the database
                conn.Close();
            }
            catch (SqlException ex)
            {
                // Displaying an error message to the user
                MessageBox.Show("Oops! An error has occured!\n" + ex.Message);
            }
        }
    }
}
