using N18DCCN109_BACKUP_RESTORE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18DCCN109_BACKUP_RESTORE.DAO
{
    public class BackupDAO
    {
        public static BackupDAO instance;

        public static BackupDAO Instance
        {
            get { if (instance == null) instance = new BackupDAO(); return instance; }
            private set { instance = value; }
        }

        private BackupDAO() { }

        public List<Backup> GetAllBackups(string connection, string tenCSDL)
        {
            List<Backup> backups = new List<Backup>();

            DataProvider dp = new DataProvider(connection);

            DataTable dt = dp.ExecuteQuery("SELECT position, name, user_name FROM  msdb.dbo.backupset  WHERE database_name = '"+tenCSDL+"' AND type = 'D' AND backup_set_id >= (SELECT  MAX(backup_set_id) FROM msdb.dbo.backupset WHERE database_name = '"+tenCSDL+"' AND type = 'D' AND position = '1') ORDER BY position DESC");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Backup data = new Backup(item);
                    backups.Add(data);
                }
            }

            return backups;
        }
    }
}
