using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_App
{
    public class DataBase
    {
        static public String ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings
                ["IST440GRP4"].ConnectionString;
            }
        }
    }
}
