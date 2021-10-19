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
        public NewBookingUI(BookingController aController)
        {
            InitializeComponent();

            lblDate.Text = DateTime.Now.ToLongDateString() + "" + DateTime.Now.ToLongTimeString(); //current date and time of booking

            bookingController = aController;
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
            txtArrivaleDate.Visible = true;
            txtDepartureDate.Visible = true;
            txtNoOfPeople.Visible = true;
            richTxtSpecInstructions.Visible = true;
            radExistingGuest.Visible = true;
            radNewGuest.Visible = true;
            btnRoomAvailability.Visible = true;
            btnCancel.Visible = true;
            btnExit.Visible = true;
            monthCalendar.Visible = true;
        }

        private void ClearAll() //method to clear all controls
        {
            txtArrivaleDate.Text = "";
            txtDepartureDate.Text = "";
            txtNoOfPeople.Text = "";
            richTxtSpecInstructions.Text = "";
            radExistingGuest.Checked = false;
            radNewGuest.Checked = false;
        }

        private void PopulateObject() //method to populate a booking object 
        {
            booking = new Booking();
            booking.getBookingDate = currentDate;
            booking.getArrival = DateTime.Parse(txtArrivaleDate.Text);
            booking.getDeparture = DateTime.Parse(txtDepartureDate.Text);
            booking.getCustomerRequests = richTxtSpecInstructions.Text;


            //ask the group about the booking object and the current UI
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
            MessageBox.Show("To be submitted to the Database!");
            bookingController.DataMaintenance(booking, DB.DBOperation.Add);
            //bookingController.FinalizeChanges(booking);
            ClearAll();
            ShowAll();
        }

        #endregion

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
