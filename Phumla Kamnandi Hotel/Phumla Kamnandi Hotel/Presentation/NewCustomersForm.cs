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
    public partial class NewCustomersForm : Form
    {
        #region Data Members
        //declaring a reference to the Booking and the Controller class
        public bool listFormClosed;
        private Customer customer;
        private BookingController bookingController;
        public bool newCustomerFormClosed = false;
        private Person person;

        #endregion

        #region Constructor
        public NewCustomersForm(BookingController aController)
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
            lblSName.Visible = true;
            lblEmail.Visible = true;
            lblStreet.Visible = true;
            lblSuburb.Visible = true;
            lblCity.Visible = true;
            lblPostalCode.Visible = true;
            txtFName.Visible = true;
            txtLName.Visible = true;
            txtEmail.Visible = true;
            txtStreet.Visible = true;
            txtSuburb.Visible = true;
            txtPostal.Visible = true;
            txtCity.Visible = true;
            btnConfirm.Visible = true;
            btnHome.Visible = true;
            btnCancel.Visible = true;
        }

        private void ClearAll() //method to clear all controls
        {
            txtFName.Text = " ";
            txtLName.Text = " ";
            txtEmail.Text = " ";
            txtStreet.Text = " ";
            txtSuburb.Text = " ";
            txtCity.Text = " ";
            txtPostal.Text = " ";

        }

        private void PopulatePerson() //method to populate a booking object 
        {
            /*person = new Person();
            person.getPersonID = iDTxt.Text;
            person.getFName = txtFName.Text;
            person.getSName = txtLName.Text;
            person.getEmail = txtEmail.Text;
            person.getStreetName = txtStreet.Text;
            person.getSuburbName = txtSuburb.Text;
            person.getCityName = txtCity.Text;
            person.getPostalCode = txtPostal.Text;*/

            string pID = iDTxt.Text;
            string fname = txtFName.Text;
            string sname = txtLName.Text;
            string mail = txtEmail.Text;
            string streetname = txtStreet.Text;
            string suburbname = txtSuburb.Text;
            string cityname = txtCity.Text;
            string postalcode = txtPostal.Text;

            person = new Person(pID, fname, sname, mail, streetname, suburbname, cityname, postalcode);

        }

        private void PopulateCustomer()
        {
            customer = new Customer();
            customer.getPersonID = iDTxt.Text;
        }


        private bool IsValidData()
        {
            return
                // Validate all the items to ensure they all have the correct inputs
                // This ensure that that the input texts (strings) are correctly inputed.
                Validator.IsPresent(iDTxt) &&
                Validator.IsPresent(txtFName) &&
                Validator.IsPresent(txtLName) &&
                Validator.IsPresent(txtEmail) &&
                Validator.IsPresent(txtCity) &&
                Validator.IsPresent(txtStreet) &&
                Validator.IsPresent(txtSuburb) &&
                Validator.IsPresent(txtPostal) &&


                //The below ensures that the ID is only allowed to be 13 digits.
                Validator.IsWithinRange2(iDTxt);

        }
        #endregion


        #region Form Events

        private void NewBookingUI_Activated(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void NewCustomersForm_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            //assigns the dialogresult variable the value of OK when pressed. MDIParent reads this, closes the form, and shows itself
            DialogResult = DialogResult.OK;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           

            //look at the flow diagram  and interlink the mdi form 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void NewCustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }


        #endregion

        private void LinkToNewBookingUI()
        {
            NewBookingUI newBookingForm = new NewBookingUI(bookingController);
            newBookingForm.ShowDialog();
            this.Close();
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            //By clicking the confirm button a customer object is created and added to the database 
            try
            {
                if(IsValidData())
                {
                    DialogResult returnDialogResult = MessageBox.Show("Confirm Customer to be submitted to Database?", "Customer Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (returnDialogResult == DialogResult.Yes)
                    {
                        PopulatePerson();
                        bookingController.DataMaintenance(person, DB.DBOperation.Add);
                        bookingController.FinalizeChanges(person);
                        PopulateCustomer();
                        bookingController.DataMaintenance(customer, DB.DBOperation.Add);
                        bookingController.FinalizeChanges(customer);

                        ClearAll();
                        ShowAll();
                        LinkToNewBookingUI();

                    }
                }
               

            }
            catch (Exception ex) //catch any other expection that might occur
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }

            /*
            DialogResult returnDialogResult = MessageBox.Show("Confirm Customer to be submitted to Database?", "Customer Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (returnDialogResult == DialogResult.Yes)
            {
                PopulatePerson();
                bookingController.DataMaintenance(person, DB.DBOperation.Add);
                bookingController.FinalizeChanges(person);
                PopulateCustomer();
                bookingController.DataMaintenance(customer, DB.DBOperation.Add);
                bookingController.FinalizeChanges(customer);
                
                ClearAll();
                ShowAll();
                LinkToNewBookingUI();

            }
            */
        }

       
    }
}
