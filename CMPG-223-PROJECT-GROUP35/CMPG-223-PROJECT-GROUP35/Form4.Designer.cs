
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
            this.txtGuestPhoneNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.existingGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // existingGB
            // 
            this.existingGB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.existingGB.Controls.Add(this.label1);
            this.existingGB.Controls.Add(this.txtGuestPhoneNum);
            this.existingGB.Controls.Add(this.label2);
            this.existingGB.Controls.Add(this.cbChangeGuestInfo);
            this.existingGB.Controls.Add(this.cbBookings);
            this.existingGB.Location = new System.Drawing.Point(33, 125);
            this.existingGB.Name = "existingGB";
            this.existingGB.Size = new System.Drawing.Size(411, 200);
            this.existingGB.TabIndex = 0;
            this.existingGB.TabStop = false;
            this.existingGB.Text = "Exisiting Guests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // cbChangeGuestInfo
            // 
            this.cbChangeGuestInfo.AutoSize = true;
            this.cbChangeGuestInfo.Location = new System.Drawing.Point(30, 111);
            this.cbChangeGuestInfo.Name = "cbChangeGuestInfo";
            this.cbChangeGuestInfo.Size = new System.Drawing.Size(168, 21);
            this.cbChangeGuestInfo.TabIndex = 1;
            this.cbChangeGuestInfo.Text = "Change Guest Details";
            this.cbChangeGuestInfo.UseVisualStyleBackColor = true;
            // 
            // cbBookings
            // 
            this.cbBookings.AutoSize = true;
            this.cbBookings.Location = new System.Drawing.Point(27, 54);
            this.cbBookings.Name = "cbBookings";
            this.cbBookings.Size = new System.Drawing.Size(160, 21);
            this.cbBookings.TabIndex = 0;
            this.cbBookings.Text = "Proceed to bookings";
            this.cbBookings.UseVisualStyleBackColor = true;
            // 
            // rdoNewGuest
            // 
            this.rdoNewGuest.AutoSize = true;
            this.rdoNewGuest.Location = new System.Drawing.Point(32, 36);
            this.rdoNewGuest.Name = "rdoNewGuest";
            this.rdoNewGuest.Size = new System.Drawing.Size(98, 21);
            this.rdoNewGuest.TabIndex = 0;
            this.rdoNewGuest.TabStop = true;
            this.rdoNewGuest.Text = "New Guest";
            this.rdoNewGuest.UseVisualStyleBackColor = true;
            // 
            // rdoExGuest
            // 
            this.rdoExGuest.AutoSize = true;
            this.rdoExGuest.Location = new System.Drawing.Point(33, 74);
            this.rdoExGuest.Name = "rdoExGuest";
            this.rdoExGuest.Size = new System.Drawing.Size(119, 21);
            this.rdoExGuest.TabIndex = 1;
            this.rdoExGuest.TabStop = true;
            this.rdoExGuest.Text = "Existing Guest";
            this.rdoExGuest.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(299, 354);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 58);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtGuestPhoneNum
            // 
            this.txtGuestPhoneNum.Location = new System.Drawing.Point(243, 91);
            this.txtGuestPhoneNum.Name = "txtGuestPhoneNum";
            this.txtGuestPhoneNum.Size = new System.Drawing.Size(120, 22);
            this.txtGuestPhoneNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guest Phone Number:";
            // 
            // FormNewExisting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 435);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.existingGB);
            this.Controls.Add(this.rdoExGuest);
            this.Controls.Add(this.rdoNewGuest);
            this.Name = "FormNewExisting";
            this.Text = "New or Existing";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuestPhoneNum;
    }
}