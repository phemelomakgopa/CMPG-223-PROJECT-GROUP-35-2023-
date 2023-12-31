﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG_223_PROJECT_GROUP35
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        // Declaring public variables to store the user inputs
        public string fName;
        public string flastname;
        public string fEmail;
        public string fPassword;
        public string fCellNumber;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the receptionist details
                fName = txtFname.Text;
                flastname = txtLName.Text;
                fEmail = txtEmail.Text;
                fPassword = txtPassword.Text;
                fCellNumber = txtCellNum.Text;
                
                if (string.IsNullOrWhiteSpace(fName))
                {
                    MessageBox.Show("Please enter your first name validly.");
                }
                else if (string.IsNullOrWhiteSpace(flastname))
                {
                    MessageBox.Show("Please enter your last name validly.");
                }
                else if (string.IsNullOrWhiteSpace(fEmail))
                {
                    MessageBox.Show("Please enter your email validly.");
                }
                else if (string.IsNullOrWhiteSpace(fPassword))
                {
                    MessageBox.Show("Please enter your password validly.");
                }
                else if (string.IsNullOrWhiteSpace(fCellNumber))
                {
                    MessageBox.Show("Please enter your cell number validly.");
                }
                else
                {
                    //Sign up code
                    frmLogIn connection = new frmLogIn();
                   
                    try
                    {
                        connection.conn = new SqlConnection(connection.ConnectionString);
                        connection.conn.Open();
                        string insertStatement = $"INSERT INTO Receptionists VALUES(@FirstName,@LastName,@Email_Address,@Cellnumber,@password)";
                        connection.comm = new SqlCommand(insertStatement, connection.conn);

                        connection.comm.Parameters.AddWithValue("@FirstName",fName);
                        connection.comm.Parameters.AddWithValue("@LastName",flastname);
                        connection.comm.Parameters.AddWithValue("@Email_Address", fEmail);
                        connection.comm.Parameters.AddWithValue("@password", fPassword);
                        connection.comm.Parameters.AddWithValue("@Cellnumber", fCellNumber);

                        connection.comm.ExecuteNonQuery();

                        connection.conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops! An error has occured\n" + ex.Message);
                    }


                    MessageBox.Show(txtFname.Text + " " + txtLName.Text + " has uccessfully signed up!\nWelcome to Lehlabile Hotel\nYou may proceed to log in");
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops! There was an error\n" + ex.Message);
            }
        }
    }
}
