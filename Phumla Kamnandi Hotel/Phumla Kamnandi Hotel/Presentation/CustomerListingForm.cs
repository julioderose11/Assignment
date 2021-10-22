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
            customersListView.View = View.Details;
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
        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                idTextBox.Enabled = !value;
                //do the same for all buttons & textboxes
                cusIDTextBox.Enabled = !value;
            }
            else
            {
                idTextBox.Enabled = value;
                cusIDTextBox.Enabled = value;
            }
            nameTextBox.Enabled = value;
            emailTextBox.Enabled = value;
            streetNameTextBox.Enabled = value;
            suburbTextBox.Enabled = value;
            cityTextBox.Enabled = value;
            PostalCodeTextBox.Enabled = value;
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
        private void PopulateTextBoxes(Customer customer)
        {
            
            idTextBox.Text = customer.getPersonID;
            cusIDTextBox.Text = customer.CustomerID;
            nameTextBox.Text = customer.getFName;
            emailTextBox.Text = customer.getEmail;
            streetNameTextBox.Text = customer.getStreetName;
            suburbTextBox.Text = customer.getSuburbName;
            cityTextBox.Text = customer.getCityName;
            PostalCodeTextBox.Text = customer.getPostalCode;
            
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
            customersListView.Columns.Insert(3, "Email", 120, HorizontalAlignment.Left);
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
            private void listLabel_Click(object sender, EventArgs e)
        {

        }

        private void bookingListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            if (customersListView.SelectedItems.Count > 0)   // if you selected an item 
            {
                customer = bookingController.FindCustomer(customersListView.SelectedItems[0].Text);  //selected customer becomes current customer
                                                                                             // Show the details of the selected customer in the controls
                PopulateTextBoxes(customer);
            }
        }
        #endregion
    }
}
