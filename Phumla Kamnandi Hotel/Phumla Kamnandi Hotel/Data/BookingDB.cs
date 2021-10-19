﻿using System;
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
        private Collection<Room> rooms;

        #endregion

        #region: Property methods
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

        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }

        public Collection<Room> AllRooms
        {
            get
            {
                return rooms;
            }
        }
        #endregion

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
        //FillRow method for Customer Table
        private void FillRow(DataRow aRow, Customer aCus, DB.DBOperation operation)
        {
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
        //FillRow method for booking table
        private void FillRow(DataRow aRow, Booking book, DB.DBOperation operation)
        {          
            if (operation == DB.DBOperation.Add)
            {
                aRow["BookingID"] = book.getBookingID;  //NOTE square brackets to indicate index of collections of fields in row.
                aRow["CustomerRequests"] = book.getCustomerRequests;
                aRow["BookingDate"] = book.getBookingDate;
                aRow["ArrivalDate"] = book.getArrival;
                aRow["DepartureDate"] = book.getDeparture;
                aRow["ReferenceNum"] = book.getRefNumber;
            }
        }


        //FindRow method for customer table
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
                    if (aCus.CustomerID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["CustomerID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        //FindRow method for booking table
        private int FindRow(Booking book, string table)
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
                    if (book.getBookingID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        #region Database Operations CRUD
        //DataSetChange method for customer table
        public void DataSetChange(Customer aCus, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aCus, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    
                    break;
                case DB.DBOperation.Edit:
                    
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aCus, dataTable)];
                    
                    FillRow(aRow, aCus, operation);
                    break;
                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aCus, dataTable)];
                    aRow.Delete();
                    break;
            }
        }

        //DataSetChange method for booking table
        public void DataSetChange(Booking book, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table3;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, book, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;

                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(book, dataTable)];
                    FillRow(aRow, book, operation);
                    break;

                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(book, dataTable)];
                    aRow.Delete();
                    break;
            }
        }


        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Customer aCust)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 15, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PersonID", SqlDbType.NVarChar, 15, "PersonID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@StreetName", SqlDbType.NVarChar, 100, "StreetName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SuburbName", SqlDbType.NVarChar, 100, "SuburbName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CityName", SqlDbType.NVarChar, 50, "CityName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PostalCode", SqlDbType.NVarChar, 10, "PostalCode");
            daMain.InsertCommand.Parameters.Add(param);          
        }

        private void Build_UPDATE_Parameters(Customer aCust)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and EMPID as for Insert 
            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@StreetName", SqlDbType.NVarChar, 100, "Streetname");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Suburbname", SqlDbType.NVarChar, 100, "SuburbName");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CityName", SqlDbType.NVarChar, 50, "CityName");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@PostalCode", SqlDbType.NVarChar, 10, "PostalCode");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "CustomerID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 15, "CustomerID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Customer aCust)
        {
            //Create the command that must be used to insert values into the customer table..
            daMain.InsertCommand = new SqlCommand("INSERT into Customer (CustomerID, Name, PersonID, Email, StreetName, SuburbName, CityName, PostalCode) VALUES (@CustomerID, @Name, @PersonID, @Email, @StreetName, @SuburbName, @CityName, @PostalCode)", cnMain);
            Build_INSERT_Parameters(aCust);
        }

        private void Create_UPDATE_Command(Customer aCust)
        {
            //Create the command that must be used to insert values into cutosmer table
            //Assumption is that the CustomerID and PersonID cannot be changed
            daMain.UpdateCommand = new SqlCommand("UPDATE Customer SET Name =@Name, Email =@Email, StreetName =@StreetName, SuburbName = @SuburbName, CityName = @CityName, PostalCode = @PostalCode " + "WHERE CustomerID = @Original_ID", cnMain);
            Build_UPDATE_Parameters(aCust);
        }

        private string Create_DELETE_Command(Customer aCust)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the Customer table
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Customer WHERE CustomerID = @CustomerID", cnMain);

            try
            {
                Build_DELETE_Parameters();
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            return errorString;
        }

        public bool UpdateDataSource(Customer aCust)
        {
            bool success = true;
            Create_INSERT_Command(aCust);
            Create_UPDATE_Command(aCust);
            Create_DELETE_Command(aCust);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }
        #endregion
    }
}

