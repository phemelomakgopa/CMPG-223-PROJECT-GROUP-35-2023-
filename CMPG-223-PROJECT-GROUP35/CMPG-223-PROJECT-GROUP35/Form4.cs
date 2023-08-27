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
    public partial class FormNewExisting : Form
    {
        public FormNewExisting()
        {
            InitializeComponent();
            existingGB.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int GuestNum = int.Parse(txtGuestPhoneNum.Text);

                if (rdoNewGuest.Checked)
                {
                    Form FormGuests = new FormGuests();

                    FormGuests.ShowDialog();
                }
                else if (rdoExGuest.Checked)
                {
                    existingGB.Show();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Oops, something went wrong.");
            }
            

        }
    }
}
