
namespace QuanLyBenhVien
{
    partial class ListRole
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
            this.dtListRole = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateNewRole = new System.Windows.Forms.Button();
            this.btnViewDetailRole = new System.Windows.Forms.Button();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnReFresh = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tbSearchRole = new System.Windows.Forms.TextBox();
            this.tbNameOfRole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtListRole)).BeginInit();
            this.SuspendLayout();
            // 
            // dtListRole
            // 
            this.dtListRole.BackgroundColor = System.Drawing.Color.White;
            this.dtListRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListRole.Location = new System.Drawing.Point(12, 131);
            this.dtListRole.Name = "dtListRole";
            this.dtListRole.Size = new System.Drawing.Size(605, 413);
            this.dtListRole.TabIndex = 0;
            this.dtListRole.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListRole_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách các role trong hệ thống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên role: ";
            // 
            // btnCreateNewRole
            // 
            this.btnCreateNewRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnCreateNewRole.FlatAppearance.BorderSize = 0;
            this.btnCreateNewRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewRole.ForeColor = System.Drawing.Color.White;
            this.btnCreateNewRole.Location = new System.Drawing.Point(441, 62);
            this.btnCreateNewRole.Name = "btnCreateNewRole";
            this.btnCreateNewRole.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewRole.TabIndex = 3;
            this.btnCreateNewRole.Text = "Tạo mới";
            this.btnCreateNewRole.UseVisualStyleBackColor = false;
            this.btnCreateNewRole.Click += new System.EventHandler(this.btnCreateNewRole_Click);
            // 
            // btnViewDetailRole
            // 
            this.btnViewDetailRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnViewDetailRole.FlatAppearance.BorderSize = 0;
            this.btnViewDetailRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetailRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetailRole.ForeColor = System.Drawing.Color.White;
            this.btnViewDetailRole.Location = new System.Drawing.Point(522, 62);
            this.btnViewDetailRole.Name = "btnViewDetailRole";
            this.btnViewDetailRole.Size = new System.Drawing.Size(95, 23);
            this.btnViewDetailRole.TabIndex = 5;
            this.btnViewDetailRole.Text = "Xem chi tiết";
            this.btnViewDetailRole.UseVisualStyleBackColor = false;
            this.btnViewDetailRole.Click += new System.EventHandler(this.btnViewDetailRole_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.btnDeleteRole.FlatAppearance.BorderSize = 0;
            this.btnDeleteRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRole.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.Location = new System.Drawing.Point(522, 102);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteRole.TabIndex = 6;
            this.btnDeleteRole.Text = "Xóa";
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnReFresh
            // 
            this.btnReFresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(166)))), ((int)(((byte)(135)))));
            this.btnReFresh.FlatAppearance.BorderSize = 0;
            this.btnReFresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReFresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReFresh.ForeColor = System.Drawing.Color.White;
            this.btnReFresh.Location = new System.Drawing.Point(441, 102);
            this.btnReFresh.Name = "btnReFresh";
            this.btnReFresh.Size = new System.Drawing.Size(75, 23);
            this.btnReFresh.TabIndex = 7;
            this.btnReFresh.Text = "Xem tất cả";
            this.btnReFresh.UseVisualStyleBackColor = false;
            this.btnReFresh.Click += new System.EventHandler(this.btnReFresh_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(594, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tbSearchRole
            // 
            this.tbSearchRole.Location = new System.Drawing.Point(96, 102);
            this.tbSearchRole.Multiline = true;
            this.tbSearchRole.Name = "tbSearchRole";
            this.tbSearchRole.Size = new System.Drawing.Size(282, 23);
            this.tbSearchRole.TabIndex = 9;
            this.tbSearchRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchRole_KeyPress);
            // 
            // tbNameOfRole
            // 
            this.tbNameOfRole.Enabled = false;
            this.tbNameOfRole.Location = new System.Drawing.Point(96, 64);
            this.tbNameOfRole.Multiline = true;
            this.tbNameOfRole.Name = "tbNameOfRole";
            this.tbNameOfRole.Size = new System.Drawing.Size(282, 23);
            this.tbNameOfRole.TabIndex = 10;
            // 
            // ListRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(629, 556);
            this.Controls.Add(this.tbNameOfRole);
            this.Controls.Add(this.tbSearchRole);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnReFresh);
            this.Controls.Add(this.btnDeleteRole);
            this.Controls.Add(this.btnViewDetailRole);
            this.Controls.Add(this.btnCreateNewRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtListRole);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(629, 556);
            this.Name = "ListRole";
            this.Text = "ListRole";
            this.Load += new System.EventHandler(this.ListRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtListRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateNewRole;
        private System.Windows.Forms.Button btnViewDetailRole;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.Button btnReFresh;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tbSearchRole;
        private System.Windows.Forms.TextBox tbNameOfRole;
    }
}