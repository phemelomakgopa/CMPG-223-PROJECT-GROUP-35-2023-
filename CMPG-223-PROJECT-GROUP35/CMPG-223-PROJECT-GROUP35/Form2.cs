using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    MessageBox.Show("Successfully signed up!");
                    this.Close();
                }
                //MessageBox.Show("Invalid " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
