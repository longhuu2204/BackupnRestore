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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textTenSV.Text))
            {
                lblMessage.Text = "Tên Server không được để trống!!!";
                textTenSV.Focus();
            }
            else
            {
                if (String.IsNullOrEmpty(textTaiKhoan.Text))
                {
                    lblMessage.Text = "Tên đăng nhập không được để trống!!!";
                    textTaiKhoan.Focus();
                }
                else
                {
                    if (String.IsNullOrEmpty(textMatKhau.Text))
                    {
                        lblMessage.Text = "Tên đăng nhập không được để trống!!!";
                        textMatKhau.Focus();
                    }
                    else
                    {
                        string connection = $"Data Source={textTenSV.Text};user={textTaiKhoan.Text};password={textMatKhau.Text}";
                        DataProvider dp = new DataProvider(connection);
                        if (dp.CheckConnection())
                        {
                            this.Hide();
                            mainForm mf = new mainForm(connection);
                            mf.ShowDialog();
                            textMatKhau.Clear();  
                            this.Show();
                        }
                        else
                        {
                            lblMessage.Text = "Sai thông tin đăng nhập!!!";
                        }
                    }
                }
            }
        }

       

        private void btnThoatLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
