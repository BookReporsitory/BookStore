using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using MySql.Data;

namespace BooksManagement.DBOpreation
{
    public class DBConnection
    {
        /// <summary>
        /// get default connection string.
        /// </summary>
        /// <returns>Connection String</returns>
        static public string GetConnectionString()
        {
            DbConnectionStringBuilder connectBuilder = new DbConnectionStringBuilder();

            connectBuilder.Add("Data Source", "localhost");
            connectBuilder.Add("Database", "bookstore");
            connectBuilder.Add("User ID", "root");
            connectBuilder.Add("Password", "v*elocIpEd");

            return connectBuilder.ConnectionString;
        }
    }
}
