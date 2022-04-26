using N18DCCN109_BACKUP_RESTORE.DAO;
using N18DCCN109_BACKUP_RESTORE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N18DCCN109_BACKUP_RESTORE
{
    public partial class mainForm : Form
    {
        string tenDevice;
        string tenCSDL;
        string strFullPathDevice;
        int numrow;
        List<Database> listDatabase;
        List<Backup> listBackups;
        private string _connection;



        public mainForm(string connection)
        {
            _connection = connection;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            listDatabase = DatabaseDAO.Instance.GetAllDatabases(_connection);

            lvDatabaseList.Items.Clear();

            foreach (Database item in listDatabase)
            {
                lvDatabaseList.Items.Add(item.name);
            }
            saoLưuToolStripMenuItem.Enabled = false;
            tạoDeviceSaoLưuToolStripMenuItem.Enabled = false;

        }

        private void lvDatabaseList_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lvDatabaseList.SelectedItems[0].Text);
            tenCSDL = lvDatabaseList.SelectedItems[0].Text;
            txtTenCSDL.Text = tenCSDL;
            tenDevice = "DEVICE_" + lvDatabaseList.SelectedItems[0].Text;

            Device device = DeviceDAO.Instance.GetDevice(_connection, tenDevice);
            //MessageBox.Show(device.name);
            if (device.name != "")
            {
                tạoDeviceSaoLưuToolStripMenuItem.Enabled = false;
                saoLưuToolStripMenuItem.Enabled = true;
            }
            else
            {
                tạoDeviceSaoLưuToolStripMenuItem.Enabled = true;
                saoLưuToolStripMenuItem.Enabled = false;
            }


            listBackups = BackupDAO.Instance.GetAllBackups(_connection, tenCSDL);
            dataGridBackup.DataSource = listBackups;
            txtTenDevice.Text = tenDevice;
            txtSoLuong.Text = listBackups.Count.ToString();

        }


        private void tạoDeviceSaoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {


            strFullPathDevice = Program.strDefaultPath + tenDevice + ".BAK";
            DataProvider dp = new DataProvider(_connection);
            string query = "EXEC sp_addumpdevice 'disk', '" + tenDevice + "','" + strFullPathDevice + "'";
            dp.ExecuteNonQuery(query);
            MessageBox.Show("Tạo Device thành công!!!");
        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider(_connection);
            string query = "BACKUP DATABASE " + tenCSDL + " TO " + tenDevice;
            dp.ExecuteNonQuery(query);
            MessageBox.Show("Tạo Backup thành công!!!");
        }

        private void dataGridBackup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            numrow = e.RowIndex;
            DataProvider dp = new DataProvider(_connection);
            string query = "RESTORE DATABASE " + tenCSDL + "FROM " + tenDevice;
            dp.ExecuteNonQuery(query);
            MessageBox.Show("Restore thành công!!!");

        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
