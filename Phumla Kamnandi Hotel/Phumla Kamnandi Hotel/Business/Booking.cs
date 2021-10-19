using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    public class Booking
    {
        #region Fields
        private string bookingID;
        private string customerRequests;
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

        public string getCustomerRequests
        {
            get { return customerRequests; }
            set { customerRequests = value; }
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
            customerRequests = "";
            bookingDate = default(DateTime);
            arrivalDate = default(DateTime);
            departureDate = default(DateTime);
            refNum = "";
        
        }

        public Booking(string RefNum, string custRequests, DateTime BookingDate, DateTime ArrivalDate , DateTime DepartureDate)
        {
            refNum = RefNum;
            bookingID = IdGenerator();
            customerRequests = custRequests;
            bookingDate = BookingDate;
            arrivalDate = ArrivalDate;
            departureDate = DepartureDate;
        }
        #endregion

        #region Methods
        public static string IdGenerator()    //method to create unique booking id.
        {
            int length = 7;

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
