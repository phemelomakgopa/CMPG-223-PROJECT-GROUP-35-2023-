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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblRoomType.Enabled = false;
            txtUpdateType.Enabled= false;
            lblRoomPrice.Enabled = false;
            txtUpdatePrice.Enabled = false;
            lblCapacity.Enabled = false;
            cmbUpdateCapacity.Enabled= false;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string RoomType = txtRoomType.Text;
            int roomNum = int.Parse(txtRoomNum.Text);
            double roomPrice = 0;
            string roomDescr = txtRoomDescr.Text;

            if (RoomType == "Standard")
            {
                if (cmbUpdateCapacity.SelectedIndex > 5)
                {
                    roomPrice = 150+(roomNum * cmbUpdateCapacity.SelectedIndex) * 20 / 100;
                }
                else if (cmbUpdateCapacity.SelectedIndex == 2)
                {
                    roomPrice = 275+(roomNum * cmbUpdateCapacity.SelectedIndex) * 7 / 100;
                }
                else
                {
                    roomPrice = 420+(roomNum * cmbUpdateCapacity.SelectedIndex);
                }
            }
           else if(RoomType == "5-Star")
            {
                if (cmbUpdateCapacity.SelectedIndex > 5)
                {
                    roomPrice = 600 + (roomNum * cmbUpdateCapacity.SelectedIndex);
                }
                else if (cmbUpdateCapacity.SelectedIndex == 2)
                {
                    roomPrice = 1000 + (roomNum * cmbUpdateCapacity.SelectedIndex);
                }
                else
                {
                    roomPrice = 1500+(roomNum * cmbUpdateCapacity.SelectedIndex);
                }
            }
           else
            {
                if(cmbUpdateCapacity.SelectedIndex == 2 && RoomType == "HoneyMoon_Room")
                {
                    roomPrice = 780;
                }
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblRoomType.Enabled = true;
            txtUpdateType.Enabled = true;
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                FormGuests guest = new FormGuests();
                SqlConnection conn = new SqlConnection(guest.conStr);
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string removeRoom = "DELETE FROM Rooms WHERE RoomID LIKE'"+deleteRoom.Text+"'";
                SqlCommand command = new SqlCommand(removeRoom,conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Room succesfully removed.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbUpdatePrice_CheckedChanged(object sender, EventArgs e)
        {
            lblRoomPrice.Enabled = true;
            txtUpdatePrice.Enabled = true;
        }

        private void cbUpdateCapacity_CheckedChanged(object sender, EventArgs e)
        {
            lblCapacity.Enabled = true;
            cmbUpdateCapacity.Enabled = true;
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
