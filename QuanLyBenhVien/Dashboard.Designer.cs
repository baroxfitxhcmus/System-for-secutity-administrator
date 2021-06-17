
namespace QuanLyBenhVien
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQL_TB_View = new System.Windows.Forms.Button();
            this.btnQL_Role = new System.Windows.Forms.Button();
            this.btnQL_User = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            pnlChild = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            pnlChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(177)))), ((int)(((byte)(173)))));
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Location = new System.Drawing.Point(606, 13);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(88, 23);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(699, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.btnQL_TB_View);
            this.panel2.Controls.Add(this.btnQL_Role);
            this.panel2.Controls.Add(this.btnQL_User);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 555);
            this.panel2.TabIndex = 1;
            // 
            // btnQL_TB_View
            // 
            this.btnQL_TB_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnQL_TB_View.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQL_TB_View.FlatAppearance.BorderSize = 0;
            this.btnQL_TB_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQL_TB_View.Location = new System.Drawing.Point(0, 286);
            this.btnQL_TB_View.Name = "btnQL_TB_View";
            this.btnQL_TB_View.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQL_TB_View.Size = new System.Drawing.Size(171, 40);
            this.btnQL_TB_View.TabIndex = 4;
            this.btnQL_TB_View.Text = "Quản lý table/view";
            this.btnQL_TB_View.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQL_TB_View.UseVisualStyleBackColor = false;
            this.btnQL_TB_View.Click += new System.EventHandler(this.btnQL_TB_View_Click);
            // 
            // btnQL_Role
            // 
            this.btnQL_Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnQL_Role.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQL_Role.FlatAppearance.BorderSize = 0;
            this.btnQL_Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQL_Role.Location = new System.Drawing.Point(0, 246);
            this.btnQL_Role.Name = "btnQL_Role";
            this.btnQL_Role.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQL_Role.Size = new System.Drawing.Size(171, 40);
            this.btnQL_Role.TabIndex = 3;
            this.btnQL_Role.Text = "Quản lý role";
            this.btnQL_Role.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQL_Role.UseVisualStyleBackColor = false;
            this.btnQL_Role.Click += new System.EventHandler(this.btnQL_Role_Click);
            // 
            // btnQL_User
            // 
            this.btnQL_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnQL_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQL_User.FlatAppearance.BorderSize = 0;
            this.btnQL_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQL_User.Location = new System.Drawing.Point(0, 206);
            this.btnQL_User.Name = "btnQL_User";
            this.btnQL_User.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQL_User.Size = new System.Drawing.Size(171, 40);
            this.btnQL_User.TabIndex = 2;
            this.btnQL_User.Text = "Quản lý user";
            this.btnQL_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQL_User.UseVisualStyleBackColor = false;
            this.btnQL_User.Click += new System.EventHandler(this.btnQL_User_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXemThongTin);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 206);
            this.panel3.TabIndex = 0;
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(177)))), ((int)(((byte)(173)))));
            this.btnXemThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemThongTin.FlatAppearance.BorderSize = 0;
            this.btnXemThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemThongTin.Location = new System.Drawing.Point(0, 121);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(171, 40);
            this.btnXemThongTin.TabIndex = 1;
            this.btnXemThongTin.Text = "Xem thông tin";
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::QuanLyBenhVien.Properties.Resources.user_100px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.label1.Location = new System.Drawing.Point(109, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hệ thống dành cho người quản trị bảo mật";
            // 
            // pnlChild
            // 
            pnlChild.Controls.Add(this.label1);
            pnlChild.Controls.Add(this.pictureBox2);
            pnlChild.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlChild.Location = new System.Drawing.Point(171, 44);
            pnlChild.Name = "pnlChild";
            pnlChild.Size = new System.Drawing.Size(629, 555);
            pnlChild.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyBenhVien.Properties.Resources.b644232f670a5f54bbfb992f81589ff9;
            this.pictureBox2.Location = new System.Drawing.Point(72, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(503, 344);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(pnlChild);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            pnlChild.ResumeLayout(false);
            pnlChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThoat;
        public  System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQL_Role;
        private System.Windows.Forms.Button btnQL_User;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnQL_TB_View;
        public static System.Windows.Forms.Panel pnlChild;
    }
}