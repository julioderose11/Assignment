﻿using System;
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
        private Customer customer;
        private BookingController bookingController;
        public bool newCustomerFormClosed = false;

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

        private void PopulateObject() //method to populate a booking object 
        {
            customer = new Customer();
            customer.getFName = txtFName.Text;
            customer.getSName = txtLName.Text;
            customer.getEmail = txtEmail.Text;
            customer.getStreetName = txtStreet.Text;
            customer.getSuburbName = txtSuburb.Text;
            customer.getCityName = txtCity.Text;
            customer.getPostalCode = txtPostal.Text;


            //ask how to retrieve specific data from the database. 
        }
        #endregion


        #region Form Events

        private void btnHome_Click(object sender, EventArgs e)
        {
            newCustomerFormClosed = true; //return user to BookingMDI
        }

        private void NewBookingUI_Activated(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void NewCustomersForm_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //By clicking the confirm button a customer object is created and added to the database 
            PopulateObject();
            MessageBox.Show("Confirm Customer to be submitted to Database?", "Customer Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            bookingController.DataMaintenance(customer, DB.DBOperation.Add);
            bookingController.FinalizeChanges(customer);
            ClearAll();
            ShowAll();

            //look at the flow diagram  and interlink the mdi form 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        #endregion
    }
}
