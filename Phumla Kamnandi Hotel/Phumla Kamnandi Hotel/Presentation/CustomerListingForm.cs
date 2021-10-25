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
        public bool listFormClosed;
        private Collection<Customer> customers;
        private Collection<Person> persons;
        private Customer customer;
        private Person person;
        private BookingController bookingController;
        private FormStates state;
        private int numCustomer;


        //Add form states - Out of scope - can be use if project needed to be expanded to edit and delete customer records 
         public enum FormStates
         {
          View = 0,
           Add = 1,
           Edit = 2,
          Delete = 3
          }

        #endregion

        #region Constructor

        public CustomerListingForm(BookingController cusController)
        {
            InitializeComponent();
            bookingController = cusController;
            this.Load += CustomerListingForm_Load;
            this.Activated += CustomerListingForm_Activated;
            state = FormStates.View;
        }
        #endregion

        #region Events
        private void CustomerListingForm_Activated(object sender, EventArgs e)
        {
            customersListView.View = View.Details;
            setUpCustomerListView();
        }

        private void CustomerListingForm_Load(object sender, EventArgs e)
        {
            customersListView.View = View.Details;
        }
        #endregion

        #region Utility Methods

        //Clears all textbox information when called
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
        
        //sets enabled property of all textbox controls to specified boolean value
        private void EnableEntries(bool value)
        {
         
            idTextBox.Enabled = value;
            cusIDTextBox.Enabled = value;
            nameTextBox.Enabled = value;
            emailTextBox.Enabled = value;
            streetNameTextBox.Enabled = value;
            suburbTextBox.Enabled = value;
            cityTextBox.Enabled = value;
            PostalCodeTextBox.Enabled = value;
            txtNumCustomers.Enabled = value;

        }

        //Populates textboxes with information from the provided attribute objects
        private void PopulateTextBoxes(Customer customer, Person person)
        {
            
            idTextBox.Text = customer.getPersonID;
            cusIDTextBox.Text = customer.CustomerID;
            nameTextBox.Text = person.getFName;
            emailTextBox.Text = person.getEmail;
            streetNameTextBox.Text = person.getStreetName;
            suburbTextBox.Text = person.getSuburbName;
            cityTextBox.Text = person.getCityName;
            PostalCodeTextBox.Text = person.getPostalCode;
            
        }

        //Populates customer object with textbox information when called
        private void PopulateObject()
        {
            customer = new Customer();
            customer.CustomerID = cusIDTextBox.Text;
            customer.getPersonID = idTextBox.Text;
            customer.getEmail = emailTextBox.Text;
            customer.getStreetName = streetNameTextBox.Text;
            customer.getSuburbName = suburbTextBox.Text;
            customer.getCityName = cityTextBox.Text;
            customer.getPostalCode = PostalCodeTextBox.Text;

        }
       

        #endregion

        #region ListView set up
        //populates the list view with customer records from db
        public void setUpCustomerListView()
        {
            ListViewItem customerDetails;
            customers = null;
            customersListView.Clear();

            //Inserts column names into the listview
            customersListView.Columns.Insert(0, "PersonID", 160, HorizontalAlignment.Left);
            customersListView.Columns.Insert(1, "CustomerID", 160, HorizontalAlignment.Left);
            customersListView.Columns.Insert(2, "FirstName", 140, HorizontalAlignment.Left);
            customersListView.Columns.Insert(3, "SecondName", 140, HorizontalAlignment.Left);
            customersListView.Columns.Insert(4, "Email", 140, HorizontalAlignment.Left);

            //populates collections with all records from db
            customers = bookingController.AllCustomers;
            persons = bookingController.AllPersons;

            //uses two foreach loops to find the corresponding customer and person records from the two separate tables using the
            //foreign key PersonID to see if they correspond.
            //if they correspond then the attributes from those corresponding records are used to populate the listview
            foreach (Customer customer in customers)
            {
                foreach (Person person in persons)
                {
                    customerDetails = new ListViewItem();
                    
                    if (customer.getPersonID.Equals(person.getPersonID))
                    {
                        //listview column cells are populated with corresponding record information retrieved from collections
                        customerDetails.Text = customer.getPersonID.ToString();
                        customerDetails.SubItems.Add(customer.CustomerID.ToString());
                        customerDetails.SubItems.Add(person.getFName.ToString());
                        customerDetails.SubItems.Add(person.getSName.ToString());
                        customerDetails.SubItems.Add(person.getEmail.ToString());

                        customersListView.Items.Add(customerDetails);

                        //increment customer record count
                        numCustomer++;
                        txtNumCustomers.Text = Convert.ToString(numCustomer);
                    }
                        
                }

            }
            //List view is refreshed to show newly populated items
            customersListView.Refresh();
            //gridlines are shown on listview
            customersListView.GridLines = true;
        }

        private void bookingListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            state = FormStates.View;
            EnableEntries(false);

            //checks to see if item in listview is selected 
            if (customersListView.SelectedItems.Count > 0)    
            {
                //first cell of selected item is used as parameter for findcustomer and findperson methods to find the corresponding
                //objects in the collection populated from the db
                customer = bookingController.FindCustomer2(customersListView.SelectedItems[0].Text);  
                person = bookingController.FindPerson(customersListView.SelectedItems[0].Text);
                //the retrieved objects are used to populate the textboxes with their attribute information
                PopulateTextBoxes(customer, person);
            }
        }
        #endregion

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Populates the customer object
            PopulateObject();
            if (state == FormStates.Edit)
            {
                //if receptionist chooses to edit customer, then the newly populated customer object is inserted into the
                //place of the original customer record in the db 
                //by calling the DataMaintenance method from bookingController
                bookingController.DataMaintenance(customer, Data.DB.DBOperation.Edit);
            }
            else if (state == FormStates.Delete)
            {
                //else if the delete button is clicked then customer record will be deleted from db
                bookingController.DataMaintenance(customer, Data.DB.DBOperation.Delete);
            }
            bookingController.FinalizeChanges(customer);

            //Clear the populated textboxes
            ClearAll();
            state = FormStates.View;
            //reset listview i.e. refresh it
            setUpCustomerListView();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            //assigns the dialogresult variable the value of OK when pressed.
            DialogResult = DialogResult.OK;
        }


    }
}
