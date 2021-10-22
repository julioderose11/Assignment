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
        #region Fields
        private string customerID;
 
        #endregion

        #region Properties
        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        #endregion

        #region Construtor
        public Customer() : base()
        {
            customerID = IdGenerator();

        }


        #endregion

        #region: Methods
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
