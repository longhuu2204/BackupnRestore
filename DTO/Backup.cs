using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N18DCCN109_BACKUP_RESTORE.DTO
{
    public class Backup
    {
        public int position { get; set; }
        public string name { get; set; }
      //  public string dateTime { get; set; }

        public string username { get; set; }

        public Backup(int position, string name, string username)
        {
            this.position = position;
            this.name = name;
          //  this.dateTime = datetime;
            this.username = username;
        }
        public Backup() : this(-1, "", "") { }

        public Backup(DataRow dataRow)
        {
            try
            {
                this.position = int.Parse(dataRow["position"].ToString());
                this.name = dataRow["name"].ToString();
              //  this.dateTime = Convert.ToString(dataRow["backup_start_date"]);
                this.username = dataRow["user_name"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
