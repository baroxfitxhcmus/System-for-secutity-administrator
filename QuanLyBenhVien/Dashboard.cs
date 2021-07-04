using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class Dashboard : Form
    {

        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        public Dashboard()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        private static string username;
        private static string password;
        public static string connectionString;

        private void GetMessage(string Message)
        {
            username = Message.Substring(0, Message.IndexOf(','));
            password = Message.Substring(Message.IndexOf(',')+1);

            connectionString = Config.connectionString(username, password);
            if(username.ToLower() == "sys")
            {
                connectionString += "DBA PRIVILEGE = SYSDBA;";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            username = "";
            password = "";
            connectionString = "";
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void resetColorMenuButton()
        {
            btnQL_User.BackColor = Color.FromArgb(83, 166, 135);
            btnQL_Role.BackColor = Color.FromArgb(83, 166, 135);
            btnQL_TB_View.BackColor = Color.FromArgb(83, 166, 135);
        }

        static Form activeForm = null;
        public  static void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChild.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQL_User_Click(object sender, EventArgs e)
        {
            
            resetColorMenuButton();
            btnQL_User.BackColor = Color.FromArgb(173, 217, 201);
            ListUser listUser = new ListUser();            
            listUser.SenderListUser(connectionString);
            openChildForm(listUser);
        }

        private void btnQL_Role_Click(object sender, EventArgs e)
        {
            resetColorMenuButton();
            btnQL_Role.BackColor = Color.FromArgb(173, 217, 201);
            ListRole listRole = new ListRole();
            listRole.SenderListRole(connectionString);
            openChildForm(listRole);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
            btnXemThongTin.Text = username.ToUpper();
        }

        private void btnQL_TB_View_Click(object sender, EventArgs e)
        {
            resetColorMenuButton();
            btnQL_TB_View.BackColor = Color.FromArgb(173, 217, 201);
            OthersObject ot = new OthersObject();
            openChildForm(ot);
        }
    }
}
