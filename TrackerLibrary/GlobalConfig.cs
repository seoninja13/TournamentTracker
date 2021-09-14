using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    // 'Static Class' can not be instantiaed and it is 'Global' (can be used by everyone).
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DataBaseType db)
        {
            // another way to simplify the use of 'if' statements.
            //switch (db)
            //{
            //    case DataBaseType.Sql:
            //        break;
            //    case DataBaseType.TextFile:
            //        break;
            //    default:
            //        break;
            //}

            if (db == DataBaseType.Sql)
            {
                // TODO: Setup the sql connector properly
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if(db == DataBaseType.TextFile)
            {
                // TODO: Create the text file connection.
                TextConnector TextConnection = new TextConnector();
                Connection = TextConnection;
            }
        }

        public static string ConnString (string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
}
    }

