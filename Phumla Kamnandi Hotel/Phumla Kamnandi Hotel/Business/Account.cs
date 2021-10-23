using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    public class Account
    {
        #region Fields
        private string accountNum;
        private decimal amountDue;
        private decimal depositAmount;
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

        public Account(decimal aDue, decimal dAmnt)
        {
            accountNum = AccountNumGenerator();
            amountDue = aDue;
            depositAmount = dAmnt;
        }
        #endregion

        #region Methods
        //method to create unique Account Num
        public string AccountNumGenerator1()   
        {
            int length = 5;
            

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

        public string AccountNumGenerator()
        {
            string src = "0123456789";
            int length = 7;
            StringBuilder sb = new StringBuilder();
            Random rng = new Random();
            for(var i = 0; i < length; i++)
            {
                var c = src[rng.Next(0, src.Length)];
                sb.Append(c);
            }
            return sb.ToString();
        }

        //addBooking method needs to be included

        //calculateDeposit method needs to be included

        #endregion


    }
}
