using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    class Account
    {
        #region Fields
        private string accountNum;
        private decimal amountDue;
        private decimal depositAmount;
        private decimal random;
        //payment array needs to be added
        #endregion

        #region Property Methods
        public string AccountNum
        {
            get { return accountNum; }
            set { accountNum = value; }
        }

        public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

        public decimal DepositAmount
        {
            get { return depositAmount; }
            set { depositAmount = value; }
        }
        #endregion

        #region Constructors
        public Account()
        {
            accountNum = "";
            amountDue = 0;
            depositAmount = 0;
        }

        public Account(string aNum, int aDue, int dAmnt)
        {
            accountNum = aNum;
            amountDue = aDue;
            depositAmount = dAmnt;
        }
        #endregion

        #region Methods
        //addBooking method needs to be included

        //calculateDeposit method needs to be included

        #endregion

         
    }
}
