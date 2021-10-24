using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    public class Room
    {
        #region: Fields
        protected int roomNo;
        protected int floorNo;
        protected decimal roomPrice;


        public enum RateType
        {
            lowSeason = 0,
            midSeason = 1,
            highSeason = 2
        }

        public RateType rate;
        #endregion

        #region: constructors
        public Room()
        {

        }

        public Room(int rNum, int fNo, RateType rRate)
        {
            rNum = roomNo;
            fNo = floorNo;
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

        public RateType getRate
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
        public decimal getPrice
        {
            get
            {
                return roomPrice;
            }
            set
            {
                roomPrice = value;
            }
        }
        #endregion

        #region: Methods
        public override string ToString()
        {
            return "Room Number: " + roomNo + "\nFloor Number: " + floorNo + "\nRoomRate: " + rate;
        }
        #endregion 
    }
}
