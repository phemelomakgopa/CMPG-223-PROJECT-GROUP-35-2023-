
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
            this.roomPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabGuests.Location = new System.Drawing.Point(11, 10);
            this.tabGuests.Name = "tabGuests";
            this.tabGuests.SelectedIndex = 0;
            this.tabGuests.Size = new System.Drawing.Size(1371, 770);
            this.tabGuests.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1363, 741);
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
            this.groupBox1.Controls.Add(this.roomPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRoomType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRoomNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(479, 501);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Room";
            // 
            // cmbCapacity
            // 
            this.cmbCapacity.FormattingEnabled = true;
            this.cmbCapacity.Location = new System.Drawing.Point(38, 245);
            this.cmbCapacity.Name = "cmbCapacity";
            this.cmbCapacity.Size = new System.Drawing.Size(121, 28);
            this.cmbCapacity.TabIndex = 11;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(97, 396);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(280, 53);
            this.btnAddRoom.TabIndex = 10;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtRoomDescr
            // 
            this.txtRoomDescr.Location = new System.Drawing.Point(37, 331);
            this.txtRoomDescr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomDescr.Name = "txtRoomDescr";
            this.txtRoomDescr.Size = new System.Drawing.Size(391, 26);
            this.txtRoomDescr.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Room Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "How many people can this room accomodate?:";
            // 
            // roomPrice
            // 
            this.roomPrice.Location = new System.Drawing.Point(38, 157);
            this.roomPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomPrice.Name = "roomPrice";
            this.roomPrice.Size = new System.Drawing.Size(377, 26);
            this.roomPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Price";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(207, 73);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(208, 26);
            this.txtRoomType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Type";
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Location = new System.Drawing.Point(37, 73);
            this.txtRoomNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(160, 26);
            this.txtRoomNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Number";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1363, 741);
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
            this.groupBox2.Location = new System.Drawing.Point(32, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 583);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Room Details";
            // 
            // txtUpdateDescr
            // 
            this.txtUpdateDescr.Location = new System.Drawing.Point(415, 399);
            this.txtUpdateDescr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdateDescr.Name = "txtUpdateDescr";
            this.txtUpdateDescr.Size = new System.Drawing.Size(263, 22);
            this.txtUpdateDescr.TabIndex = 21;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Location = new System.Drawing.Point(411, 367);
            this.lblDescr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(115, 16);
            this.lblDescr.TabIndex = 20;
            this.lblDescr.Text = "Room Description";
            // 
            // cmbUpdateCapacity
            // 
            this.cmbUpdateCapacity.FormattingEnabled = true;
            this.cmbUpdateCapacity.Location = new System.Drawing.Point(417, 316);
            this.cmbUpdateCapacity.Name = "cmbUpdateCapacity";
            this.cmbUpdateCapacity.Size = new System.Drawing.Size(114, 24);
            this.cmbUpdateCapacity.TabIndex = 19;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(413, 279);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(287, 16);
            this.lblCapacity.TabIndex = 18;
            this.lblCapacity.Text = "How many people can this room accomodate?:";
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(417, 228);
            this.txtUpdatePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(345, 22);
            this.txtUpdatePrice.TabIndex = 17;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Location = new System.Drawing.Point(413, 197);
            this.lblRoomPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(78, 16);
            this.lblRoomPrice.TabIndex = 16;
            this.lblRoomPrice.Text = "Room Price";
            // 
            // txtUpdateType
            // 
            this.txtUpdateType.Location = new System.Drawing.Point(417, 152);
            this.txtUpdateType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpdateType.Name = "txtUpdateType";
            this.txtUpdateType.Size = new System.Drawing.Size(298, 22);
            this.txtUpdateType.TabIndex = 15;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(413, 131);
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
            this.GBchange.Location = new System.Drawing.Point(68, 131);
            this.GBchange.Name = "GBchange";
            this.GBchange.Size = new System.Drawing.Size(324, 273);
            this.GBchange.TabIndex = 3;
            this.GBchange.TabStop = false;
            this.GBchange.Text = "What Do You Want To Change";
            // 
            // cbUpdateDescr
            // 
            this.cbUpdateDescr.AutoSize = true;
            this.cbUpdateDescr.Location = new System.Drawing.Point(27, 185);
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
            this.cbUpdateCapacity.Name = "cbUpdateCapacity";
            this.cbUpdateCapacity.Size = new System.Drawing.Size(122, 20);
            this.cbUpdateCapacity.TabIndex = 2;
            this.cbUpdateCapacity.Text = "Room Capacity";
            this.cbUpdateCapacity.UseVisualStyleBackColor = true;
            this.cbUpdateCapacity.CheckedChanged += new System.EventHandler(this.cbUpdateCapacity_CheckedChanged);
            // 
            // cbUpdatePrice
            // 
            this.cbUpdatePrice.AutoSize = true;
            this.cbUpdatePrice.Location = new System.Drawing.Point(27, 100);
            this.cbUpdatePrice.Name = "cbUpdatePrice";
            this.cbUpdatePrice.Size = new System.Drawing.Size(100, 20);
            this.cbUpdatePrice.TabIndex = 1;
            this.cbUpdatePrice.Text = "Room Price";
            this.cbUpdatePrice.UseVisualStyleBackColor = true;
            this.cbUpdatePrice.CheckedChanged += new System.EventHandler(this.cbUpdatePrice_CheckedChanged);
            // 
            // cbRoomType
            // 
            this.cbRoomType.AutoSize = true;
            this.cbRoomType.Location = new System.Drawing.Point(27, 53);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(101, 20);
            this.cbRoomType.TabIndex = 0;
            this.cbRoomType.Text = "Room Type";
            this.cbRoomType.UseVisualStyleBackColor = true;
            this.cbRoomType.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Location = new System.Drawing.Point(629, 52);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(133, 35);
            this.btnChangeInfo.TabIndex = 2;
            this.btnChangeInfo.Text = "Change Info";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Room ID:";
            // 
            // txtUpdateSearch
            // 
            this.txtUpdateSearch.Location = new System.Drawing.Point(202, 58);
            this.txtUpdateSearch.Name = "txtUpdateSearch";
            this.txtUpdateSearch.Size = new System.Drawing.Size(338, 22);
            this.txtUpdateSearch.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(1363, 741);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Remove Room";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRemoveRoom);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.deleteRoom);
            this.groupBox4.Location = new System.Drawing.Point(74, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(755, 160);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Remove Rooms";
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Location = new System.Drawing.Point(588, 48);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(133, 35);
            this.btnRemoveRoom.TabIndex = 5;
            this.btnRemoveRoom.Text = "Remove Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Room ID:";
            // 
            // deleteRoom
            // 
            this.deleteRoom.Location = new System.Drawing.Point(161, 54);
            this.deleteRoom.Name = "deleteRoom";
            this.deleteRoom.Size = new System.Drawing.Size(338, 22);
            this.deleteRoom.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 837);
            this.Controls.Add(this.tabGuests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox roomPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label label1;
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