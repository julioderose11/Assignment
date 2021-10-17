using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    class Room
    {
        #region: Fields
        protected int roomNo;
        protected int floorNo;
        protected bool roomAvailability;
        public enum RoomRate
        {
            lowSeason = 0,
            midSeason = 1,
            highSeason = 2
        }

        protected RoomRate rate;
        #endregion

        #region: constructors
        public Room()
        {

        }

        public Room(int rNum, int fNo, bool roomAvail, RoomRate rRate)
        {
            rNum = roomNo;
            fNo = floorNo;
            roomAvail = roomAvailability;
            rRate = rate;
        }
        #endregion

        #region: Property methods
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
        public int getFloorNo
        {
            get
            {
                return floorNo;
            }
            set
            {
                floorNo = value;
            }
        }

        public bool getRoomAvailability
        {
            get
            {
                return roomAvailability;
            }
            set
            {
                roomAvailability = value;
            }
        }

        public RoomRate getRate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }
        }
        #endregion

        #region: Methods
        public override string ToString()
        {
            return "Room Number: " + roomNo + "\nFloor Number: " + floorNo + "\nRoom Availability: " + roomAvailability + "\nRoomRate: " + rate;
        }
        #endregion 
    }
}
