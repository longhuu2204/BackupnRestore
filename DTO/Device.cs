using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18DCCN109_BACKUP_RESTORE.DTO
{
    public class Device
    {
        public string name { get; set; }

        public Device(string name)
        {
            this.name = name;
        }

        public Device() : this("") { }
        public Device(DataRow dataRow)
        {
            this.name = dataRow["name"].ToString();
        }
    }
}
