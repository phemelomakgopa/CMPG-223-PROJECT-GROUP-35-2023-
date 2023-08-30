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
    public partial class FormNewExisting : Form
    {
        public FormNewExisting()
        {
            InitializeComponent();
            existingGB.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoNewGuest.Checked)
                {
                    Form FormGuests = new FormGuests();
                    existingGB.Enabled = false;
                    FormGuests.ShowDialog();
                }
                else if (rdoExGuest.Checked)
                {
                    existingGB.Enabled = true;
                }

                if (cbBookings.Checked)
                {
                    FormBookings book = new FormBookings();
                    book.ShowDialog();
                }
                else if(cbChangeGuestInfo.Checked)
                {
                    FormGuests guest = new FormGuests();
                    guest.ShowDialog();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void btnMainRooms_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 rooms = new Form3();
                rooms.ShowDialog();
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
