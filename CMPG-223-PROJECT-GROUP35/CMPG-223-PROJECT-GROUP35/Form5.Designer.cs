
namespace CMPG_223_PROJECT_GROUP35
{
    partial class FormBookings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.gbAppointment = new System.Windows.Forms.GroupBox();
            this.gbBookDateTime = new System.Windows.Forms.GroupBox();
            this.datePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCheckTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbtnAnotherTime = new System.Windows.Forms.RadioButton();
            this.rdbtnNow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReceptionistID = new System.Windows.Forms.TextBox();
            this.lblReceiptionist = new System.Windows.Forms.Label();
            this.displayGuest = new System.Windows.Forms.DataGridView();
            this.guestID = new System.Windows.Forms.Label();
            this.txtGuestId = new System.Windows.Forms.TextBox();
            this.btnSearchGuest = new System.Windows.Forms.Button();
            this.txtSearchGuest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.roomID = new System.Windows.Forms.Label();
            this.numericUDcap = new System.Windows.Forms.NumericUpDown();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.displayCheckin = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimeChckInMan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCheckInTimeMan = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.gbDateTime = new System.Windows.Forms.GroupBox();
            this.dateTimePickerChkOut = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTransaction = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCheckOutTime = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cancelBookingID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbAppointment.SuspendLayout();
            this.gbBookDateTime.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayGuest)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDcap)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayCheckin)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.gbDateTime.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(24, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1401, 960);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConfirmBooking);
            this.tabPage1.Controls.Add(this.gbAppointment);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1393, 927);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Make A Booking";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(804, 731);
            this.btnConfirmBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(195, 84);
            this.btnConfirmBooking.TabIndex = 14;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // gbAppointment
            // 
            this.gbAppointment.Controls.Add(this.gbBookDateTime);
            this.gbAppointment.Controls.Add(this.label12);
            this.gbAppointment.Controls.Add(this.rdbtnAnotherTime);
            this.gbAppointment.Controls.Add(this.rdbtnNow);
            this.gbAppointment.Location = new System.Drawing.Point(376, 401);
            this.gbAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAppointment.Name = "gbAppointment";
            this.gbAppointment.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAppointment.Size = new System.Drawing.Size(389, 414);
            this.gbAppointment.TabIndex = 12;
            this.gbAppointment.TabStop = false;
            this.gbAppointment.Text = "Appointment";
            // 
            // gbBookDateTime
            // 
            this.gbBookDateTime.Controls.Add(this.datePickerCheckIn);
            this.gbBookDateTime.Controls.Add(this.lblDate);
            this.gbBookDateTime.Controls.Add(this.txtCheckTime);
            this.gbBookDateTime.Controls.Add(this.lblTime);
            this.gbBookDateTime.Location = new System.Drawing.Point(16, 159);
            this.gbBookDateTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBookDateTime.Name = "gbBookDateTime";
            this.gbBookDateTime.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBookDateTime.Size = new System.Drawing.Size(331, 226);
            this.gbBookDateTime.TabIndex = 15;
            this.gbBookDateTime.TabStop = false;
            this.gbBookDateTime.Text = "DATE/TIME";
            // 
            // datePickerCheckIn
            // 
            this.datePickerCheckIn.Location = new System.Drawing.Point(24, 74);
            this.datePickerCheckIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datePickerCheckIn.Name = "datePickerCheckIn";
            this.datePickerCheckIn.Size = new System.Drawing.Size(281, 26);
            this.datePickerCheckIn.TabIndex = 16;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(20, 46);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 20);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date:";
            // 
            // txtCheckTime
            // 
            this.txtCheckTime.Location = new System.Drawing.Point(24, 140);
            this.txtCheckTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCheckTime.Name = "txtCheckTime";
            this.txtCheckTime.Size = new System.Drawing.Size(173, 26);
            this.txtCheckTime.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(20, 116);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 20);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "When do you want to check in?";
            // 
            // rdbtnAnotherTime
            // 
            this.rdbtnAnotherTime.AutoSize = true;
            this.rdbtnAnotherTime.Location = new System.Drawing.Point(24, 96);
            this.rdbtnAnotherTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnAnotherTime.Name = "rdbtnAnotherTime";
            this.rdbtnAnotherTime.Size = new System.Drawing.Size(129, 24);
            this.rdbtnAnotherTime.TabIndex = 13;
            this.rdbtnAnotherTime.TabStop = true;
            this.rdbtnAnotherTime.Text = "Another Time";
            this.rdbtnAnotherTime.UseVisualStyleBackColor = true;
            this.rdbtnAnotherTime.CheckedChanged += new System.EventHandler(this.rdbtnAnotherTime_CheckedChanged);
            // 
            // rdbtnNow
            // 
            this.rdbtnNow.AutoSize = true;
            this.rdbtnNow.Location = new System.Drawing.Point(24, 62);
            this.rdbtnNow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtnNow.Name = "rdbtnNow";
            this.rdbtnNow.Size = new System.Drawing.Size(65, 24);
            this.rdbtnNow.TabIndex = 12;
            this.rdbtnNow.TabStop = true;
            this.rdbtnNow.Text = "Now";
            this.rdbtnNow.UseVisualStyleBackColor = true;
            this.rdbtnNow.CheckedChanged += new System.EventHandler(this.rdbtnNow_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReceptionistID);
            this.groupBox1.Controls.Add(this.lblReceiptionist);
            this.groupBox1.Controls.Add(this.displayGuest);
            this.groupBox1.Controls.Add(this.guestID);
            this.groupBox1.Controls.Add(this.txtGuestId);
            this.groupBox1.Controls.Add(this.btnSearchGuest);
            this.groupBox1.Controls.Add(this.txtSearchGuest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(181, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1096, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guest";
            // 
            // txtReceptionistID
            // 
            this.txtReceptionistID.Location = new System.Drawing.Point(165, 262);
            this.txtReceptionistID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReceptionistID.Name = "txtReceptionistID";
            this.txtReceptionistID.Size = new System.Drawing.Size(84, 26);
            this.txtReceptionistID.TabIndex = 16;
            // 
            // lblReceiptionist
            // 
            this.lblReceiptionist.AutoSize = true;
            this.lblReceiptionist.Location = new System.Drawing.Point(22, 268);
            this.lblReceiptionist.Name = "lblReceiptionist";
            this.lblReceiptionist.Size = new System.Drawing.Size(126, 20);
            this.lblReceiptionist.TabIndex = 9;
            this.lblReceiptionist.Text = "Receiptionist ID:";
            // 
            // displayGuest
            // 
            this.displayGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayGuest.Location = new System.Drawing.Point(26, 69);
            this.displayGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayGuest.Name = "displayGuest";
            this.displayGuest.RowHeadersWidth = 62;
            this.displayGuest.RowTemplate.Height = 28;
            this.displayGuest.Size = new System.Drawing.Size(1053, 170);
            this.displayGuest.TabIndex = 8;
            // 
            // guestID
            // 
            this.guestID.AutoSize = true;
            this.guestID.Location = new System.Drawing.Point(373, 268);
            this.guestID.Name = "guestID";
            this.guestID.Size = new System.Drawing.Size(78, 20);
            this.guestID.TabIndex = 7;
            this.guestID.Text = "Guest ID:";
            // 
            // txtGuestId
            // 
            this.txtGuestId.Location = new System.Drawing.Point(457, 262);
            this.txtGuestId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGuestId.Name = "txtGuestId";
            this.txtGuestId.Size = new System.Drawing.Size(84, 26);
            this.txtGuestId.TabIndex = 6;
            // 
            // btnSearchGuest
            // 
            this.btnSearchGuest.Location = new System.Drawing.Point(548, 36);
            this.btnSearchGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchGuest.Name = "btnSearchGuest";
            this.btnSearchGuest.Size = new System.Drawing.Size(75, 28);
            this.btnSearchGuest.TabIndex = 2;
            this.btnSearchGuest.Text = "Search";
            this.btnSearchGuest.UseVisualStyleBackColor = true;
            this.btnSearchGuest.Click += new System.EventHandler(this.btnSearchGuest_Click);
            // 
            // txtSearchGuest
            // 
            this.txtSearchGuest.Location = new System.Drawing.Point(176, 36);
            this.txtSearchGuest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchGuest.Name = "txtSearchGuest";
            this.txtSearchGuest.Size = new System.Drawing.Size(365, 26);
            this.txtSearchGuest.TabIndex = 1;
            this.txtSearchGuest.TextChanged += new System.EventHandler(this.txtSearchGuest_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search For Guest:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRoomID);
            this.groupBox2.Controls.Add(this.roomID);
            this.groupBox2.Controls.Add(this.numericUDcap);
            this.groupBox2.Controls.Add(this.cmbRoomType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(789, 401);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(247, 282);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room Type";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(108, 230);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(102, 26);
            this.txtRoomID.TabIndex = 15;
            // 
            // roomID
            // 
            this.roomID.AutoSize = true;
            this.roomID.Location = new System.Drawing.Point(16, 233);
            this.roomID.Name = "roomID";
            this.roomID.Size = new System.Drawing.Size(77, 20);
            this.roomID.TabIndex = 11;
            this.roomID.Text = "Room ID:";
            // 
            // numericUDcap
            // 
            this.numericUDcap.Location = new System.Drawing.Point(20, 171);
            this.numericUDcap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUDcap.Name = "numericUDcap";
            this.numericUDcap.Size = new System.Drawing.Size(190, 26);
            this.numericUDcap.TabIndex = 10;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Single Standard",
            "Double Standard",
            "Twin Room",
            "Deluxe King",
            "Family Suite",
            "Executive Suite",
            "Honeymoon Suite",
            "Suite",
            "Family Room"});
            this.cmbRoomType.Location = new System.Drawing.Point(20, 80);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(190, 28);
            this.cmbRoomType.TabIndex = 7;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Capacity";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1393, 927);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check In";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.displayCheckin);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnCheckIn);
            this.groupBox4.Controls.Add(this.btnSearchID);
            this.groupBox4.Controls.Add(this.txtBookingID);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(222, 65);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(998, 779);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Check In";
            // 
            // displayCheckin
            // 
            this.displayCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayCheckin.Location = new System.Drawing.Point(54, 95);
            this.displayCheckin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayCheckin.Name = "displayCheckin";
            this.displayCheckin.RowHeadersWidth = 62;
            this.displayCheckin.RowTemplate.Height = 28;
            this.displayCheckin.Size = new System.Drawing.Size(885, 220);
            this.displayCheckin.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimeChckInMan);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtCheckInTimeMan);
            this.groupBox5.Location = new System.Drawing.Point(54, 346);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(903, 227);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date and Time";
            // 
            // dateTimeChckInMan
            // 
            this.dateTimeChckInMan.Location = new System.Drawing.Point(26, 65);
            this.dateTimeChckInMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeChckInMan.Name = "dateTimeChckInMan";
            this.dateTimeChckInMan.Size = new System.Drawing.Size(281, 26);
            this.dateTimeChckInMan.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, -70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date:";
            // 
            // txtCheckInTimeMan
            // 
            this.txtCheckInTimeMan.Location = new System.Drawing.Point(27, 152);
            this.txtCheckInTimeMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCheckInTimeMan.Name = "txtCheckInTimeMan";
            this.txtCheckInTimeMan.Size = new System.Drawing.Size(173, 26);
            this.txtCheckInTimeMan.TabIndex = 13;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(54, 581);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(903, 70);
            this.btnCheckIn.TabIndex = 4;
            this.btnCheckIn.Text = "Check In Guest";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(831, 34);
            this.btnSearchID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(108, 36);
            this.btnSearchID.TabIndex = 2;
            this.btnSearchID.Text = "Search";
            this.btnSearchID.UseVisualStyleBackColor = true;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(230, 39);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(595, 26);
            this.txtBookingID.TabIndex = 1;
            this.txtBookingID.TextChanged += new System.EventHandler(this.txtSearchID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search For Booking ID:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(1393, 927);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Check Out";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridViewBookings);
            this.groupBox6.Controls.Add(this.gbDateTime);
            this.groupBox6.Controls.Add(this.btnCheckout);
            this.groupBox6.Controls.Add(this.btnSearch);
            this.groupBox6.Controls.Add(this.txtSearch);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(189, 58);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(1014, 808);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Guest";
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(53, 89);
            this.dataGridViewBookings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.RowHeadersWidth = 62;
            this.dataGridViewBookings.RowTemplate.Height = 28;
            this.dataGridViewBookings.Size = new System.Drawing.Size(867, 210);
            this.dataGridViewBookings.TabIndex = 8;
            // 
            // gbDateTime
            // 
            this.gbDateTime.Controls.Add(this.dateTimePickerChkOut);
            this.gbDateTime.Controls.Add(this.label5);
            this.gbDateTime.Controls.Add(this.comboTransaction);
            this.gbDateTime.Controls.Add(this.label13);
            this.gbDateTime.Controls.Add(this.label9);
            this.gbDateTime.Controls.Add(this.label10);
            this.gbDateTime.Controls.Add(this.txtCheckOutTime);
            this.gbDateTime.Location = new System.Drawing.Point(53, 325);
            this.gbDateTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDateTime.Name = "gbDateTime";
            this.gbDateTime.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDateTime.Size = new System.Drawing.Size(853, 310);
            this.gbDateTime.TabIndex = 2;
            this.gbDateTime.TabStop = false;
            this.gbDateTime.Text = "Date & Time";
            // 
            // dateTimePickerChkOut
            // 
            this.dateTimePickerChkOut.Location = new System.Drawing.Point(36, 82);
            this.dateTimePickerChkOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerChkOut.Name = "dateTimePickerChkOut";
            this.dateTimePickerChkOut.Size = new System.Drawing.Size(281, 26);
            this.dateTimePickerChkOut.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date:";
            // 
            // comboTransaction
            // 
            this.comboTransaction.FormattingEnabled = true;
            this.comboTransaction.Location = new System.Drawing.Point(36, 246);
            this.comboTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTransaction.Name = "comboTransaction";
            this.comboTransaction.Size = new System.Drawing.Size(173, 28);
            this.comboTransaction.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Transaction Method:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, -70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Date:";
            // 
            // txtCheckOutTime
            // 
            this.txtCheckOutTime.Location = new System.Drawing.Point(37, 162);
            this.txtCheckOutTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCheckOutTime.Name = "txtCheckOutTime";
            this.txtCheckOutTime.Size = new System.Drawing.Size(173, 26);
            this.txtCheckOutTime.TabIndex = 13;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(54, 663);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(852, 70);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Check Out Guest";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(831, 34);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(230, 39);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(595, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Search For Booking ID:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(1393, 927);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cancel a Booking";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelBooking);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cancelBookingID);
            this.groupBox3.Location = new System.Drawing.Point(98, 85);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(814, 162);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cancel a booking";
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(426, 73);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(193, 36);
            this.btnCancelBooking.TabIndex = 5;
            this.btnCancelBooking.Text = "Cancel the booking";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(135, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Booking ID:";
            // 
            // cancelBookingID
            // 
            this.cancelBookingID.Location = new System.Drawing.Point(238, 78);
            this.cancelBookingID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBookingID.Name = "cancelBookingID";
            this.cancelBookingID.Size = new System.Drawing.Size(165, 26);
            this.cancelBookingID.TabIndex = 3;
            // 
            // FormBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 1002);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBookings";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.FormBookings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbAppointment.ResumeLayout(false);
            this.gbAppointment.PerformLayout();
            this.gbBookDateTime.ResumeLayout(false);
            this.gbBookDateTime.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayGuest)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDcap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayCheckin)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.gbDateTime.ResumeLayout(false);
            this.gbDateTime.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchGuest;
        private System.Windows.Forms.TextBox txtSearchGuest;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.GroupBox gbAppointment;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUDcap;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtCheckTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbtnAnotherTime;
        private System.Windows.Forms.RadioButton rdbtnNow;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCheckInTimeMan;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox gbDateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCheckOutTime;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label guestID;
        private System.Windows.Forms.TextBox txtGuestId;
        private System.Windows.Forms.GroupBox gbBookDateTime;
        private System.Windows.Forms.DataGridView displayGuest;
        private System.Windows.Forms.Label roomID;
        private System.Windows.Forms.Label lblReceiptionist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.DataGridView displayCheckin;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.ComboBox comboTransaction;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cancelBookingID;
        private System.Windows.Forms.DateTimePicker datePickerCheckIn;
        private System.Windows.Forms.DateTimePicker dateTimeChckInMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerChkOut;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.TextBox txtReceptionistID;
    }
}