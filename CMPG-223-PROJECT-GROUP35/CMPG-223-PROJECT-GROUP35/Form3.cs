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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            lblRoomType.Visible = false;
            txtUpdateType.Visible = false;
            lblRoomPrice.Visible = false;
            txtUpdatePrice.Visible = false;
            lblCapacity.Visible = false;
            cmbUpdateCapacity.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string RoomType = txtRoomType.Text;
            int roomNum = int.Parse(txtRoomNum.Text);
            decimal roomPrice;
            string roomDescr = txtRoomDescr.Text;

            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblRoomType.Show();
            txtUpdateType.Show();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Room succesfully removed.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbUpdatePrice_CheckedChanged(object sender, EventArgs e)
        {
            lblRoomPrice.Show();
            txtUpdatePrice.Show();
        }

        private void cbUpdateCapacity_CheckedChanged(object sender, EventArgs e)
        {
            lblCapacity.Show();
            cmbUpdateCapacity.Show();
        }
    }
}
