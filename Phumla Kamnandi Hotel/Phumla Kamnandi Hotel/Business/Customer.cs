using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamnandi_Hotel.Business;
namespace Phumla_Kamnandi_Hotel.Business
{
    class Customer : Person
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

             customerID = Booking.IdGenerator();


        }

        
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return base.ToString() + "customerID: " + customerID;
        }

        #endregion

    }
}
