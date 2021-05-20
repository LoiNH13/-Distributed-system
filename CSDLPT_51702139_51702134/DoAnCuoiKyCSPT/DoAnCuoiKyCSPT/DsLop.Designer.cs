
namespace DoAnCuoiKyCSPT
{
    partial class DsLop
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
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_maLop = new System.Windows.Forms.TextBox();
            this.tb_tenlop = new System.Windows.Forms.TextBox();
            this.tb_khoa = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dtGrid_dsLop = new System.Windows.Forms.DataGridView();
            this.btn_esc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_dsLop)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 249);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 34);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách lớp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khoa:";
            // 
            // tb_maLop
            // 
            this.tb_maLop.Location = new System.Drawing.Point(90, 79);
            this.tb_maLop.Name = "tb_maLop";
            this.tb_maLop.Size = new System.Drawing.Size(204, 31);
            this.tb_maLop.TabIndex = 5;
            // 
            // tb_tenlop
            // 
            this.tb_tenlop.Location = new System.Drawing.Point(90, 130);
            this.tb_tenlop.Name = "tb_tenlop";
            this.tb_tenlop.Size = new System.Drawing.Size(204, 31);
            this.tb_tenlop.TabIndex = 6;
            // 
            // tb_khoa
            // 
            this.tb_khoa.Location = new System.Drawing.Point(90, 183);
            this.tb_khoa.Name = "tb_khoa";
            this.tb_khoa.Size = new System.Drawing.Size(204, 31);
            this.tb_khoa.TabIndex = 7;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(182, 249);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 34);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Cập nhập";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(12, 321);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 34);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(182, 321);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 34);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dtGrid_dsLop
            // 
            this.dtGrid_dsLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrid_dsLop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrid_dsLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_dsLop.Location = new System.Drawing.Point(358, 79);
            this.dtGrid_dsLop.Name = "dtGrid_dsLop";
            this.dtGrid_dsLop.ReadOnly = true;
            this.dtGrid_dsLop.RowHeadersVisible = false;
            this.dtGrid_dsLop.RowHeadersWidth = 62;
            this.dtGrid_dsLop.RowTemplate.Height = 33;
            this.dtGrid_dsLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid_dsLop.Size = new System.Drawing.Size(417, 359);
            this.dtGrid_dsLop.TabIndex = 11;
            this.dtGrid_dsLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_dsLop_CellClick);
            // 
            // btn_esc
            // 
            this.btn_esc.Location = new System.Drawing.Point(679, 20);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(112, 34);
            this.btn_esc.TabIndex = 12;
            this.btn_esc.Text = "Thoát";
            this.btn_esc.UseVisualStyleBackColor = true;
            this.btn_esc.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // DsLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.btn_esc);
            this.Controls.Add(this.dtGrid_dsLop);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tb_khoa);
            this.Controls.Add(this.tb_tenlop);
            this.Controls.Add(this.tb_maLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Name = "DsLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DsLop";
            this.Load += new System.EventHandler(this.DsLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_dsLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_maLop;
        private System.Windows.Forms.TextBox tb_tenlop;
        private System.Windows.Forms.TextBox tb_khoa;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dtGrid_dsLop;
        private System.Windows.Forms.Button btn_esc;
    }
}