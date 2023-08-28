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
    public partial class FormGuests : Form
    {
        public FormGuests()
        {
            InitializeComponent();
        }
       
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        SqlDataReader theReader;
        DataSet ds;
        string conStr;


        private void btnAddNewGuest_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection();
                conn.Open();
                string SQL = $"INSERT INTO Guests VALUES(@name,@surname,@number,@email)";
                comm = new SqlCommand(SQL, conn);
                adap = new SqlDataAdapter();
                comm.Parameters.AddWithValue("@name, @surname");

                conn.Close();

                
                
                MessageBox.Show("Guest successfully added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
