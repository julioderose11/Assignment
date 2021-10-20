
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
            this.richTxtSpecInstructions = new System.Windows.Forms.RichTextBox();
            this.btnRoomAvailability = new System.Windows.Forms.Button();
            this.lblSpecialInstructions = new System.Windows.Forms.Label();
            this.lblNoOfPeople = new System.Windows.Forms.Label();
            this.txtNoOfPeople = new System.Windows.Forms.TextBox();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dTPArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dTPDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // richTxtSpecInstructions
            // 
            this.richTxtSpecInstructions.Location = new System.Drawing.Point(170, 188);
            this.richTxtSpecInstructions.Margin = new System.Windows.Forms.Padding(2);
            this.richTxtSpecInstructions.Name = "richTxtSpecInstructions";
            this.richTxtSpecInstructions.Size = new System.Drawing.Size(251, 65);
            this.richTxtSpecInstructions.TabIndex = 23;
            this.richTxtSpecInstructions.Text = "";
            // 
            // btnRoomAvailability
            // 
            this.btnRoomAvailability.Location = new System.Drawing.Point(82, 365);
            this.btnRoomAvailability.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoomAvailability.Name = "btnRoomAvailability";
            this.btnRoomAvailability.Size = new System.Drawing.Size(146, 32);
            this.btnRoomAvailability.TabIndex = 21;
            this.btnRoomAvailability.Text = "Check Room Availability";
            this.btnRoomAvailability.UseVisualStyleBackColor = true;
            this.btnRoomAvailability.Click += new System.EventHandler(this.btnRoomAvailability_Click);
            // 
            // lblSpecialInstructions
            // 
            this.lblSpecialInstructions.AutoSize = true;
            this.lblSpecialInstructions.Location = new System.Drawing.Point(50, 188);
            this.lblSpecialInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecialInstructions.Name = "lblSpecialInstructions";
            this.lblSpecialInstructions.Size = new System.Drawing.Size(102, 13);
            this.lblSpecialInstructions.TabIndex = 20;
            this.lblSpecialInstructions.Text = "Special Instructions:";
            // 
            // lblNoOfPeople
            // 
            this.lblNoOfPeople.AutoSize = true;
            this.lblNoOfPeople.Location = new System.Drawing.Point(50, 137);
            this.lblNoOfPeople.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoOfPeople.Name = "lblNoOfPeople";
            this.lblNoOfPeople.Size = new System.Drawing.Size(72, 13);
            this.lblNoOfPeople.TabIndex = 19;
            this.lblNoOfPeople.Text = "No of People:";
            // 
            // txtNoOfPeople
            // 
            this.txtNoOfPeople.Location = new System.Drawing.Point(170, 137);
            this.txtNoOfPeople.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoOfPeople.Name = "txtNoOfPeople";
            this.txtNoOfPeople.Size = new System.Drawing.Size(60, 20);
            this.txtNoOfPeople.TabIndex = 18;
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Location = new System.Drawing.Point(50, 84);
            this.lblDepartureDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(83, 13);
            this.lblDepartureDate.TabIndex = 15;
            this.lblDepartureDate.Text = "Departure Date:";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Location = new System.Drawing.Point(50, 41);
            this.lblArrivalDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(65, 13);
            this.lblArrivalDate.TabIndex = 14;
            this.lblArrivalDate.Text = "Arrival Date:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(274, 365);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 32);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(462, 365);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 32);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(572, 65);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 13);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "Current Date";
            // 
            // dTPArrivalDate
            // 
            this.dTPArrivalDate.Location = new System.Drawing.Point(220, 41);
            this.dTPArrivalDate.Name = "dTPArrivalDate";
            this.dTPArrivalDate.Size = new System.Drawing.Size(200, 20);
            this.dTPArrivalDate.TabIndex = 31;
            // 
            // dTPDepartureDate
            // 
            this.dTPDepartureDate.Location = new System.Drawing.Point(221, 78);
            this.dTPDepartureDate.Name = "dTPDepartureDate";
            this.dTPDepartureDate.Size = new System.Drawing.Size(200, 20);
            this.dTPDepartureDate.TabIndex = 32;
            // 
            // NewBookingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 418);
            this.Controls.Add(this.dTPDepartureDate);
            this.Controls.Add(this.dTPArrivalDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.richTxtSpecInstructions);
            this.Controls.Add(this.btnRoomAvailability);
            this.Controls.Add(this.lblSpecialInstructions);
            this.Controls.Add(this.lblNoOfPeople);
            this.Controls.Add(this.txtNoOfPeople);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewBookingUI";
            this.Text = "NewBookingUI";
            this.Load += new System.EventHandler(this.NewBookingUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTxtSpecInstructions;
        private System.Windows.Forms.Button btnRoomAvailability;
        private System.Windows.Forms.Label lblSpecialInstructions;
        private System.Windows.Forms.Label lblNoOfPeople;
        private System.Windows.Forms.TextBox txtNoOfPeople;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dTPArrivalDate;
        private System.Windows.Forms.DateTimePicker dTPDepartureDate;
    }
}