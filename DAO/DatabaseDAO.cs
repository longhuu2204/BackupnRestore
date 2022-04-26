using N18DCCN109_BACKUP_RESTORE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18DCCN109_BACKUP_RESTORE.DAO
{
    public class DatabaseDAO
    {
        private static DatabaseDAO instance;

        public static DatabaseDAO Instance
        {
            get { if (instance == null) instance = new DatabaseDAO(); return instance; }
            private set { instance = value; }
        }
        private DatabaseDAO() { }

        public List<Database> GetAllDatabases(string connection)
        {
            List<Database> databases = new List<Database>();

            DataProvider dp = new DataProvider(connection);

            DataTable dt = dp.ExecuteQuery("SELECT database_id, name FROM sys.databases WHERE(database_id >= 5) AND(NOT(name LIKE N'ReportServer%')) ORDER BY NAME");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Database db = new Database(item);
                    databases.Add(db);
                }
            }

            return databases;
        }
    }
   
}
