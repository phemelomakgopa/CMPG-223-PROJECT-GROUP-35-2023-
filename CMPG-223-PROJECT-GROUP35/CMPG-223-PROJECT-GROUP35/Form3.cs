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

        
        frmLogIn frmLogIn = new frmLogIn();

        private void displayRooms()
        {
            try
            {
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);
                frmLogIn.conn.Open();

                string sql = "SELECT * FROM Rooms";
                frmLogIn.comm = new SqlCommand(sql, frmLogIn.conn);

                frmLogIn.adap = new SqlDataAdapter();
                frmLogIn.ds = new DataSet();

                frmLogIn.adap.SelectCommand = frmLogIn.comm;
                frmLogIn.adap.Fill(frmLogIn.ds, "Rooms");

                addedRooms.DataSource = frmLogIn.ds;
                addedRooms.DataMember = "Rooms";

                changedRooms.DataSource = frmLogIn.ds;
                changedRooms.DataMember = "Rooms";

                roomsDataGridView.DataSource = frmLogIn.ds;
                roomsDataGridView.DataMember = "Rooms";


                frmLogIn.conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Oops! An Error has occured\n" + ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Displaying rooms
            displayRooms();

            // Disabling controls
            lblRoomType.Enabled = false;
            txtUpdateType.Enabled= false;
            lblRoomPrice.Enabled = false;
            txtUpdatePrice.Enabled = false;
            lblCapacity.Enabled = false;
            cmbUpdateCapacity.Enabled= false;
            lblDescr.Enabled = false;
            txtUpdateDescr.Enabled = false;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            // Declaring variables to store user's inputs
            string RoomType = txtRoomType.Text;
            decimal roomPrice = decimal.Parse(txtRoomPrice.Text);
            string roomDescr = txtRoomDescr.Text;
            int roomCap = cmbCapacity.SelectedIndex + 1;

            try
            {

                frmLogIn.conn.Open();

                string sql_InsertData = "INSERT INTO Rooms VALUES (@roomType, @roomPrice, @roomCapacity, @description)";

                frmLogIn.comm = new SqlCommand(sql_InsertData, frmLogIn.conn);
                
                frmLogIn.comm.Parameters.AddWithValue("@roomType", RoomType );
                frmLogIn.comm.Parameters.AddWithValue("@roomPrice", roomPrice);
                frmLogIn.comm.Parameters.AddWithValue("@roomCapacity", roomCap);
                frmLogIn.comm.Parameters.AddWithValue("@description", roomDescr);

                frmLogIn.comm.ExecuteNonQuery();

                MessageBox.Show("Room is successfully added!");

                displayRooms();

                frmLogIn.conn.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.ToString());
            }

        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {   
                
                if(string.IsNullOrEmpty(deleteRoom.Text))
                {
                    MessageBox.Show("Please enter room id");
                }
                else
                {
                    if (frmLogIn.conn.State == ConnectionState.Closed)
                    {
                        frmLogIn.conn.Open();
                    }

                    string removeRoom = "DELETE FROM Rooms WHERE Room_ID = '" + deleteRoom.Text + "'";

                    frmLogIn.comm = new SqlCommand(removeRoom, frmLogIn.conn);
                    frmLogIn.adap = new SqlDataAdapter();
                    frmLogIn.adap.DeleteCommand = frmLogIn.comm;
                    frmLogIn.adap.DeleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Room is succesfully removed.");

                    deleteRoom.Text = " ";

                    displayRooms();
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogIn.conn = new SqlConnection(frmLogIn.ConnectionString);

                //frmLogIn.conn.Open();
               // int RoomCapacity = ;


                if (txtRoomIDRemove.Text != "")
                {
                    int RoomID = int.Parse(txtRoomIDRemove.Text);
                    
                    if (cbRoomType.Checked == true)
                    {
                        frmLogIn.conn.Open();

                        string update = $"UPDATE Rooms SET Room_Type = @roomType WHERE Room_ID = @roomID";
                        
                        frmLogIn.comm = new SqlCommand(update, frmLogIn.conn);
                        frmLogIn.comm.Parameters.AddWithValue("@roomType", txtUpdateType.Text);
                        frmLogIn.comm.Parameters.AddWithValue("@roomID", RoomID);
                        frmLogIn.comm.ExecuteNonQuery();
                        frmLogIn.conn.Close();
                        
                    }
                    if (cbUpdatePrice.Checked == true)
                    {
                        frmLogIn.conn.Open();
                        string update = "UPDATE Rooms SET Room_Price = @roomPrice WHERE Room_ID = @roomID";
                        frmLogIn.comm = new SqlCommand(update, frmLogIn.conn);
                        frmLogIn.comm.Parameters.AddWithValue("@roomPrice", txtUpdatePrice.Text);
                        frmLogIn.comm.Parameters.AddWithValue("@roomID", RoomID);
                        frmLogIn.comm.ExecuteNonQuery();
                        frmLogIn.conn.Close();
                    }
                    if (cbUpdateDescr.Checked == true)
                    {

                        frmLogIn.conn.Open();
                        string update = "UPDATE Rooms SET Description = @descr WHERE Room_ID = @roomID";
                        frmLogIn.comm = new SqlCommand(update, frmLogIn.conn);
                        frmLogIn.comm.Parameters.AddWithValue("@descr", txtUpdateDescr.Text);
                        frmLogIn.comm.Parameters.AddWithValue("@roomID", RoomID);
                        frmLogIn.comm.ExecuteNonQuery();
                        frmLogIn.conn.Close();
                    }
                    if (cbUpdateCapacity.Checked == true)
                    {
                        frmLogIn.conn.Open();
                        string update = "UPDATE Rooms SET Room_Capacity = @capacity WHERE Room_ID = @roomID";
                        frmLogIn.comm = new SqlCommand(update, frmLogIn.conn);
                        frmLogIn.comm.Parameters.AddWithValue("@capacity", int.Parse(cmbUpdateCapacity.SelectedItem.ToString()));
                        frmLogIn.comm.Parameters.AddWithValue("@roomID", RoomID);
                        frmLogIn.comm.ExecuteNonQuery();
                        frmLogIn.conn.Close();
                    }

                    MessageBox.Show("Room details changed");
                    displayRooms();
                 
                }
                else
                {
                    MessageBox.Show("Provide the room_ID to make changes");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbRoomType_CheckedChanged(object sender, EventArgs e)
        {
            lblRoomType.Enabled = true;
            txtUpdateType.Enabled = true;
        }

        private void cbUpdatePrice_CheckedChanged(object sender, EventArgs e)
        {
            lblRoomPrice.Enabled = true;
            txtUpdatePrice.Enabled = true;
        }

        private void cbUpdateDescr_CheckedChanged(object sender, EventArgs e)
        {
            lblDescr.Enabled = true;
            txtUpdateDescr.Enabled = true;
        }

        private void cbUpdateCapacity_CheckedChanged(object sender, EventArgs e)
        {
            lblCapacity.Enabled = true;
            cmbUpdateCapacity.Enabled = true;
        }
    }

        
    }

