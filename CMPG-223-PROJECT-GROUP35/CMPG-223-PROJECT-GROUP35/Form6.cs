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

        frmLogIn frmLogIn = new frmLogIn();

        private void btnAddNewGuest_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);
                frmLogIn.conn.Open();
                string SQL = $"INSERT INTO Guests VALUES(@name,@surname,@email,@cellnumber)";
                frmLogIn.comm = new SqlCommand(SQL, frmLogIn.conn);

                frmLogIn.comm.Parameters.AddWithValue("@name", txtFnameAdd.Text);
                frmLogIn.comm.Parameters.AddWithValue("@surname", txtLNameAdd.Text);
                frmLogIn.comm.Parameters.AddWithValue("@email", txtEmailAdd.Text);
                frmLogIn.comm.Parameters.AddWithValue("@cellnumber", txtCellNumAdd.Text);

                frmLogIn.comm.ExecuteNonQuery();
                frmLogIn.conn.Close();

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
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);

                frmLogIn.conn.Open();  

                int guestID;

                if (int.TryParse(txtGuestID.Text, out guestID))
                {

                    if (cbUpdateSurname.Checked)
                    {
                        lblUpdateSurname.Enabled = true;
                        txtUpdateSurname.Enabled = true;

                        string SQL = $"UPDATE Guests SET LastName = @surname WHERE Guest_ID = @guestid";

                        frmLogIn.comm = new SqlCommand(SQL, frmLogIn.conn);
                        frmLogIn.comm.Parameters.AddWithValue("@surname", txtUpdateSurname.Text);
                        frmLogIn.comm.Parameters.AddWithValue("@guestid", guestID);

                        frmLogIn.comm.ExecuteNonQuery();
                        
                    }
                    if (cbUpdateEmail.Checked)
                    {
                        lblUpdateEmail.Enabled = true;
                        txtUpdateEmail.Enabled = true;

                        string SQL = $"UPDATE Guests SET Email_Address = @email WHERE Guest_ID = @guestid";

                        frmLogIn.comm = new SqlCommand(SQL, frmLogIn.conn);
                        frmLogIn.comm.Parameters.AddWithValue("@email", txtUpdateEmail.Text);
                        frmLogIn.comm.Parameters.AddWithValue("@guestid", guestID);

                        frmLogIn.comm.ExecuteNonQuery();
                    }
                    if (cbUpdateNum.Checked)
                    {
                        lblUpdateNum.Enabled = true;
                        txtUpdateNum.Enabled = true;

                        string SQL = $"UPDATE Guests SET Cellphone_Number = @cellphone WHERE Guest_ID = @guestid";
                        frmLogIn.comm = new SqlCommand(SQL, frmLogIn.conn);
                        frmLogIn.comm.Parameters.AddWithValue("@cellphone", txtUpdateNum.Text);
                        frmLogIn.comm.Parameters.AddWithValue("@guestid", guestID);

                        frmLogIn.comm.ExecuteNonQuery();
                        
                    }

                 frmLogIn.conn.Close();
                 MessageBox.Show("Details successfully changed.");

                }
                else
                {
                    MessageBox.Show("Provide the guest id to make changes");
                }

                display();

               

            }
            catch (SqlException ex)
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

        public void display()
        {
            frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);
            frmLogIn.conn.Open();

            frmLogIn.ds = new DataSet();
            frmLogIn.adap = new SqlDataAdapter();

            string sql = "SELECT * FROM Guests";
            frmLogIn.comm = new SqlCommand(sql, frmLogIn.conn);

            frmLogIn.adap.SelectCommand = frmLogIn.comm;
            frmLogIn.adap.Fill(frmLogIn.ds, "Guests");

           dgvGuestsOutput.DataSource = frmLogIn.ds;
           dgvGuestsOutput.DataMember = "Guests";

            dataDelete.DataSource = frmLogIn.ds;
            dataDelete.DataMember = "Guests";




            frmLogIn.conn.Close();
        }
        private void txtUGuest_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);
                frmLogIn.conn.Open();

                frmLogIn.ds = new DataSet();
                frmLogIn.adap = new SqlDataAdapter();

                string query = "SELECT * FROM Guests WHERE Cellphone_Number LIKE '%" + txtUGuest.Text + "%'";

                frmLogIn.comm = new SqlCommand(query, frmLogIn.conn);
                
                frmLogIn.adap.SelectCommand = frmLogIn.comm;
                frmLogIn.adap.Fill(frmLogIn.ds, "Guests");

                dgvGuestsOutput.DataSource = frmLogIn.ds;
                dgvGuestsOutput.DataMember = "Guests";

                frmLogIn.conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            try
            {
                display();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);
                frmLogIn.conn.Open();
                int deleteGuest = int.Parse(txtSearchGuest.Text);

                string delete = "DELETE FROM Guests WHERE Guest_ID = '" + deleteGuest+ "'";

                frmLogIn.comm = new SqlCommand(delete, frmLogIn.conn);
                frmLogIn.adap = new SqlDataAdapter();
                frmLogIn.adap.DeleteCommand = frmLogIn.comm;
                frmLogIn.adap.DeleteCommand.ExecuteNonQuery();
                frmLogIn.conn.Close();
             
                MessageBox.Show("Guest is successfully removed from the system");
                display();

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormGuests_Load(object sender, EventArgs e)
        {
            lblUpdateSurname.Enabled = false;
            txtUpdateSurname.Enabled = false;
            lblUpdateEmail.Enabled = false;
            txtUpdateEmail.Enabled = false;
            lblUpdateSurname.Enabled = false;
            txtUpdateSurname.Enabled = false;
            display();
        }

        private void btnUpdateGuestSearch_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);
                frmLogIn.conn.Open();

                frmLogIn.ds = new DataSet();
                frmLogIn.adap = new SqlDataAdapter();

                string query = "SELECT * FROM Guests WHERE Cellphone_Number LIKE '%" + txtUGuest.Text + "%'";

                frmLogIn.comm = new SqlCommand(query, frmLogIn.conn);

                frmLogIn.adap.SelectCommand = frmLogIn.comm;
                frmLogIn.adap.Fill(frmLogIn.ds, "Guests");

                dgvGuestsOutput.DataSource = frmLogIn.ds;
                dgvGuestsOutput.DataMember = "Guests";

                frmLogIn.conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
           try
            {
                display();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
