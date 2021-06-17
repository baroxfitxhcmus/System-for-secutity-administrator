
namespace QuanLyBenhVien
{
    partial class OthersObject
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
            this.dtTable_View = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbCreate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtTable_View)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTable_View
            // 
            this.dtTable_View.BackgroundColor = System.Drawing.Color.White;
            this.dtTable_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTable_View.Location = new System.Drawing.Point(12, 115);
            this.dtTable_View.Name = "dtTable_View";
            this.dtTable_View.Size = new System.Drawing.Size(605, 429);
            this.dtTable_View.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(187, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(263, 20);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Danh sách các bảng trong hệ thống";
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(135)))), ((int)(((byte)(217)))));
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.Location = new System.Drawing.Point(12, 53);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(110, 25);
            this.btnTable.TabIndex = 2;
            this.btnTable.Text = "Bảng";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(59)))), ((int)(((byte)(169)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(128, 53);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(110, 25);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(94)))), ((int)(((byte)(163)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(594, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(245, 53);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 25);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(13)))), ((int)(((byte)(217)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(244, 84);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 25);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Xem tất cả";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 84);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(226, 25);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // tbCreate
            // 
            this.tbCreate.ForeColor = System.Drawing.Color.Silver;
            this.tbCreate.Location = new System.Drawing.Point(361, 53);
            this.tbCreate.Multiline = true;
            this.tbCreate.Name = "tbCreate";
            this.tbCreate.Size = new System.Drawing.Size(256, 56);
            this.tbCreate.TabIndex = 8;
            this.tbCreate.Text = "Script to create new table/view ...";
            this.tbCreate.Click += new System.EventHandler(this.tbCreate_Click);
            // 
            // OthersObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(629, 556);
            this.Controls.Add(this.tbCreate);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dtTable_View);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OthersObject";
            this.Text = "RoleAddPrivilege";
            this.Load += new System.EventHandler(this.OthersObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTable_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtTable_View;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbCreate;
    }
}