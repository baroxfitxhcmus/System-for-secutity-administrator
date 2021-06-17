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
    public partial class RoleDetail : Form
    {
        public delegate void SendMessage(string Message);
        public SendMessage SenderRoleDetail;
        public RoleDetail()
        {
            InitializeComponent();
            SenderRoleDetail = new SendMessage(GetConnection);
        }
        private static string connectionStringRole;
        public static string roleName;
        public static bool statusView = true;
        private void GetConnection(string Message)
        {
            connectionStringRole = Message.Substring(0, Message.IndexOf(','));
            roleName = Message.Substring(Message.IndexOf(',') + 1);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoleDetail_Load(object sender, EventArgs e)
        {
            lbRoleName.Text = "Tên role: " + " " + roleName;
            tbSearchPrivs.Text = "";
            if(statusView == true)
            {
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }
            if (statusView == true)
            {
                
                using (OracleConnection conn = new OracleConnection(connectionStringRole))
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + roleName + "'", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dtPrivOfRole.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
            else
            {
                using (OracleConnection conn = new OracleConnection(connectionStringRole))
                {
                    OracleCommand cmd = new OracleCommand("SELECT  OWNER, PRIVILEGE, TABLE_NAME, GRANTOR, TYPE  FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + roleName + "'", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dtPrivOfRole.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
            RoleDetail_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtPrivOfRole.Rows[e.RowIndex];
                tbSearchPrivs.Text = row.Cells[1].Value.ToString();
                if (statusView == false)
                {
                    tbSearchPrivs.Text += " ON " + row.Cells[2].Value.ToString();
                }
            }
        }

        private void btnView_Object_System_Click(object sender, EventArgs e)
        {
            if (statusView == true)
            {
                statusView = false;
                btnView_Object_System.Text = "Xem quyền hệ thống";
                RoleDetail_Load(sender, e);
            }
            else
            {
                statusView = true;
                btnView_Object_System.Text = "Xem quyền đối tượng";
                RoleDetail_Load(sender, e);
            }
        }

        private void btnDeletePriv_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("REVOKE " + tbSearchPrivs.Text.ToUpper() + " FROM " + roleName, conn);
                    cmd.ExecuteReader();
                    conn.Close();
                }
                MessageBox.Show("Xóa quyền " + tbSearchPrivs.Text + " thành công");
                RoleDetail_Load(sender, e);
                tbSearchPrivs.Text = "";
            }
            catch
            {
                MessageBox.Show("Xóa quyền không thành công");
            }
        }
        public static AddPrivilege aPrivRole = null;
        private void btnAddPriv_Click(object sender, EventArgs e)
        {
            if(aPrivRole == null)
            {
                aPrivRole = new AddPrivilege();
                aPrivRole.senderAddPriv("role");
                aPrivRole.Show();
            }
            else
            {
                aPrivRole.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT GRANTEE, PRIVILEGE, GRANTOR, COLUMN_NAME, TABLE_NAME FROM USER_COL_PRIVS_MADE WHERE GRANTEE = '" + roleName + "'", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dtPrivOfRole.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
            else
            {
                RoleDetail_Load(sender, e);
            }
        }
    }
}
