
namespace Phumla_Kamnandi_Hotel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Booking = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(628, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Booking
            // 
            this.Booking.Location = new System.Drawing.Point(3, 47);
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(75, 23);
            this.Booking.TabIndex = 2;
            this.Booking.Text = "Booking";
            this.Booking.UseVisualStyleBackColor = true;
            this.Booking.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(84, 47);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(75, 23);
            this.Calendar.TabIndex = 3;
            this.Calendar.Text = "Calendar";
            this.Calendar.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.Reports.Location = new System.Drawing.Point(165, 47);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(75, 23);
            this.Reports.TabIndex = 4;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(578, 52);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(44, 13);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search:";
            this.Search.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Reports);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.Booking);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Booking;
        private System.Windows.Forms.Button Calendar;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Label Search;
    }
}

