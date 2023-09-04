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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMPG_223_PROJECT_GROUP35
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent(); 
            cbShowPassword.Checked = true;
        }

        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\legen\Documents\GitHub\CMPG-223-PROJECT-GROUP-35-2023-\SQL Server Scripts For LEHLABILE HOTEL\SQL Server Scripts For LEHLABILE HOTEL\DATA\Lehlabile Hotel DB.mdf"";Integrated Security=True;Connect Timeout=30";
        public SqlConnection conn;
        public SqlCommand comm;
        public SqlCommand comm1;
        public SqlDataAdapter adap;
        public SqlDataReader reader;
        public SqlDataReader reader1;
        public DataSet ds;

        public string recID;

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            // Makes the form invisible when the form loads
            lblError.Visible = false; 

            //
            //cbShowPassword.Checked = true;
        }
        

        public string getReceptionistID()
        {
            string recepID = "";

            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();

                string sql = "SELECT * FROM Receptionists WHERE Email_Address = '" + txtEmail.Text + "'";
                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();

                while(reader.Read())
                {
                    recepID = reader.GetString(0).ToString();
                }

                return recepID;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! An error has occured!\n" + ex.Message);
            }

            return recepID;
        }


        private void isManager(string username, string password)
        {
            try
            {
                conn = new SqlConnection(ConnectionString);

                conn.Open(); // Open connection

                // Creating the Form Report instance
                Reports frmReports = new Reports();

                string sqlForManger = "SELECT Password FROM Receptionists WHERE Email_Address = '" + username + "'";
                comm = new SqlCommand(sqlForManger, conn);
                reader = comm.ExecuteReader();

                if (password == "khomotsoTheManager") //reader.GetValue(5).ToString())
                {
                    frmReports.Show();
                }

                conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Oops! An error has occurred...\n" +  ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Getting the user log in details
            String username = txtEmail.Text.Trim();
            String password = txtPassword.Text.Trim();

            


           ///*
            if (username == "Manager1@lehlabilehotel.co.za")
            {
                // Calling the isManager method to check whether it is the manager who is logging in
                isManager(username, password);
            }
            else if (CheckAdminDetails(username, password))
            {
                // Open the form accessor if it is the receptionist logging in
                FormNewExisting frmAccesor = new FormNewExisting();
                frmAccesor.ShowDialog();

                // Clear the textboxes after loging in
                txtEmail.Clear();
                txtPassword.Clear();
            }
            else
            {
                // Make the label visible to the user when they have entered incorrect username or password
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
            }

        }

        //CheckAdminDetails method checks if the user entered corrrect log in details
        private bool CheckAdminDetails(string username, string password)
        {
            conn = new SqlConnection(ConnectionString);
            
            conn.Open(); // Open connection

            string sqlStatement = "SELECT COUNT(*) FROM Receptionists WHERE Email_Address = @Username AND Password = @Password";

            comm = new SqlCommand(sqlStatement, conn);
                
            comm.Parameters.AddWithValue("@Username", username);
            comm.Parameters.AddWithValue("@Password", password);

            int count = Convert.ToInt32(comm.ExecuteScalar());

            conn.Close();

            return count > 0;               
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Hiding and showing the password
            txtPassword.UseSystemPasswordChar = cbShowPassword.Checked;
        }

        private void linkLblAddNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Make the sign up form appear
            FormSignUp signUpWindow = new FormSignUp();
            signUpWindow.ShowDialog();
        }
    }
}
