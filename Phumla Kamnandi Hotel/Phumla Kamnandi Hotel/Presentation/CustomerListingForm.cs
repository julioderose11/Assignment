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

        #region Constructor
        public CustomerListingForm()
        {
            InitializeComponent();
           // this.Load += CustomerListingForm_Load;
           // this.Activated += EmployeeListingForm_Activated;
           // state = FormStates.View;
        }

        public CustomerListingForm(BookingController cusController)
        {
            InitializeComponent();
            bookingController = cusController;
            //this.Load += EmployeeListingForm_Load;
          //  this.Activated += EmployeeListingForm_Activated;
          //  state = FormStates.View;
        }
        #endregion

    }
}
