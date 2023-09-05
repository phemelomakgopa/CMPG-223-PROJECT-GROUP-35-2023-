namespace CMPG_223_PROJECT_GROUP35
{
    partial class Reports
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
            this.btnDone = new System.Windows.Forms.Button();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.viewReceptionistReport = new System.Windows.Forms.Button();
            this.viewBookings = new System.Windows.Forms.Button();
            this.viewRooms = new System.Windows.Forms.Button();
            this.viewTransactions = new System.Windows.Forms.Button();
            this.viewGuests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(1067, 577);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(125, 66);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lstReport
            // 
            this.lstReport.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstReport.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReport.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstReport.FormattingEnabled = true;
            this.lstReport.ItemHeight = 34;
            this.lstReport.Location = new System.Drawing.Point(23, 27);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(999, 616);
            this.lstReport.TabIndex = 3;
            // 
            // viewReceptionistReport
            // 
            this.viewReceptionistReport.Location = new System.Drawing.Point(1067, 27);
            this.viewReceptionistReport.Name = "viewReceptionistReport";
            this.viewReceptionistReport.Size = new System.Drawing.Size(122, 58);
            this.viewReceptionistReport.TabIndex = 4;
            this.viewReceptionistReport.Text = "Receiptionists";
            this.viewReceptionistReport.UseVisualStyleBackColor = true;
            this.viewReceptionistReport.Click += new System.EventHandler(this.viewReceptionistReport_Click);
            // 
            // viewBookings
            // 
            this.viewBookings.Location = new System.Drawing.Point(1070, 232);
            this.viewBookings.Name = "viewBookings";
            this.viewBookings.Size = new System.Drawing.Size(122, 60);
            this.viewBookings.TabIndex = 5;
            this.viewBookings.Text = "Bookings";
            this.viewBookings.UseVisualStyleBackColor = true;
            this.viewBookings.Click += new System.EventHandler(this.viewBookings_Click);
            // 
            // viewRooms
            // 
            this.viewRooms.Location = new System.Drawing.Point(1070, 356);
            this.viewRooms.Name = "viewRooms";
            this.viewRooms.Size = new System.Drawing.Size(122, 50);
            this.viewRooms.TabIndex = 6;
            this.viewRooms.Text = "Rooms";
            this.viewRooms.UseVisualStyleBackColor = true;
            this.viewRooms.Click += new System.EventHandler(this.viewRooms_Click);
            // 
            // viewTransactions
            // 
            this.viewTransactions.Location = new System.Drawing.Point(1070, 470);
            this.viewTransactions.Name = "viewTransactions";
            this.viewTransactions.Size = new System.Drawing.Size(122, 58);
            this.viewTransactions.TabIndex = 7;
            this.viewTransactions.Text = "Transactions";
            this.viewTransactions.UseVisualStyleBackColor = true;
            this.viewTransactions.Click += new System.EventHandler(this.viewTransactions_Click);
            // 
            // viewGuests
            // 
            this.viewGuests.Location = new System.Drawing.Point(1070, 127);
            this.viewGuests.Name = "viewGuests";
            this.viewGuests.Size = new System.Drawing.Size(119, 63);
            this.viewGuests.TabIndex = 8;
            this.viewGuests.Text = "Guests";
            this.viewGuests.UseVisualStyleBackColor = true;
            this.viewGuests.Click += new System.EventHandler(this.viewGuests_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 749);
            this.Controls.Add(this.viewGuests);
            this.Controls.Add(this.viewTransactions);
            this.Controls.Add(this.viewRooms);
            this.Controls.Add(this.viewBookings);
            this.Controls.Add(this.viewReceptionistReport);
            this.Controls.Add(this.lstReport);
            this.Controls.Add(this.btnDone);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDone;
        public System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.Button viewReceptionistReport;
        private System.Windows.Forms.Button viewBookings;
        private System.Windows.Forms.Button viewRooms;
        private System.Windows.Forms.Button viewTransactions;
        private System.Windows.Forms.Button viewGuests;
    }
}