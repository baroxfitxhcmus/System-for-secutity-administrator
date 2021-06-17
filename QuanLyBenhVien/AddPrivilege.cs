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
    public partial class AddPrivilege : Form
    {
        public delegate void SendMessage(string Message);
        public SendMessage senderAddPriv;
        public static string Mode;

        public AddPrivilege()
        {
            InitializeComponent();
            senderAddPriv = new SendMessage(getMessage);
        }
        public void getMessage(string Message)
        {
            Mode = Message;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserDetail.addPriv = null;
            RoleDetail.aPrivRole = null;
            this.Close();
        }

        private void AddPrivilege_Load(object sender, EventArgs e)
        {
            if (Mode == "user")
            {
                if (UserDetail.viewStatus == true)
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("SELECT distinct PRIVILEGE, ADMIN_OPTION, COMMON, INHERITED FROM DBA_SYS_PRIVS WHERE GRANTEE != '" + UserDetail.userName + "' AND PRIVILEGE NOT IN (SELECT DISTINCT DA.PRIVILEGE FROM DBA_SYS_PRIVS  DA  WHERE DA.GRANTEE = '" + UserDetail.userName + "')", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        dtAddPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                    btnNewPriv.Visible = false;
                    cbbThaoTac.Visible = false;
                    cbbBang.Visible = false;
                    cbbCot.Visible = false;
                    label1.Visible = false;
                    label3.Visible = false;                 
                    rbtnView.Visible = false;
                    rtbnTable.Visible = false;
                }
                else
                {
                    lbUserDetail_Title.Text = "Thêm quyền đối tượng từ danh sách hoặc tạo mới";
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("select distinct owner, privilege, table_name, grantor, type, inherited from dba_tab_privs where rownum <= 150 and grantee != '" + UserDetail.userName + "' and concat(privilege,table_name) not in (SELECT concat(d.privilege,d.table_name) From dba_tab_privs d where d.grantee = '" + UserDetail.userName + "')", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        dtAddPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                }
                tbSearchPriv.Text = "";
            }
            else
            {
                if (RoleDetail.statusView == true)
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("SELECT distinct PRIVILEGE, ADMIN_OPTION, COMMON, INHERITED FROM DBA_SYS_PRIVS WHERE GRANTEE != '" + RoleDetail.roleName + "' AND PRIVILEGE NOT IN (SELECT DISTINCT DA.PRIVILEGE FROM DBA_SYS_PRIVS  DA  WHERE DA.GRANTEE = '" + UserDetail.userName + "')", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        dtAddPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                    btnNewPriv.Visible = false;
                    cbbThaoTac.Visible = false;
                    cbbBang.Visible = false;
                    cbbCot.Visible = false;
                    label1.Visible = false;
                    label3.Visible = false;
                    rbtnView.Visible = false;
                    rbtnView.Visible = false;

                }
                else
                {
                    lbUserDetail_Title.Text = "Thêm quyền đối tượng từ danh sách hoặc tạo mới";
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("select distinct owner, privilege, table_name, grantor, type, inherited from dba_tab_privs where rownum <= 150 and grantee != '" + RoleDetail.roleName + "' and concat(privilege,table_name) not in (SELECT concat(d.privilege,d.table_name) From dba_tab_privs d where d.grantee = '" + UserDetail.userName + "')", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        dtAddPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                }
                tbSearchPriv.Text = "";
            }
        }

        private void tbSearchPriv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Mode == "user")
            {
                if (UserDetail.viewStatus == true)
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("SELECT distinct PRIVILEGE, ADMIN_OPTION, COMMON, INHERITED FROM DBA_SYS_PRIVS WHERE GRANTEE != '" + UserDetail.userName + "' AND PRIVILEGE LIKE '%" + tbSearchPriv.Text.ToUpper() + "%' AND PRIVILEGE NOT IN (SELECT DISTINCT DA.PRIVILEGE FROM DBA_SYS_PRIVS  DA  WHERE DA.GRANTEE = '" + UserDetail.userName + "')", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        dtAddPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                }
                else if (UserDetail.viewStatus == false & (tbSearchPriv.Text.Length % 4 == 0 || tbSearchPriv.Text.Length > 10))
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        string priv = "";
                        string table = "";
                        if (tbSearchPriv.Text.IndexOf(" ") > 0)
                        {
                            priv = tbSearchPriv.Text.Substring(0, tbSearchPriv.Text.IndexOf(" ")).ToUpper();
                            table = tbSearchPriv.Text.Substring(tbSearchPriv.Text.IndexOf(" ") + 1).ToUpper();
                        }
                        else
                        {
                            priv = tbSearchPriv.Text.ToUpper();
                        }

                        OracleCommand cmd = new OracleCommand("select distinct owner, privilege, table_name, grantor, type, inherited from dba_tab_privs where rownum <= 150 and grantee != '" + UserDetail.userName + "' and PRIVILEGE LIKE '%" + priv + "%' and TABLE_NAME LIKE '%" + table + "%'and concat(privilege,table_name) not in (SELECT concat(d.privilege,d.table_name) From dba_tab_privs d where d.grantee = '" + UserDetail.userName + "')", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        dtAddPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
            else
            {
                if (RoleDetail.statusView == true)
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("SELECT distinct PRIVILEGE, ADMIN_OPTION, COMMON, INHERITED FROM DBA_SYS_PRIVS WHERE GRANTEE != '" + RoleDetail.roleName + "' AND PRIVILEGE LIKE '%" + tbSearchPriv.Text.ToUpper() + "%' AND PRIVILEGE NOT IN (SELECT DISTINCT DA.PRIVILEGE FROM DBA_SYS_PRIVS  DA  WHERE DA.GRANTEE = '" + RoleDetail.roleName + "')", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        dtAddPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                }
                else if (UserDetail.viewStatus == false & (tbSearchPriv.Text.Length % 4 == 0 || tbSearchPriv.Text.Length > 10))
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        string priv = "";
                        string table = "";
                        if (tbSearchPriv.Text.IndexOf(" ") > 0)
                        {
                            priv = tbSearchPriv.Text.Substring(0, tbSearchPriv.Text.IndexOf(" ")).ToUpper();
                            table = tbSearchPriv.Text.Substring(tbSearchPriv.Text.IndexOf(" ") + 1).ToUpper();
                        }
                        else
                        {
                            priv = tbSearchPriv.Text.ToUpper();
                        }

                        OracleCommand cmd = new OracleCommand("select distinct owner, privilege, table_name, grantor, type, inherited from dba_tab_privs where rownum <= 150 and grantee != '" + RoleDetail.roleName + "' and PRIVILEGE LIKE '%" + priv + "%' and TABLE_NAME LIKE '%" + table + "%'and concat(privilege,table_name) not in (SELECT concat(d.privilege,d.table_name) From dba_tab_privs d where d.grantee = '" + RoleDetail.roleName + "')", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        dtAddPriv.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
        }

        private string tableAddPriv = "";

        private void dtAddPriv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtAddPriv.Rows[e.RowIndex];
                if(UserDetail.viewStatus == true)
                {
                    tbSearchPriv.Text = row.Cells[0].Value.ToString();
                }
                else
                {
                    tbSearchPriv.Text = row.Cells[1].Value.ToString() + " ON " + tableAddPriv;
                    tableAddPriv = row.Cells[2].Value.ToString();
                }
                
            }
        }

        private void btnAddPriv_Click(object sender, EventArgs e)
        {
            if (tbSearchPriv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn quyền muốn thêm vào");
                return;
            }
            string withGrantOption = "";
            if (cbWithGrantOption.Checked == true)
            {
                withGrantOption = " WITH ADMIN OPTION ";

            }
            if (Mode == "user")
            {                
                try
                {
                    if (UserDetail.viewStatus == true)
                    {
                        using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                        {
                            OracleCommand cmd = new OracleCommand("GRANT " + tbSearchPriv.Text + " TO " + UserDetail.userName + withGrantOption, conn);
                            conn.Open();
                            cmd.ExecuteReader();
                        }
                    }
                    else
                    {
                        using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                        {
                            OracleCommand cmd = new OracleCommand("GRANT " + tbSearchPriv.Text + " TO " + UserDetail.userName + withGrantOption, conn);
                            conn.Open();
                            cmd.ExecuteReader();
                        }
                    }

                    MessageBox.Show("Thêm quyền thành công");
                    AddPrivilege_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Thêm quyền không thành công");
                }
            }
            else
            {
                try
                {
                    if (UserDetail.viewStatus == true)
                    {
                        using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                        {
                            OracleCommand cmd = new OracleCommand("GRANT " + tbSearchPriv.Text + " TO " + RoleDetail.roleName + withGrantOption, conn);
                            conn.Open();
                            cmd.ExecuteReader();
                        }
                    }
                    else
                    {
                        using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                        {
                            OracleCommand cmd = new OracleCommand("GRANT " + tbSearchPriv.Text + " TO " + RoleDetail.roleName + withGrantOption, conn);
                            conn.Open();
                            cmd.ExecuteReader();
                        }
                    }

                    MessageBox.Show("Thêm quyền thành công");
                    AddPrivilege_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Thêm quyền không thành công");
                }
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            AddPrivilege_Load(sender, e);
        }

        private void btnNewPriv_Click(object sender, EventArgs e)
        {
            if (cbbThaoTac.Text == "" || cbbBang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
                return;
            }
            if (Mode == "user")
            {
                
                try
                {
                    if (cbbCot.Enabled == true)
                    {
                        using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                        {
                            conn.Open();
                            OracleCommand cmd = new OracleCommand("GRANT " + cbbThaoTac.Text + " (" + cbbCot.Text + ") ON " + cbbBang.Text + " TO " + UserDetail.userName, conn);
                            cmd.ExecuteReader();
                        }
                    }
                    else
                    {
                        using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                        {
                            conn.Open();
                            OracleCommand cmd = new OracleCommand("GRANT " + cbbThaoTac.Text + " ON " + cbbBang.Text + " TO " + UserDetail.userName, conn);
                            cmd.ExecuteReader();
                        }
                    }
                    MessageBox.Show("Thêm quyền thành công");
                    cbbBang.Text = "";
                    cbbThaoTac.Text = "";
                    cbbCot.Text = "";
                }
                catch
                {
                    MessageBox.Show("Thêm quyền không thành công");
                }
            }
            else
            {
                try
                {
                    if (cbbCot.Enabled == true)
                    {
                        using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                        {
                            conn.Open();
                            OracleCommand cmd = new OracleCommand("GRANT " + cbbThaoTac.Text + " (" + cbbCot.Text + ") ON " + cbbBang.Text + " TO " + RoleDetail.roleName, conn);
                            cmd.ExecuteReader();
                        }
                    }
                    else
                    {
                        using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                        {
                            conn.Open();
                            OracleCommand cmd = new OracleCommand("GRANT " + cbbThaoTac.Text + " ON " + cbbBang.Text + " TO " + RoleDetail.roleName, conn);
                            cmd.ExecuteReader();
                        }
                    }
                    MessageBox.Show("Thêm quyền thành công");
                    cbbBang.Text = "";
                    cbbThaoTac.Text = "";
                    cbbCot.Text = "";
                }
                catch
                {
                    MessageBox.Show("Thêm quyền không thành công");
                }
            }
        }

        private void rtbnTable_CheckedChanged(object sender, EventArgs e)
        {
            if(rtbnTable.Checked == false)
            {
                return;
            }
            try
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("SELECT TABLE_NAME FROM ALL_TABLES", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    cbbBang.DataSource = ds.Tables[0];
                    cbbBang.DisplayMember = "TABLE_NAME";
                }
            }
            catch
            {
                MessageBox.Show("Load danh sách bảng không thành công");
            }
        }

        private void rbtnView_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnView.Checked == false)
            {
                return;
            }
            try
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("SELECT VIEW_NAME FROM ALL_VIEWS", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    cbbBang.DataSource = ds.Tables[0];
                    cbbBang.DisplayMember = "VIEW_NAME";
                }
            }
            catch
            {
                MessageBox.Show("Load danh sách view không thành công");
            }
        }

        private void cbbThaoTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbThaoTac.Text == "SELECT" || cbbThaoTac.Text == "DELETE")
            {
                cbbCot.Text = "";
                cbbCot.Enabled = false;
            }
            else
            {
                cbbCot.Enabled = true;
            }
        }

        private void cbbBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbThaoTac.Text == "SELECT" || cbbThaoTac.Text == "DELETE")
            {
                return;
            }
            try
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand("SELECT COLUMN_NAME FROM ALL_TAB_COLS WHERE TABLE_NAME = '" + cbbBang.Text.ToUpper() + "'", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    cbbCot.DataSource = ds.Tables[0];
                    cbbCot.DisplayMember = "COLUMN_NAME";
                }
            }
            catch
            {

            }
        }
    }
}
