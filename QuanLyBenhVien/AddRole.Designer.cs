
namespace QuanLyBenhVien
{
    partial class AddRole
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtListRoleWithoutOfUser = new System.Windows.Forms.DataGridView();
            this.tbSearchRole = new System.Windows.Forms.TextBox();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.cbWithGrantOption = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtListRoleWithoutOfUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cấp role mới cho người dùng từ hệ thống";
            // 
            // dtListRoleWithoutOfUser
            // 
            this.dtListRoleWithoutOfUser.BackgroundColor = System.Drawing.Color.White;
            this.dtListRoleWithoutOfUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListRoleWithoutOfUser.Location = new System.Drawing.Point(12, 82);
            this.dtListRoleWithoutOfUser.Name = "dtListRoleWithoutOfUser";
            this.dtListRoleWithoutOfUser.Size = new System.Drawing.Size(370, 356);
            this.dtListRoleWithoutOfUser.TabIndex = 1;
            this.dtListRoleWithoutOfUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListRoleWithoutOfUser_CellClick);
            // 
            // tbSearchRole
            // 
            this.tbSearchRole.Location = new System.Drawing.Point(12, 55);
            this.tbSearchRole.Name = "tbSearchRole";
            this.tbSearchRole.Size = new System.Drawing.Size(161, 20);
            this.tbSearchRole.TabIndex = 2;
            this.tbSearchRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchRole_KeyPress);
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(185)))), ((int)(((byte)(12)))));
            this.btnAddRole.FlatAppearance.BorderSize = 0;
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.Location = new System.Drawing.Point(307, 53);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(75, 23);
            this.btnAddRole.TabIndex = 3;
            this.btnAddRole.Text = "Thêm ";
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // cbWithGrantOption
            // 
            this.cbWithGrantOption.AutoSize = true;
            this.cbWithGrantOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWithGrantOption.ForeColor = System.Drawing.Color.White;
            this.cbWithGrantOption.Location = new System.Drawing.Point(179, 57);
            this.cbWithGrantOption.Name = "cbWithGrantOption";
            this.cbWithGrantOption.Size = new System.Drawing.Size(122, 19);
            this.cbWithGrantOption.TabIndex = 4;
            this.cbWithGrantOption.Text = "With Grant Option";
            this.cbWithGrantOption.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(359, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbWithGrantOption);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.tbSearchRole);
            this.Controls.Add(this.dtListRoleWithoutOfUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRole";
            this.Load += new System.EventHandler(this.AddRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtListRoleWithoutOfUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtListRoleWithoutOfUser;
        private System.Windows.Forms.TextBox tbSearchRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.CheckBox cbWithGrantOption;
        private System.Windows.Forms.Button btnExit;
    }
}