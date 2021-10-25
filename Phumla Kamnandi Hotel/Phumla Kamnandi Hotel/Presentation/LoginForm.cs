using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_Hotel.Presentation
{
    public partial class LoginForm : Form
    {
        #region: Variables
        private const string username = "Admin";
        private const string password = "Admin";       

        #endregion
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
              //Pathway for Phumla Kamnandi Sfaff to go from Login Form to BookingMDIParent, this is an extra secuirty feature for the system to ensure that only employees have access to the system
              //Please note this code is not complete and has no parameters in regards to the number of characters the passsowrd and staffID needs. The purpose of this is to build it out in a later stage
              //as this is a bonus feature.


            if (employeeIDTxt.Text == username && passwordTxt.Text == password)//The Employee must enter both his/her ID and Password 
            {
                BookingMDIParent bookingMDI = new BookingMDIParent();
                bookingMDI.Show();
                this.Hide();


            }
            else if(employeeIDTxt.Text != username && passwordTxt.Text != password)//Messagebox if both the ID and password isn't entered
            {
                MessageBox.Show("Please enter valid credentials", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeeIDTxt.SelectAll();
                employeeIDTxt.Focus();
            }
            else if (employeeIDTxt.Text == username && passwordTxt.Text != password)//Logical operator that states if the employee doesn't enter their Employee ID
            {
                MessageBox.Show("Password incorrect ", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 //NB throughout my code i have added in Selectall and Focus to ensure it indicates where the employee must type in the missing data
                passwordTxt.Clear();
                passwordTxt.Focus();

            }
            else if (employeeIDTxt.Text != username && passwordTxt.Text == password)//Logical operator that states if the employee doesn't enter their password
            {
                MessageBox.Show("Staff ID incorrect ", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeeIDTxt.Clear();
                employeeIDTxt.Focus();
            }
            

        }

    }
}
