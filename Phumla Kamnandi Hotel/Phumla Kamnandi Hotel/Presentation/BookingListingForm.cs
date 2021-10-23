﻿using System;
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
    public partial class bookingListingForm : Form
    {
        #region Variables
        public bool listFormClosed;//= true;
        private Collection<Booking> bookings;
        private Booking booking;
        private BookingController bookingController;
        private FormStates state;

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
        
        public bookingListingForm(BookingController cusController)
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
            txtBookingID.Text = " ";
            txtAccount.Text = " ";
            txtCusID.Text = " ";
            txtCustomerRequests.Text = " ";
            txtBookingDate.Text = " ";
            txtArrivalDate.Text = " ";
            txtDepartureDate.Text = " ";
            
        }


        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                txtBookingID.Enabled = !value;
                //do the same for all buttons & textboxes
                txtAccount.Enabled = !value;
            }
            else
            {
                txtBookingID.Enabled = value;
                txtAccount.Enabled = value;
            }
            txtCusID.Enabled = value;
            txtCustomerRequests.Enabled = value;
            txtBookingDate.Enabled = value;
            txtArrivalDate.Enabled = value;
            txtDepartureDate.Enabled = value;
            
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
            txtCustomerRequests.Text = booking.getCustomerRequests;
            txtBookingDate.Text = Convert.ToString(booking.getBookingDate);
            txtArrivalDate.Text = Convert.ToString(booking.getArrival);
            txtDepartureDate.Text = Convert.ToString(booking.getDeparture);

        }
        private void PopulateObject()
        {
            booking = new Booking();
            booking.getBookingID = txtBookingID.Text;                                    
            booking.getCustomerRequests = txtCustomerRequests.Text; 
            booking.getBookingDate =Convert.ToDateTime(txtBookingDate.Text); 
            booking.getArrival = Convert.ToDateTime(txtArrivalDate.Text); 
            booking.getDeparture = Convert.ToDateTime(txtDepartureDate.Text); 
           // booking.getNumPeople = txt.Text;       No num people txt box
        }
        #endregion

        #region ListView set up
        public void setUpBookingListView()
        {
            ListViewItem bookingDetails;
            bookings = null;
            bookingListView.Clear();

            bookingListView.Columns.Insert(0, "Reference Number", 120, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(1, "CustomerID", 120, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(2, "AccountNum", 120, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(3, "CustomerRequests", 120, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(4, "BookingDate", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(1, "ArrivalDate", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(2, "DepartureDate", 120, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(7, "numPeople", 120, HorizontalAlignment.Left);

            bookings = bookingController.AllBookings;
            foreach (Booking booking in bookings)
            {
                bookingDetails = new ListViewItem();
                bookingDetails.Text = booking.getBookingID.ToString();
                //bookingDetails.SubItems.Add(booking.getCustomerID.ToString());
                //bookingDetails.SubItems.Add(booking.getAccountNum.ToString());
                //bookingDetails.SubItems.Add(booking.getCustomerRequests.ToString());
                //bookingDetails.SubItems.Add(booking.getBookingDate.ToString());
                bookingDetails.SubItems.Add(booking.getArrival.ToString());
                bookingDetails.SubItems.Add(booking.getDeparture.ToString());
                //bookingDetails.SubItems.Add(booking.getNumPeople.ToString());

                bookingListView.Items.Add(bookingDetails); 
            }
            bookingListView.Refresh();
            bookingListView.GridLines = true;

        }

        private void bookingListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            if (bookingListView.SelectedItems.Count > 0)   
            {
                booking = bookingController.FindBooking(bookingListView.SelectedItems[0].Text);  
                                                                                                     
                PopulateTextBoxes(booking);
            }
        }


        #endregion

        private void submitButton_Click(object sender, EventArgs e)
        {
            PopulateObject();
            if (state == FormStates.Edit)
            {
                bookingController.DataMaintenance(booking, Data.DB.DBOperation.Edit);
            }
            else
            {
                bookingController.DataMaintenance(booking, Data.DB.DBOperation.Delete);
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

        private void bookingListingForm_Load_1(object sender, EventArgs e)
        {

        }

        private void bookingListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //set the form state to Delete
            state = FormStates.Delete;
            editButton.Visible = false;
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
    }
}
