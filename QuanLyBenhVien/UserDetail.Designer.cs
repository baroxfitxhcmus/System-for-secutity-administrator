
namespace QuanLyBenhVien
{
    partial class UserDetail
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
            this.dtListPriv = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbNameOfUser = new System.Windows.Forms.Label();
            this.btnViewObjectRole = new System.Windows.Forms.Button();
            this.btnAddPriv = new System.Windows.Forms.Button();
            this.btnDeletePriv = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tbSearchPriv = new System.Windows.Forms.TextBox();
            this.btnViewObjectPriv = new System.Windows.Forms.Button();
            this.cbGradeColumn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtListPriv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListPriv
            // 
            this.dtListPriv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtListPriv.BackgroundColor = System.Drawing.Color.White;
            this.dtListPriv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListPriv.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtListPriv.Location = new System.Drawing.Point(12, 124);
            this.dtListPriv.Name = "dtListPriv";
            this.dtListPriv.Size = new System.Drawing.Size(605, 420);
            this.dtListPriv.TabIndex = 0;
            this.dtListPriv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListPriv_CellClick);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(156, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(351, 20);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Thông tin về các quyền hệ thống của người dùng";
            // 
            // lbNameOfUser
            // 
            this.lbNameOfUser.AutoSize = true;
            this.lbNameOfUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameOfUser.ForeColor = System.Drawing.Color.Yellow;
            this.lbNameOfUser.Location = new System.Drawing.Point(12, 63);
            this.lbNameOfUser.Name = "lbNameOfUser";
            this.lbNameOfUser.Size = new System.Drawing.Size(113, 18);
            this.lbNameOfUser.TabIndex = 2;
            this.lbNameOfUser.Text = "Tên người dùng:";
            // 
            // btnViewObjectRole
            // 
            this.btnViewObjectRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnViewObjectRole.FlatAppearance.BorderSize = 0;
            this.btnViewObjectRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewObjectRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewObjectRole.ForeColor = System.Drawing.Color.White;
            this.btnViewObjectRole.Location = new System.Drawing.Point(372, 60);
            this.btnViewObjectRole.Name = "btnViewObjectRole";
            this.btnViewObjectRole.Size = new System.Drawing.Size(133, 23);
            this.btnViewObjectRole.TabIndex = 3;
            this.btnViewObjectRole.Text = "Xem role của user";
            this.btnViewObjectRole.UseVisualStyleBackColor = false;
            this.btnViewObjectRole.Click += new System.EventHandler(this.btnViewObjectRole_Click);
            // 
            // btnAddPriv
            // 
            this.btnAddPriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnAddPriv.FlatAppearance.BorderSize = 0;
            this.btnAddPriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPriv.ForeColor = System.Drawing.Color.White;
            this.btnAddPriv.Location = new System.Drawing.Point(511, 60);
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
            this.btnDeletePriv.Location = new System.Drawing.Point(511, 95);
            this.btnDeletePriv.Name = "btnDeletePriv";
            this.btnDeletePriv.Size = new System.Drawing.Size(106, 23);
            this.btnDeletePriv.TabIndex = 6;
            this.btnDeletePriv.Text = "Xóa quyền";
            this.btnDeletePriv.UseVisualStyleBackColor = false;
            this.btnDeletePriv.Click += new System.EventHandler(this.btnDeletePriv_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(15, 95);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Xem tất cả";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(594, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tbSearchPriv
            // 
            this.tbSearchPriv.Location = new System.Drawing.Point(124, 95);
            this.tbSearchPriv.Multiline = true;
            this.tbSearchPriv.Name = "tbSearchPriv";
            this.tbSearchPriv.Size = new System.Drawing.Size(242, 23);
            this.tbSearchPriv.TabIndex = 9;
            this.tbSearchPriv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchPriv_KeyPress);
            // 
            // btnViewObjectPriv
            // 
            this.btnViewObjectPriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnViewObjectPriv.FlatAppearance.BorderSize = 0;
            this.btnViewObjectPriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewObjectPriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewObjectPriv.ForeColor = System.Drawing.Color.White;
            this.btnViewObjectPriv.Location = new System.Drawing.Point(372, 95);
            this.btnViewObjectPriv.Name = "btnViewObjectPriv";
            this.btnViewObjectPriv.Size = new System.Drawing.Size(133, 23);
            this.btnViewObjectPriv.TabIndex = 10;
            this.btnViewObjectPriv.Text = "Xem quyền đối tượng";
            this.btnViewObjectPriv.UseVisualStyleBackColor = false;
            this.btnViewObjectPriv.Click += new System.EventHandler(this.btnViewObjectPriv_Click);
            // 
            // cbGradeColumn
            // 
            this.cbGradeColumn.AutoSize = true;
            this.cbGradeColumn.ForeColor = System.Drawing.Color.White;
            this.cbGradeColumn.Location = new System.Drawing.Point(299, 65);
            this.cbGradeColumn.Name = "cbGradeColumn";
            this.cbGradeColumn.Size = new System.Drawing.Size(67, 17);
            this.cbGradeColumn.TabIndex = 13;
            this.cbGradeColumn.Text = "Mức cột";
            this.cbGradeColumn.UseVisualStyleBackColor = true;
            this.cbGradeColumn.CheckedChanged += new System.EventHandler(this.cbGradeColumn_CheckedChanged);
            // 
            // UserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(629, 556);
            this.Controls.Add(this.cbGradeColumn);
            this.Controls.Add(this.btnViewObjectPriv);
            this.Controls.Add(this.tbSearchPriv);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeletePriv);
            this.Controls.Add(this.btnAddPriv);
            this.Controls.Add(this.btnViewObjectRole);
            this.Controls.Add(this.lbNameOfUser);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dtListPriv);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(629, 556);
            this.Name = "UserDetail";
            this.Text = "UserDetail";
            this.Load += new System.EventHandler(this.UserDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtListPriv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbNameOfUser;
        private System.Windows.Forms.Button btnViewObjectRole;
        private System.Windows.Forms.Button btnAddPriv;
        private System.Windows.Forms.Button btnDeletePriv;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tbSearchPriv;
        public System.Windows.Forms.DataGridView dtListPriv;
        private System.Windows.Forms.Button btnViewObjectPriv;
        private System.Windows.Forms.CheckBox cbGradeColumn;
    }
}