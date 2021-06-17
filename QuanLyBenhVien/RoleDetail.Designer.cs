
namespace QuanLyBenhVien
{
    partial class RoleDetail
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
            this.dtPrivOfRole = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRoleName = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddPriv = new System.Windows.Forms.Button();
            this.btnDeletePriv = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbSearchPrivs = new System.Windows.Forms.TextBox();
            this.btnView_Object_System = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrivOfRole)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPrivOfRole
            // 
            this.dtPrivOfRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPrivOfRole.BackgroundColor = System.Drawing.Color.White;
            this.dtPrivOfRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPrivOfRole.Location = new System.Drawing.Point(12, 124);
            this.dtPrivOfRole.Name = "dtPrivOfRole";
            this.dtPrivOfRole.Size = new System.Drawing.Size(605, 420);
            this.dtPrivOfRole.TabIndex = 0;
            this.dtPrivOfRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin về quyền của role";
            // 
            // lbRoleName
            // 
            this.lbRoleName.AutoSize = true;
            this.lbRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoleName.ForeColor = System.Drawing.Color.Red;
            this.lbRoleName.Location = new System.Drawing.Point(12, 62);
            this.lbRoleName.Name = "lbRoleName";
            this.lbRoleName.Size = new System.Drawing.Size(70, 18);
            this.lbRoleName.TabIndex = 2;
            this.lbRoleName.Text = "Tên role: ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(12, 95);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Xem tất cả";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddPriv
            // 
            this.btnAddPriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnAddPriv.FlatAppearance.BorderSize = 0;
            this.btnAddPriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPriv.ForeColor = System.Drawing.Color.White;
            this.btnAddPriv.Location = new System.Drawing.Point(399, 59);
            this.btnAddPriv.Name = "btnAddPriv";
            this.btnAddPriv.Size = new System.Drawing.Size(106, 23);
            this.btnAddPriv.TabIndex = 5;
            this.btnAddPriv.Text = "Thêm quyền";
            this.btnAddPriv.UseVisualStyleBackColor = false;
            this.btnAddPriv.Click += new System.EventHandler(this.btnAddPriv_Click);
            // 
            // btnDeletePriv
            // 
            this.btnDeletePriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.btnDeletePriv.FlatAppearance.BorderSize = 0;
            this.btnDeletePriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePriv.ForeColor = System.Drawing.Color.White;
            this.btnDeletePriv.Location = new System.Drawing.Point(511, 60);
            this.btnDeletePriv.Name = "btnDeletePriv";
            this.btnDeletePriv.Size = new System.Drawing.Size(106, 23);
            this.btnDeletePriv.TabIndex = 6;
            this.btnDeletePriv.Text = "Xóa quyền";
            this.btnDeletePriv.UseVisualStyleBackColor = false;
            this.btnDeletePriv.Click += new System.EventHandler(this.btnDeletePriv_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(594, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbSearchPrivs
            // 
            this.tbSearchPrivs.Location = new System.Drawing.Point(118, 95);
            this.tbSearchPrivs.Multiline = true;
            this.tbSearchPrivs.Name = "tbSearchPrivs";
            this.tbSearchPrivs.Size = new System.Drawing.Size(275, 23);
            this.tbSearchPrivs.TabIndex = 8;
            // 
            // btnView_Object_System
            // 
            this.btnView_Object_System.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnView_Object_System.FlatAppearance.BorderSize = 0;
            this.btnView_Object_System.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView_Object_System.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView_Object_System.ForeColor = System.Drawing.Color.White;
            this.btnView_Object_System.Location = new System.Drawing.Point(399, 95);
            this.btnView_Object_System.Name = "btnView_Object_System";
            this.btnView_Object_System.Size = new System.Drawing.Size(218, 23);
            this.btnView_Object_System.TabIndex = 9;
            this.btnView_Object_System.Text = "Xem quyền đối tượng";
            this.btnView_Object_System.UseVisualStyleBackColor = false;
            this.btnView_Object_System.Click += new System.EventHandler(this.btnView_Object_System_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(310, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Mức cột";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RoleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(629, 556);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnView_Object_System);
            this.Controls.Add(this.tbSearchPrivs);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDeletePriv);
            this.Controls.Add(this.btnAddPriv);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbRoleName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPrivOfRole);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(629, 556);
            this.Name = "RoleDetail";
            this.Text = "RoleDetail";
            this.Load += new System.EventHandler(this.RoleDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPrivOfRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtPrivOfRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRoleName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddPriv;
        private System.Windows.Forms.Button btnDeletePriv;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbSearchPrivs;
        private System.Windows.Forms.Button btnView_Object_System;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}