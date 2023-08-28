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
        public string conStr;
        //conn = new SqlConnection(conStr);

        private void btnAddNewGuest_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                string SQL = $"INSERT INTO Guests VALUES(@name,@surname,@cellnumber,@email)";
                comm = new SqlCommand(SQL, conn);
                
                comm.Parameters.AddWithValue("@name", txtFnameAdd.Text);
                comm.Parameters.AddWithValue("@surname", txtLNameAdd.Text);
                comm.Parameters.AddWithValue("@email", txtEmailAdd.Text);
                comm.Parameters.AddWithValue("@cellnumber", txtCellNumAdd.Text);

                comm.ExecuteNonQuery();


                conn.Close();

                
                
                MessageBox.Show("Guest successfully added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                string SQL = $"UPDATE Guests SET LastName = @surname, EmailAddress = @email, CellNumber = @cellnumber WHERE GuestID = @guestid";
                comm = new SqlCommand(SQL, conn);

                
                comm.Parameters.AddWithValue("@surname", txtUpdateSurname.Text);
                comm.Parameters.AddWithValue("@email", txtUpdateEmail.Text);
                comm.Parameters.AddWithValue("@cellnumber", txtUpdateNum.Text);
                comm.Parameters.AddWithValue("@guestid", txtGuestID.Text);
                comm.ExecuteNonQuery();

                
                conn.Close();
                MessageBox.Show("Details successfully changed.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbUpdateSurname_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUpdateSurname.Checked)
            {
                lblUpdateSurname.Enabled = true;
                txtUpdateSurname.Enabled = true;

            }
            else if (cbUpdateSurname.Checked == false)
            {
                lblUpdateSurname.Enabled = false;
                txtUpdateSurname.Enabled = false;
            }
        }

        private void cbUpdateEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUpdateEmail.Checked)
            {
                lblUpdateEmail.Enabled = true;
                txtUpdateEmail.Enabled = true;

            }
            else if (cbUpdateSurname.Checked == false)
            {
                lblUpdateEmail.Enabled = false;
                txtUpdateEmail.Enabled = false;

            }
        }

        private void cbUpdateNum_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUpdateNum.Checked)
            {
                lblUpdateNum.Enabled = true;
                txtUpdateNum.Enabled = true;

            }
            else if (cbUpdateNum.Checked == false)
            {
                lblUpdateNum.Enabled = false;
                txtUpdateNum.Enabled = false;

            }
        }

        private void btnUpdateGuestSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtUGuest_TextChanged(object sender, EventArgs e)
        {
            lstGuestOutput.Items.Clear();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * from Guests WHERE cellnumber LIKE '%" + txtSearchGuest.Text + "%'";
                comm = new SqlCommand(query, conn);
                theReader = comm.ExecuteReader();

                while (theReader.Read())
                {
                    lstSearchOutput.Items.Add(theReader.GetValue(0) + "\t" + theReader.GetValue(1) + "\t" + theReader.GetValue(2) + "\t" + theReader.GetValue(3) + "\t" + theReader.GetValue(4));
                    lstSearchOutput.Items.Add("");
                }
                conn.Close();

            }



            /*
                            SqlDataAdapter adap = new SqlDataAdapter(query, conStr);
                            DataSet ds = new DataSet();
                            adap.Fill(ds, "Guests");

                            lstGuestOutput.DataSource = ds;
                            //lstGuestOutput;

                        }*/

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {

        }
    }
}
