
namespace QuanLyBenhVien
{
    partial class AddPrivilege
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
            this.lbUserDetail_Title = new System.Windows.Forms.Label();
            this.dtAddPriv = new System.Windows.Forms.DataGridView();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnAddPriv = new System.Windows.Forms.Button();
            this.btnNewPriv = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cbWithGrantOption = new System.Windows.Forms.CheckBox();
            this.tbSearchPriv = new System.Windows.Forms.TextBox();
            this.cbbThaoTac = new System.Windows.Forms.ComboBox();
            this.cbbBang = new System.Windows.Forms.ComboBox();
            this.cbbCot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnView = new System.Windows.Forms.RadioButton();
            this.rtbnTable = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtAddPriv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUserDetail_Title
            // 
            this.lbUserDetail_Title.AutoSize = true;
            this.lbUserDetail_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserDetail_Title.ForeColor = System.Drawing.Color.White;
            this.lbUserDetail_Title.Location = new System.Drawing.Point(118, 9);
            this.lbUserDetail_Title.Name = "lbUserDetail_Title";
            this.lbUserDetail_Title.Size = new System.Drawing.Size(238, 18);
            this.lbUserDetail_Title.TabIndex = 0;
            this.lbUserDetail_Title.Text = "Thêm quyền hệ thống từ danh sách";
            // 
            // dtAddPriv
            // 
            this.dtAddPriv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAddPriv.BackgroundColor = System.Drawing.Color.White;
            this.dtAddPriv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAddPriv.Location = new System.Drawing.Point(13, 135);
            this.dtAddPriv.Name = "dtAddPriv";
            this.dtAddPriv.Size = new System.Drawing.Size(487, 363);
            this.dtAddPriv.TabIndex = 1;
            this.dtAddPriv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAddPriv_CellClick);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(143)))), ((int)(((byte)(85)))));
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(344, 106);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 4;
            this.btnViewAll.Text = "Xem tất cả";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnAddPriv
            // 
            this.btnAddPriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(185)))), ((int)(((byte)(12)))));
            this.btnAddPriv.FlatAppearance.BorderSize = 0;
            this.btnAddPriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPriv.ForeColor = System.Drawing.Color.White;
            this.btnAddPriv.Location = new System.Drawing.Point(425, 106);
            this.btnAddPriv.Name = "btnAddPriv";
            this.btnAddPriv.Size = new System.Drawing.Size(75, 23);
            this.btnAddPriv.TabIndex = 7;
            this.btnAddPriv.Text = "Thêm";
            this.btnAddPriv.UseVisualStyleBackColor = false;
            this.btnAddPriv.Click += new System.EventHandler(this.btnAddPriv_Click);
            // 
            // btnNewPriv
            // 
            this.btnNewPriv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(143)))), ((int)(((byte)(85)))));
            this.btnNewPriv.FlatAppearance.BorderSize = 0;
            this.btnNewPriv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPriv.ForeColor = System.Drawing.Color.White;
            this.btnNewPriv.Location = new System.Drawing.Point(344, 73);
            this.btnNewPriv.Name = "btnNewPriv";
            this.btnNewPriv.Size = new System.Drawing.Size(156, 23);
            this.btnNewPriv.TabIndex = 8;
            this.btnNewPriv.Text = "Thêm mới";
            this.btnNewPriv.UseVisualStyleBackColor = false;
            this.btnNewPriv.Click += new System.EventHandler(this.btnNewPriv_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(102)))), ((int)(((byte)(133)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(477, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cbWithGrantOption
            // 
            this.cbWithGrantOption.AutoSize = true;
            this.cbWithGrantOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWithGrantOption.ForeColor = System.Drawing.Color.White;
            this.cbWithGrantOption.Location = new System.Drawing.Point(216, 79);
            this.cbWithGrantOption.Name = "cbWithGrantOption";
            this.cbWithGrantOption.Size = new System.Drawing.Size(122, 19);
            this.cbWithGrantOption.TabIndex = 10;
            this.cbWithGrantOption.Text = "With Grant Option";
            this.cbWithGrantOption.UseVisualStyleBackColor = true;
            // 
            // tbSearchPriv
            // 
            this.tbSearchPriv.Location = new System.Drawing.Point(93, 106);
            this.tbSearchPriv.Multiline = true;
            this.tbSearchPriv.Name = "tbSearchPriv";
            this.tbSearchPriv.Size = new System.Drawing.Size(245, 23);
            this.tbSearchPriv.TabIndex = 13;
            this.tbSearchPriv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchPriv_KeyPress);
            // 
            // cbbThaoTac
            // 
            this.cbbThaoTac.FormattingEnabled = true;
            this.cbbThaoTac.Items.AddRange(new object[] {
            "SELECT",
            "UPDATE",
            "INSERT",
            "DELETE"});
            this.cbbThaoTac.Location = new System.Drawing.Point(93, 48);
            this.cbbThaoTac.Name = "cbbThaoTac";
            this.cbbThaoTac.Size = new System.Drawing.Size(109, 21);
            this.cbbThaoTac.TabIndex = 14;
            this.cbbThaoTac.SelectedIndexChanged += new System.EventHandler(this.cbbThaoTac_SelectedIndexChanged);
            // 
            // cbbBang
            // 
            this.cbbBang.DropDownHeight = 100;
            this.cbbBang.FormattingEnabled = true;
            this.cbbBang.IntegralHeight = false;
            this.cbbBang.ItemHeight = 13;
            this.cbbBang.Location = new System.Drawing.Point(344, 48);
            this.cbbBang.MaxDropDownItems = 5;
            this.cbbBang.Name = "cbbBang";
            this.cbbBang.Size = new System.Drawing.Size(156, 21);
            this.cbbBang.TabIndex = 15;
            this.cbbBang.SelectedIndexChanged += new System.EventHandler(this.cbbBang_SelectedIndexChanged);
            // 
            // cbbCot
            // 
            this.cbbCot.FormattingEnabled = true;
            this.cbbCot.Location = new System.Drawing.Point(93, 79);
            this.cbbCot.Name = "cbbCot";
            this.cbbCot.Size = new System.Drawing.Size(108, 21);
            this.cbbCot.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chọn quyền: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Chọn cột: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnView);
            this.panel1.Controls.Add(this.rtbnTable);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(208, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 37);
            this.panel1.TabIndex = 20;
            // 
            // rbtnView
            // 
            this.rbtnView.AutoSize = true;
            this.rbtnView.ForeColor = System.Drawing.Color.White;
            this.rbtnView.Location = new System.Drawing.Point(79, 13);
            this.rbtnView.Name = "rbtnView";
            this.rbtnView.Size = new System.Drawing.Size(48, 17);
            this.rbtnView.TabIndex = 1;
            this.rbtnView.TabStop = true;
            this.rbtnView.Text = "View";
            this.rbtnView.UseVisualStyleBackColor = true;
            this.rbtnView.CheckedChanged += new System.EventHandler(this.rbtnView_CheckedChanged);
            // 
            // rtbnTable
            // 
            this.rtbnTable.AutoSize = true;
            this.rtbnTable.ForeColor = System.Drawing.Color.White;
            this.rtbnTable.Location = new System.Drawing.Point(8, 12);
            this.rtbnTable.Name = "rtbnTable";
            this.rtbnTable.Size = new System.Drawing.Size(52, 17);
            this.rtbnTable.TabIndex = 0;
            this.rtbnTable.TabStop = true;
            this.rtbnTable.Text = "Table";
            this.rtbnTable.UseVisualStyleBackColor = true;
            this.rtbnTable.CheckedChanged += new System.EventHandler(this.rtbnTable_CheckedChanged);
            // 
            // AddPrivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(234)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(512, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCot);
            this.Controls.Add(this.cbbBang);
            this.Controls.Add(this.cbbThaoTac);
            this.Controls.Add(this.tbSearchPriv);
            this.Controls.Add(this.cbWithGrantOption);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnNewPriv);
            this.Controls.Add(this.btnAddPriv);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.dtAddPriv);
            this.Controls.Add(this.lbUserDetail_Title);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPrivilege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPrivilege";
            this.Load += new System.EventHandler(this.AddPrivilege_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtAddPriv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserDetail_Title;
        private System.Windows.Forms.DataGridView dtAddPriv;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnAddPriv;
        private System.Windows.Forms.Button btnNewPriv;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox cbWithGrantOption;
        private System.Windows.Forms.TextBox tbSearchPriv;
        private System.Windows.Forms.ComboBox cbbThaoTac;
        private System.Windows.Forms.ComboBox cbbBang;
        private System.Windows.Forms.ComboBox cbbCot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnView;
        private System.Windows.Forms.RadioButton rtbnTable;
    }
}