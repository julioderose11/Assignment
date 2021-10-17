using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamnandi_Hotel.Business;

namespace Phumla_Kamnandi_Hotel.Data
{
    class BookingDB : DB
    {
        #region Data members
        private string table1 = "Customer";
        private string sqlLocal1 = "SELECT * FROM Customer";
        private string table2 = "RoomBooking";
        private string sqlLocal2 = "SELECT * FROM RoomBooking";
        private string table3 = "Booking";
        private string sqlLocal3 = "SELECT * FROM Booking";
        private string table4 = "Room";
        private string sqlLocal4 = "SELECT * FROM Room";
        private string table5 = "Payment";
        private string sqlLocal5 = "SELECT * FROM Payment";
        private string table6 = "Account";
        private string sqlLocal6 = "SELECT * FROM Account";
        private string table7 = "Booking";
        private string sqlLocal7 = "SELECT * FROM Booking";
        private string table8 = "Booking";
        private string sqlLocal8 = "SELECT * FROM Booking";
        private string table9 = "Booking";
        private string sqlLocal9 = "SELECT * FROM Booking";

        private Collection<Customer> customers;
        private Collection<RoomBooking> roomBookings;
        private Collection<Booking> bookings;

        #endregion

        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }
        public Collection<RoomBooking> AllRoomBookings
        {
            get
            {
                return roomBookings;
            }
        }

        #region Constructor
        public BookingDB() : base()
        {
            customers = new Collection<Customer>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
            FillDataSet(sqlLocal2, table2);
            Add2Collection(table2);
            FillDataSet(sqlLocal3, table3);
            Add2Collection(table3);
            FillDataSet(sqlLocal4,table4);
            Add2Collection(table4);
            FillDataSet(sqlLocal5, table5);
            Add2Collection(table5);
            FillDataSet(sqlLocal6, table6);
            Add2Collection(table6);
            FillDataSet(sqlLocal7, table7);
            Add2Collection(table7);
            FillDataSet(sqlLocal8, table8);
            Add2Collection(table8);
        }
        #endregion
        private void Add2Collection(string table)  //
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            Customer aCus;
            RoomBooking RB;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Employee object
                    aCus = new Customer();
                    //Obtain each employee attribute from the specific field in the row in the table
                    aCus.CustomerID = Convert.ToString(myRow["CustomerID"]).TrimEnd();
                    //Do the same for all other attributes
                    aCus.getPersonID = Convert.ToString(myRow["PersonID"]).TrimEnd();
                    aCus.getName = Convert.ToString(myRow["Name"]).TrimEnd(); 
                    customers.Add(aCus);
                }
            }

        }
        private void FillRow(DataRow aRow, Customer aCus, DB.DBOperation operation)
        {
            Customer cus;
            RoomBooking RB;
            if (operation == DB.DBOperation.Add)
            {
                aRow["CustomerID"] = aCus.CustomerID;  //NOTE square brackets to indicate index of collections of fields in row.
                aRow["PersonID"] = aCus.getPersonID;
                aRow["Name"] = aCus.getName;
                aRow["Email"] = aCus.getEmail;
                aRow["StreetName"] = aCus.getStreetName;
                aRow["SuburbName"] = aCus.getSuburbName;
                aRow["CityName"] = aCus.getCityName;
                aRow["PostalCode"] = aCus.getPostalCode;              
            }           
        }
        private void FillRow(DataRow aRow, RoomBooking RB, DB.DBOperation operation)
        {          
            RoomBooking RoomBooking;
            if (operation == DB.DBOperation.Add)
            {
                aRow["RoomNumber"] = RB.getRoomNo;  //NOTE square brackets to indicate index of collections of fields in row.
                aRow["BookingID"] = RB.getBookingID;
                
            }
        }



        private int FindRow(Customer aCus, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it is automatically known to the compiler when used as below
                    if (aCus.CustomerID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #region Database Operations CRUD
        
        #endregion
    }
}

