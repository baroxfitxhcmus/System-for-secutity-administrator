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
    public partial class AddRole : Form
    {
        public AddRole()
        {
            InitializeComponent();
        }

        private void dtListRoleWithoutOfUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtListRoleWithoutOfUser.Rows[e.RowIndex];
                tbSearchRole.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            if(tbSearchRole.Text == "")
            {
                MessageBox.Show("Vui lòng chọn role muốn cấp cho user");
                return;
            }
            string withGrantOption = "";
            if(cbWithGrantOption.Checked == true)
            {
                withGrantOption = " WITH ADMIN OPTION ";
            }
            try
            {
                using(OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("GRANT " + tbSearchRole.Text.ToUpper() + " TO " + UserDetail.userName + withGrantOption, conn);
                    conn.Open();
                    cmd.ExecuteReader();

                }
                MessageBox.Show("Cấp role " + tbSearchRole.Text + " thành công");
                tbSearchRole.Text = "";
                AddRole_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cấp role không thành công");
            }
        }

        private void tbSearchRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT DISTINCT ROLE, ROLE_ID FROM DBA_ROLES WHERE ROLE LIKE '%"+ tbSearchRole.Text.ToUpper() +"%' AND ROLE NOT IN (SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + UserDetail.userName + "')", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    dtListRoleWithoutOfUser.DataSource = ds.Tables[0].DefaultView;
                }
            }
            catch
            {           
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            UserDetail.addRole = null;
            this.Close();
        }

        private void AddRole_Load(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT DISTINCT ROLE, ROLE_ID FROM DBA_ROLES WHERE ROLE NOT IN (SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + UserDetail.userName + "')", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    dtListRoleWithoutOfUser.DataSource = ds.Tables[0].DefaultView;
                }
            }
            catch
            {
                MessageBox.Show("Không tải được trang");
                this.Close();
            }
        }
    }
}
