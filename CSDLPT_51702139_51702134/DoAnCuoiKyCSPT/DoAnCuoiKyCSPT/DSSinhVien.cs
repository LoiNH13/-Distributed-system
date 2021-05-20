using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoAnCuoiKyCSPT
{
    public partial class DSSinhVien : Form
    {
        private string connect;

        public DSSinhVien()
        {
            InitializeComponent();
        }

        public DSSinhVien(string connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void DSSinhVien_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                string sql = String.Format("select * from SinhVien");
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dtGrid_dsSV.DataSource = ds.Tables[0];
                dtGrid_dsSV.BackgroundColor = Color.White;
                dtGrid_dsSV.RowHeadersVisible = false;
                
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGrid_dsSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGrid_dsSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                tb_masv.Text = (dtGrid_dsSV.Rows[e.RowIndex].Cells[0].Value).ToString();
                tb_ho.Text = (dtGrid_dsSV.Rows[e.RowIndex].Cells[1].Value).ToString();
                tb_ten.Text = (dtGrid_dsSV.Rows[e.RowIndex].Cells[2].Value).ToString();
                tb_malop.Text = (dtGrid_dsSV.Rows[e.RowIndex].Cells[3].Value).ToString();
                tb_ns.Text = (dtGrid_dsSV.Rows[e.RowIndex].Cells[5].Value).ToString();
                tb_noisinh.Text = (dtGrid_dsSV.Rows[e.RowIndex].Cells[6].Value).ToString();
                tb_diachi.Text = (dtGrid_dsSV.Rows[e.RowIndex].Cells[7].Value).ToString();
                if ((dtGrid_dsSV.Rows[e.RowIndex].Cells[4].Value).ToString().Equals("True"))
                {
                    cb_gt.Checked = true;
                }
                else
                {
                    cb_gt.Checked = false;
                }
                if ((dtGrid_dsSV.Rows[e.RowIndex].Cells[8].Value).ToString().Equals("True"))
                {
                    cb_nghihoc.Checked = true;
                }
                else
                {
                    cb_nghihoc.Checked = false;
                }
            }
        }
        private bool checkSVCode()
        {
            //throw new NotImplementedException();
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string sql = String.Format("select * from SinhVien where MaSV='{0}'", tb_masv.Text);
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader sqlData = command.ExecuteReader();

            if (sqlData.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tb_masv.Text.Equals(""))
            {
                MessageBox.Show("Nhập mã sinh viên");
            }
            else
            {
                if (checkSVCode())
                {
                    MessageBox.Show("Mã sv đã tồn tại");
                }
                else
                {
                    MessageBox.Show("Mã sv chưa tồn tại");
                }

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string masv = tb_masv.Text;
            string ho = tb_ho.Text;
            string ten = tb_ten.Text;
            string malop = tb_malop.Text;
            bool phai = cb_gt.Checked;
            string ngaysinh = tb_ns.Text;
            string noisinh = tb_noisinh.Text;
            string diachi = tb_diachi.Text;
            bool nghihoc = cb_nghihoc.Checked;

            if (malop.Equals("") || ten.Equals("") || ho.Equals("")|| masv.Equals(""))
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                if (checkSVCode())
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại");
                }
                else
                {
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string sql = String.Format("insert into SinhVien(MaSV,Ho,Ten,MaLop,Phai,NgaySinh,NoiSinh,DiaChi,NghiHoc) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", masv, ho, ten,malop,phai,ngaysinh,noisinh,diachi,nghihoc);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    LoadForm();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string masv = tb_masv.Text;
            string ho = tb_ho.Text;
            string ten = tb_ten.Text;
            string malop = tb_malop.Text;
            bool phai = cb_gt.Checked;
            string ngaysinh = tb_ns.Text;
            string noisinh = tb_noisinh.Text;
            string diachi = tb_diachi.Text;
            bool nghihoc = cb_nghihoc.Checked;

            if (malop.Equals("") || ten.Equals("") || ho.Equals("") || masv.Equals(""))
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                if (checkSVCode())
                {
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string sql = String.Format("update SinhVien set Ho ='{1}',Ten='{2}',MaLop='{3}',Phai='{4}',NgaySinh='{5}',NoiSinh='{6}',DiaChi='{7}',NghiHoc='{8}' where MaSV='{0}'", masv, ho, ten, malop, phai, ngaysinh, noisinh, diachi, nghihoc);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    LoadForm();
                }
                else
                {
                    MessageBox.Show("Mã sinh viên không tồn tại vui lòng nhấn thêm nếu cần.");
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string masv = tb_masv.Text;
            if (masv.Equals(""))
            {
                MessageBox.Show("Chọn một sinh viên để xóa");
            }
            else
            {
                if (checkSVCode())
                {
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string sql = String.Format("delete from SinhVien where MaSV='{0}'", masv);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    LoadForm();

                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại.");
                }
            }
        }
    }
}
