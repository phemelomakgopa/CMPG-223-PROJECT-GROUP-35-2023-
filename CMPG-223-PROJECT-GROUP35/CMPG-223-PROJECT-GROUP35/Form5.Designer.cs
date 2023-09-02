
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
            this.btnShowBookingInfo = new System.Windows.Forms.Button();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.lstbxBookingInfo = new System.Windows.Forms.ListBox();
            this.gbAppointment = new System.Windows.Forms.GroupBox();
            this.gbBookDateTime = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheckTime = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbtnAnotherTime = new System.Windows.Forms.RadioButton();
            this.rdbtnNow = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUDcap = new System.Windows.Forms.NumericUpDown();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.roomID = new System.Windows.Forms.Label();
            this.txtRecep = new System.Windows.Forms.TextBox();
            this.lblReceiptionist = new System.Windows.Forms.Label();
            this.displayGuest = new System.Windows.Forms.DataGridView();
            this.guestID = new System.Windows.Forms.Label();
            this.txtGuestId = new System.Windows.Forms.TextBox();
            this.btnSearchGuest = new System.Windows.Forms.Button();
            this.txtSearchGuest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCheckInInfo = new System.Windows.Forms.Button();
            this.lstCheckInInfo = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCheckInTime = new System.Windows.Forms.TextBox();
            this.calendarBooking = new System.Windows.Forms.MonthCalendar();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCheckOutInfo = new System.Windows.Forms.Button();
            this.lstBookingInfo = new System.Windows.Forms.ListBox();
            this.gbDateTime = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCheckOutTime = new System.Windows.Forms.TextBox();
            this.CalendarMonth = new System.Windows.Forms.MonthCalendar();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.displayCheckin = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.comboTransaction = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbAppointment.SuspendLayout();
            this.gbBookDateTime.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDcap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayGuest)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(24, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1401, 960);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnShowBookingInfo);
            this.tabPage1.Controls.Add(this.btnConfirmBooking);
            this.tabPage1.Controls.Add(this.lstbxBookingInfo);
            this.tabPage1.Controls.Add(this.gbAppointment);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1393, 927);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Make A Booking";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnShowBookingInfo
            // 
            this.btnShowBookingInfo.Location = new System.Drawing.Point(870, 809);
            this.btnShowBookingInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowBookingInfo.Name = "btnShowBookingInfo";
            this.btnShowBookingInfo.Size = new System.Drawing.Size(195, 84);
            this.btnShowBookingInfo.TabIndex = 15;
            this.btnShowBookingInfo.Text = "Show Booking Info";
            this.btnShowBookingInfo.UseVisualStyleBackColor = true;
            this.btnShowBookingInfo.Click += new System.EventHandler(this.btnShowBookingInfo_Click);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(1082, 809);
            this.btnConfirmBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(195, 84);
            this.btnConfirmBooking.TabIndex = 14;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // lstbxBookingInfo
            // 
            this.lstbxBookingInfo.FormattingEnabled = true;
            this.lstbxBookingInfo.ItemHeight = 20;
            this.lstbxBookingInfo.Location = new System.Drawing.Point(870, 400);
            this.lstbxBookingInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstbxBookingInfo.Name = "lstbxBookingInfo";
            this.lstbxBookingInfo.Size = new System.Drawing.Size(407, 344);
            this.lstbxBookingInfo.TabIndex = 13;
            // 
            // gbAppointment
            // 
            this.gbAppointment.Controls.Add(this.gbBookDateTime);
            this.gbAppointment.Controls.Add(this.label12);
            this.gbAppointment.Controls.Add(this.rdbtnAnotherTime);
            this.gbAppointment.Controls.Add(this.rdbtnNow);
            this.gbAppointment.Controls.Add(this.groupBox2);
            this.gbAppointment.Location = new System.Drawing.Point(191, 368);
            this.gbAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAppointment.Name = "gbAppointment";
            this.gbAppointment.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAppointment.Size = new System.Drawing.Size(633, 500);
            this.gbAppointment.TabIndex = 12;
            this.gbAppointment.TabStop = false;
            this.gbAppointment.Text = "Appointment";
            // 
            // gbBookDateTime
            // 
            this.gbBookDateTime.Controls.Add(this.label4);
            this.gbBookDateTime.Controls.Add(this.txtCheckTime);
            this.gbBookDateTime.Controls.Add(this.monthCalendar);
            this.gbBookDateTime.Controls.Add(this.label5);
            this.gbBookDateTime.Location = new System.Drawing.Point(282, 26);
            this.gbBookDateTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBookDateTime.Name = "gbBookDateTime";
            this.gbBookDateTime.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBookDateTime.Size = new System.Drawing.Size(331, 466);
            this.gbBookDateTime.TabIndex = 15;
            this.gbBookDateTime.TabStop = false;
            this.gbBookDateTime.Text = "DATE/TIME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date:";
            // 
            // txtCheckTime
            // 
            this.txtCheckTime.Location = new System.Drawing.Point(10, 405);
            this.txtCheckTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCheckTime.Name = "txtCheckTime";
            this.txtCheckTime.Size = new System.Drawing.Size(173, 26);
            this.txtCheckTime.TabIndex = 9;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(10, 64);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 8;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time:";
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUDcap);
            this.groupBox2.Controls.Add(this.cmbRoomType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(24, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(220, 235);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room Type";
            // 
            // numericUDcap
            // 
            this.numericUDcap.Location = new System.Drawing.Point(32, 76);
            this.numericUDcap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUDcap.Name = "numericUDcap";
            this.numericUDcap.Size = new System.Drawing.Size(135, 26);
            this.numericUDcap.TabIndex = 10;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(25, 169);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(121, 28);
            this.cmbRoomType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Capacity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRoomID);
            this.groupBox1.Controls.Add(this.roomID);
            this.groupBox1.Controls.Add(this.txtRecep);
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
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(423, 265);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(144, 26);
            this.txtRoomID.TabIndex = 12;
            // 
            // roomID
            // 
            this.roomID.AutoSize = true;
            this.roomID.Location = new System.Drawing.Point(330, 271);
            this.roomID.Name = "roomID";
            this.roomID.Size = new System.Drawing.Size(77, 20);
            this.roomID.TabIndex = 11;
            this.roomID.Text = "Room ID:";
            // 
            // txtRecep
            // 
            this.txtRecep.Location = new System.Drawing.Point(150, 265);
            this.txtRecep.Name = "txtRecep";
            this.txtRecep.Size = new System.Drawing.Size(148, 26);
            this.txtRecep.TabIndex = 10;
            // 
            // lblReceiptionist
            // 
            this.lblReceiptionist.AutoSize = true;
            this.lblReceiptionist.Location = new System.Drawing.Point(22, 268);
            this.lblReceiptionist.Name = "lblReceiptionist";
            this.lblReceiptionist.Size = new System.Drawing.Size(122, 20);
            this.lblReceiptionist.TabIndex = 9;
            this.lblReceiptionist.Text = "Receiptionist ID";
            // 
            // displayGuest
            // 
            this.displayGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayGuest.Location = new System.Drawing.Point(26, 69);
            this.displayGuest.Name = "displayGuest";
            this.displayGuest.RowHeadersWidth = 62;
            this.displayGuest.RowTemplate.Height = 28;
            this.displayGuest.Size = new System.Drawing.Size(1053, 170);
            this.displayGuest.TabIndex = 8;
            // 
            // guestID
            // 
            this.guestID.AutoSize = true;
            this.guestID.Location = new System.Drawing.Point(898, 274);
            this.guestID.Name = "guestID";
            this.guestID.Size = new System.Drawing.Size(78, 20);
            this.guestID.TabIndex = 7;
            this.guestID.Text = "Guest ID:";
            // 
            // txtGuestId
            // 
            this.txtGuestId.Location = new System.Drawing.Point(982, 268);
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
            this.groupBox4.Controls.Add(this.btnCheckInInfo);
            this.groupBox4.Controls.Add(this.lstCheckInInfo);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnCheckIn);
            this.groupBox4.Controls.Add(this.btnSearchID);
            this.groupBox4.Controls.Add(this.txtSearchID);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(222, 65);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(1014, 808);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Guest";
            // 
            // btnCheckInInfo
            // 
            this.btnCheckInInfo.Location = new System.Drawing.Point(502, 715);
            this.btnCheckInInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckInInfo.Name = "btnCheckInInfo";
            this.btnCheckInInfo.Size = new System.Drawing.Size(192, 70);
            this.btnCheckInInfo.TabIndex = 7;
            this.btnCheckInInfo.Text = "Check In Info";
            this.btnCheckInInfo.UseVisualStyleBackColor = true;
            this.btnCheckInInfo.Click += new System.EventHandler(this.btnCheckInInfo_Click);
            // 
            // lstCheckInInfo
            // 
            this.lstCheckInInfo.BackColor = System.Drawing.SystemColors.Info;
            this.lstCheckInInfo.FormattingEnabled = true;
            this.lstCheckInInfo.ItemHeight = 20;
            this.lstCheckInInfo.Location = new System.Drawing.Point(502, 348);
            this.lstCheckInInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCheckInInfo.Name = "lstCheckInInfo";
            this.lstCheckInInfo.Size = new System.Drawing.Size(404, 284);
            this.lstCheckInInfo.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtCheckInTime);
            this.groupBox5.Controls.Add(this.calendarBooking);
            this.groupBox5.Location = new System.Drawing.Point(53, 325);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(366, 460);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date and Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 324);
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
            // txtCheckInTime
            // 
            this.txtCheckInTime.Location = new System.Drawing.Point(37, 370);
            this.txtCheckInTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCheckInTime.Name = "txtCheckInTime";
            this.txtCheckInTime.Size = new System.Drawing.Size(173, 26);
            this.txtCheckInTime.TabIndex = 13;
            // 
            // calendarBooking
            // 
            this.calendarBooking.Location = new System.Drawing.Point(37, 42);
            this.calendarBooking.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.calendarBooking.Name = "calendarBooking";
            this.calendarBooking.TabIndex = 12;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(714, 715);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(192, 70);
            this.btnCheckIn.TabIndex = 4;
            this.btnCheckIn.Text = "Check In Guest";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(831, 29);
            this.btnSearchID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(75, 49);
            this.btnSearchID.TabIndex = 2;
            this.btnSearchID.Text = "Search";
            this.btnSearchID.UseVisualStyleBackColor = true;
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(230, 39);
            this.txtSearchID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(595, 26);
            this.txtSearchID.TabIndex = 1;
            this.txtSearchID.TextChanged += new System.EventHandler(this.txtSearchID_TextChanged);
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
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Controls.Add(this.btnCheckOutInfo);
            this.groupBox6.Controls.Add(this.lstBookingInfo);
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
            // btnCheckOutInfo
            // 
            this.btnCheckOutInfo.Location = new System.Drawing.Point(502, 715);
            this.btnCheckOutInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckOutInfo.Name = "btnCheckOutInfo";
            this.btnCheckOutInfo.Size = new System.Drawing.Size(192, 70);
            this.btnCheckOutInfo.TabIndex = 7;
            this.btnCheckOutInfo.Text = "Check Out Info";
            this.btnCheckOutInfo.UseVisualStyleBackColor = true;
            this.btnCheckOutInfo.Click += new System.EventHandler(this.btnCheckOutInfo_Click);
            // 
            // lstBookingInfo
            // 
            this.lstBookingInfo.BackColor = System.Drawing.SystemColors.Info;
            this.lstBookingInfo.FormattingEnabled = true;
            this.lstBookingInfo.ItemHeight = 20;
            this.lstBookingInfo.Location = new System.Drawing.Point(502, 348);
            this.lstBookingInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBookingInfo.Name = "lstBookingInfo";
            this.lstBookingInfo.Size = new System.Drawing.Size(404, 284);
            this.lstBookingInfo.TabIndex = 6;
            // 
            // gbDateTime
            // 
            this.gbDateTime.Controls.Add(this.comboTransaction);
            this.gbDateTime.Controls.Add(this.label13);
            this.gbDateTime.Controls.Add(this.label9);
            this.gbDateTime.Controls.Add(this.label10);
            this.gbDateTime.Controls.Add(this.txtCheckOutTime);
            this.gbDateTime.Controls.Add(this.CalendarMonth);
            this.gbDateTime.Location = new System.Drawing.Point(53, 325);
            this.gbDateTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDateTime.Name = "gbDateTime";
            this.gbDateTime.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDateTime.Size = new System.Drawing.Size(366, 460);
            this.gbDateTime.TabIndex = 2;
            this.gbDateTime.TabStop = false;
            this.gbDateTime.Text = "Date & Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 306);
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
            this.txtCheckOutTime.Location = new System.Drawing.Point(37, 330);
            this.txtCheckOutTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCheckOutTime.Name = "txtCheckOutTime";
            this.txtCheckOutTime.Size = new System.Drawing.Size(173, 26);
            this.txtCheckOutTime.TabIndex = 13;
            // 
            // CalendarMonth
            // 
            this.CalendarMonth.Location = new System.Drawing.Point(37, 42);
            this.CalendarMonth.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.CalendarMonth.Name = "CalendarMonth";
            this.CalendarMonth.TabIndex = 12;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(714, 715);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(192, 70);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Check Out Guest";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(831, 29);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 49);
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
            // displayCheckin
            // 
            this.displayCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayCheckin.Location = new System.Drawing.Point(54, 81);
            this.displayCheckin.Name = "displayCheckin";
            this.displayCheckin.RowHeadersWidth = 62;
            this.displayCheckin.RowTemplate.Height = 28;
            this.displayCheckin.Size = new System.Drawing.Size(852, 222);
            this.displayCheckin.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(853, 211);
            this.dataGridView1.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Transaction Method";
            // 
            // comboTransaction
            // 
            this.comboTransaction.FormattingEnabled = true;
            this.comboTransaction.Location = new System.Drawing.Point(37, 412);
            this.comboTransaction.Name = "comboTransaction";
            this.comboTransaction.Size = new System.Drawing.Size(173, 28);
            this.comboTransaction.TabIndex = 17;
            // 
            // FormBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1028);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDcap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayGuest)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbDateTime.ResumeLayout(false);
            this.gbDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchGuest;
        private System.Windows.Forms.TextBox txtSearchGuest;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.ListBox lstbxBookingInfo;
        private System.Windows.Forms.GroupBox gbAppointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUDcap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCheckTime;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowBookingInfo;
        private System.Windows.Forms.RadioButton rdbtnAnotherTime;
        private System.Windows.Forms.RadioButton rdbtnNow;
        private System.Windows.Forms.Button btnCheckInInfo;
        private System.Windows.Forms.ListBox lstCheckInInfo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCheckInTime;
        private System.Windows.Forms.MonthCalendar calendarBooking;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCheckOutInfo;
        private System.Windows.Forms.ListBox lstBookingInfo;
        private System.Windows.Forms.GroupBox gbDateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCheckOutTime;
        private System.Windows.Forms.MonthCalendar CalendarMonth;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label guestID;
        private System.Windows.Forms.TextBox txtGuestId;
        private System.Windows.Forms.GroupBox gbBookDateTime;
        private System.Windows.Forms.DataGridView displayGuest;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label roomID;
        private System.Windows.Forms.TextBox txtRecep;
        private System.Windows.Forms.Label lblReceiptionist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.DataGridView displayCheckin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboTransaction;
        private System.Windows.Forms.Label label13;
    }
}