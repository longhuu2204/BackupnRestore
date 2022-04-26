using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18DCCN109_BACKUP_RESTORE.DTO
{
    public class Database
    {
        public int id { get; set; }
        public string name { get; set; }

        public Database(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Database() : this(-1, "") { }
        public Database(DataRow dataRow)
        {
            this.id = int.Parse(dataRow["database_id"].ToString());
            this.name = dataRow["name"].ToString();
        }
    }
  
}
