
namespace CMPG_223_PROJECT_GROUP35
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabGuests = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCapacity = new System.Windows.Forms.ComboBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.txtRoomDescr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUpdateDescr = new System.Windows.Forms.TextBox();
            this.lblDescr = new System.Windows.Forms.Label();
            this.cmbUpdateCapacity = new System.Windows.Forms.ComboBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.txtUpdateType = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.GBchange = new System.Windows.Forms.GroupBox();
            this.cbUpdateDescr = new System.Windows.Forms.CheckBox();
            this.cbUpdateCapacity = new System.Windows.Forms.CheckBox();
            this.cbUpdatePrice = new System.Windows.Forms.CheckBox();
            this.cbRoomType = new System.Windows.Forms.CheckBox();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoomIDRemove = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.deleteRoom = new System.Windows.Forms.TextBox();
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.changedRooms = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addedRooms = new System.Windows.Forms.DataGridView();
            this.tabGuests.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GBchange.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changedRooms)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addedRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGuests
            // 
            this.tabGuests.Controls.Add(this.tabPage1);
            this.tabGuests.Controls.Add(this.tabPage2);
            this.tabGuests.Controls.Add(this.tabPage3);
            this.tabGuests.Location = new System.Drawing.Point(77, 45);
            this.tabGuests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGuests.Name = "tabGuests";
            this.tabGuests.SelectedIndex = 0;
            this.tabGuests.Size = new System.Drawing.Size(1019, 703);
            this.tabGuests.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1011, 674);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Room";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCapacity);
            this.groupBox1.Controls.Add(this.btnAddRoom);
            this.groupBox1.Controls.Add(this.txtRoomDescr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRoomPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRoomType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(101, 368);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(838, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Room";
            // 
            // cmbCapacity
            // 
            this.cmbCapacity.FormattingEnabled = true;
            this.cmbCapacity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbCapacity.Location = new System.Drawing.Point(526, 48);
            this.cmbCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCapacity.Name = "cmbCapacity";
            this.cmbCapacity.Size = new System.Drawing.Size(121, 24);
            this.cmbCapacity.TabIndex = 11;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(485, 142);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(171, 70);
            this.btnAddRoom.TabIndex = 10;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtRoomDescr
            // 
            this.txtRoomDescr.Location = new System.Drawing.Point(29, 126);
            this.txtRoomDescr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomDescr.Multiline = true;
            this.txtRoomDescr.Name = "txtRoomDescr";
            this.txtRoomDescr.Size = new System.Drawing.Size(391, 86);
            this.txtRoomDescr.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Room Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "How many people can this room accomodate?:";
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Location = new System.Drawing.Point(331, 48);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(154, 23);
            this.txtRoomPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Price";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(30, 48);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(261, 23);
            this.txtRoomType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Type";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1011, 674);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Room Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.changedRooms);
            this.groupBox2.Controls.Add(this.txtUpdateDescr);
            this.groupBox2.Controls.Add(this.lblDescr);
            this.groupBox2.Controls.Add(this.cmbUpdateCapacity);
            this.groupBox2.Controls.Add(this.lblCapacity);
            this.groupBox2.Controls.Add(this.txtUpdatePrice);
            this.groupBox2.Controls.Add(this.lblRoomPrice);
            this.groupBox2.Controls.Add(this.txtUpdateType);
            this.groupBox2.Controls.Add(this.lblRoomType);
            this.groupBox2.Controls.Add(this.GBchange);
            this.groupBox2.Controls.Add(this.btnChangeInfo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRoomIDRemove);
            this.groupBox2.Location = new System.Drawing.Point(32, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(953, 630);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Room Details";
            // 
            // txtUpdateDescr
            // 
            this.txtUpdateDescr.Location = new System.Drawing.Point(407, 554);
            this.txtUpdateDescr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdateDescr.Multiline = true;
            this.txtUpdateDescr.Name = "txtUpdateDescr";
            this.txtUpdateDescr.Size = new System.Drawing.Size(299, 70);
            this.txtUpdateDescr.TabIndex = 21;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Location = new System.Drawing.Point(403, 522);
            this.lblDescr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(115, 16);
            this.lblDescr.TabIndex = 20;
            this.lblDescr.Text = "Room Description";
            // 
            // cmbUpdateCapacity
            // 
            this.cmbUpdateCapacity.FormattingEnabled = true;
            this.cmbUpdateCapacity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbUpdateCapacity.Location = new System.Drawing.Point(409, 471);
            this.cmbUpdateCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUpdateCapacity.Name = "cmbUpdateCapacity";
            this.cmbUpdateCapacity.Size = new System.Drawing.Size(113, 24);
            this.cmbUpdateCapacity.TabIndex = 19;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(405, 434);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(287, 16);
            this.lblCapacity.TabIndex = 18;
            this.lblCapacity.Text = "How many people can this room accomodate?:";
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(409, 383);
            this.txtUpdatePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(345, 22);
            this.txtUpdatePrice.TabIndex = 17;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Location = new System.Drawing.Point(405, 352);
            this.lblRoomPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(78, 16);
            this.lblRoomPrice.TabIndex = 16;
            this.lblRoomPrice.Text = "Room Price";
            // 
            // txtUpdateType
            // 
            this.txtUpdateType.Location = new System.Drawing.Point(409, 308);
            this.txtUpdateType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdateType.Name = "txtUpdateType";
            this.txtUpdateType.Size = new System.Drawing.Size(297, 22);
            this.txtUpdateType.TabIndex = 15;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(405, 285);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(79, 16);
            this.lblRoomType.TabIndex = 14;
            this.lblRoomType.Text = "Room Type";
            // 
            // GBchange
            // 
            this.GBchange.Controls.Add(this.cbUpdateDescr);
            this.GBchange.Controls.Add(this.cbUpdateCapacity);
            this.GBchange.Controls.Add(this.cbUpdatePrice);
            this.GBchange.Controls.Add(this.cbRoomType);
            this.GBchange.Location = new System.Drawing.Point(35, 348);
            this.GBchange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBchange.Name = "GBchange";
            this.GBchange.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GBchange.Size = new System.Drawing.Size(339, 278);
            this.GBchange.TabIndex = 3;
            this.GBchange.TabStop = false;
            this.GBchange.Text = "What Do You Want To Change";
            // 
            // cbUpdateDescr
            // 
            this.cbUpdateDescr.AutoSize = true;
            this.cbUpdateDescr.Location = new System.Drawing.Point(27, 185);
            this.cbUpdateDescr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUpdateDescr.Name = "cbUpdateDescr";
            this.cbUpdateDescr.Size = new System.Drawing.Size(137, 20);
            this.cbUpdateDescr.TabIndex = 3;
            this.cbUpdateDescr.Text = "Room Description";
            this.cbUpdateDescr.UseVisualStyleBackColor = true;
            // 
            // cbUpdateCapacity
            // 
            this.cbUpdateCapacity.AutoSize = true;
            this.cbUpdateCapacity.Location = new System.Drawing.Point(27, 144);
            this.cbUpdateCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUpdateCapacity.Name = "cbUpdateCapacity";
            this.cbUpdateCapacity.Size = new System.Drawing.Size(122, 20);
            this.cbUpdateCapacity.TabIndex = 2;
            this.cbUpdateCapacity.Text = "Room Capacity";
            this.cbUpdateCapacity.UseVisualStyleBackColor = true;
            // 
            // cbUpdatePrice
            // 
            this.cbUpdatePrice.AutoSize = true;
            this.cbUpdatePrice.Location = new System.Drawing.Point(27, 100);
            this.cbUpdatePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUpdatePrice.Name = "cbUpdatePrice";
            this.cbUpdatePrice.Size = new System.Drawing.Size(100, 20);
            this.cbUpdatePrice.TabIndex = 1;
            this.cbUpdatePrice.Text = "Room Price";
            this.cbUpdatePrice.UseVisualStyleBackColor = true;
            // 
            // cbRoomType
            // 
            this.cbRoomType.AutoSize = true;
            this.cbRoomType.Location = new System.Drawing.Point(27, 53);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(101, 20);
            this.cbRoomType.TabIndex = 0;
            this.cbRoomType.Text = "Room Type";
            this.cbRoomType.UseVisualStyleBackColor = true;
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Location = new System.Drawing.Point(781, 566);
            this.btnChangeInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(158, 58);
            this.btnChangeInfo.TabIndex = 2;
            this.btnChangeInfo.Text = "Change Info";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Room ID:";
            // 
            // txtRoomIDRemove
            // 
            this.txtRoomIDRemove.Location = new System.Drawing.Point(35, 308);
            this.txtRoomIDRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomIDRemove.Name = "txtRoomIDRemove";
            this.txtRoomIDRemove.Size = new System.Drawing.Size(104, 22);
            this.txtRoomIDRemove.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1011, 674);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Remove Room";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRemoveRoom);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.deleteRoom);
            this.groupBox4.Location = new System.Drawing.Point(18, 374);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(975, 134);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Remove Rooms";
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Location = new System.Drawing.Point(580, 58);
            this.btnRemoveRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(133, 34);
            this.btnRemoveRoom.TabIndex = 5;
            this.btnRemoveRoom.Text = "Remove Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Room ID:";
            // 
            // deleteRoom
            // 
            this.deleteRoom.Location = new System.Drawing.Point(290, 64);
            this.deleteRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteRoom.Name = "deleteRoom";
            this.deleteRoom.Size = new System.Drawing.Size(266, 22);
            this.deleteRoom.TabIndex = 3;
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGridView.Location = new System.Drawing.Point(17, 21);
            this.roomsDataGridView.Name = "roomsDataGridView";
            this.roomsDataGridView.RowHeadersWidth = 51;
            this.roomsDataGridView.RowTemplate.Height = 24;
            this.roomsDataGridView.Size = new System.Drawing.Size(952, 295);
            this.roomsDataGridView.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.roomsDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(18, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(975, 331);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Rooms";
            // 
            // changedRooms
            // 
            this.changedRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.changedRooms.Location = new System.Drawing.Point(35, 20);
            this.changedRooms.Name = "changedRooms";
            this.changedRooms.RowHeadersWidth = 51;
            this.changedRooms.RowTemplate.Height = 24;
            this.changedRooms.Size = new System.Drawing.Size(904, 235);
            this.changedRooms.TabIndex = 22;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.addedRooms);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(52, 32);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(927, 313);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "View Rooms";
            // 
            // addedRooms
            // 
            this.addedRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addedRooms.Location = new System.Drawing.Point(17, 21);
            this.addedRooms.Name = "addedRooms";
            this.addedRooms.RowHeadersWidth = 51;
            this.addedRooms.RowTemplate.Height = 24;
            this.addedRooms.Size = new System.Drawing.Size(895, 286);
            this.addedRooms.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 784);
            this.Controls.Add(this.tabGuests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabGuests.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GBchange.ResumeLayout(false);
            this.GBchange.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changedRooms)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addedRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGuests;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCapacity;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox txtRoomDescr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRoomIDRemove;
        private System.Windows.Forms.GroupBox GBchange;
        private System.Windows.Forms.CheckBox cbUpdateCapacity;
        private System.Windows.Forms.CheckBox cbUpdatePrice;
        private System.Windows.Forms.CheckBox cbRoomType;
        private System.Windows.Forms.TextBox txtUpdateDescr;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.ComboBox cmbUpdateCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.TextBox txtUpdateType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.CheckBox cbUpdateDescr;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRemoveRoom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox deleteRoom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private System.Windows.Forms.DataGridView changedRooms;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView addedRooms;
    }
}