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

        //
        frmLogIn frmLogIn = new frmLogIn();

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
            //
            string RoomType = txtRoomType.Text;
            decimal roomPrice = decimal.Parse(txtRoomPrice.Text);
            string roomDescr = txtRoomDescr.Text;


            try
            {

                if (frmLogIn.conn.State == ConnectionState.Closed)
                {
                    frmLogIn.conn.Open();
                }
                string sql_InsertData = "INSERT INTO Rooms VALUES ('{RoomType}',{roomPrice},'{roomDescr.Text}') " + cmbCapacity.SelectedValue + "'";
               
                
                frmLogIn.adap = new SqlDataAdapter();
                frmLogIn.comm = new SqlCommand(sql_InsertData, frmLogIn.conn);
                frmLogIn.adap.SelectCommand = frmLogIn.comm;
                frmLogIn.adap.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Data succeffuly inserted");


                frmLogIn.conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.ToString());
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

                string removeRoom = "DELETE FROM Rooms WHERE Room_ID = '" + deleteRoom.Text + "'";
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
