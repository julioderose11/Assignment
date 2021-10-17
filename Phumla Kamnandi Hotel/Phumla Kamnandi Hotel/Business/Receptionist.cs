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
        public void makeCustomerAccount()
        {
         
        }

        //MakeBooking Method: creates a booking object based on the reference number and date values given by the customer.
        public void makeBooking(string custRequests, DateTime BookingDate, DateTime ArrivalDate, DateTime DepartureDate) 
        {
            DateTime current = DateTime.UtcNow;
            string refNum = refNumGenerator();
            //instantiate booking object
            Booking booking = new Booking(refNum, custRequests, current, ArrivalDate, DepartureDate);            
        }

        //Double check the placing of this method. We need to make sure a new reference number isn't created when a customer makes two bookings
        public string refNumGenerator() //method to create unique reference number
        {
            int length = 8;

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
