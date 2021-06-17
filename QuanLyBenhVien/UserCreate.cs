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
    public partial class UserCreate : Form
    {
        public delegate void SendMessage(string message);
        public SendMessage senderCreateUser;
        private string connectionString;
        public UserCreate()
        {
            InitializeComponent();
            senderCreateUser = new SendMessage(getMessage);
        }
        public void getMessage(string Message)
        {
            connectionString = Message;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ListUser.newUser = null;
            this.Close();
        }

        private void tbCreate_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    OracleCommand cmd = new OracleCommand("CREATE USER " + username + " IDENTIFIED BY " + password, conn);
                    conn.Open();
                    cmd.ExecuteReader();
                }
                tbUsername.Text = "";
                tbPassword.Text = "";
                ListUser.load_gridView();
                MessageBox.Show("Tạo người dùng thành công!"); 
            }
            catch
            {
                lbAnnounce.Text = "Tạo người dùng không thành công";
            }
            
        }
    }
}
