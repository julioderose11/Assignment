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
    public partial class ExistingCustomersForm : Form
    {
        #region Data Members
        //declaring a reference to the Booking and the Controller class
        private Customer customer;
        private BookingController bookingController;
        public bool existingCustomerFormClosed = false;

        #endregion

        #region Constructor
        public ExistingCustomersForm(BookingController aController)
        {
            InitializeComponent();
            bookingController = aController;
        }
        #endregion

        #region Utility Methods
        //methods which bring utility to the UI 
        private void ShowAll() //method to activated and show controls and labels
        {
            lblFName.Visible = true;
            lblLName.Visible = true;
            lblQuestion.Visible = true;
            txtFName.Visible = true;
            txtGuestID.Visible = true;
            txtLName.Visible = true;
            btnSearch.Visible = true;
            btnHome.Visible = true;
            btnConfirm.Visible = true;
            btnCancel.Visible = true;


        }

        private void ClearAll() //method to clear all controls
        {
            txtFName.Text = " ";
            txtGuestID.Text = " ";
            txtLName.Text = " ";
        }

        private void PopulateObject() //method to populate a booking object 
        {

            customer = new Customer();
            customer.CustomerID = 


            //ask how to retrieve specific data from the database. 
        }

        #endregion

        #region Form Events


        private void lblGuestType_Click(object sender, EventArgs e)
        {
            //Please ignore by accidental double click
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            existingCustomerFormClosed = true;
        }


        private void NewBookingUI_Load(object sender, EventArgs e)
        {
            ShowAll();
            bookingController = new BookingController();

        }

        private void NewBookingUI_Activated(object sender, EventArgs e)
        {
            ShowAll();
            
        }

        private void btnRoomAvailability_Click(object sender, EventArgs e)
        {

            PopulateObject();
            MessageBox.Show("To be submitted to the Database!");
            bookingController.DataMaintenance(customer, DB.DBOperation.Add);
            //bookingController.FinalizeChanges(booking);
            ClearAll();
            ShowAll();
        }

        #endregion

    }
}
