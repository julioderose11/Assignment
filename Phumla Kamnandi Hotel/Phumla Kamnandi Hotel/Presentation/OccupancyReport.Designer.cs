
namespace Phumla_Kamnandi_Hotel.Presentation
{
    partial class OccupancyReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotalBooking = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.bookingListView = new System.Windows.Forms.ListView();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.dTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.dTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lblTotalBooking);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 459);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(444, 101);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Occupancy Details";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(179, 43);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(185, 27);
            this.txtTotal.TabIndex = 63;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTotalBooking
            // 
            this.lblTotalBooking.AutoSize = true;
            this.lblTotalBooking.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBooking.Location = new System.Drawing.Point(6, 47);
            this.lblTotalBooking.Name = "lblTotalBooking";
            this.lblTotalBooking.Size = new System.Drawing.Size(128, 18);
            this.lblTotalBooking.TabIndex = 62;
            this.lblTotalBooking.Text = "Total Bookings:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(58, 134);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(80, 18);
            this.lblEndDate.TabIndex = 54;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(58, 81);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(96, 18);
            this.lblStartDate.TabIndex = 55;
            this.lblStartDate.Text = "Start Date:";
            // 
            // bookingListView
            // 
            this.bookingListView.HideSelection = false;
            this.bookingListView.Location = new System.Drawing.Point(51, 215);
            this.bookingListView.Name = "bookingListView";
            this.bookingListView.Size = new System.Drawing.Size(920, 191);
            this.bookingListView.TabIndex = 75;
            this.bookingListView.UseCompatibleStateImageBehavior = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(47, 182);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(153, 20);
            this.lblMessage.TabIndex = 76;
            this.lblMessage.Text = "Occupancy Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Please select the Dates to view Occupancy";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(844, 519);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(111, 41);
            this.btnHome.TabIndex = 78;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // dTPStartDate
            // 
            this.dTPStartDate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPStartDate.Location = new System.Drawing.Point(203, 76);
            this.dTPStartDate.Name = "dTPStartDate";
            this.dTPStartDate.Size = new System.Drawing.Size(292, 25);
            this.dTPStartDate.TabIndex = 79;
            // 
            // dTPEndDate
            // 
            this.dTPEndDate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPEndDate.Location = new System.Drawing.Point(203, 129);
            this.dTPEndDate.Name = "dTPEndDate";
            this.dTPEndDate.Size = new System.Drawing.Size(292, 25);
            this.dTPEndDate.TabIndex = 80;
            // 
            // OccupancyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 638);
            this.Controls.Add(this.dTPEndDate);
            this.Controls.Add(this.dTPStartDate);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.bookingListView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Name = "OccupancyReport";
            this.Text = "OccupancyReport";
            this.Load += new System.EventHandler(this.OccupancyReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotalBooking;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ListView bookingListView;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DateTimePicker dTPStartDate;
        private System.Windows.Forms.DateTimePicker dTPEndDate;
    }
}