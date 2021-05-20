
namespace DoAnCuoiKyCSPT
{
    partial class DSSinhVien
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
            this.btn_esc = new System.Windows.Forms.Button();
            this.dtGrid_dsSV = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NghiHoc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rowguid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_ho = new System.Windows.Forms.TextBox();
            this.tb_masv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_malop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_noisinh = new System.Windows.Forms.TextBox();
            this.tb_ns = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_gt = new System.Windows.Forms.CheckBox();
            this.cb_nghihoc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_dsSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_esc
            // 
            this.btn_esc.Location = new System.Drawing.Point(879, 24);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(112, 34);
            this.btn_esc.TabIndex = 25;
            this.btn_esc.Text = "Thoát";
            this.btn_esc.UseVisualStyleBackColor = true;
            this.btn_esc.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // dtGrid_dsSV
            // 
            this.dtGrid_dsSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrid_dsSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrid_dsSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_dsSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.Ho,
            this.Ten,
            this.MaLop,
            this.Phai,
            this.NgaySinh,
            this.NoiSinh,
            this.DiaChi,
            this.NghiHoc,
            this.rowguid});
            this.dtGrid_dsSV.Location = new System.Drawing.Point(363, 81);
            this.dtGrid_dsSV.Name = "dtGrid_dsSV";
            this.dtGrid_dsSV.ReadOnly = true;
            this.dtGrid_dsSV.RowHeadersVisible = false;
            this.dtGrid_dsSV.RowHeadersWidth = 62;
            this.dtGrid_dsSV.RowTemplate.Height = 33;
            this.dtGrid_dsSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid_dsSV.Size = new System.Drawing.Size(628, 444);
            this.dtGrid_dsSV.TabIndex = 24;
            this.dtGrid_dsSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_dsSV_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.MinimumWidth = 8;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Width = 96;
            // 
            // Ho
            // 
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Họ";
            this.Ho.MinimumWidth = 8;
            this.Ho.Name = "Ho";
            this.Ho.ReadOnly = true;
            this.Ho.Width = 67;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 8;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 74;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.MinimumWidth = 8;
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            this.MaLop.Width = 104;
            // 
            // Phai
            // 
            this.Phai.DataPropertyName = "Phai";
            this.Phai.HeaderText = "Giới tính Nam";
            this.Phai.MinimumWidth = 8;
            this.Phai.Name = "Phai";
            this.Phai.ReadOnly = true;
            this.Phai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Phai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Phai.Width = 149;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 8;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 117;
            // 
            // NoiSinh
            // 
            this.NoiSinh.DataPropertyName = "NoiSinh";
            this.NoiSinh.HeaderText = "Nơi sinh";
            this.NoiSinh.MinimumWidth = 8;
            this.NoiSinh.Name = "NoiSinh";
            this.NoiSinh.ReadOnly = true;
            this.NoiSinh.Width = 106;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 96;
            // 
            // NghiHoc
            // 
            this.NghiHoc.DataPropertyName = "NghiHoc";
            this.NghiHoc.HeaderText = "Nghỉ học";
            this.NghiHoc.MinimumWidth = 8;
            this.NghiHoc.Name = "NghiHoc";
            this.NghiHoc.ReadOnly = true;
            this.NghiHoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NghiHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NghiHoc.Width = 110;
            // 
            // rowguid
            // 
            this.rowguid.DataPropertyName = "rowguid";
            this.rowguid.HeaderText = "Row";
            this.rowguid.MinimumWidth = 8;
            this.rowguid.Name = "rowguid";
            this.rowguid.ReadOnly = true;
            this.rowguid.Visible = false;
            this.rowguid.Width = 79;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(184, 470);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 34);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(14, 470);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 34);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(184, 419);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 34);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Cập nhập";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(126, 155);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(206, 28);
            this.tb_ten.TabIndex = 20;
            // 
            // tb_ho
            // 
            this.tb_ho.Location = new System.Drawing.Point(126, 121);
            this.tb_ho.Name = "tb_ho";
            this.tb_ho.Size = new System.Drawing.Size(206, 28);
            this.tb_ho.TabIndex = 19;
            // 
            // tb_masv
            // 
            this.tb_masv.Location = new System.Drawing.Point(126, 87);
            this.tb_masv.Name = "tb_masv";
            this.tb_masv.Size = new System.Drawing.Size(206, 28);
            this.tb_masv.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Họ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã MSSV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(394, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Danh sách lớp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(15, 419);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 34);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_malop
            // 
            this.tb_malop.Location = new System.Drawing.Point(126, 190);
            this.tb_malop.Name = "tb_malop";
            this.tb_malop.Size = new System.Drawing.Size(206, 28);
            this.tb_malop.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Giới tính nam:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mã lớp:";
            // 
            // tb_noisinh
            // 
            this.tb_noisinh.Location = new System.Drawing.Point(126, 292);
            this.tb_noisinh.Name = "tb_noisinh";
            this.tb_noisinh.Size = new System.Drawing.Size(206, 28);
            this.tb_noisinh.TabIndex = 34;
            // 
            // tb_ns
            // 
            this.tb_ns.Location = new System.Drawing.Point(126, 258);
            this.tb_ns.Name = "tb_ns";
            this.tb_ns.Size = new System.Drawing.Size(206, 28);
            this.tb_ns.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nơi sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ngày sinh";
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(126, 328);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(206, 28);
            this.tb_diachi.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Nghỉ học";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Địa chỉ:";
            // 
            // cb_gt
            // 
            this.cb_gt.AutoSize = true;
            this.cb_gt.Location = new System.Drawing.Point(126, 224);
            this.cb_gt.Name = "cb_gt";
            this.cb_gt.Size = new System.Drawing.Size(22, 21);
            this.cb_gt.TabIndex = 39;
            this.cb_gt.UseVisualStyleBackColor = true;
            // 
            // cb_nghihoc
            // 
            this.cb_nghihoc.AutoSize = true;
            this.cb_nghihoc.Location = new System.Drawing.Point(126, 363);
            this.cb_nghihoc.Name = "cb_nghihoc";
            this.cb_nghihoc.Size = new System.Drawing.Size(22, 21);
            this.cb_nghihoc.TabIndex = 40;
            this.cb_nghihoc.UseVisualStyleBackColor = true;
            // 
            // DSSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 534);
            this.Controls.Add(this.cb_nghihoc);
            this.Controls.Add(this.cb_gt);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_noisinh);
            this.Controls.Add(this.tb_ns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_malop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_esc);
            this.Controls.Add(this.dtGrid_dsSV);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_ho);
            this.Controls.Add(this.tb_masv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "DSSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSSinhVien";
            this.Load += new System.EventHandler(this.DSSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_dsSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_esc;
        private System.Windows.Forms.DataGridView dtGrid_dsSV;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_ho;
        private System.Windows.Forms.TextBox tb_masv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_malop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_noisinh;
        private System.Windows.Forms.TextBox tb_ns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NghiHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguid;
        private System.Windows.Forms.CheckBox cb_gt;
        private System.Windows.Forms.CheckBox cb_nghihoc;
    }
}