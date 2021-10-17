using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel
{
    class Person
    {
        #region data members
        private string personID, name, email, streetName, suburbName, cityName, postalCode;
        #endregion
        #region Properties
        public string getPersonID
        {
            get { return personID; }
            set { personID = value; }
        }

        public string getName
        {
            get { return name; }
            set { name = value; }
        }
        public string getEmail
        {
            get { return email; }
            set { email = value; }
        }

        public string getStreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }
        public string getSuburbName
        {
            get { return suburbName; }
            set { suburbName = value; }
        }
        public string getCityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        public string getPostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
        #endregion
        #region Construtor
        public Person()
        {
            personID = "";
            name = "";
            email = "";
            streetName = "";
            suburbName = "";
            cityName = "";
            postalCode = "";
        }

        public Person(string pID, string pName, string pEmail, string street, string suburb, string city, string pCode)
        {
            personID = pID;
            name = pName;
            email = pEmail;
            streetName = street;
            suburbName = suburb;
            cityName = city;
            postalCode = pCode;
        }
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return "PersonID: " + personID + "\nName: " + name + "\nEmail: " + email;
        }
        #endregion



    }

}
