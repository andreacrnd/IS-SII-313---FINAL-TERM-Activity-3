using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace Inventory
{
    public static class Database
    {
        public static readonly string DBpATH = 
            Path.GetFullPath(
                 Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\sampledb.accdb"
                 )
            );

        private static readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBpATH + ";Persist Security Info=False;";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }
    }
}
