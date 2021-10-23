
namespace Phumla_Kamnandi_Hotel.Presentation
{
    partial class BookingListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingListingForm));
            this.bookingListView = new System.Windows.Forms.ListView();
            this.listLabel = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblCustomerReq = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblAccountNum = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rTxtCustRequests = new System.Windows.Forms.RichTextBox();
            this.dTPDepDate = new System.Windows.Forms.DateTimePicker();
            this.dtPArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.txtNumPeople = new System.Windows.Forms.TextBox();
            this.lblNumPeople = new System.Windows.Forms.Label();
            this.txtBookingDate = new System.Windows.Forms.TextBox();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingListView
            // 
            this.bookingListView.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingListView.HideSelection = false;
            this.bookingListView.Location = new System.Drawing.Point(28, 28);
            this.bookingListView.Name = "bookingListView";
            this.bookingListView.Size = new System.Drawing.Size(848, 254);
            this.bookingListView.TabIndex = 5;
            this.bookingListView.UseCompatibleStateImageBehavior = false;
            this.bookingListView.SelectedIndexChanged += new System.EventHandler(this.bookingListView_SelectedIndexChanged_1);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(28, 8);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(72, 17);
            this.listLabel.TabIndex = 4;
            this.listLabel.Text = "Bookings";
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureDate.Location = new System.Drawing.Point(13, 288);
            this.lblDepartureDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(105, 14);
            this.lblDepartureDate.TabIndex = 69;
            this.lblDepartureDate.Text = "Departure Date";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(591, 463);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(77, 34);
            this.submitButton.TabIndex = 68;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(434, 463);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 34);
            this.cancelButton.TabIndex = 67;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(132, 76);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(140, 23);
            this.txtAccount.TabIndex = 61;
            // 
            // txtCusID
            // 
            this.txtCusID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.Location = new System.Drawing.Point(132, 29);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.ReadOnly = true;
            this.txtCusID.Size = new System.Drawing.Size(140, 23);
            this.txtCusID.TabIndex = 60;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingID.Location = new System.Drawing.Point(148, 33);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(178, 23);
            this.txtBookingID.TabIndex = 59;
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalDate.Location = new System.Drawing.Point(13, 252);
            this.lblArrivalDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(91, 14);
            this.lblArrivalDate.TabIndex = 58;
            this.lblArrivalDate.Text = "Arrival Date";
            // 
            // lblCustomerReq
            // 
            this.lblCustomerReq.AutoSize = true;
            this.lblCustomerReq.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerReq.Location = new System.Drawing.Point(13, 79);
            this.lblCustomerReq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerReq.Name = "lblCustomerReq";
            this.lblCustomerReq.Size = new System.Drawing.Size(126, 14);
            this.lblCustomerReq.TabIndex = 56;
            this.lblCustomerReq.Text = "Customer Requests";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(8, 33);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(84, 14);
            this.lblCustomerID.TabIndex = 55;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblAccountNum
            // 
            this.lblAccountNum.AutoSize = true;
            this.lblAccountNum.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNum.Location = new System.Drawing.Point(8, 76);
            this.lblAccountNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountNum.Name = "lblAccountNum";
            this.lblAccountNum.Size = new System.Drawing.Size(105, 14);
            this.lblAccountNum.TabIndex = 54;
            this.lblAccountNum.Text = "Account Number";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(13, 37);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(70, 14);
            this.lblBookingID.TabIndex = 53;
            this.lblBookingID.Text = "BookingID";
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(823, 352);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(45, 34);
            this.deleteButton.TabIndex = 66;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(740, 352);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(45, 34);
            this.editButton.TabIndex = 65;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.lblAccountNum);
            this.groupBox1.Controls.Add(this.lblCustomerID);
            this.groupBox1.Controls.Add(this.txtCusID);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(396, 304);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(331, 126);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details for Booking";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rTxtCustRequests);
            this.groupBox2.Controls.Add(this.dTPDepDate);
            this.groupBox2.Controls.Add(this.dtPArrivalDate);
            this.groupBox2.Controls.Add(this.txtNumPeople);
            this.groupBox2.Controls.Add(this.lblNumPeople);
            this.groupBox2.Controls.Add(this.txtBookingDate);
            this.groupBox2.Controls.Add(this.lblBookingID);
            this.groupBox2.Controls.Add(this.lblCustomerReq);
            this.groupBox2.Controls.Add(this.lblDepartureDate);
            this.groupBox2.Controls.Add(this.lblBookingDate);
            this.groupBox2.Controls.Add(this.lblArrivalDate);
            this.groupBox2.Controls.Add(this.txtBookingID);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 304);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(360, 366);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Booking Details";
            // 
            // rTxtCustRequests
            // 
            this.rTxtCustRequests.Location = new System.Drawing.Point(148, 71);
            this.rTxtCustRequests.Name = "rTxtCustRequests";
            this.rTxtCustRequests.Size = new System.Drawing.Size(178, 122);
            this.rTxtCustRequests.TabIndex = 75;
            this.rTxtCustRequests.Text = "";
            // 
            // dTPDepDate
            // 
            this.dTPDepDate.Location = new System.Drawing.Point(148, 286);
            this.dTPDepDate.Name = "dTPDepDate";
            this.dTPDepDate.Size = new System.Drawing.Size(178, 23);
            this.dTPDepDate.TabIndex = 74;
            // 
            // dtPArrivalDate
            // 
            this.dtPArrivalDate.Location = new System.Drawing.Point(148, 252);
            this.dtPArrivalDate.Name = "dtPArrivalDate";
            this.dtPArrivalDate.Size = new System.Drawing.Size(178, 23);
            this.dtPArrivalDate.TabIndex = 73;
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPeople.Location = new System.Drawing.Point(148, 325);
            this.txtNumPeople.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Size = new System.Drawing.Size(36, 23);
            this.txtNumPeople.TabIndex = 72;
            // 
            // lblNumPeople
            // 
            this.lblNumPeople.AutoSize = true;
            this.lblNumPeople.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPeople.Location = new System.Drawing.Point(13, 325);
            this.lblNumPeople.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPeople.Name = "lblNumPeople";
            this.lblNumPeople.Size = new System.Drawing.Size(119, 14);
            this.lblNumPeople.TabIndex = 71;
            this.lblNumPeople.Text = "Number of People";
            // 
            // txtBookingDate
            // 
            this.txtBookingDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingDate.Location = new System.Drawing.Point(148, 210);
            this.txtBookingDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookingDate.Name = "txtBookingDate";
            this.txtBookingDate.Size = new System.Drawing.Size(178, 23);
            this.txtBookingDate.TabIndex = 63;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.Location = new System.Drawing.Point(13, 210);
            this.lblBookingDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(91, 14);
            this.lblBookingDate.TabIndex = 57;
            this.lblBookingDate.Text = "Booking Date";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(745, 396);
            this.lblEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(40, 17);
            this.lblEdit.TabIndex = 75;
            this.lblEdit.Text = "Edit";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(820, 396);
            this.lblDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(56, 17);
            this.lblDelete.TabIndex = 76;
            this.lblDelete.Text = "Delete";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(799, 636);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 34);
            this.button1.TabIndex = 77;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookingListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.bookingListView);
            this.Controls.Add(this.listLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookingListingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit/Delete Booking Form";
            this.Activated += new System.EventHandler(this.bookingListingForm_Activated_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bookingListView;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblCustomerReq;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblAccountNum;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtNumPeople;
        private System.Windows.Forms.Label lblNumPeople;
        private System.Windows.Forms.DateTimePicker dTPDepDate;
        private System.Windows.Forms.DateTimePicker dtPArrivalDate;
        private System.Windows.Forms.TextBox txtBookingDate;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.RichTextBox rTxtCustRequests;
        private System.Windows.Forms.Button button1;
    }
}