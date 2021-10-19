using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    public class RoomBooking
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
        public Room getRoomNo
        {
            get
            {
                return room;
            }
           
        }
        public Booking getBookingID
        {
            get
            {
                return booking;
            }
            
        }
        #endregion

        #region: Methods
        
        #endregion
    }
}
