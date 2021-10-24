﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamnandi_Hotel.Data;
using System.Collections.ObjectModel;

namespace Phumla_Kamnandi_Hotel.Business
{
    public class BookingController
    {
        #region: Fields
         BookingDB bookingDB;
         public Collection<Customer> customers;
         public Collection<Booking> bookings;
         public Collection<Room> rooms;
         public Collection<RoomBooking> roomBookings;
         public Collection<Person> persons;
        public Collection<Account> accounts;

         Room availRoom;
        #endregion

        #region Properties
        public Room AvailRoom
        {
            get
            {
                return availRoom;
            }
        }
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
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
        public Collection<RoomBooking> AllRoomBookings
        {
            get
            {
                return roomBookings;
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

        #region: Constructor
        public BookingController()
        {
            //***instantiate the BookingDB object to communicate with the database
            bookingDB = new BookingDB();
            customers = bookingDB.AllCustomers;
            bookings = bookingDB.AllBookings;
            rooms = bookingDB.AllRooms;
            roomBookings = bookingDB.AllRoomBookings;
            persons = bookingDB.AllPersons;
            accounts = bookingDB.AllAccounts;
        }
        #endregion 
        
          #region Database Communication.
        //DataMaintenance method for customer table
        public void DataMaintenance(Customer aCust, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            bookingDB.DataSetChange(aCust, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the customer to the Collection
                    customers.Add(aCust);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aCust);
                    customers[index] = aCust;  // replace customer at this index with the updated customer
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aCust);  // find the index of the specific customer in collection
                    customers.RemoveAt(index);  // remove that customer form the collection
                    break;

            }
        }

        //DataMaintenance method for booking table 
        public void DataMaintenance(Booking book, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            bookingDB.DataSetChange(book, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the customer to the Collection
                    bookings.Add(book);
                    break;

                    
                    case DB.DBOperation.Edit:
                        index = FindIndex(book);
                        bookings[index] = book;  // replace booking at this index with the updated booking
                        break;
                    case DB.DBOperation.Delete:
                        index = FindIndex(book);  // find the index of the specific booking in collection
                        bookings.RemoveAt(index);  // remove that booking from the collection
                        break;
            }
        }

        //DataMaintenance method for roombooking table?
        public void DataMaintenance(RoomBooking roombook, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            bookingDB.DataSetChange(roombook, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the customer to the Collection
                    roomBookings.Add(roombook);
                    break;

                    //Uncomment when FindIndex method is created
                    /* case DB.DBOperation.Edit:
                         index = FindIndex(book);
                         bookings[index] = book;  // replace booking at this index with the updated booking
                         break;
                     case DB.DBOperation.Delete:
                         index = FindIndex(book);  // find the index of the specific booking in collection
                         bookings.RemoveAt(index);  // remove that booking from the collection
                         break;*/
            }
        }

        public void DataMaintenance(Person p, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            bookingDB.DataSetChange(p, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the person to the Collection
                    persons.Add(p);
                    break;

                    //Uncomment when FindIndex method is created
                     case DB.DBOperation.Edit:
                         index = FindIndex(p);
                         persons[index] = p;  // replace booking at this index with the updated booking
                         break;
                     case DB.DBOperation.Delete:
                         index = FindIndex(p);  // find the index of the specific booking in collection
                        persons.RemoveAt(index);  // remove that booking from the collection
                         break;
            }
        }

        public void DataMaintenance(Account acc, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            bookingDB.DataSetChange(acc, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the person to the Collection
                    accounts.Add(acc);
                    break;

                //Uncomment when FindIndex method is created
                case DB.DBOperation.Edit:
                    index = FindIndex(acc);
                    accounts[index] = acc;  // replace booking at this index with the updated booking
                    break;
              
            }
        }
        //***Commit the changes to the database
        public bool FinalizeChanges(Customer customer)
        {
            
            return bookingDB.UpdateDataSource(customer);
        }

        public bool FinalizeChanges(Booking booking)
        {
            //***call the BookingDB method that will commit the changes to the database
            return bookingDB.UpdateDataSource(booking);
        }

        public bool FinalizeChanges(Person person)
        {
            //***call the BookingDB method that will commit the changes to the database
            return bookingDB.UpdateDataSource(person);
        }

        public bool FinalizeChanges(RoomBooking rb)
        {
            //***call the BookingDB method that will commit the changes to the database
            return bookingDB.UpdateDataSource(rb);
        }

        public bool FinalizeChanges(Account acc)
        {
            //***call the BookingDB method that will commit the changes to the database
            return bookingDB.UpdateDataSource(acc);
        }
        #endregion

        #region: Methods
        //This method receives a CustomerID as a parameter; finds the customer object in the collection of customers and then returns this object
        public Customer FindCustomer(string ID)
        {
            int index = 0;
            bool found = (customers[index].CustomerID == ID);  //check if it is the first customer
            int count = customers.Count;
            while (!(found) && (index < customers.Count - 1))  //if not "this" customer and you are not at the end of the list 
            {
                index = index + 1;
                found = (customers[index].CustomerID == ID);   // this will be TRUE if found
            }
            if (found == false)
            {
                return null;
            }
            return customers[index];  // this is the one!  
        }
        public Customer FindCustomer2(string pID)
        {
            int index = 0;
            bool found = (customers[index].getPersonID == pID);  //check if it is the first customer
            int count = customers.Count;
            while (!(found) && (index < customers.Count - 1))  //if not "this" customer and you are not at the end of the list 
            {
                index = index + 1;
                found = (customers[index].getPersonID == pID);   // this will be TRUE if found
            }
            if (found == false)
            {
                return null;
            }
            return customers[index];  // this is the one!  
        }
        public Person FindPerson(string ID)
        {
            int index = 0;
            bool found = (persons[index].getPersonID == ID);  //check if it is the first customer
            int count = persons.Count;
            while (!(found) && (index < persons.Count - 1))  //if not "this" customer and you are not at the end of the list 
            {
                index = index + 1;
                found = (persons[index].getPersonID == ID);   // this will be TRUE if found
            }
            if (found == false)
            {
                return null;
            }
            return persons[index];  // this is the one!  
        }
        public int FindIndex(Customer aCust)
        {
            int counter = 0;
            bool found = false;
            found = (aCust.CustomerID == customers[counter].CustomerID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < customers.Count - 1)
            {
                counter += 1;
                found = (aCust.CustomerID == customers[counter].CustomerID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        public int FindIndex(Person aPers)
        {
            int counter = 0;
            bool found = false;
            found = (aPers.getPersonID == persons[counter].getPersonID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < persons.Count - 1)
            {
                counter += 1;
                found = (aPers.getPersonID == persons[counter].getPersonID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        public int FindIndex(Account acc)
        {
            int counter = 0;
            bool found = false;
            found = (acc.AccountNum == accounts[counter].AccountNum);   //using a Boolean Expression to initialise found
            while (!(found) & counter < accounts.Count - 1)
            {
                counter += 1;
                found = (acc.AccountNum == accounts[counter].AccountNum);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        //This method receives a BookingID as a parameter; finds the booking object in the collection of bookings and then returns this object
        public Booking FindBooking(string ID)
        {
            int index = 0;
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
        public int FindIndex(Booking aBook)
        {
            int counter = 0;
            bool found = false;
            found = (aBook.getBookingID == bookings[counter].getBookingID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < bookings.Count - 1)
            {
                counter += 1;
                found = (aBook.getBookingID == bookings[counter].getBookingID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        public int FindIndex(RoomBooking rBook)
        {
            int counter = 0;
            bool found1 = false;
            bool found2 = false;
            found1 = (rBook.getBookingObject.getBookingID == roomBookings[counter].getBookingObject.getBookingID);   //using a Boolean Expression to initialise found
            found2 = (rBook.getRoomObject.getRoomNo == roomBookings[counter].getRoomObject.getRoomNo);
            while (!(found1 && found2) & counter < roomBookings.Count - 1)
            {
                counter += 1;
                found1 = (rBook.getBookingObject.getBookingID == roomBookings[counter].getBookingObject.getBookingID);
                found2 = (rBook.getRoomObject.getRoomNo == roomBookings[counter].getRoomObject.getRoomNo);
            }
            if (found1 && found2)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        //RoomBooking?

        public bool isAvailable(Booking booking)
        {
            bool flag = false;
            Collection<RoomBooking> matches;
            if(roomBookings == null)
            {
                flag = true;
                
            }
            else
            {
                foreach (RoomBooking roomBooking in roomBookings)
                {
                    matches = FindByRoom(roomBookings, roomBooking.getRoomObject);
                    foreach (RoomBooking match in matches)
                    {
                        if (booking.getBookingID==match.getBookingObject.getBookingID)
                        {
                            matches.Remove(match);
                            break;
                        }
                        if (booking.getArrival.CompareTo(match.getBookingObject.getDeparture) > 0)
                        {
                            flag = true;
                        }
                        else if (booking.getArrival.CompareTo(match.getBookingObject.getDeparture) < 0)
                        {
                            if (booking.getDeparture.CompareTo(match.getBookingObject.getArrival) < 0)
                            {
                                flag = true;
                            }
                            else
                            {
                                flag = false;
                                break;
                            }
                        }
                    }
                    if (flag == true)
                    {
                        availRoom = roomBooking.getRoomObject;
                        break;
                    }
                }
            }
            
            return flag;       
        }
        public bool isAvailable(DateTime arrival, DateTime departure)
        {
            bool flag = false;
            Collection<RoomBooking> matches;
            if (roomBookings == null)
            {
                flag = true;

            }
            else
            {
                foreach (RoomBooking roomBooking in roomBookings)
                {
                    matches = FindByRoom(roomBookings, roomBooking.getRoomObject);
                    foreach (RoomBooking match in matches)
                    {
                        
                        if (arrival.CompareTo(match.getBookingObject.getDeparture) > 0)
                        {
                            flag = true;
                        }
                        else if (arrival.CompareTo(match.getBookingObject.getDeparture) < 0)
                        {
                            if (departure.CompareTo(match.getBookingObject.getArrival) < 0)
                            {
                                flag = true;
                            }
                            else
                            {
                                flag = false;
                                break;
                            }
                        }
                    }
                    if (flag == true)
                    {
                        availRoom = roomBooking.getRoomObject;
                        break;
                    }
                }
            }

            return flag;
        }

        public Collection<RoomBooking> FindByRoom(Collection<RoomBooking> rbs, Room room)
        {
            Collection<RoomBooking> matches = new Collection<RoomBooking>();
            foreach (RoomBooking rb in rbs)
            {
                if (rb.getRoomObject == room)
                {
                    matches.Add(rb);
                }
            }
            return matches;
        }


        #endregion
    }
}
