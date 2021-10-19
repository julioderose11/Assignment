using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel
{
    public class Person
    {
        #region data members
        private string personID, FName, SName, email, streetName, suburbName, cityName, postalCode;
        #endregion
        #region Properties
        public string getPersonID
        {
            get { return personID; }
            set { personID = value; }
        }

        public string getFName
        {
            get { return FName; }
            set { FName = value; }
        }
        public string getSName
        {
            get { return SName; }
            set { SName = value; }
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
            FName = "";
            SName = "";
            email = "";
            streetName = "";
            suburbName = "";
            cityName = "";
            postalCode = "";
        }

        public Person(string pID, string pFName, string pSName, string pEmail, string street, string suburb, string city, string pCode)
        {
            personID = pID;
            FName = pFName;
            SName = pSName;
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
            return "PersonID: " + personID + "\nName: " + FName+ "\n" + SName + "\nEmail: " + email;
        }
        #endregion



    }

}
