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
    public partial class ListRole : Form
    {
        public delegate void SendMessage(string Message);

        public SendMessage SenderListRole;

        public ListRole()
        {
            InitializeComponent();
            SenderListRole = new SendMessage(GetConnection);
        }

        private static string connectionStringRole;

        private void GetConnection(string Message)
        {
            connectionStringRole = Message;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListRole_Load(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM dba_roles", conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    dtListRole.DataSource = ds.Tables[0].DefaultView;
                }
            }
        }
        // View detail about privs of role
        private void btnViewDetailRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNameOfRole.Text.ToString() == "")
                {
                    MessageBox.Show("Vui lòng chọn role muốn xem");
                    return;
                }
                RoleDetail rDetail = new RoleDetail();
                rDetail.SenderRoleDetail(connectionStringRole + "," + tbNameOfRole.Text.ToString());
                Dashboard.openChildForm(rDetail);
            }
            catch
            {
                MessageBox.Show("Không thể xem chi tiết role");
            }
        }
        // Table cellclick to get role name
        private void dtListRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtListRole.Rows[e.RowIndex];
                tbNameOfRole.Text = row.Cells[0].Value.ToString();
                tbNameOfRole.Enabled = false;
            }
        }
        // Keypress to search Role
        private void tbSearchRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            using(OracleConnection conn = new OracleConnection(Dashboard.connectionString))
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM DBA_ROLES WHERE ROLE LIKE '%" + tbSearchRole.Text.ToUpper() + "%'", conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dtListRole.DataSource = ds.Tables[0].DefaultView;
            }
        }
        // Refresh table
        private void btnReFresh_Click(object sender, EventArgs e)
        {
            tbSearchRole.Text = "";
            ListRole_Load(sender, e);
        }
        // Delete role
        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            try
            {
                using(OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("DROP ROLE " + tbNameOfRole.Text, conn);
                    conn.Open();
                    cmd.ExecuteReader();
                    conn.Close();                       
                }
                MessageBox.Show("Xóa role " + tbNameOfRole.Text + " thành công");
                tbNameOfRole.Text = "";
                ListRole_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa role không thành công");
            }
        }
        public static RoleCreate rCreate = null;
        private void btnCreateNewRole_Click(object sender, EventArgs e)
        {
            if(rCreate == null)
            {
                rCreate = new RoleCreate();
                rCreate.Show();
            }
            else
            {
                rCreate.Show();
            }
            
        }
    }
}
