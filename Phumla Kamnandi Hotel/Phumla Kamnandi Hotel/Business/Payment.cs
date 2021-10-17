using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    class Payment
    {
        #region Field
        private string paymentID, paymentType;
        private DateTime paymentDate;
        private decimal amount;
        #endregion

        #region properties
        public string PaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }
        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        #endregion

        #region Constructor
        public Payment()
        {
            paymentID = "";
            paymentType = "";
            paymentDate = default(DateTime);
            amount = default(decimal);
        }
        #endregion

    }
}