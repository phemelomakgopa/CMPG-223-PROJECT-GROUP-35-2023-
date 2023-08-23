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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=.\SQLEXPRESS01;Initial Catalog=LEHLABILE HOTEL DB;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;

        private void btnLogin_Click(object sender, EventArgs e)
        {
           try
            {
                conn = new SqlConnection(conStr);

                conn.Open();

                conn.Close();

                MessageBox.Show("Succesfully connected");
            }
            catch (SqlException error)
            {
                MessageBox.Show("Oops! \n" + error.Message);
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();

                adap = new SqlDataAdapter();               // Instantiating the sql data adapter
                ds = new DataSet();                           // Instantiating the data set

                string sql = "SELECT * FROM Receptionists";            // Declaring and assigning a sql string to extract the contents of the Data table

                cmd = new SqlCommand(sql, conn);              // Instantiating the sql command
                adap.SelectCommand = cmd;                  // Assigning the Select Command to the sql command         
                adap.Fill(ds, "Receptionists");                     // Populating the data source with the table contents

                dataGridView1.DataSource = ds;                  // Assigning the data source of the data grid view 
                dataGridView1.DataMember = "Receptionists";              // Displaying the Movies table to the data grid view


                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show("Oops! \n" + error.Message);
            }
        }
    }
}
