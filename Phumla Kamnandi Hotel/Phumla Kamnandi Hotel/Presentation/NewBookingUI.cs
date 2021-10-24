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
        public bool listFormClosed;
        private Booking booking;
        private RoomBooking roombooking;
        private Room room;
        private BookingController bookingController;
        public bool newBookingFormClosed = false;
        private DateTime currentDate = DateTime.Now;
        private Collection<RoomBooking> roomBookings;
        private Collection<Room> rooms;
        private Collection<Customer> customers;
        private Customer customer;
        private Collection<Person> persons;
        private Person person;
        private Account account;
        public string customerID;
        public string storeBookigID;
   

        #endregion

        #region Constructor
        public NewBookingUI(BookingController bController)
        {
            InitializeComponent();
            currentDatetxt.Text = DateTime.Now.ToLongDateString() + "" + DateTime.Now.ToLongTimeString(); //current date and time of booking
            bookingController = bController;
            this.Load += NewBookingUI_Load;
            this.Activated += NewBookingUI_Activated_1; 
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
            customersListView.Visible = true;
        }

        private void ClearAll() //method to clear all controls
        {
            dTPArrivalDate.Text = "";
            dTPDepartureDate.Text = "";
            txtNoOfPeople.Text = "";
            richTxtSpecInstructions.Text = "";

        }

        public void PopulateAccountObject()
        {
  
            account = new Account();
            account.AmountDue = 0;
            account.DepositAmount = 0;
            //account.DepositAmount = account.AmountDue * 0.15;
            MessageBox.Show(account.AccountNum);
        }

        public void PopulateBookingObject() //method to populate a booking object 
        {
            
            booking = new Booking();
            booking.getAccountNum = account.AccountNum;
            booking.getCustomerID = customerID; 
            booking.getBookingDate = currentDate;
            booking.getArrival = (DateTime) dTPArrivalDate.Value;
            booking.getDeparture = (DateTime)dTPDepartureDate.Value;
            booking.getCustomerRequests = richTxtSpecInstructions.Text;
            booking.getNumPeople = Convert.ToInt32(txtNoOfPeople.Text);
            booking.getPrice = GenerateAmountDue(booking.getArrival);
             
            storeBookigID = booking.getBookingID;
            

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
            dTPArrivalDate.Enabled = value;
            dTPDepartureDate.Enabled = value;
            txtNoOfPeople.Enabled = value;
            richTxtSpecInstructions.Enabled = value;
            btnRoomAvailability.Enabled = value;
        }

        private bool IsValidData()
        {
            return
                // Validate all the items to ensure they all have the correct inputs
                // This ensure that there is a a text input into the: no of people and current date text box as well as the specInstruction rich textbo
                Validator.IsPresent(txtNoOfPeople) &&
                Validator.IsPresent(currentDatetxt) &&
                Validator.IsPresent(richTxtSpecInstructions) &&
                

                //The below ensures that the datetimepicker has input of DateTime
                Validator.IsDateTime(dTPArrivalDate) &&
                Validator.IsDateTime(dTPDepartureDate) &&

                //The below ensure  that the number of people is an int variable type
                Validator.IsInt32(txtNoOfPeople) &&
                

                //the below ensure that the the minimun number of people is 1 and the maxium number of people per room is 2
                Validator.IsWithinRange(txtNoOfPeople, 1, 2);
            

        }
        #endregion

        #region Form Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            //assigns the dialogresult variable the value of OK when pressed. MDIParent reads this, closes the form, and shows itself
            DialogResult = DialogResult.OK;
        }

        private void NewBookingUI_Load(object sender, EventArgs e)
        {
            dTPArrivalDate.Format = DateTimePickerFormat.Short;
            dTPDepartureDate.Format = DateTimePickerFormat.Short;
            currentDatetxt.Enabled = false;
            ClearAll();
            ShowAll();
            EnableEntries(false);
            customersListView.View = View.Details;
        }

        private void NewBookingUI_Activated_1(object sender, EventArgs e)
        {
            customersListView.View = View.Details;
            setUpCustomerListView();

        }

        private void btnRoomAvailability_Click(object sender, EventArgs e)
        {
            try
            {
                //controller class enacts availability method to determine whether a room is available for specified dates

                if (IsValidData() && bookingController.isAvailable(dTPArrivalDate.Value, dTPDepartureDate.Value) == true)
                {
                    DialogResult returnDialogResult = MessageBox.Show("Confirm Booking", "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (returnDialogResult == DialogResult.Yes)
                    {
                        //populate account object first to obtain account number for booking object
                        PopulateAccountObject();
                        bookingController.DataMaintenance(account, DB.DBOperation.Add);
                        bookingController.FinalizeChanges(account);

                        PopulateBookingObject();
                        bookingController.DataMaintenance(booking, DB.DBOperation.Add);
                        bookingController.FinalizeChanges(booking);

                        //Must also populate roomBooking class - so give it the newly populated booking object and the associated room
                        PopulateRoomBookingObject();
                        bookingController.DataMaintenance(roombooking, DB.DBOperation.Add);
                        bookingController.FinalizeChanges(roombooking);

                        MessageBox.Show("Customer booking reference number is: " + storeBookigID, "Reference Number", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //assigns the dialogresult variable the value of OK when pressed. MDIParent reads this, closes the form, and shows itself
                        DialogResult = DialogResult.OK;
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
            catch (Exception ex) //catch any other expection that might occur
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }


            /*
            //controller class enacts availability method to determine whether a room is available for specified dates

            if (bookingController.isAvailable(dTPArrivalDate.Value, dTPDepartureDate.Value) == true)
            {
                DialogResult returnDialogResult = MessageBox.Show("Confirm Booking", "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (returnDialogResult == DialogResult.Yes)
                {
                    //populate account object first to obtain account number for booking object
                    PopulateAccountObject();
                    bookingController.DataMaintenance(account, DB.DBOperation.Add);
                    bookingController.FinalizeChanges(account);

                    PopulateBookingObject();
                    bookingController.DataMaintenance(booking, DB.DBOperation.Add);
                    bookingController.FinalizeChanges(booking);

                    //Must also populate roomBooking class - so give it the newly populated booking object and the associated room
                    PopulateRoomBookingObject();
                    bookingController.DataMaintenance(roombooking, DB.DBOperation.Add);
                    bookingController.FinalizeChanges(roombooking);

                    MessageBox.Show("Customer booking reference number is: " + storeBookigID, "Reference Number", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    //assigns the dialogresult variable the value of OK when pressed. MDIParent reads this, closes the form, and shows itself
                    DialogResult = DialogResult.OK;
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
            */

            

        }


        #endregion

        #region ListView set up
        public void setUpCustomerListView()
        {
            ListViewItem customerDetails;
            persons = null;
            customersListView.Clear();

            customersListView.Columns.Insert(0, "CustomerID", 160, HorizontalAlignment.Left);
            customersListView.Columns.Insert(1, "PersonID", 160, HorizontalAlignment.Left);
            customersListView.Columns.Insert(2, "FirstName", 160, HorizontalAlignment.Left);
            customersListView.Columns.Insert(3, "SecondName", 160, HorizontalAlignment.Left);
            /*customersListView.Columns.Insert(4, "StreetName", 120, HorizontalAlignment.Left);
            customersListView.Columns.Insert(5, "SuburbName", 120, HorizontalAlignment.Left);
            customersListView.Columns.Insert(6, "Cityname", 120, HorizontalAlignment.Left);
            customersListView.Columns.Insert(7, "PostalCode", 120, HorizontalAlignment.Left);
            customersListView.Columns.Insert(8, "Email", 120, HorizontalAlignment.Left);*/

            customers = bookingController.AllCustomers;
            persons = bookingController.AllPersons;
            foreach (Customer customer in customers)
            {               
                foreach(Person person in persons)
                {
                    
                    
                    customerDetails = new ListViewItem();
                    if (customer.getPersonID.Equals(person.getPersonID))
                    {
                        customerDetails.Text = customer.CustomerID.ToString();
                        customerDetails.SubItems.Add(customer.getPersonID);
                        customerDetails.SubItems.Add(person.getFName.ToString());
                        customerDetails.SubItems.Add(person.getSName.ToString());
                        /*customerDetails.SubItems.Add(person.getEmail.ToString());
                        customerDetails.SubItems.Add(person.getStreetName.ToString());
                        customerDetails.SubItems.Add(person.getSuburbName.ToString());
                        customerDetails.SubItems.Add(person.getCityName.ToString());
                        customerDetails.SubItems.Add(person.getPostalCode.ToString())*/;
                        customersListView.Items.Add(customerDetails);
                    }
                }
            }
            
            customersListView.Refresh();
            customersListView.GridLines = true;
        }

        //Determine the index of the selected item in the ListView
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll();
            EnableEntries(true);
            if (customersListView.SelectedItems.Count > 0)   // if you selected an item 
            {
                //person = bookingController.FindPerson(customersListView.SelectedItems[0].Text);  //selected customer becomes current customer
                customer = bookingController.FindCustomer(customersListView.SelectedItems[0].Text);
                customerID = customer.CustomerID;
            }
            
        }



        #endregion

        private void txtNoOfPeople_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void currentDatetxt_TextChanged(object sender, EventArgs e)
        {
            currentDatetxt.Text= Convert.ToString(DateTime.UtcNow);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void lblSpecialInstructions_Click(object sender, EventArgs e)
        {
            //ignore
        }
    }
}
