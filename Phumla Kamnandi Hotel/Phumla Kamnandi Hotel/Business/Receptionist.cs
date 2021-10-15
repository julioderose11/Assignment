using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    class Receptionist:Staff
    {
        #region: constructor
        public Receptionist(): base()
        {


        }
        #endregion

        #region: methods
        public void makeBooking(string RefNum, DateTime BookingDate, DateTime ArrivalDate, DateTime DepartureDate)  //creates a booking object based on the reference number and date values given by the customer.
        {
            DateTime current = DateTime.UtcNow;
            Booking booking = new Booking(RefNum, current, ArrivalDate, DepartureDate);            
        }
        #endregion
    }
}
