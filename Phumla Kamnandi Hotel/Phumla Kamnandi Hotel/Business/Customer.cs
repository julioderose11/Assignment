using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    class Customer : Person
    {
        #region Fields
        private string customerID;
        private int mobilePhone;
        private int noOfGuests;
        #endregion

        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public Customer()
        {
            customerID = "";
            mobilePhone = default(int);
            noOfGuests = default(int);
        }

        public Customer(string cID, int cPhone, int cGuests)
        {
            customerID = cID;
            mobilePhone = cPhone;
            noOfGuests = cGuests;
        }


    }
}
