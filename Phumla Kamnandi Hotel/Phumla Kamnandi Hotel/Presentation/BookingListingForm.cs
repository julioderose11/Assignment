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
           // setUpEmployeeListView();
           // ShowAll(false, roleValue);
        }
        #endregion

        #region ListView set up
        public void setUpEmployeeListView()
        {

            ListViewItem bookingDetails;
            booking.ListView.Clear();

            employeeListView.Columns.Insert(0, "ID", 120, HorizontalAlignment.Left);
            employeeListView.Columns.Insert(1, "EMPID", 120, HorizontalAlignment.Left);
            employeeListView.Columns.Insert(2, "Name", 120, HorizontalAlignment.Left);
            employeeListView.Columns.Insert(3, "Phone", 120, HorizontalAlignment.Left);



            foreach (Employee employee in employees)
            {
                employeeDetails = new ListViewItem();
                employeeDetails.Text = employee.ID.ToString();
                employeeDetails.SubItems.Add(employee.EmployeeID.ToString());
                employeeDetails.SubItems.Add(employee.Name.ToString());
                employeeDetails.SubItems.Add(employee.Telephone.ToString());
                // Do the same for EmpID, Name and Phone
                switch (employee.role.getRoleValue)
                {
                    case Role.RoleType.Headwaiter:
                        headW = (HeadWaiter)employee.role;
                        employeeDetails.SubItems.Add(headW.SalaryAmount.ToString());
                        break;
                    case Role.RoleType.Waiter:
                        waiter = (Waiter)employee.role;
                        employeeDetails.SubItems.Add(waiter.getRate.ToString());
                        employeeDetails.SubItems.Add(waiter.getShifts.ToString());
                        employeeDetails.SubItems.Add(waiter.getTips.ToString());
                        break;
                    case Role.RoleType.Runner:
                        runner = (Runner)employee.role;
                        employeeDetails.SubItems.Add(runner.getRate.ToString());
                        employeeDetails.SubItems.Add(runner.getShifts.ToString());
                        employeeDetails.SubItems.Add(runner.getTips.ToString());
                        break;

                }

                employeeListView.Items.Add(employeeDetails);


            }

            employeeListView.Refresh();
            employeeListView.GridLines = true;
        }

    }
}
