
namespace Phumla_Kamnandi_Hotel.Presentation
{
    partial class NewBookingUI
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
            this.radNewGuest = new System.Windows.Forms.RadioButton();
            this.radExistingGuest = new System.Windows.Forms.RadioButton();
            this.richTxtSpecInstructions = new System.Windows.Forms.RichTextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnRoomAvailability = new System.Windows.Forms.Button();
            this.lblSpecialInstructions = new System.Windows.Forms.Label();
            this.lblNoOfPeople = new System.Windows.Forms.Label();
            this.txtNoOfPeople = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.txtArrivaleDate = new System.Windows.Forms.TextBox();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.gpBoxGuest = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gpBoxGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // radNewGuest
            // 
            this.radNewGuest.AutoSize = true;
            this.radNewGuest.Location = new System.Drawing.Point(211, 57);
            this.radNewGuest.Name = "radNewGuest";
            this.radNewGuest.Size = new System.Drawing.Size(98, 21);
            this.radNewGuest.TabIndex = 25;
            this.radNewGuest.TabStop = true;
            this.radNewGuest.Text = "New Guest";
            this.radNewGuest.UseVisualStyleBackColor = true;
            // 
            // radExistingGuest
            // 
            this.radExistingGuest.AutoSize = true;
            this.radExistingGuest.Location = new System.Drawing.Point(211, 30);
            this.radExistingGuest.Name = "radExistingGuest";
            this.radExistingGuest.Size = new System.Drawing.Size(119, 21);
            this.radExistingGuest.TabIndex = 24;
            this.radExistingGuest.TabStop = true;
            this.radExistingGuest.Text = "Existing Guest";
            this.radExistingGuest.UseVisualStyleBackColor = true;
            // 
            // richTxtSpecInstructions
            // 
            this.richTxtSpecInstructions.Location = new System.Drawing.Point(226, 232);
            this.richTxtSpecInstructions.Name = "richTxtSpecInstructions";
            this.richTxtSpecInstructions.Size = new System.Drawing.Size(333, 79);
            this.richTxtSpecInstructions.TabIndex = 23;
            this.richTxtSpecInstructions.Text = "";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(626, 90);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 22;
            // 
            // btnRoomAvailability
            // 
            this.btnRoomAvailability.Location = new System.Drawing.Point(110, 449);
            this.btnRoomAvailability.Name = "btnRoomAvailability";
            this.btnRoomAvailability.Size = new System.Drawing.Size(194, 39);
            this.btnRoomAvailability.TabIndex = 21;
            this.btnRoomAvailability.Text = "Check Room Availability";
            this.btnRoomAvailability.UseVisualStyleBackColor = true;
            this.btnRoomAvailability.Click += new System.EventHandler(this.btnRoomAvailability_Click);
            // 
            // lblSpecialInstructions
            // 
            this.lblSpecialInstructions.AutoSize = true;
            this.lblSpecialInstructions.Location = new System.Drawing.Point(66, 232);
            this.lblSpecialInstructions.Name = "lblSpecialInstructions";
            this.lblSpecialInstructions.Size = new System.Drawing.Size(134, 17);
            this.lblSpecialInstructions.TabIndex = 20;
            this.lblSpecialInstructions.Text = "Special Instructions:";
            // 
            // lblNoOfPeople
            // 
            this.lblNoOfPeople.AutoSize = true;
            this.lblNoOfPeople.Location = new System.Drawing.Point(66, 169);
            this.lblNoOfPeople.Name = "lblNoOfPeople";
            this.lblNoOfPeople.Size = new System.Drawing.Size(94, 17);
            this.lblNoOfPeople.TabIndex = 19;
            this.lblNoOfPeople.Text = "No of People:";
            // 
            // txtNoOfPeople
            // 
            this.txtNoOfPeople.Location = new System.Drawing.Point(226, 169);
            this.txtNoOfPeople.Name = "txtNoOfPeople";
            this.txtNoOfPeople.Size = new System.Drawing.Size(78, 22);
            this.txtNoOfPeople.TabIndex = 18;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(300, 100);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(234, 22);
            this.txtDepartureDate.TabIndex = 17;
            // 
            // txtArrivaleDate
            // 
            this.txtArrivaleDate.Location = new System.Drawing.Point(300, 50);
            this.txtArrivaleDate.Name = "txtArrivaleDate";
            this.txtArrivaleDate.Size = new System.Drawing.Size(234, 22);
            this.txtArrivaleDate.TabIndex = 16;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Location = new System.Drawing.Point(66, 103);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(110, 17);
            this.lblDepartureDate.TabIndex = 15;
            this.lblDepartureDate.Text = "Departure Date:";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Location = new System.Drawing.Point(66, 50);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(86, 17);
            this.lblArrivalDate.TabIndex = 14;
            this.lblArrivalDate.Text = "Arrival Date:";
            // 
            // gpBoxGuest
            // 
            this.gpBoxGuest.Controls.Add(this.radExistingGuest);
            this.gpBoxGuest.Controls.Add(this.radNewGuest);
            this.gpBoxGuest.Location = new System.Drawing.Point(69, 328);
            this.gpBoxGuest.Name = "gpBoxGuest";
            this.gpBoxGuest.Size = new System.Drawing.Size(338, 100);
            this.gpBoxGuest.TabIndex = 27;
            this.gpBoxGuest.TabStop = false;
            this.gpBoxGuest.Text = "Guest Type:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(365, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 39);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(616, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 39);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // NewBookingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 515);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gpBoxGuest);
            this.Controls.Add(this.richTxtSpecInstructions);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.btnRoomAvailability);
            this.Controls.Add(this.lblSpecialInstructions);
            this.Controls.Add(this.lblNoOfPeople);
            this.Controls.Add(this.txtNoOfPeople);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtArrivaleDate);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Name = "NewBookingUI";
            this.Text = "NewBookingUI";
            this.Load += new System.EventHandler(this.NewBookingUI_Load);
            this.gpBoxGuest.ResumeLayout(false);
            this.gpBoxGuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radNewGuest;
        private System.Windows.Forms.RadioButton radExistingGuest;
        private System.Windows.Forms.RichTextBox richTxtSpecInstructions;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnRoomAvailability;
        private System.Windows.Forms.Label lblSpecialInstructions;
        private System.Windows.Forms.Label lblNoOfPeople;
        private System.Windows.Forms.TextBox txtNoOfPeople;
        private System.Windows.Forms.TextBox txtDepartureDate;
        private System.Windows.Forms.TextBox txtArrivaleDate;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.GroupBox gpBoxGuest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
    }
}