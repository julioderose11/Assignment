
namespace Phumla_Kamnandi_Hotel.Presentation
{
    partial class CustomerListingForm
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
            this.bookingListView = new System.Windows.Forms.ListView();
            this.listLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookingListView
            // 
            this.bookingListView.HideSelection = false;
            this.bookingListView.Location = new System.Drawing.Point(32, 53);
            this.bookingListView.Margin = new System.Windows.Forms.Padding(4);
            this.bookingListView.Name = "bookingListView";
            this.bookingListView.Size = new System.Drawing.Size(1119, 312);
            this.bookingListView.TabIndex = 3;
            this.bookingListView.UseCompatibleStateImageBehavior = false;
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(32, 28);
            this.listLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(59, 20);
            this.listLabel.TabIndex = 2;
            this.listLabel.Text = "label1";
            // 
            // ListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 626);
            this.Controls.Add(this.bookingListView);
            this.Controls.Add(this.listLabel);
            this.Name = "ListingForm";
            this.Text = "ListingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bookingListView;
        private System.Windows.Forms.Label listLabel;
    }
}