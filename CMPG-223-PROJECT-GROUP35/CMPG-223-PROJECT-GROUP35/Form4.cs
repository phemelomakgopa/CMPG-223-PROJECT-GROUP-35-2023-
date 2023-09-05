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
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
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

        private void cbBookings_CheckedChanged(object sender, EventArgs e)
        {          
        }

        private void FormNewExisting_Load(object sender, EventArgs e)
        {     
        }

        private void rdoNewGuest_CheckedChanged(object sender, EventArgs e)
        {              
        }

        private void cbChangeGuestInfo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdoExGuest_CheckedChanged(object sender, EventArgs e)
        {         
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void makeABookingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBookings bookingWindow = new FormBookings();    
            bookingWindow.MdiParent = this; 
            bookingWindow.Show(); 
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBookings checkInWindow = new FormBookings();
            checkInWindow.MdiParent = this; 
            checkInWindow.Show();
            checkInWindow.tabControl1.SelectedTab = checkInWindow.tabPage2;

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBookings checkOutWindow = new FormBookings();
            checkOutWindow.MdiParent = this;
            checkOutWindow.Show();
            checkOutWindow.tabControl1.SelectedTab = checkOutWindow.tabPage3;
        }

        private void cancelABookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBookings cancelBookingWindow = new FormBookings();
            cancelBookingWindow.MdiParent = this;
            cancelBookingWindow.Show();
            cancelBookingWindow.tabControl1.SelectedTab = cancelBookingWindow.tabPage4;
        }

        private void addNewGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGuests addGuestWindow = new FormGuests();
            addGuestWindow.MdiParent = this;
            addGuestWindow.Show();  
        }

        private void changeGuestDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGuests changeGuestWindow = new FormGuests();
            changeGuestWindow.MdiParent = this;
            changeGuestWindow.Show();
            changeGuestWindow.tabControl2.SelectedTab = changeGuestWindow.changeDetails;
        }

        private void removeGuestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGuests removeGuestWindow = new FormGuests();
            removeGuestWindow.MdiParent = this;
            removeGuestWindow.Show();
            removeGuestWindow.tabControl2.SelectedTab = removeGuestWindow.tabPage3;
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 addRoomWindow = new Form3();
            addRoomWindow.MdiParent = this;
            addRoomWindow.Show();
            addRoomWindow.tabGuests.SelectedTab = addRoomWindow.tabPage1;
        }

        private void changeRoomDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 changeRoomWindow = new Form3();
            changeRoomWindow.MdiParent = this;
            changeRoomWindow.Show();
            changeRoomWindow.tabGuests.SelectedTab = changeRoomWindow.tabPage2;
        }

        private void removeRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 removeRoomWindow = new Form3();
            removeRoomWindow.MdiParent = this;
            removeRoomWindow.Show();
            removeRoomWindow.tabGuests.SelectedTab = removeRoomWindow.tabPage3;
        }
    }
}
