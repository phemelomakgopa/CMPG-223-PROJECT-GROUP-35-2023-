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
                if (txtFname.Text.Length < 1 || txtLName.Text.Length < 1 || txtEmail.Text.Length < 1 || txtPassword.Text.Length < 1 || txtCellNum.Text.Length < 10) 
                {
                    MessageBox.Show("Please enter valid data.");
                }
                else
                {
                    MessageBox.Show("Receptionists succesfully signed up!\nWelcome to Lehlabile Hotel");
                }


                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid " + ex.Message);
            }

        }
    }
}
