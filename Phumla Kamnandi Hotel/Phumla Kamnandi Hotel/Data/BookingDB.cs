﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamnandi_Hotel.Business;
using System.Windows.Forms;

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
        private string table4 = "Person";
        private string sqlLocal4 = "SELECT * FROM Person";
        private string table5 = "Room";
        private string sqlLocal5 = "SELECT * FROM Room";
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
        private Collection<Person> persons;
        private Collection<Account> accounts;

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

        public Collection<Person> AllPersons
        {
            get
            {
                return persons;
            }
        }

        public Collection<Account> AllAccounts
        {
            get
            {
                return accounts;
            }
        }
        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            customers = new Collection<Customer>();
            persons = new Collection<Person>();
            bookings = new Collection<Booking>();
            roomBookings = new Collection<RoomBooking>();
            rooms = new Collection<Room>();
            accounts = new Collection<Account>();

            FillDataSet(sqlLocal6, table6);
            Add2Collection(table6);
            FillDataSet(sqlLocal5, table5);
            Add2Collection(table5);
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);           
            FillDataSet(sqlLocal3, table3);
            Add2Collection(table3);
            FillDataSet(sqlLocal2, table2);
            Add2Collection(table2);
            FillDataSet(sqlLocal4,table4);
            Add2Collection(table4);
                      
        }
        #endregion
        private void Add2Collection(string table)  
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            Customer aCus;
            RoomBooking RB;
            Booking booking;
            Person person;
            Room room;
            Account acc;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //MessageBox.Show("i");
                if (table == table1)
                {
                   
                    if (!(myRow.RowState == DataRowState.Deleted))
                    {
                        //Instantiate a new customer object
                        aCus = new Customer();
                        //Obtain each Customer attribute from the specific field in the row in the table
                        aCus.CustomerID = Convert.ToString(myRow["CustomerID"]).TrimEnd();
                        aCus.getPersonID = Convert.ToString(myRow["PersonID"]).TrimEnd();
                       //aCus.getPerson.FName = Convert.ToString(myRow["FirstName"]).TrimEnd();
                      
                        customers.Add(aCus);
                        
                    }
                }
                else if (table == table4)
                {
                    
                    if (!(myRow.RowState == DataRowState.Deleted))
                    {

                        //Instantiate a new Person object
                        person = new Person();
                        //Obtain each Person attribute from the specific field in the row in the table
                        person.getPersonID = Convert.ToString(myRow["PersonID"]).TrimEnd();
                        person.getFName = Convert.ToString(myRow["FirstName"]).TrimEnd();
                        person.getSName = Convert.ToString(myRow["SecondName"]).TrimEnd();
                        person.getEmail = Convert.ToString(myRow["Email"]).TrimEnd();
                        person.getStreetName = Convert.ToString(myRow["StreetName"]).TrimEnd();
                        person.getSuburbName = Convert.ToString(myRow["SuburbName"]).TrimEnd();
                        person.getCityName = Convert.ToString(myRow["CityName"]).TrimEnd();
                        person.getPostalCode = Convert.ToString(myRow["PostalCode"]).TrimEnd();

                        persons.Add(person);
                    }
                }
                else if (table == table3)
                {
                    if (!(myRow.RowState == DataRowState.Deleted))
                    {
                        //Instantiate a new Booking object
                        booking = new Booking();
                        //Obtain each Booking attribute from the specific field in the row in the table
                        booking.getBookingID = Convert.ToString(myRow["BookingID"]).TrimEnd();
                        booking.getCustomerID = Convert.ToString(myRow["CustomerID"]).TrimEnd();
                        booking.getAccountNum = Convert.ToString(myRow["AccountNum"]).TrimEnd();
                        booking.getCustomerRequests = Convert.ToString(myRow["CustomerRequests"]).TrimEnd();
                        booking.getBookingDate = Convert.ToDateTime(myRow["BookingDate"]);
                        booking.getArrival = Convert.ToDateTime(myRow["ArrivalDate"]);
                        booking.getDeparture = Convert.ToDateTime(myRow["DepartureDate"]);
                        booking.getNumPeople = Convert.ToInt32(myRow["NumPeople"]);
                        bookings.Add(booking);
                    }
                }
                else if(table == table2)
                {
                    if (!(myRow.RowState == DataRowState.Deleted))
                    {
                        //Instantiate a new roomBooking object
                        RB = new RoomBooking();
                        Booking book = RB.getBookingObject;
                        //Obtain each roomBooking attribute from the specific field in the row in the table
                        string bID = Convert.ToString(myRow["BookingID"]).TrimEnd();
                        RB.getBookingObject = FindBooking(bID);
                        int rnum = Convert.ToInt32((myRow["RoomNumber"]));
                        RB.getRoomObject = FindRoom(rnum);
                        roomBookings.Add(RB);
                    }
                }
                else if (table == table5)
                {
                    if (!(myRow.RowState == DataRowState.Deleted))
                    {
                        //Instantiate a new room object
                        room = new Room();
                        room.getRoomNo = Convert.ToInt32(myRow["RoomNumber"]);
                        switch (room.getRate)
                        {
                            case Room.RateType.lowSeason:
                                room.getPrice = 550;
                                break;
                            case Room.RateType.midSeason:
                                room.getPrice = 750;
                                break;
                            case Room.RateType.highSeason:
                                room.getPrice = 995;
                                break;
                        }
                        room.getFloorNo = Convert.ToInt32(myRow["FloorNumber"]);
                        room.getRate = (Room.RateType)Convert.ToByte(myRow["Rate"]);
                       // room.getPrice = Convert.ToDecimal(myRow["Price"]);
                        rooms.Add(room);
                    }
                }
                else if (table == table6)
                {

                    if (!(myRow.RowState == DataRowState.Deleted))
                    {
                        //Instantiate a new account object
                        acc = new Account();
                        //Obtain each Customer attribute from the specific field in the row in the table
                        //MessageBox.Show(Convert.ToString(myRow["AccountNum"]).TrimEnd());
                        acc.AccountNum = Convert.ToString(myRow["AccountNum"]).TrimEnd();
                        acc.AmountDue = Convert.ToDecimal(myRow["AmountDue"]);
                        acc.DepositAmount = Convert.ToDecimal(myRow["DepositAmount"]);

                        accounts.Add(acc);

                    }
                }


            }

        }
        public Booking FindBooking(string ID)
        {
            
            int index = 0;
            //MessageBox.Show(Convert.ToString(bookings.Count));
            bool found = (bookings[index].getBookingID == ID);  //check if it is the first booking
            
            int count = bookings.Count;
             
            while (!(found) && (index < bookings.Count - 1))  //if not "this" booking and you are not at the end of the list 
            {
                index = index + 1;
                found = (bookings[index].getBookingID == ID);   // this will be TRUE if found
            }
            if (found == false)
            {
                return null;
            }
            return bookings[index];  // this is the one!  
        }
        public Room FindRoom(int num)
        {
            int index = 0;
            bool found = (rooms[index].getRoomNo == num);  //check if it is the first booking
            int count = rooms.Count;
            while (!(found) && (index < rooms.Count - 1))  //if not "this" booking and you are not at the end of the list 
            {
                index = index + 1;
                found = (rooms[index].getRoomNo == num);   // this will be TRUE if found
            }
            if (found == false)
            {
                return null;
            }
            return rooms[index];  // this is the one!  
        }


        //FillRow method for Customer Table
        private void FillRow(DataRow aRow, Customer aCus, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["CustomerID"] = aCus.CustomerID;  //NOTE square brackets to indicate index of collections of fields in row.
                aRow["PersonID"] = aCus.getPersonID;         
            }           
        }

        //FillRow method for booking table
        private void FillRow(DataRow aRow, Booking book, DB.DBOperation operation)
        {          
            if (operation == DB.DBOperation.Add)
            {
                aRow["BookingID"] = book.getBookingID;  //NOTE square brackets to indicate index of collections of fields in row.
                aRow["CustomerID"] = book.getCustomerID;
                //aRow["AccountNum"] = book.getAccountNum;
                aRow["CustomerRequests"] = book.getCustomerRequests;
                aRow["BookingDate"] = book.getBookingDate;
                aRow["ArrivalDate"] = book.getArrival;
                aRow["DepartureDate"] = book.getDeparture;
                aRow["numPeople"] = book.getNumPeople;
            }
        }
        //FillRow method for person table
        private void FillRow(DataRow aRow, Person aPers, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {               
                aRow["PersonID"] = aPers.getPersonID;
                aRow["FirstName"] = aPers.getFName;
                aRow["SecondName"] = aPers.getSName;
                aRow["Email"] = aPers.getEmail;
                aRow["StreetName"] = aPers.getStreetName;
                aRow["SuburbName"] = aPers.getSuburbName;
                aRow["CityName"] = aPers.getCityName;
                aRow["PostalCode"] = aPers.getPostalCode;
            }
        }

        //FillRow method for roombooking table
        private void FillRow(DataRow aRow, RoomBooking rb, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["RoomNumber"] = rb.getRoomObject.getRoomNo;  //NOTE square brackets to indicate index of collections of fields in row.
                aRow["BookingID"] = rb.getBookingObject.getBookingID;            
            }
        }

        //FillRow method for account Table
        private void FillRow(DataRow aRow, Account acc, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["AccountNum"] = acc.AccountNum;  //NOTE square brackets to indicate index of collections of fields in row.
                aRow["AmountDue"] = acc.AmountDue;
                aRow["DepositAmount"] = acc.DepositAmount;
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
                    if ( book.getBookingID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        //FindRow method for roombooking table
        private int FindRow(RoomBooking rBooking, string table)
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
                    if (Convert.ToString(rBooking.getRoomObject.getRoomNo) == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["RoomNumber"]) && Convert.ToString(rBooking.getBookingObject.getBookingID) == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        //FindRow method for Person table
        private int FindRow(Person person, string table)
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
                    if (person.getPersonID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["PersonID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        //FindRow method for account table
        private int FindRow(Account acc, string table)
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
                    if (acc.AccountNum == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["AccountNum"]))
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

        //DataSetChange method for roombooking table
        public void DataSetChange(RoomBooking rbook, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table2;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, rbook, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;

                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(rbook, dataTable)];
                    FillRow(aRow, rbook, operation);
                    break;

                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(rbook, dataTable)];
                    aRow.Delete();
                    break;
            }
        }

        //Datasetchange method for person table
        public void DataSetChange(Person person, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table4;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, person, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;

                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(person, dataTable)];
                    FillRow(aRow, person, operation);
                    break;

                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(person, dataTable)];
                    aRow.Delete();
                    break;
            }
        }

        //Datasetchange method for account table
        public void DataSetChange(Account acc, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table6;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, acc, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;

                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(acc, dataTable)];
                    FillRow(aRow, acc, operation);
                    break;

                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(acc, dataTable)];
                    aRow.Delete();
                    break;

            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database

        //////////////////////////////////////////////////////////////////////////////////// Build_INSERT_Parameter methods ///////////////////////////////////////////////////////////

        ////Build_INSERT_Parameters for customer
        private void Build_INSERT_Parameters(Customer aCust)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 15, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@PersonID", SqlDbType.NVarChar, 15, "PersonID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

        }

        //Build_INSERT_Parameters for booking
        private void Build_INSERT_Parameters(Booking book)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 15, "BookingID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 15, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountNum", SqlDbType.NVarChar, 15, "AccountNum");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CustomerRequests", SqlDbType.NVarChar, 200, "CustomerRequests");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@BookingDate", SqlDbType.DateTime, 100, "BookingDate"); //what to do with the number parameter?
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ArrivalDate", SqlDbType.DateTime, 100, "ArrivalDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepartureDate", SqlDbType.DateTime, 100, "DepartureDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@numPeople", SqlDbType.TinyInt, 1, "numPeople"); //Do i include this?? doublecheck
            daMain.InsertCommand.Parameters.Add(param);
        }

        ////Build_UPDATE_Parameters for roombooking
        private void Build_INSERT_Parameters(RoomBooking rb)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomNumber", SqlDbType.Int, 5, "RoomNumber");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 15, "BookingID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.
        }
        ////Build_INSERT_Parameters for person
        private void Build_INSERT_Parameters(Person aPers)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@FirstName", SqlDbType.NVarChar, 100, "FirstName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SecondName", SqlDbType.NVarChar, 100, "SecondName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PersonID", SqlDbType.NVarChar, 15, "PersonID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@StreetName", SqlDbType.NVarChar, 100, "StreetName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SuburbName", SqlDbType.NVarChar, 50, "SuburbName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CityName", SqlDbType.NVarChar, 50, "CityName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PostalCode", SqlDbType.NVarChar, 50, "PostalCode");
            daMain.InsertCommand.Parameters.Add(param);
        }

        ////Build_INSERT_Parameters for account
        private void Build_INSERT_Parameters(Account acc)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@AccountNum", SqlDbType.NVarChar, 15, "AccountNum");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@DepositAmount", SqlDbType.Money, 15, "DepositAmount");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@AmountDue", SqlDbType.Money, 15, "AmountDue");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

        }

        //////////////////////////////////////////////////////////////////////////////////// Build_UPDATE_Parameter methods ///////////////////////////////////////////////////////////

        ////Build_UPDATE_Parameters for booking
        private void Build_UPDATE_Parameters(Booking book)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@CustomerRequests", SqlDbType.NVarChar, 200, "CustomerRequests");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and EMPID as for Insert 
            param = new SqlParameter("@BookingDate", SqlDbType.DateTime, 50, "BookingDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@ArrivalDate", SqlDbType.DateTime, 100, "ArrivalDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@DepartureDate", SqlDbType.DateTime, 100, "DepartureDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@numPeople", SqlDbType.TinyInt, 1, "numPeople");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "BookingID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        ////Build_UPDATE_Parameters for roomBooking
        private void Build_UPDATE_Parameters(RoomBooking rb)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@RoomNumber", SqlDbType.Int, 5, "RoomNumber");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 15, "BookingID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

        }

        private void Build_UPDATE_Parameters(Account acc)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@DepositAmount", SqlDbType.Money, 15, "DepositAmount");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@AmountDue", SqlDbType.Money, 15, "AmountDue");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "AccountNum");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

        }

        //////////////////////////////////////////////////////////////////////////////////// Build_DELETE_Parameter methods ///////////////////////////////////////////////////////////

        //Build_DELETE_Parameters for Booking
        private void Build_DELETE_Parameters(Booking book)
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 15, "BookingID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }

        //Build_DELETE_Parameters for roomBooking
        private void Build_DELETE_Parameters(RoomBooking rb)
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 15, "BookingID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNumber", SqlDbType.Int, 5, "RoomNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }

        //////////////////////////////////////////////////////////////////////////////////// Create_INSERT_Parameter methods ///////////////////////////////////////////////////////////
        
        private void Create_INSERT_Command(Person aPerson)
        {
            //Create the command that must be used to insert values into the person table..
            daMain.InsertCommand = new SqlCommand("INSERT into Person (PersonID, FirstName, SecondName, Email, StreetName, SuburbName, CityName, PostalCode) VALUES (@PersonID, @FirstName, @SecondName, @Email, @StreetName, @SuburbName, @CityName, @PostalCode)", cnMain);
            Build_INSERT_Parameters(aPerson);
        }

        private void Create_INSERT_Command(Customer aCust)
        {
            //Create the command that must be used to insert values into the customer table..
            daMain.InsertCommand = new SqlCommand("INSERT into Customer (CustomerID, PersonID) VALUES (@CustomerID, @PersonID)", cnMain);
            Build_INSERT_Parameters(aCust);
        }

        private void Create_INSERT_Command(Booking book)
        {
            //Create the command that must be used to insert values into the booking table..
            daMain.InsertCommand = new SqlCommand("INSERT into Booking (BookingID, CustomerID, AccountNum, CustomerRequests, BookingDate, ArrivalDate, DepartureDate, numPeople) VALUES (@BookingID, @CustomerID, @AccountNum, @CustomerRequests, @BookingDate, @ArrivalDate, @DepartureDate, @numPeople)", cnMain);
            Build_INSERT_Parameters(book);
        }

        private void Create_INSERT_Command(RoomBooking rb)
        {
            //Create the command that must be used to insert values into the customer table..
            daMain.InsertCommand = new SqlCommand("INSERT into RoomBooking (RoomNumber, BookingID) VALUES (@RoomNumber, @BookingID)", cnMain);
            Build_INSERT_Parameters(rb);
        }

        private void Create_INSERT_Command(Account acc)
        {
            //Create the command that must be used to insert values into the customer table..
            daMain.InsertCommand = new SqlCommand("INSERT into Account (AccountNum, AmountDue, DepositAmount ) VALUES (@AccountNum, @AmountDue, @DepositAmount)", cnMain);
            Build_INSERT_Parameters(acc);
        }

        //////////////////////////////////////////////////////////////////////////////////// Create_UPDATE_Parameter methods /////////////////////////////////////////////////////////// 

        private void Create_UPDATE_Command(Booking book)
        {
            //Create the command that must be used to insert values into cutosmer table
            //Assumption is that the CustomerID and PersonID cannot be changed
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET CustomerRequests =@CustomerRequests, BookingDate =@BookingDate, ArrivalDate =@ArrivalDate, DepartureDate = @DepartureDate, numPeople = @numPeople " + "WHERE BookingID = @Original_ID", cnMain);
            Build_UPDATE_Parameters(book);
        }

        private void Create_UPDATE_Command(Account acc)
        {
            //Create the command that must be used to insert values into cutosmer table
            //Assumption is that the CustomerID and PersonID cannot be changed
            daMain.UpdateCommand = new SqlCommand("UPDATE Account SET AmountDue =@AmountDue, DepositAmount =@DepositAmount " + "WHERE AccountNum = @Original_ID", cnMain);
            Build_UPDATE_Parameters(acc);
        }

        //////////////////////////////////////////////////////////////////////////////////// Create_DELETE_Parameter methods ///////////////////////////////////////////////////////////

        private string Create_DELETE_Command(Booking book)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the Customer table
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Booking WHERE BookingID = @BookingID", cnMain);

            try
            {
                Build_DELETE_Parameters(book);
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            return errorString;
        }

        private string Create_DELETE_Command(RoomBooking rb)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the roombooking table
            daMain.DeleteCommand = new SqlCommand("DELETE FROM RoomBooking WHERE BookingID = @BookingID", cnMain);

            try
            {
                Build_DELETE_Parameters(rb);
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            return errorString;
        }

        //////////////////////////////////////////////////////////////////////////////////// UpdateDataSource methods ///////////////////////////////////////////////////////////

        public bool UpdateDataSource(Customer aCust)
        {
            bool success = true;
            Create_INSERT_Command(aCust);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        public bool UpdateDataSource(Person aPerson)
        {
            bool success = true;
            Create_INSERT_Command(aPerson);
            success = UpdateDataSource(sqlLocal4, table4);
            return success;
        }

        public bool UpdateDataSource(Booking book)
        {
            bool success = true;
            Create_INSERT_Command(book);
            Create_UPDATE_Command(book);
            Create_DELETE_Command(book);
            success = UpdateDataSource(sqlLocal3, table3);
            return success;
        }

        public bool UpdateDataSource(RoomBooking rb)
        {
            bool success = true;
            Create_INSERT_Command(rb);
            Create_DELETE_Command(rb);
            success = UpdateDataSource(sqlLocal2, table2);
            return success;
        }

        public bool UpdateDataSource(Account acc)
        {
            bool success = true;
            Create_INSERT_Command(acc);
            Create_UPDATE_Command(acc);
            success = UpdateDataSource(sqlLocal6, table6);
            return success;
        }
        #endregion
    }
}

