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
    public partial class BookingListingForm : Form
    {
        #region Variables
        public bool listFormClosed;//= true;
        private Collection<Booking> bookings;
        private Booking booking;
        private RoomBooking roomBook;
        private BookingController bookingController;
        private FormStates state;
        private String arrivalDateTempVal;
        private String departureDateTempVal;

        //Form state enumeration allows the recpetionist to edit or change bookings
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }

        #endregion

        #region Constructor
        
        public BookingListingForm(BookingController cusController)
        {
            InitializeComponent();
            bookingController = cusController;
            this.Load += BookingListingForm_Load;
            this.Activated += BookingListingForm_Activated;
            state = FormStates.View;
        }

        #endregion

        #region Events
        private void BookingListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        private void BookingListingForm_Load(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
        }

        private void BookingListingForm_Activated(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
            setUpBookingListView();
            ShowAll(false);
        }
        #endregion

        #region Utility methods

        private void ShowAll(bool value)
        {


            
            //If the form state is View, the Submit button and the Edit button should not be visible
            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                submitButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                submitButton.Visible = value;
            }

        }

        private void ClearAll()
        {
            txtBookingID.Text = "";
            txtAccount.Text = "";
            txtCusID.Text = "";
            rTxtCustRequests.Text = "";
            txtBookingDate.Text = " ";
            dtPArrivalDate.CustomFormat = "";
            dTPDepDate.CustomFormat = "";
            txtNumPeople.Text = "";
            
        }


        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                txtBookingID.Enabled = !value;
                txtAccount.Enabled = !value;
                txtCusID.Enabled = !value;
                txtBookingDate.Enabled = !value;
            }
            else
            {
                txtBookingID.Enabled = value;
                txtAccount.Enabled = value;
                txtCusID.Enabled = value;
            }
            
            rTxtCustRequests.Enabled = value;
            txtBookingDate.Enabled = value;
            dtPArrivalDate.Enabled = value;
            dTPDepDate.Enabled = value;
            txtNumPeople.Enabled = value;
            
            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                submitButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                submitButton.Visible = value;
            }
        }
        private void PopulateTextBoxes(Booking booking)
        {
            txtBookingID.Text = booking.getBookingID;
            txtCusID.Text = booking.getCustomerID;
            txtAccount.Text = booking.getAccountNum;
            rTxtCustRequests.Text = booking.getCustomerRequests;
            txtBookingDate.Text = Convert.ToString(booking.getBookingDate);
            dtPArrivalDate.Text = Convert.ToString(booking.getArrival);
            dTPDepDate.Text = Convert.ToString(booking.getDeparture);
            txtNumPeople.Text = Convert.ToString(booking.getNumPeople);

        }
        private void PopulateObject()
        {
            booking = new Booking();
            booking.getBookingID = txtBookingID.Text;
            booking.getCustomerID = txtCusID.Text;
            booking.getAccountNum = txtAccount.Text;
            booking.getCustomerRequests = rTxtCustRequests.Text; 
            booking.getBookingDate =Convert.ToDateTime(txtBookingDate.Text); 
            booking.getArrival = Convert.ToDateTime(dtPArrivalDate.Text); 
            booking.getDeparture = Convert.ToDateTime(dTPDepDate.Text); 
            booking.getNumPeople = Convert.ToInt32(txtNumPeople.Text);

            roomBook = new RoomBooking();
            roomBook.getBookingObject = booking;

        }
        #endregion

        #region ListView set up
        public void setUpBookingListView()
        {
            ListViewItem bookingDetails;
            bookings = null;
            bookingListView.Clear();

            bookingListView.Columns.Insert(0, "Reference Number", 150, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(1, "CustomerID", 120, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(2, "AccountNum", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(1, "CustomerRequests", 240, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(4, "BookingDate", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(2, "ArrivalDate", 150, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(3, "DepartureDate", 150, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(4, "numPeople", 120, HorizontalAlignment.Left);

            bookings = bookingController.AllBookings;
            foreach (Booking booking in bookings)
            {
                bookingDetails = new ListViewItem();
                bookingDetails.Text = booking.getBookingID.ToString();
                //bookingDetails.SubItems.Add(booking.getCustomerID.ToString());
                //bookingDetails.SubItems.Add(booking.getAccountNum.ToString());
                bookingDetails.SubItems.Add(booking.getCustomerRequests.ToString());
                //bookingDetails.SubItems.Add(booking.getBookingDate.ToString());
                bookingDetails.SubItems.Add(booking.getArrival.ToShortDateString());
                bookingDetails.SubItems.Add(booking.getDeparture.ToShortDateString());
                bookingDetails.SubItems.Add(booking.getNumPeople.ToString());

                bookingListView.Items.Add(bookingDetails); 
            }
            bookingListView.Refresh();
            bookingListView.GridLines = true;

        }

         
        private void bookingListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            //checks if a list item is selected
            if (bookingListView.SelectedItems.Count > 0)
            {
                //populates a booking object with the selected booking items information using the FindBooking objec
                booking = bookingController.FindBooking(bookingListView.SelectedItems[0].Text);
                //Calls the PopulateTextBoxes method to populate texboxes with the selected bookings information from the database
                PopulateTextBoxes(booking);
                //captures the original dates of the booking to use as reference if the user decides to edit them 
                arrivalDateTempVal = Convert.ToString(booking.getArrival);
                departureDateTempVal = Convert.ToString(booking.getDeparture);
            }
        }

        #endregion

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Depending on which state the receptionist has entered (Edit or delete), the following code will run
            if (state == FormStates.Edit)
            {
                //first checks whether the user has entered new arrival and/or departure dates
                if(arrivalDateTempVal != dtPArrivalDate.Text || departureDateTempVal != dTPDepDate.Text)
                {
                    //checks whether there are any rooms available for the new dates
                    if (bookingController.isAvailable(dtPArrivalDate.Value, dTPDepDate.Value) == true)
                    {
                        MessageBox.Show("i");
                        PopulateObject();
                        bookingController.DataMaintenance(booking, Data.DB.DBOperation.Edit);
                    }
                    else
                    {
                        MessageBox.Show("Unavailable dates, please try again.", "New Dates Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dtPArrivalDate.Focus();
                    }
                }
                else //dont have to check room availability
                {
                    PopulateObject();
                    bookingController.DataMaintenance(booking, Data.DB.DBOperation.Edit);
                } 
               // PopulateObject();
               // bookingController.DataMaintenance(booking, Data.DB.DBOperation.Edit);
            }
            else
            {
                PopulateObject();
                bookingController.DataMaintenance(booking, Data.DB.DBOperation.Delete);
                bookingController.DataMaintenance(roomBook, Data.DB.DBOperation.Delete);
            }
            bookingController.FinalizeChanges(booking);
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpBookingListView();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            state = FormStates.Edit;
            EnableEntries(true);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //set the form state to Delete
            state = FormStates.Delete;
            //call the ShowAll method
            //ShowAll(false);
            EnableEntries(false);
            MessageBox.Show("This record is about to be deleted");
        }

        private void bookingListingForm_Activated_1(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
            setUpBookingListView();
            ShowAll(false);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            
            ClearAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //assigns the dialogresult variable the value of OK when pressed. MDIParent reads this, closes the form, and shows itself
            DialogResult = DialogResult.OK;
        }
    }
}
