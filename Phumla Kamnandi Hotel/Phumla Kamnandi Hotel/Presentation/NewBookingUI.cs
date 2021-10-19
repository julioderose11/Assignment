using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi_Hotel.Business;
using Phumla_Kamnandi_Hotel.Data;


namespace Phumla_Kamnandi_Hotel.Presentation
{
    public partial class NewBookingUI : Form
    {
        #region Data Members
        //declaring a reference to the Booking and the Controller class
        private Booking booking;
        private BookingController bookingController;
        public bool newBookingFormClosed = false;
        private DateTime currentDate = DateTime.Now;
        #endregion

        #region Constructor
        public NewBookingUI(BookingController bController)
        {
            InitializeComponent();

            lblDate.Text = DateTime.Now.ToLongDateString() + "" + DateTime.Now.ToLongTimeString(); //current date and time of booking

            bookingController = bController;
        }
        #endregion

        #region Utility Methods
        //methods which bring utility to the UI 
        private void ShowAll() //method to activated and show controls and labels
        {
            lblArrivalDate.Visible = true;
            lblDepartureDate.Visible = true;
            lblNoOfPeople.Visible = true;
            lblSpecialInstructions.Visible = true;
            gpBoxGuest.Visible = true;
            dTPArrivalDate.Visible = true;
            dTPDepartureDate.Visible = true;
            txtNoOfPeople.Visible = true;
            richTxtSpecInstructions.Visible = true;
            radExistingGuest.Visible = true;
            radNewGuest.Visible = true;
            btnRoomAvailability.Visible = true;
            btnCancel.Visible = true;
            btnExit.Visible = true;
        }

        private void ClearAll() //method to clear all controls
        {
            dTPArrivalDate.Text = "";
            dTPDepartureDate.Text = "";
            txtNoOfPeople.Text = "";
            richTxtSpecInstructions.Text = "";
            radExistingGuest.Checked = false;
            radNewGuest.Checked = false;
        }

        private void PopulateObject() //method to populate a booking object 
        {
            
            booking = new Booking();
            //may have to put bookingID generator method here and create id here...
            booking.getBookingDate = currentDate;
            booking.getArrival = (DateTime) dTPArrivalDate.Value;
            booking.getDeparture = (DateTime)dTPDepartureDate.Value;
            booking.getCustomerRequests = richTxtSpecInstructions.Text;

        }

        #endregion

        #region Radio Button CheckChanged Events

        //come back for forms 


        #endregion


        #region Form Events


        private void lblGuestType_Click(object sender, EventArgs e)
        {
            //Please ignore by accidental double click
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            newBookingFormClosed = true;
        }

      
        private void NewBookingUI_Load(object sender, EventArgs e)
        {
            dTPArrivalDate.Format = DateTimePickerFormat.Short;
            dTPDepartureDate.Format = DateTimePickerFormat.Short;
            ShowAll();
        }

        private void NewBookingUI_Activated(object sender, EventArgs e)
        {
            ShowAll();
            radExistingGuest.Checked = false;
            radNewGuest.Checked = false;

        }

        private void btnRoomAvailability_Click(object sender, EventArgs e)
        {
            
            PopulateObject();
            MessageBox.Show("Confirm Booking", "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            bookingController.DataMaintenance(booking, DB.DBOperation.Add);
            bookingController.FinalizeChanges(booking);
            ClearAll();
            ShowAll();
        }

        #endregion

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
