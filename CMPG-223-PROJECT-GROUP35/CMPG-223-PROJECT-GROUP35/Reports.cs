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

        private void Reports_Load(object sender, EventArgs e)
        {
            try
            {
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);

                frmLogIn.conn.Open();

                string sql = "SELECT * FROM Transactions";

                frmLogIn.comm = new SqlCommand(sql, frmLogIn.conn);         // Create a command, setting the SQL string as well as the connection

                frmLogIn.adap = new SqlDataAdapter();
                frmLogIn.ds = new DataSet();

                frmLogIn.adap.SelectCommand = frmLogIn.comm;
                frmLogIn.adap.Fill(frmLogIn.ds, "Transactions");

                reportsDataGridView.DataSource = frmLogIn.ds;
                reportsDataGridView.DataMember = "Transactions";

                // Closing the connection to the database
                frmLogIn.conn.Close();
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

        }

        private void btnShowBookings_Click(object sender, EventArgs e)
        {
            try
            {      
                // Opening the connection
                frmLogIn.conn.Open();

                // Declaring string variables
                string sql = "SELECT * FROM Bookings";


                frmLogIn.comm = new SqlCommand(sql, frmLogIn.conn);         // Create a command, setting the SQL string as well as the connection

                frmLogIn.adap = new SqlDataAdapter();
                frmLogIn.ds = new DataSet();

                frmLogIn.adap.SelectCommand = frmLogIn.comm;
                frmLogIn.adap.Fill(frmLogIn.ds, "Bookings");

                reportsDataGridView.DataSource = frmLogIn.ds;
                reportsDataGridView.DataMember = "Bookings";

                // Closing the connection to the database
                frmLogIn.conn.Close();
            }
            catch (SqlException ex)
            {
                // Displaying an error message to the user
                MessageBox.Show("Oops! An error has occured!\n" + ex.Message);
            }
        }
    }
}
