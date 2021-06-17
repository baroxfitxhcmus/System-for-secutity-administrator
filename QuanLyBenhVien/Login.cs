using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace QuanLyBenhVien
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbTenDN.Text;
            string password = tbMK.Text;
            string connectionString = Config.connectionString(username, password);
            try
            {
                
                if (username == "sys")
                {
                    connectionString += "DBA PRIVILEGE = SYSDBA;";
                }
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    Dashboard home = new Dashboard();
                    home.Sender(username + "," + password);
                    home.Show();
                    this.Hide();
                    con.Close();
                }
            }
            catch
            {
                lbAnnouce.Text = "Tên đăng nhập hoặc mật khẩu không đúng" ;
            }
        }
    }
}
