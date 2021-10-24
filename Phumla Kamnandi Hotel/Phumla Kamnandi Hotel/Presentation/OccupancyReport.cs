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
        private Collection<Account> accounts;

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
            public void setUpOccupancyListView()
        {
            ListViewItem OccupancyReport;
            roomBookings = null;
            bookingListView.Clear();

            bookingListView.Columns.Insert(0, "Reference Number", 150, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(1, "CustomerID", 120, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(2, "AccountNum", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(1, "CustomerRequests", 240, HorizontalAlignment.Left);
            //bookingListView.Columns.Insert(4, "BookingDate", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(2, "ArrivalDate", 150, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(3, "DepartureDate", 150, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(4, "numPeople", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(5, "Amount Due", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(6, "Deposit Amount", 120, HorizontalAlignment.Left);

            roomBookings = bookingController.AllRoomBookings;
            Collection<RoomBooking> rbs;
            rbs = BookingController.FindByDate(roomBookings, dTPStartDate.Value, dTPEndDate.Value);
            accounts = bookingController.AllAccounts;
            
                foreach (RoomBooking rb in rbs)
                {
                foreach (Account account in accounts)
                {
                    if (rb.getBookingObject.getAccountNum == account.AccountNum)
                    {
                        OccupancyReport = new ListViewItem();
                        OccupancyReport.Text = rb.getBookingObject.getBookingID.ToString();
                        OccupancyReport.SubItems.Add(rb.getBookingObject.getCustomerRequests.ToString());
                        OccupancyReport.SubItems.Add(rb.getBookingObject.getArrival.ToShortDateString());
                        OccupancyReport.SubItems.Add(rb.getBookingObject.getDeparture.ToShortDateString());
                        OccupancyReport.SubItems.Add(rb.getBookingObject.getNumPeople.ToString());
                        OccupancyReport.SubItems.Add(account.AmountDue.ToString());
                        OccupancyReport.SubItems.Add(account.DepositAmount.ToString());
                        bookingListView.Items.Add(OccupancyReport);
                    }
                }                    
                }            
            bookingListView.Refresh();
            bookingListView.GridLines = true;
            txtTotal.Text = Convert.ToString(rbs.Count);
        }
        #endregion

        
    }
}
