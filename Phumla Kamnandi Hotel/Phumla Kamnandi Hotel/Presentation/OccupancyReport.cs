using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi_Hotel.Business;

namespace Phumla_Kamnandi_Hotel.Presentation
{
    public partial class OccupancyReport : Form
    {
        #region Info
        //This form is used to show the occupancy levels at the hotel. It does this by calling methods from the controller to view roomBooking objects
        #endregion

        #region Variables
        //declaring varoables 
        private Collection<RoomBooking> roomBookings;
        private Collection<Booking> bookings;
        private RoomBooking roomBook;
        
        private BookingController bookingController;
        public bool listFormClosed;//= true;
        #endregion

        #region Constructor
        public OccupancyReport(BookingController cusController)
        {
            InitializeComponent();
            bookingController = cusController;
           this.Load += OccupancyReport_Load;
           this.Activated += OccupancyReport_Activated;
        }
        #endregion

        #region events

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ignore 
        }

        private void OccupancyReport_Load(object sender, EventArgs e)
        {
            //this ensure that the listview actually populates details
            bookingListView.View = View.Details;

        }

        private void OccupancyReport_Activated(object sender, EventArgs e)
        {
            //this activates the form to operate
            bookingListView.View = View.Details;
           // setUpBookingListView();
          
        }

        private void OccupancyReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        #endregion

        #region Utility Methods
        //clearall method clears the textbox of all text
        private void ClearAll()
        {
           
            txtTotal.Text = "";
            
            

        }

        private void EnableEntries(bool value)
        {
            //this method enables and or unenables data entry into textboxes
           
            txtTotal.Enabled = value;
            
        }
        private void PopulateTextBoxes(RoomBooking roombooking)
        {


        }



       
        #endregion
    }
}
