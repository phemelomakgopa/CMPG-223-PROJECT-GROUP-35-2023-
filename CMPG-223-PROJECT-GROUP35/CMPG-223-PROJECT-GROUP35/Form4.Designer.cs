
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
            this.existingGB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChangeGuestInfo = new System.Windows.Forms.CheckBox();
            this.cbBookings = new System.Windows.Forms.CheckBox();
            this.rdoNewGuest = new System.Windows.Forms.RadioButton();
            this.rdoExGuest = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMainRooms = new System.Windows.Forms.Button();
            this.existingGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // existingGB
            // 
            this.existingGB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.existingGB.Controls.Add(this.label2);
            this.existingGB.Controls.Add(this.cbChangeGuestInfo);
            this.existingGB.Controls.Add(this.cbBookings);
            this.existingGB.Location = new System.Drawing.Point(37, 156);
            this.existingGB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.existingGB.Name = "existingGB";
            this.existingGB.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.existingGB.Size = new System.Drawing.Size(462, 250);
            this.existingGB.TabIndex = 0;
            this.existingGB.TabStop = false;
            this.existingGB.Text = "Exisiting Guests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // cbChangeGuestInfo
            // 
            this.cbChangeGuestInfo.AutoSize = true;
            this.cbChangeGuestInfo.Location = new System.Drawing.Point(34, 139);
            this.cbChangeGuestInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbChangeGuestInfo.Name = "cbChangeGuestInfo";
            this.cbChangeGuestInfo.Size = new System.Drawing.Size(192, 24);
            this.cbChangeGuestInfo.TabIndex = 1;
            this.cbChangeGuestInfo.Text = "Change Guest Details";
            this.cbChangeGuestInfo.UseVisualStyleBackColor = true;
            // 
            // cbBookings
            // 
            this.cbBookings.AutoSize = true;
            this.cbBookings.Location = new System.Drawing.Point(30, 68);
            this.cbBookings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBookings.Name = "cbBookings";
            this.cbBookings.Size = new System.Drawing.Size(180, 24);
            this.cbBookings.TabIndex = 0;
            this.cbBookings.Text = "Proceed to bookings";
            this.cbBookings.UseVisualStyleBackColor = true;
            // 
            // rdoNewGuest
            // 
            this.rdoNewGuest.AutoSize = true;
            this.rdoNewGuest.Location = new System.Drawing.Point(36, 45);
            this.rdoNewGuest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoNewGuest.Name = "rdoNewGuest";
            this.rdoNewGuest.Size = new System.Drawing.Size(113, 24);
            this.rdoNewGuest.TabIndex = 0;
            this.rdoNewGuest.TabStop = true;
            this.rdoNewGuest.Text = "New Guest";
            this.rdoNewGuest.UseVisualStyleBackColor = true;
            // 
            // rdoExGuest
            // 
            this.rdoExGuest.AutoSize = true;
            this.rdoExGuest.Location = new System.Drawing.Point(37, 92);
            this.rdoExGuest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoExGuest.Name = "rdoExGuest";
            this.rdoExGuest.Size = new System.Drawing.Size(137, 24);
            this.rdoExGuest.TabIndex = 1;
            this.rdoExGuest.TabStop = true;
            this.rdoExGuest.Text = "Existing Guest";
            this.rdoExGuest.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(336, 442);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(163, 72);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMainRooms
            // 
            this.btnMainRooms.Location = new System.Drawing.Point(36, 442);
            this.btnMainRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainRooms.Name = "btnMainRooms";
            this.btnMainRooms.Size = new System.Drawing.Size(156, 72);
            this.btnMainRooms.TabIndex = 4;
            this.btnMainRooms.Text = "Maintain Rooms";
            this.btnMainRooms.UseVisualStyleBackColor = true;
            this.btnMainRooms.Click += new System.EventHandler(this.btnMainRooms_Click);
            // 
            // FormNewExisting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 544);
            this.Controls.Add(this.btnMainRooms);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.existingGB);
            this.Controls.Add(this.rdoExGuest);
            this.Controls.Add(this.rdoNewGuest);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNewExisting";
            this.Text = "Form Accessor";
            this.existingGB.ResumeLayout(false);
            this.existingGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox existingGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbChangeGuestInfo;
        private System.Windows.Forms.CheckBox cbBookings;
        private System.Windows.Forms.RadioButton rdoNewGuest;
        private System.Windows.Forms.RadioButton rdoExGuest;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMainRooms;
    }
}