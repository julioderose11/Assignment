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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
              //Pathway for Phumla Kamnandi Sfaff to go from Login Form to BookingMDIParent, this is an extra secuirty feature for the system to ensure that only employees have access to the system
              //Please note this code is not complete and has no parameters in regards to the number of characters the passsowrd and staffID needs. The purpose of this is to build it out in a later stage
              //as this is a bonus feature.


            if (employeeIDTxt.Text != "" && passwordTxt.Text != "")//The Employee must enter both his/her ID and Password 
            {
                BookingMDIParent bookingMDI = new BookingMDIParent();
                bookingMDI.Show();
                this.Hide();


            }
            else if (employeeIDTxt.Text == "" && passwordTxt.Text != "")//Logical operator that states if the employee doesn't enter their Employee ID
            {
                MessageBox.Show("Please enter your Employee ID ", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeeIDTxt.SelectAll(); //NB throughout my code i have added in Selectall and Focus to ensure it indicates where the employee must type in the missing data
                employeeIDTxt.Focus();

            }
            else if (passwordTxt.Text == "" && employeeIDTxt.Text != "")//Logical operator that states if the employee doesn't enter their password
            {
                MessageBox.Show("Please enter your Password ", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTxt.SelectAll();
                passwordTxt.Focus();
            }
            else //Messagebox if both the ID and password isn't entered
            {
                MessageBox.Show("You did not enter both your Employee ID or Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeeIDTxt.SelectAll();
                employeeIDTxt.Focus();
            }

        }
    }
}
