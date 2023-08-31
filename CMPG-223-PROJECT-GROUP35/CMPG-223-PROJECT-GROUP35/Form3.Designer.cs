
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
            this.txtUpdateSearch = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.deleteRoom = new System.Windows.Forms.TextBox();
            this.tabGuests.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GBchange.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGuests
            // 
            this.tabGuests.Controls.Add(this.tabPage1);
            this.tabGuests.Controls.Add(this.tabPage2);
            this.tabGuests.Controls.Add(this.tabPage3);
            this.tabGuests.Location = new System.Drawing.Point(8, 8);
            this.tabGuests.Margin = new System.Windows.Forms.Padding(2);
            this.tabGuests.Name = "tabGuests";
            this.tabGuests.SelectedIndex = 0;
            this.tabGuests.Size = new System.Drawing.Size(1028, 626);
            this.tabGuests.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1020, 600);
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
            this.groupBox1.Location = new System.Drawing.Point(35, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 407);
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
            this.cmbCapacity.Location = new System.Drawing.Point(28, 199);
            this.cmbCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCapacity.Name = "cmbCapacity";
            this.cmbCapacity.Size = new System.Drawing.Size(92, 24);
            this.cmbCapacity.TabIndex = 11;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(73, 322);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(210, 43);
            this.btnAddRoom.TabIndex = 10;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtRoomDescr
            // 
            this.txtRoomDescr.Location = new System.Drawing.Point(28, 269);
            this.txtRoomDescr.Name = "txtRoomDescr";
            this.txtRoomDescr.Size = new System.Drawing.Size(294, 23);
            this.txtRoomDescr.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Room Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "How many people can this room accomodate?:";
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Location = new System.Drawing.Point(28, 128);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(284, 23);
            this.txtRoomPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Price";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(29, 65);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(155, 23);
            this.txtRoomType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Type";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1020, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Room Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Controls.Add(this.txtUpdateSearch);
            this.groupBox2.Location = new System.Drawing.Point(24, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(602, 474);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Room Details";
            // 
            // txtUpdateDescr
            // 
            this.txtUpdateDescr.Location = new System.Drawing.Point(311, 324);
            this.txtUpdateDescr.Name = "txtUpdateDescr";
            this.txtUpdateDescr.Size = new System.Drawing.Size(198, 20);
            this.txtUpdateDescr.TabIndex = 21;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Location = new System.Drawing.Point(308, 298);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(91, 13);
            this.lblDescr.TabIndex = 20;
            this.lblDescr.Text = "Room Description";
            // 
            // cmbUpdateCapacity
            // 
            this.cmbUpdateCapacity.FormattingEnabled = true;
            this.cmbUpdateCapacity.Location = new System.Drawing.Point(313, 257);
            this.cmbUpdateCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUpdateCapacity.Name = "cmbUpdateCapacity";
            this.cmbUpdateCapacity.Size = new System.Drawing.Size(86, 21);
            this.cmbUpdateCapacity.TabIndex = 19;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(310, 227);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(229, 13);
            this.lblCapacity.TabIndex = 18;
            this.lblCapacity.Text = "How many people can this room accomodate?:";
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(313, 185);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(260, 20);
            this.txtUpdatePrice.TabIndex = 17;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Location = new System.Drawing.Point(310, 160);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(62, 13);
            this.lblRoomPrice.TabIndex = 16;
            this.lblRoomPrice.Text = "Room Price";
            // 
            // txtUpdateType
            // 
            this.txtUpdateType.Location = new System.Drawing.Point(313, 124);
            this.txtUpdateType.Name = "txtUpdateType";
            this.txtUpdateType.Size = new System.Drawing.Size(224, 20);
            this.txtUpdateType.TabIndex = 15;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(310, 106);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(62, 13);
            this.lblRoomType.TabIndex = 14;
            this.lblRoomType.Text = "Room Type";
            // 
            // GBchange
            // 
            this.GBchange.Controls.Add(this.cbUpdateDescr);
            this.GBchange.Controls.Add(this.cbUpdateCapacity);
            this.GBchange.Controls.Add(this.cbUpdatePrice);
            this.GBchange.Controls.Add(this.cbRoomType);
            this.GBchange.Location = new System.Drawing.Point(51, 106);
            this.GBchange.Margin = new System.Windows.Forms.Padding(2);
            this.GBchange.Name = "GBchange";
            this.GBchange.Padding = new System.Windows.Forms.Padding(2);
            this.GBchange.Size = new System.Drawing.Size(243, 222);
            this.GBchange.TabIndex = 3;
            this.GBchange.TabStop = false;
            this.GBchange.Text = "What Do You Want To Change";
            // 
            // cbUpdateDescr
            // 
            this.cbUpdateDescr.AutoSize = true;
            this.cbUpdateDescr.Location = new System.Drawing.Point(20, 150);
            this.cbUpdateDescr.Margin = new System.Windows.Forms.Padding(2);
            this.cbUpdateDescr.Name = "cbUpdateDescr";
            this.cbUpdateDescr.Size = new System.Drawing.Size(110, 17);
            this.cbUpdateDescr.TabIndex = 3;
            this.cbUpdateDescr.Text = "Room Description";
            this.cbUpdateDescr.UseVisualStyleBackColor = true;
            // 
            // cbUpdateCapacity
            // 
            this.cbUpdateCapacity.AutoSize = true;
            this.cbUpdateCapacity.Location = new System.Drawing.Point(20, 117);
            this.cbUpdateCapacity.Margin = new System.Windows.Forms.Padding(2);
            this.cbUpdateCapacity.Name = "cbUpdateCapacity";
            this.cbUpdateCapacity.Size = new System.Drawing.Size(98, 17);
            this.cbUpdateCapacity.TabIndex = 2;
            this.cbUpdateCapacity.Text = "Room Capacity";
            this.cbUpdateCapacity.UseVisualStyleBackColor = true;
            this.cbUpdateCapacity.CheckedChanged += new System.EventHandler(this.cbUpdateCapacity_CheckedChanged);
            // 
            // cbUpdatePrice
            // 
            this.cbUpdatePrice.AutoSize = true;
            this.cbUpdatePrice.Location = new System.Drawing.Point(20, 81);
            this.cbUpdatePrice.Margin = new System.Windows.Forms.Padding(2);
            this.cbUpdatePrice.Name = "cbUpdatePrice";
            this.cbUpdatePrice.Size = new System.Drawing.Size(81, 17);
            this.cbUpdatePrice.TabIndex = 1;
            this.cbUpdatePrice.Text = "Room Price";
            this.cbUpdatePrice.UseVisualStyleBackColor = true;
            this.cbUpdatePrice.CheckedChanged += new System.EventHandler(this.cbUpdatePrice_CheckedChanged);
            // 
            // cbRoomType
            // 
            this.cbRoomType.AutoSize = true;
            this.cbRoomType.Location = new System.Drawing.Point(20, 43);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(81, 17);
            this.cbRoomType.TabIndex = 0;
            this.cbRoomType.Text = "Room Type";
            this.cbRoomType.UseVisualStyleBackColor = true;
            this.cbRoomType.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Location = new System.Drawing.Point(472, 42);
            this.btnChangeInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(100, 28);
            this.btnChangeInfo.TabIndex = 2;
            this.btnChangeInfo.Text = "Change Info";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Room ID:";
            // 
            // txtUpdateSearch
            // 
            this.txtUpdateSearch.Location = new System.Drawing.Point(152, 47);
            this.txtUpdateSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateSearch.Name = "txtUpdateSearch";
            this.txtUpdateSearch.Size = new System.Drawing.Size(254, 20);
            this.txtUpdateSearch.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1020, 600);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Remove Room";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRemoveRoom);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.deleteRoom);
            this.groupBox4.Location = new System.Drawing.Point(56, 64);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(566, 130);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Remove Rooms";
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Location = new System.Drawing.Point(441, 39);
            this.btnRemoveRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveRoom.TabIndex = 5;
            this.btnRemoveRoom.Text = "Remove Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 48);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Room ID:";
            // 
            // deleteRoom
            // 
            this.deleteRoom.Location = new System.Drawing.Point(121, 44);
            this.deleteRoom.Margin = new System.Windows.Forms.Padding(2);
            this.deleteRoom.Name = "deleteRoom";
            this.deleteRoom.Size = new System.Drawing.Size(254, 20);
            this.deleteRoom.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.tabGuests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtUpdateSearch;
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
    }
}