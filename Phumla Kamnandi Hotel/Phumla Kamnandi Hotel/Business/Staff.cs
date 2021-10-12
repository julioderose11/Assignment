using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_Hotel.Business
{
    class Staff: Person
    {
        #region Fields
        private string employeeID;
        #endregion

        #region Getters and Setters
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        #endregion

        #region Constructor Methods
        public Staff()
        {
            employeeID = "";
        }

        public Staff(string sID)
        {
            employeeID = sID;
        }
        #endregion
    }
}
