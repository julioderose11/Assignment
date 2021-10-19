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
using System.Collections.ObjectModel;
using Phumla_Kamnandi_Hotel.Business;


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
        private Collection<RoomBooking> roomBookings;
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

        public void PopulateObject() //method to populate a booking object 
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            newBookingFormClosed = true;
        }

      
        private void NewBookingUI_Load(object sender, EventArgs e)
        {
            dTPArrivalDate.Format = DateTimePickerFormat.Short;
            dTPDepartureDate.Format = DateTimePickerFormat.Short;
            //bookingController = new BookingController();
            ClearAll();
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
            //retrieve all roomBooking objects and add it to the roomBookings collection
            roomBookings = bookingController.AllRoomBookings;
            //Loop through all roomBooking objects in collection to determine whther dates supplied are valid
            foreach(RoomBooking roomBooking in roomBookings)
            {
                //controller class enacts availability method to determine whether a room is available for specified dates
                if(bookingController.isAvailable(dTPArrivalDate.Value, dTPDepartureDate.Value) == true)
                {                    
                    DialogResult returnDialogResult = MessageBox.Show("Confirm Booking", "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if(returnDialogResult == DialogResult.Yes)
                    {
                        //but must first enter customer deatils and only then can we populate booking object
                        //maybe make the method public static and then call it in the other forms?
                        PopulateObject();
                        bookingController.DataMaintenance(booking, DB.DBOperation.Add);
                        bookingController.FinalizeChanges(booking);

                        //Must also populate roomBooking class - so give it the newly populated booking object and the associated room

                        if(radExistingGuest.Checked)
                        {
                            ExistingCustomersForm existingCustomerForm = new ExistingCustomersForm(bookingController); //is argument necessary???
                            existingCustomerForm.ShowDialog();

                        }
                        else
                        {
                            NewCustomersForm newCustomerForm = new NewCustomersForm(bookingController); //is argument necessary???
                            newCustomerForm.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No available rooms between " + dTPArrivalDate.Value.Date + " and " + dTPDepartureDate.Value.Date 
                        + "\nPlease select another set of dates.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dTPArrivalDate.Text = "";
                    dTPDepartureDate.Text = "";
                    dTPArrivalDate.Focus();

                }
    
            }


        }

        #endregion

 
    }
}
