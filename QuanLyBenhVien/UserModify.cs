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
    public partial class UserModify : Form
    {
        public delegate void SendMessage(string Message);
        public SendMessage senderModifyUser;
        private string userName;
        public UserModify()
        {
            InitializeComponent();
            senderModifyUser = new SendMessage(getMessage);
        }
        private void getMessage(string Message)
        {
            userName = Message;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ListUser.uModified = null;
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string newPassword = tbNewPassword.Text;
            try
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("ALTER USER " + userName + " IDENTIFIED BY " + newPassword, conn);
                    conn.Open();
                    cmd.ExecuteReader();
                }
                MessageBox.Show("Thay đổi mật khẩu thành công");
            }
            catch
            {
                MessageBox.Show("Thay đổi mật khẩu không thành công");
            }
        }

        private void UserModify_Load(object sender, EventArgs e)
        {
            tbUser.Text = userName;
        }
    }
}
