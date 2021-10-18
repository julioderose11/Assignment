using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    class RoomBooking
    {
        #region: fields
        private Room room;
        private Booking booking;
        #endregion

        #region: constructor
        public RoomBooking()
        {

        }

        public RoomBooking(Room Room, Booking Booking)
        {
            room = Room;
            booking = Booking;

        }
        #endregion

        #region property methods
        public int getRoomNo
        {
            get
            {
                return roomNo;
            }
            set
            {
                roomNo = value;
            }
        }
        public string getBookingID
        {
            get
            {
                return bookingID;
            }
            set
            {
                bookingID = value; 
            }
        }
        #endregion

        #region: Methods

        #endregion
    }
}
