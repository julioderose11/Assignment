using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    public class Season
    {
        #region Data Member
        public enum RateType
        {
            /*The rate ID will be stored as an enumeration type. 
            So that the room rates can either have a rates in the low season, that is assigned (0), midSeason (1) and highSeason Waiter (2).
            This help determine the overall prices of the rooms for different seasons.  */
            lowSeason = 0,
            midSeason = 1,
            highSeason = 2
        }
        protected   RateType rateVal;
        protected decimal price;

        #endregion

        #region Property Methods
        /*Declare properties for the Role class	*/
        public RateType getRateValue
        {
            get { return rateVal; }
            set { rateVal = value; }
        }
        public decimal getPrice
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        #region Constructor
        

        public Season()
        {
            rateVal = Season.RateType.lowSeason;
            price = 0;
        }
        #endregion

        #region Methods

        #endregion

    }
}
