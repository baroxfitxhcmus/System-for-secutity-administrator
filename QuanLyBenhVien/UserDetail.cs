using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
namespace QuanLyBenhVien
{
    public partial class UserDetail : Form
    {
        public delegate void SendMessage(string Message);
        public SendMessage SenderUserDetail;
        public UserDetail()
        {
            InitializeComponent();
            SenderUserDetail = new SendMessage(GetConnection);
        }
        public static bool viewStatus = true;
        public static bool roleStatus = false;
        public static bool systemRoleStatus = true;
        private static string connectionStringUser;
        public static string userName;
        private void GetConnection(string Message)
        {
            connectionStringUser = Message.Substring(0, Message.IndexOf(','));
            userName = Message.Substring(Message.IndexOf(',') + 1);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserDetail_Load(object sender, EventArgs e)
        {
            lbNameOfUser.Text = "Tên người dùng: " + " " + userName;
            using (OracleConnection conn = new OracleConnection(connectionStringUser))
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + userName + "'", conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    dtListPriv.DataSource = ds.Tables[0].DefaultView;
                }
            }
        }
        public void GridView_reFresh()
        {
            if (roleStatus == false)
            {
                if (viewStatus == true)
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + userName + "'", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        if (ds.Tables.Count > 0)
                        {
                            dtListPriv.DataSource = ds.Tables[0].DefaultView;
                        }
                    }
                }
                else
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("SELECT OWNER, PRIVILEGE, TABLE_NAME, GRANTOR, GRANTABLE, TYPE FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + userName + "'", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        if (ds.Tables.Count > 0)
                        {
                            dtListPriv.DataSource = ds.Tables[0].DefaultView;
                        }
                    }
                }
            }
            else
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + userName + "'", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dtListPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbSearchPriv.Text = "";
            GridView_reFresh();
        }

        private void btnSearchPriv_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + userName + "' AND PRIVILEGE LIKE '%" + tbSearchPriv.Text.ToUpper() + "%'", conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    dtListPriv.DataSource = ds.Tables[0].DefaultView;
                }
            }
        }

        private void btnDeletePriv_Click(object sender, EventArgs e)
        {
            if (roleStatus == false)
            {
                if (tbSearchPriv.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn quyền muốn xóa");
                    return;
                }
                try
                {
                    if (viewStatus == true)
                    {
                        using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                        {
                            OracleCommand cmd = new OracleCommand("REVOKE " + tbSearchPriv.Text + " FROM " + userName, conn);
                            conn.Open();
                            cmd.ExecuteReader();
                        }
                    }
                    else
                    {
                        using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                        {
                            OracleCommand cmd = new OracleCommand("REVOKE " + tbSearchPriv.Text + " FROM " + userName, conn);
                            conn.Open();
                            cmd.ExecuteReader();
                        }
                    }
                    MessageBox.Show("Đã xóa quyền " + tbSearchPriv.Text + " thành công");
                    tbSearchPriv.Text = "";
                    GridView_reFresh();
                }
                catch
                {
                    MessageBox.Show("Xóa quyền không thành công");
                }
            }
            else
            {
                if (tbSearchPriv.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn role muốn xóa");
                    return;
                }
                try
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("REVOKE " + tbSearchPriv.Text + " FROM " + userName, conn);
                        conn.Open();
                        cmd.ExecuteReader();
                    }
                    MessageBox.Show("Đã xóa role " + tbSearchPriv.Text + " thành công");
                    tbSearchPriv.Text = "";
                    GridView_reFresh();
                }
                catch
                {
                    MessageBox.Show("Xóa role không thành công");
                }
            }
        }
        public static string table = "";
        private void dtListPriv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtListPriv.Rows[e.RowIndex];
                if (roleStatus == false)
                {
                    if (viewStatus == false)
                    {
                        tbSearchPriv.Text = row.Cells[1].Value.ToString() + " ON " + row.Cells[2].Value.ToString();
                        table = row.Cells[2].Value.ToString();
                    }
                    else
                    {
                        tbSearchPriv.Text = row.Cells[1].Value.ToString();
                    }
                }
                else
                {
                    tbSearchPriv.Text = row.Cells[1].Value.ToString();
                }
            }
        }

        private void tbSearchPriv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (roleStatus == false)
            {
                if (viewStatus == true)
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + userName + "' AND PRIVILEGE LIKE '%" + tbSearchPriv.Text.ToUpper() + "%'", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        if (ds.Tables.Count > 0)
                        {
                            dtListPriv.DataSource = ds.Tables[0].DefaultView;
                        }
                    }
                }
                else
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("SELECT OWNER, PRIVILEGE, TABLE_NAME, GRANTOR, GRANTABLE, TYPE FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + userName + "' AND PRIVILEGE LIKE '%" + tbSearchPriv.Text.ToUpper() + "%'", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        if (ds.Tables.Count > 0)
                        {
                            dtListPriv.DataSource = ds.Tables[0].DefaultView;
                        }
                    }
                }
            }
            else
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + userName + "' AND GRANTED_ROLE LIKE '%" + tbSearchPriv.Text.ToUpper() + "%'", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dtListPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
        }
        public static AddPrivilege addPriv = null;
        public static AddRole addRole = null;
        private void btnAddPriv_Click(object sender, EventArgs e)
        {
            if (roleStatus == false)
            {
                addPriv = new AddPrivilege();
                addPriv.senderAddPriv("user");
                addPriv.TopLevel = true;
                addPriv.Show();
            }
            else
            {
                addRole = new AddRole();
                addRole.TopLevel = true;
                addRole.Show();
            }
        }

        private void btnViewObjectPriv_Click(object sender, EventArgs e)
        {
            cbGradeColumn.Checked = false;
            tbSearchPriv.Text = "";
            roleStatus = false;
            btnAddPriv.Text = "Thêm quyền";
            btnDeletePriv.Text = "Xóa quyền";
            if (viewStatus == true)
            {
                btnViewObjectPriv.Text = "Xem quyền hệ thống";
                lbTitle.Text = "Thông tin về các quyền đối tượng của người dùng";
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT OWNER, PRIVILEGE, TABLE_NAME, GRANTOR, GRANTABLE, TYPE FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + userName + "' AND PRIVILEGE LIKE '%" + tbSearchPriv.Text.ToUpper() + "%'", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dtListPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                }
                viewStatus = false;
            }
            else
            {
                btnViewObjectPriv.Text = "Xem quyền đối tượng";
                lbTitle.Text = "Thông tin về các quyền hệ thống của người dùng";
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + userName + "' AND PRIVILEGE LIKE '%" + tbSearchPriv.Text.ToUpper() + "%'", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dtListPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                }
                viewStatus = true;
            }
        }

        private void btnViewObjectRole_Click(object sender, EventArgs e)
        {
            cbGradeColumn.Checked = false;
            tbSearchPriv.Text = "";
            roleStatus = true;
            btnAddPriv.Text = "Thêm role";
            btnDeletePriv.Text = "Xóa role";
            lbTitle.Text = "Thông tin về các role của người dùng";
            using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + userName + "'", conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    dtListPriv.DataSource = ds.Tables[0].DefaultView;
                }
            }
        }

        private void cbGradeColumn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGradeColumn.Checked == true)
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT GRANTEE, PRIVILEGE, GRANTOR, COLUMN_NAME, TABLE_NAME FROM USER_COL_PRIVS_MADE WHERE GRANTEE = '" + userName + "'", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        dtListPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                }

            }
            else
            {
                GridView_reFresh();
            }
        }
    }
}
