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
        private string personID, name, email;
        #endregion
        #region Properties
        public string PersonID
        {
            get { return personID; }
            set { personID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion
        #region Construtor
        public Person()
        {
            personID = "";
            name = "";
            email = "";
        }

        public Person(string pID, string pName, string pEmail)
        {
            personID = pID;
            name = pName;
            email = pEmail;
        }
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return name + '\n' + email;
        }
        #endregion



    }

}
