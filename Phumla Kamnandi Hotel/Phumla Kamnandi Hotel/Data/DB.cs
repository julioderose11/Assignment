using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Phumla_Kamnandi_Hotel.Properties;

namespace Phumla_Kamnandi_Hotel.Data
{
    class DB
    {
        #region Variable declaration
        //***Once the database is created you can find the correct connection string by using the Settings.Default object to select the correct connection string
        private string strConn = Settings.Default.HotelDatabaseConnectionString;
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;
        #endregion 

    }
}
