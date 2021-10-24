using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel
{
    public class Validator
    {

        #region Information
        /*This class is used for data validation to ensure that the user of the system inputS the correct data and information
        This makes sure the inputs are valid and correcting formatted to ensure there is no bugs and are correctly inputte into 
        the Boooking database.
         */
        #endregion

        #region Fields
        //this is the return header sayaing that the input entry was incorrect
        private static string title = "Entry Error";
        #endregion

        #region Properties
        //this is used to recievd and set values;
        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        #endregion


        #region Methods
        public static bool IsPresent(System.Windows.Forms.TextBox textBox) //ensures that something is written textbox 
        {
            if (textBox.Text == "")
            {

                System.Windows.Forms.MessageBox.Show(textBox.Tag + "Missing Information in Textbox.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsPresent(System.Windows.Forms.RichTextBox richTextBox) //ensures that something is written textbox 
        {
            if (richTextBox.Text == "")
            {

                System.Windows.Forms.MessageBox.Show(richTextBox.Tag + "Missing text in Special Request Textbox.", Title);
                richTextBox.Focus();
                return false;
            }
            return true;
        }


        public static bool IsInt32(System.Windows.Forms.TextBox textBox) //ensures that the textbox is an integar
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(textBox.Tag + "Please ensure that the input is an integar.", Title);
                textBox.Focus();
                return false;
            }
        }
        public static bool IsDecimal(System.Windows.Forms.TextBox textBox) //ensures that the textbox is a deciaml 
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(textBox.Tag + "Please ensure that the input is an decimal.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsDateTime(System.Windows.Forms.DateTimePicker dateTime) //ensures that the textbox is a dateTime
        {
            DateTime date = default(DateTime);
            if (DateTime.TryParse(dateTime.Text, out date))
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(dateTime.Tag + "Please ensure that the input is an DateTime Integar Type.", Title);
                dateTime.Focus();
                return false;
            }
        }

        public static bool IsWithinRange(System.Windows.Forms.TextBox textBox, decimal min, decimal max) 
        {
            //ensures the textbox is within range of a max and min number so there is a limit to the textbox
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                System.Windows.Forms.MessageBox.Show(textBox.Tag + "The input must be between " + min
                    + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
        #endregion
    }
}
