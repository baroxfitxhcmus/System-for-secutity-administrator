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
    public partial class OthersObject : Form
    {
        public static bool table = true;

        public OthersObject()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OthersObject_Load(object sender, EventArgs e)
        {
            try
            {
                using(OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM ALL_TABLES", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    dtTable_View.DataSource = ds.Tables[0].DefaultView;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi load trang, vui lòng thử lại");
                this.Close();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            table = false;
            lbTitle.Text = "Danh sách các view trong hệ thống";
            try
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT OWNER, VIEW_NAME, TEXT_LENGTH, READ_ONLY, CONTAINER_DATA, BEQUEATH, ORIGIN_CON_ID, DEFAULT_COLLATION, CONTAINERS_DEFAULT, CONTAINER_MAP, EXTENDED_DATA_LINK, EXTENDED_DATA_LINK_MAP, HAS_SENSITIVE_COLUMN FROM ALL_VIEWS", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    dtTable_View.DataSource = ds.Tables[0].DefaultView;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi load trang, vui lòng thử lại");
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "Danh sách các bảng trong hệ thống";
            table = true;
            try
            {
                using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM ALL_TABLES", conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    oda.Fill(ds);
                    dtTable_View.DataSource = ds.Tables[0].DefaultView;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi load trang, vui lòng thử lại");
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(table == true)
            {
                try
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("SELECT * FROM ALL_TABLES WHERE TABLE_NAME LIKE '%" + tbSearch.Text.ToUpper() + "%'"  , conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        dtTable_View.DataSource = ds.Tables[0].DefaultView;
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi khi load trang, vui lòng thử lại");
                }
            }
            else
            {
                try
                {
                    using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                    {
                        OracleCommand cmd = new OracleCommand("SELECT OWNER, VIEW_NAME, TEXT_LENGTH, READ_ONLY, CONTAINER_DATA, BEQUEATH, ORIGIN_CON_ID, DEFAULT_COLLATION, CONTAINERS_DEFAULT, CONTAINER_MAP, EXTENDED_DATA_LINK, EXTENDED_DATA_LINK_MAP, HAS_SENSITIVE_COLUMN FROM ALL_VIEWS WHERE VIEW_NAME LIKE '%" + tbSearch.Text.ToUpper() + "%'", conn);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        oda.Fill(ds);
                        dtTable_View.DataSource = ds.Tables[0].DefaultView;
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi khi load trang, vui lòng thử lại");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            if(table == true)
            {
                btnTable_Click(sender, e);
            }
            else
            {
                btnView_Click(sender, e);
            }
        }

        private void tbCreate_Click(object sender, EventArgs e)
        {
            tbCreate.Text = "";
            tbCreate.ForeColor = Color.Black;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using(OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(tbCreate.Text, conn);
                    cmd.ExecuteReader();
                    conn.Close();
                }
                MessageBox.Show("Tạo bảng/view thành công");
                tbCreate.Text = "Script to create new table/view ...";
                tbCreate.ForeColor = Color.Silver;
            }
            catch
            {
                MessageBox.Show("Tạo bảng/view không thành công");
            }
        }
    }
}
