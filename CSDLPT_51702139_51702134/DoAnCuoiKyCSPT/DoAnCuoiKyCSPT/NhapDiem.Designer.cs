
namespace DoAnCuoiKyCSPT
{
    partial class NhapDiem
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
            this.txt_tenlop = new System.Windows.Forms.Label();
            this.txt_monhoc = new System.Windows.Forms.Label();
            this.txt_lanthi = new System.Windows.Forms.Label();
            this.txt_hocky = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dtGrid_nhapdiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_nhapdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.AutoSize = true;
            this.txt_tenlop.Location = new System.Drawing.Point(44, 9);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(78, 25);
            this.txt_tenlop.TabIndex = 1;
            this.txt_tenlop.Text = "Tên lớp: ";
            // 
            // txt_monhoc
            // 
            this.txt_monhoc.AutoSize = true;
            this.txt_monhoc.Location = new System.Drawing.Point(44, 48);
            this.txt_monhoc.Name = "txt_monhoc";
            this.txt_monhoc.Size = new System.Drawing.Size(92, 25);
            this.txt_monhoc.TabIndex = 2;
            this.txt_monhoc.Text = "Môn học: ";
            // 
            // txt_lanthi
            // 
            this.txt_lanthi.AutoSize = true;
            this.txt_lanthi.Location = new System.Drawing.Point(531, 48);
            this.txt_lanthi.Name = "txt_lanthi";
            this.txt_lanthi.Size = new System.Drawing.Size(73, 25);
            this.txt_lanthi.TabIndex = 4;
            this.txt_lanthi.Text = "Lần thi: ";
            // 
            // txt_hocky
            // 
            this.txt_hocky.AutoSize = true;
            this.txt_hocky.Location = new System.Drawing.Point(531, 9);
            this.txt_hocky.Name = "txt_hocky";
            this.txt_hocky.Size = new System.Drawing.Size(76, 25);
            this.txt_hocky.TabIndex = 3;
            this.txt_hocky.Text = "Học kỳ: ";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(421, 442);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 34);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Lưu";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(563, 442);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 34);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dtGrid_nhapdiem
            // 
            this.dtGrid_nhapdiem.ColumnHeadersHeight = 34;
            this.dtGrid_nhapdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGrid_nhapdiem.Location = new System.Drawing.Point(44, 124);
            this.dtGrid_nhapdiem.Name = "dtGrid_nhapdiem";
            this.dtGrid_nhapdiem.RowHeadersVisible = false;
            this.dtGrid_nhapdiem.RowHeadersWidth = 62;
            this.dtGrid_nhapdiem.RowTemplate.Height = 33;
            this.dtGrid_nhapdiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtGrid_nhapdiem.Size = new System.Drawing.Size(631, 307);
            this.dtGrid_nhapdiem.TabIndex = 12;
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 502);
            this.Controls.Add(this.dtGrid_nhapdiem);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_lanthi);
            this.Controls.Add(this.txt_hocky);
            this.Controls.Add(this.txt_monhoc);
            this.Controls.Add(this.txt_tenlop);
            this.Name = "NhapDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapDiem";
            this.Load += new System.EventHandler(this.NhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_nhapdiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_tenlop;
        private System.Windows.Forms.Label txt_monhoc;
        private System.Windows.Forms.Label txt_lanthi;
        private System.Windows.Forms.Label txt_hocky;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dtGrid_nhapdiem;
    }
}