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

        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\legen\Documents\GitHub\CMPG-223-PROJECT-GROUP-35-2023-\SQL Server Scripts For LEHLABILE HOTEL\SQL Server Scripts For LEHLABILE HOTEL\DATA\Lehlabile Hotel DB.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection conn;
        public SqlCommand comm;
        public SqlDataAdapter adap;
        public DataSet ds;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Get the userr log in details
            String username = txtEmail.Text.Trim();
            String password = txtPassword.Text.Trim();

            if (CheckAdminDetails(username, password))
            {
                FormNewExisting frmAccesor = new FormNewExisting();
                frmAccesor.ShowDialog();//Open another form

                txtEmail.Clear();
                txtPassword.Clear();// Clear the textboxes after loging in
            }
            else
            {
                lblError.Visible = true; //Make the label visible to the user when the enter incorrect username or password
                //errorLabel.Text = "Username or password incorrect";

            }

        }

        //CheckAdminDetails method checks if the user entered corrrect log in details
        private bool CheckAdminDetails(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open(); // Open connection

                string sqlStatement = "SELECT COUNT(*) FROM Receptionists WHERE Email_Address = @Username AND Password = @Password";

                using (SqlCommand comm = new SqlCommand(sqlStatement, conn))
                {
                    comm.Parameters.AddWithValue("@Username", username);
                    comm.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(comm.ExecuteScalar());

                    return count > 0;
                }
            } // Connection automatically closed when leaving the using block
        }


        private void addNewDetailslbl_Click(object sender, EventArgs e)
        {
            FormSignUp signUpWindow = new FormSignUp();
            signUpWindow.ShowDialog();//Make the sign up form appear

            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                string insertStatement = $"INSERT INTO Receptionists VALUES(@FirstName,@LastName,@Email_Address,@Cellnumber,@password)";
                comm = new SqlCommand(insertStatement, conn);

                comm.Parameters.AddWithValue("@FirstName", signUpWindow.fName);
                comm.Parameters.AddWithValue("@LastName", signUpWindow.flastname);
                comm.Parameters.AddWithValue("@Email_Address", signUpWindow.fEmail);
                comm.Parameters.AddWithValue("@password", signUpWindow.fPassword);
                comm.Parameters.AddWithValue("@Cellnumber", signUpWindow.fCellNumber);

                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            lblError.Visible = false; // Makes the form invisible when the form loads
        }
    }
}
