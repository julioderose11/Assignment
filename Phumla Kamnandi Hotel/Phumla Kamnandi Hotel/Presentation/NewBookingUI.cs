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


namespace Phumla_Kamnandi_Hotel.Presentation
{
    public partial class NewBookingUI : Form
    {
        #region Data Members
        //declaring a reference to the Booking and the Controller class
        private Booking booking;
        private RoomBooking roombooking;
        private Room room;
        private BookingController bookingController;
        public bool newBookingFormClosed = false;
        private DateTime currentDate = DateTime.Now;
        private Collection<RoomBooking> roomBookings;
        private Collection<Room> rooms;
        private Collection<Customer> customers;
   

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
            lblMessage.Visible = true;
            dTPArrivalDate.Visible = true;
            dTPDepartureDate.Visible = true;
            txtNoOfPeople.Visible = true;
            richTxtSpecInstructions.Visible = true;
            btnRoomAvailability.Visible = true;
            btnCancel.Visible = true;
            btnExit.Visible = true;
            btnConfirmCustomer.Visible = true;
            customersListView.Visible = true;
        }

        private void ClearAll() //method to clear all controls
        {
            dTPArrivalDate.Text = "";
            dTPDepartureDate.Text = "";
            txtNoOfPeople.Text = "";
            richTxtSpecInstructions.Text = "";

        }

        public void PopulateBookingObject() //method to populate a booking object 
        {
            
            booking = new Booking();
            booking.getAccountNum = "";
            //booking.getCustomerID = 
            booking.getBookingDate = currentDate;
            booking.getArrival = (DateTime) dTPArrivalDate.Value;
            booking.getDeparture = (DateTime)dTPDepartureDate.Value;
            booking.getCustomerRequests = richTxtSpecInstructions.Text;
            booking.getNumPeople = Convert.ToInt32(txtNoOfPeople.Text);

        }

        public void PopulateRoomBookingObject()
        {
            //returns available room 
            room = bookingController.AvailRoom;

            //instantiates new roomBooking Object
            roombooking = new RoomBooking();
            roombooking.getBookingObject = booking;
            roombooking.getRoomObject = room;
        }

        private void EnableEntries(bool value)
        {
            if()
        }
        #endregion

        #region Radio Button CheckChanged Events

        //come back for forms 


        #endregion

        #region Form Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            newBookingFormClosed = true;
            this.Close();
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
        }

        private void btnRoomAvailability_Click(object sender, EventArgs e)
        {

            //controller class enacts availability method to determine whether a room is available for specified dates
            if (bookingController.isAvailable(dTPArrivalDate.Value, dTPDepartureDate.Value) == true)
            {
                DialogResult returnDialogResult = MessageBox.Show("Confirm Booking", "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (returnDialogResult == DialogResult.Yes)
                {
                    //but must first enter customer deatils and only then can we populate booking object
                    //maybe make the method public static and then call it in the other forms?
                    PopulateBookingObject();
                    bookingController.DataMaintenance(booking, DB.DBOperation.Add);
                    bookingController.FinalizeChanges(booking);

                    //Must also populate roomBooking class - so give it the newly populated booking object and the associated room
                    PopulateRoomBookingObject();
                    bookingController.DataMaintenance(roombooking, DB.DBOperation.Add);
                    bookingController.FinalizeChanges(roombooking);
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


        #endregion

        #region ListView set up
        public void setUpCustomerListView()
        {
            ListViewItem customerDetails;
            customers = null;
            customersListView.Clear();

            customersListView.Columns.Insert(0, "PersonID", 120, HorizontalAlignment.Left);
            customersListView.Columns.Insert(1, "CustomerID", 120, HorizontalAlignment.Left);
            customersListView.Columns.Insert(2, "FirstName", 120, HorizontalAlignment.Left);
            customersListView.Columns.Insert(4, "StreetName", 120, HorizontalAlignment.Left);
            customersListView.Columns.Insert(5, "SuburbName", 120, HorizontalAlignment.Left);
            customersListView.Columns.Insert(6, "Cityname", 120, HorizontalAlignment.Left);
            customersListView.Columns.Insert(7, "PostalCode", 120, HorizontalAlignment.Left);
            customersListView.Columns.Insert(8, "Email", 120, HorizontalAlignment.Left);
            customers = bookingController.AllCustomers;
            foreach (Customer customer in customers)
            {
                customerDetails = new ListViewItem();
                customerDetails.Text = customer.getPersonID.ToString();
                customerDetails.SubItems.Add(customer.CustomerID.ToString());
                customerDetails.SubItems.Add(customer.getFName.ToString());
                customerDetails.SubItems.Add(customer.getEmail.ToString());
                customerDetails.SubItems.Add(customer.getStreetName.ToString());
                customerDetails.SubItems.Add(customer.getSuburbName.ToString());
                customerDetails.SubItems.Add(customer.getCityName.ToString());
                customerDetails.SubItems.Add(customer.getPostalCode.ToString());

                customersListView.Items.Add(customerDetails);
            }
            customersListView.Refresh();
            customersListView.GridLines = true;
        }
        #endregion

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll();
            
            EnableEntries(false);
            if (customersListView.SelectedItems.Count > 0)   // if you selected an item 
            {
                customer = bookingController.FindCustomer(customersListView.SelectedItems[0].Text);  //selected customer becomes current customer
                                                                                                     // Show the details of the selected customer in the controls
                PopulateTextBoxes(customer);
            }
        }
    }
}
