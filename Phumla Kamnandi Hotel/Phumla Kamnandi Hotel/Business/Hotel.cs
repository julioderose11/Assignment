using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    class Hotel
    {
        #region: Fields
        private string hotelID;
        private string address;
        private string hotelName;
        #endregion

        #region: constructors
        public Hotel()
        {

        }

        public Hotel(string hotelID, string address, string hotelName)
        {
            this.hotelID = hotelID;
            this.address = address;
            this.hotelName = hotelName;
        }
        #endregion

        #region: Property methods
        public string getHotelID
        {
            get 
            {
                return hotelID;
            }
            set
            {
                hotelID = value;
            }
        }

        public string getAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string getHotelName
        {
            get
            {
                return hotelName;
            }
            set
            {
                hotelName = value;
            }
        }
        #endregion

        #region: methods
        
        #endregion
    }
}
