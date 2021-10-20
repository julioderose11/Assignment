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
         Collection<Customer> customers;
         Collection<Booking> bookings;
         Collection<Room> rooms;
         Collection<RoomBooking> roomBookings;
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
                //Include below actions if we decide to allow edit and deletion of customers/////////////////////////////
                /*case DB.DBOperation.Edit:
                    index = FindIndex(aCust);
                    customers[index] = aCust;  // replace customer at this index with the updated customer
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aCust);  // find the index of the specific customer in collection
                    customers.RemoveAt(index);  // remove that customer form the collection
                    break;*/

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

        //DataMaintenance method for roombooking table
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
        //***Commit the changes to the database
        public bool FinalizeChanges(Customer customer)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return bookingDB.UpdateDataSource(customer);
        }

        public bool FinalizeChanges(Booking booking)
        {
            //***call the BookingDB method that will commit the changes to the database
            return bookingDB.UpdateDataSource(booking);
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

        public bool isAvailable(DateTime arrivalDate, DateTime departureDate)
        {
            bool flag = false;
            Collection<RoomBooking> matches;
            foreach (RoomBooking roomBooking in roomBookings)
            {
                matches = FindByRoom(roomBookings, roomBooking.getRoomObject);
                foreach (RoomBooking match in matches)
                {
                    if (arrivalDate.CompareTo(match.getBookingObject.getDeparture) > 0)
                    {
                        flag = true;
                    }
                    else if (arrivalDate.CompareTo(match.getBookingObject.getDeparture) < 0)
                    {
                        if (departureDate.CompareTo(match.getBookingObject.getArrival) < 0)
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
                if (flag==true)
                {
                    availRoom = roomBooking.getRoomObject;
                    break;
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
