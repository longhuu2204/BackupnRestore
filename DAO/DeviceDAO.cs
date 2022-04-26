using N18DCCN109_BACKUP_RESTORE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N18DCCN109_BACKUP_RESTORE.DAO
{
    public class DeviceDAO
    {
        private static DeviceDAO instance;
        public static DeviceDAO Instance
        {
            get { if (instance == null) instance = new DeviceDAO(); return instance; }
            private set { instance = value; }
        }

        private DeviceDAO() { }
        public Device GetDevice(string connection, string tenDevice)
        {
            Device device = new Device();
            DataProvider dp = new DataProvider(connection);
            DataTable dt = dp.ExecuteQuery("SELECT name FROM master.dbo.sysdevices WHERE name = '" + tenDevice + "'");

            if (dt.Rows.Count > 0)
            {
                device.name = dt.Rows[0].ToString();
            }

            return device;
        }
    }
}