
namespace DoAnCuoiKyCSPT
{
    partial class DSMonHoc
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
            this.dtGrid_dsMH = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_tenMH = new System.Windows.Forms.TextBox();
            this.tb_maMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_dsMH)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_esc
            // 
            this.btn_esc.Location = new System.Drawing.Point(654, 22);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(112, 34);
            this.btn_esc.TabIndex = 25;
            this.btn_esc.Text = "Thoát";
            this.btn_esc.UseVisualStyleBackColor = true;
            this.btn_esc.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // dtGrid_dsMH
            // 
            this.dtGrid_dsMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrid_dsMH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrid_dsMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_dsMH.Location = new System.Drawing.Point(401, 81);
            this.dtGrid_dsMH.Name = "dtGrid_dsMH";
            this.dtGrid_dsMH.ReadOnly = true;
            this.dtGrid_dsMH.RowHeadersVisible = false;
            this.dtGrid_dsMH.RowHeadersWidth = 62;
            this.dtGrid_dsMH.RowTemplate.Height = 33;
            this.dtGrid_dsMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid_dsMH.Size = new System.Drawing.Size(331, 359);
            this.dtGrid_dsMH.TabIndex = 24;
            this.dtGrid_dsMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_dsMH_CellClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(181, 323);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(112, 34);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(11, 323);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 34);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(181, 251);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 34);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Cập nhập";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_tenMH
            // 
            this.tb_tenMH.Location = new System.Drawing.Point(89, 162);
            this.tb_tenMH.Name = "tb_tenMH";
            this.tb_tenMH.Size = new System.Drawing.Size(274, 31);
            this.tb_tenMH.TabIndex = 19;
            // 
            // tb_maMH
            // 
            this.tb_maMH.Location = new System.Drawing.Point(89, 81);
            this.tb_maMH.Name = "tb_maMH";
            this.tb_maMH.Size = new System.Drawing.Size(274, 31);
            this.tb_maMH.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên môn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã môn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Danh sách Môn học";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(11, 251);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 34);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // DSMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.btn_esc);
            this.Controls.Add(this.dtGrid_dsMH);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tb_tenMH);
            this.Controls.Add(this.tb_maMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Name = "DSMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSMonHoc";
            this.Load += new System.EventHandler(this.DSMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_dsMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_esc;
        private System.Windows.Forms.DataGridView dtGrid_dsMH;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_tenMH;
        private System.Windows.Forms.TextBox tb_maMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
    }
}