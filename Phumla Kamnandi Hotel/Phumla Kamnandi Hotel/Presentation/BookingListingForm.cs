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
        private BookingController bookingController;
        //private FormStates state;

        //Add form states 
        // public enum FormStates
        // {
        //  View = 0,
        //   Add = 1,
        //   Edit = 2,
        //  Delete = 3
        //  }

        #endregion

        public BookingListingForm()
        {
            InitializeComponent();
        }

        public BookingListingForm(BookingController cusController)
        {
            InitializeComponent();
            bookingController = cusController;
            //this.Load += EmployeeListingForm_Load;
            //  this.Activated += EmployeeListingForm_Activated;
            //  state = FormStates.View;
        }

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
           // setUpEmployeeListView();
           // ShowAll(false, roleValue);
        }
        #endregion

     

    }
}
