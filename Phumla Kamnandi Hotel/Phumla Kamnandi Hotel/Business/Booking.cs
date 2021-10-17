using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    class Booking
    {
        #region Fields
        private string bookingID;
        private string bookingDescription;
        private DateTime bookingDate;
        private DateTime arrivalDate;
        private DateTime departureDate;
        private string refNum;
        #endregion

        #region Properties
        public string getBookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public string getBookingDesciption
        {
            get { return bookingDescription; }
            set { bookingDescription = value; }
        }
        public DateTime getBookingDate
        {
            get { return bookingDate; }
            set { bookingDate = value; }
        }
        public DateTime getArrival
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }

        public DateTime getDeparture
        {
            get { return departureDate; }
            set { departureDate = value; }
        }

        public string getRefNumber
        {
            get { return refNum; }
            set { refNum = value; }
        }
        #endregion

        #region Constructors
        public Booking()
        {
            bookingID = "" ;
            bookingDescription = "";
            bookingDate = default(DateTime);
            arrivalDate = default(DateTime);
            departureDate = default(DateTime);
            refNum = "";
        
        }
        #endregion

        #region Methods
        

        #endregion

    }
}
