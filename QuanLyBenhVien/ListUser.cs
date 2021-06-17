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
    public partial class ListUser : Form
    {
        public delegate void SendMessage(string Message);

        public SendMessage SenderListUser;

        public ListUser()
        {
            InitializeComponent();
            SenderListUser = new SendMessage(GetConnection);
        }

        private static string connectionStringUser;

        private void GetConnection(string Message)
        {
            connectionStringUser = Message;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void load_gridView()
        {
            using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM all_users", conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
            }
        }

        private void ListUser_Load(object sender, EventArgs e)
        {
            tbNameOfUser.Text = "";
            using(OracleConnection conn = new OracleConnection(Dashboard.connectionString))
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM all_users", conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbNameOfUser.Text.ToString() == "")
                {
                    MessageBox.Show("Vui lòng chọn user muốn xem");
                    return;
                }
                UserDetail uDetail = new UserDetail();
                uDetail.SenderUserDetail(connectionStringUser + "," + tbNameOfUser.Text.ToString());
                Dashboard.openChildForm(uDetail);
            }
            catch
            {
                MessageBox.Show("Không thể xem chi tiết user");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbNameOfUser.Text = row.Cells[0].Value.ToString();
                tbNameOfUser.ReadOnly = true;
            }
        }

        public static UserCreate newUser = null;

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (newUser != null)
            {
                return;
            }
            newUser = new UserCreate();
            newUser.senderCreateUser(connectionStringUser);
            newUser.TopMost = true;
            newUser.Show();
        }

        public static UserModify uModified = null;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNameOfUser.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn user muốn chỉnh sửa");
                    return;
                }
                if (uModified == null)
                {
                    string userModified = tbNameOfUser.Text.ToString();
                    uModified = new UserModify();
                    uModified.senderModifyUser(userModified);
                    uModified.TopMost = true;
                    uModified.Show();
                }
                
            }
            catch
            {
                MessageBox.Show("Không thể chỉnh sửa user này");
            }
        }
        // Delete user
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                using(OracleConnection conn = new OracleConnection(Dashboard.connectionString))
                {
                    OracleCommand cmd = new OracleCommand("DROP USER " + tbNameOfUser.Text, conn);
                    conn.Open();
                    cmd.ExecuteReader();
                }
                load_gridView();
                tbNameOfUser.Text = "";
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Không thể xóa user " + tbNameOfUser.Text);
            }
        }
        // refresh grid view
        private void button7_Click(object sender, EventArgs e)
        {
            load_gridView();
            tbSearchUser.Text = "";
        }
        // Search user
        private void tbSearchUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(Dashboard.connectionString))
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM ALL_USERS WHERE USERNAME like +'%" + tbSearchUser.Text.ToUpper() + "%'", conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }
    }
}
