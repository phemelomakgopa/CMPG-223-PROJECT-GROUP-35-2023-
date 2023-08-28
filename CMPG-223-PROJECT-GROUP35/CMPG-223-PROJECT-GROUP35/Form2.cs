using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtFname.Text;
                string lastname = txtLName.Text;
                string email = txtEmail.Text;
                string newPassword = txtPassword.Text;
                int cellNum = int.Parse(txtCellNum.Text);

                MessageBox.Show("Receptionist successfully signed up.");
            }
            catch (Exception)
            {
                MessageBox.Show("Oops, something went wrong.");
            }


        }
    }
}
