using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamnandi_Hotel.Business;
namespace Phumla_Kamnandi_Hotel.Business
{
    public class Customer : Person 
    {
        #region Information 
        //This calls inherits all data members from the person class 
        #endregion

        #region Fields
        private string customerID;
        private Person person;
        //defines the the person class 
 
        #endregion

        #region Properties
        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public Person getPerson
        {
            get { return person;  }
            set { person = value;  }
        }
        #endregion

        #region Construtor
        //default constructor 
        public Customer(Person p)
        {
            person = p;
            customerID = IdGenerator();
        }
        public Customer() : base()
        {

            customerID = IdGenerator();

        }

        #endregion

        #region: Methods
        //method to display the customer id 
        public override string ToString()
        {
            return base.ToString() + "customerID: " + customerID;
        }

        public static string IdGenerator()    //method to create unique customer id.
        {
            int length = 15;

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }
        #endregion

    }
}
