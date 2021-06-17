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
    public partial class RoleCreate : Form
    {
        public RoleCreate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ListRole.rCreate = null;
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(tbNewRoleName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào tên role muốn tạo");
                return;
            }
            try
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("CREATE ROLE " + tbNewRoleName.Text, conn);
                    conn.Open();
                    cmd.ExecuteReader();
                    conn.Close();
                }
                MessageBox.Show("Tạo role " + tbNewRoleName.Text.ToUpper() + " thành công");
                tbNewRoleName.Text = "";
            }
            catch
            {
                MessageBox.Show("Tạo role không thành công");
            }
        }
    }
}
