
namespace CMPG_223_PROJECT_GROUP35
{
    partial class FormNewExisting
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeABookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainGuestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGuestDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGuestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeABookingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelABookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.makeABookingToolStripMenuItem,
            this.maintainGuestsToolStripMenuItem,
            this.maintainRoomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // makeABookingToolStripMenuItem
            // 
            this.makeABookingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeABookingToolStripMenuItem1,
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem,
            this.cancelABookingToolStripMenuItem});
            this.makeABookingToolStripMenuItem.Name = "makeABookingToolStripMenuItem";
            this.makeABookingToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.makeABookingToolStripMenuItem.Text = "Maintain Bookings";
            // 
            // maintainGuestsToolStripMenuItem
            // 
            this.maintainGuestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewGuestToolStripMenuItem,
            this.changeGuestDetailsToolStripMenuItem,
            this.removeGuestsToolStripMenuItem});
            this.maintainGuestsToolStripMenuItem.Name = "maintainGuestsToolStripMenuItem";
            this.maintainGuestsToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.maintainGuestsToolStripMenuItem.Text = "Maintain Guests";
            // 
            // maintainRoomsToolStripMenuItem
            // 
            this.maintainRoomsToolStripMenuItem.Name = "maintainRoomsToolStripMenuItem";
            this.maintainRoomsToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.maintainRoomsToolStripMenuItem.Text = "Maintain Rooms";
            // 
            // addNewGuestToolStripMenuItem
            // 
            this.addNewGuestToolStripMenuItem.Name = "addNewGuestToolStripMenuItem";
            this.addNewGuestToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.addNewGuestToolStripMenuItem.Text = "Add New Guest";
            this.addNewGuestToolStripMenuItem.Click += new System.EventHandler(this.addNewGuestToolStripMenuItem_Click);
            // 
            // changeGuestDetailsToolStripMenuItem
            // 
            this.changeGuestDetailsToolStripMenuItem.Name = "changeGuestDetailsToolStripMenuItem";
            this.changeGuestDetailsToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.changeGuestDetailsToolStripMenuItem.Text = "Change Guest Details";
            this.changeGuestDetailsToolStripMenuItem.Click += new System.EventHandler(this.changeGuestDetailsToolStripMenuItem_Click);
            // 
            // removeGuestsToolStripMenuItem
            // 
            this.removeGuestsToolStripMenuItem.Name = "removeGuestsToolStripMenuItem";
            this.removeGuestsToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.removeGuestsToolStripMenuItem.Text = "Remove Guests";
            this.removeGuestsToolStripMenuItem.Click += new System.EventHandler(this.removeGuestsToolStripMenuItem_Click);
            // 
            // makeABookingToolStripMenuItem1
            // 
            this.makeABookingToolStripMenuItem1.Name = "makeABookingToolStripMenuItem1";
            this.makeABookingToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.makeABookingToolStripMenuItem1.Text = "Make a Booking";
            this.makeABookingToolStripMenuItem1.Click += new System.EventHandler(this.makeABookingToolStripMenuItem1_Click);
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checkInToolStripMenuItem.Text = "Check In";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // cancelABookingToolStripMenuItem
            // 
            this.cancelABookingToolStripMenuItem.Name = "cancelABookingToolStripMenuItem";
            this.cancelABookingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cancelABookingToolStripMenuItem.Text = "Cancel a Booking";
            this.cancelABookingToolStripMenuItem.Click += new System.EventHandler(this.cancelABookingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormNewExisting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 681);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNewExisting";
            this.Text = "Form Accessor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNewExisting_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeABookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainGuestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeABookingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelABookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGuestDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGuestsToolStripMenuItem;
    }
}