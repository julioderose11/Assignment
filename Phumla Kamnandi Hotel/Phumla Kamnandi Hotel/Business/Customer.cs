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
 
        #endregion

        #region Properties
        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        #endregion

        #region Construtor
        public Customer()
        {
            customerID = "";
            mobilePhone = default(int);
 
        }

        public Customer(string cID, int cPhone)
        {
            customerID = cID;
            mobilePhone = cPhone;

        }
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return base.ToString() + "customerID: " + customerID + "\nPhone: " + mobilePhone;
        }

        #endregion

    }
}
