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
    public partial class CustomerListingForm : Form
    {
        #region Variables
        public bool listFormClosed;//= true;
        private Collection<Customer> customers;
        private Customer customer;
        private BookingController bookingController;
        private FormStates state;

        //Add form states 
         public enum FormStates
         {
          View = 0,
           Add = 1,
           Edit = 2,
          Delete = 3
          }

        #endregion

        #region Constructor
        public CustomerListingForm()
        {
            InitializeComponent();
            this.Load += CustomerListingForm_Load;
            //this.Activated += EmployeeListingForm_Activated;
            state = FormStates.View;
        }

        public CustomerListingForm(BookingController cusController)
        {
            InitializeComponent();
            bookingController = cusController;
            //this.Load += EmployeeListingForm_Load;
          //  this.Activated += EmployeeListingForm_Activated;
            state = FormStates.View;
        }
        #endregion

        #region Events

        #endregion

        private void CustomerListingForm_Load(object sender, EventArgs e)
        {

        }
        #region Utility Methods
        private void ShowAll(bool value)
        {
            idLabel.Visible = value;
            cusIDLabel.Visible = value;
            nameLabel.Visible = value;
            emailLabel.Visible = value;
            streetNameLabel.Visible = value;
            idTextBox.Visible = value;
            cusIDTextBox.Visible = value;
            nameTextBox.Visible = value;
            emailTextBox.Visible = value;
            streetNameTextBox.Visible = value;
            suburbNameLabel.Visible = value;
            suburbTextBox.Visible = value;
            cityTextBox.Visible = value;
            cityNamelbl.Visible = value;
            postalCodelbl.Visible = value;
            PostalCodeTextBox.Visible = value;
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
            idTextBox.Text = "";
            cusIDTextBox.Text = "";
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            streetNameTextBox.Text = "";
            suburbTextBox.Text = "";
            cityTextBox.Text = "";
            PostalCodeTextBox.Text = "";
        }

        #endregion

        private void listLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
