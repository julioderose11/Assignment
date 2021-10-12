using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    class Payment
    {
        #region Fields
        private string paymentID, paymentType;
        private DateTime paymentDate;
        private decimal amount;
        //payment array needs to be added
        #endregion

        #region Property Methods
        public string getPaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }

        public string getPaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }

        public DateTime getPaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }
        #endregion

        #region Constructors
        public Payment()
        {
            paymentID = "";
            paymentType = "";
            paymentDate = default(DateTime);
            amount = 0;
        }

        public Payment(string pID, string pType, DateTime pDate, decimal amnt)
        {
            paymentID = pID;
            paymentType = pType;
            paymentDate = pDate;
            amount = amnt;
        }
        #endregion
    }
}
