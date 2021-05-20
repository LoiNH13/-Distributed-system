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
    public partial class AddMHforSV : Form
    {
        private string connect;

        public AddMHforSV()
        {
            InitializeComponent();
        }

        public AddMHforSV(string connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void btn_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMHforSV_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            //throw new NotImplementedException();
            try
            {
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                string sql = String.Format("select MaSV as 'Mã sinh viên', MaMH as 'Mã môn học',Lan as 'Lần thi' from Diem order by MaMH");
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dtGrid_dsMH.DataSource = ds.Tables[0];
                dtGrid_dsMH.BackgroundColor = Color.White;
                dtGrid_dsMH.RowHeadersVisible = false;
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tb_maSV.Text.Equals("") || tb_MaMH.Equals(""))
            {
                MessageBox.Show("Mã sinh viên hoặc môn học đang để trống.");
            }
            else
            {
                if (checkDS())
                {
                    MessageBox.Show("Sinh viên đã học môn này");
                }
                else
                {
                    MessageBox.Show("Sinh viên chưa học môn này");
                }

            }
        }

        private bool checkDS()
        {
            //throw new NotImplementedException();
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string sql = String.Format("select * from Diem where MaMH='{0}' and MaSV='{1}'", tb_MaMH.Text,tb_maSV.Text);
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

        private void dtGrid_dsMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGrid_dsMH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                tb_maSV.Text = (dtGrid_dsMH.Rows[e.RowIndex].Cells[0].Value).ToString();
                tb_MaMH.Text = (dtGrid_dsMH.Rows[e.RowIndex].Cells[1].Value).ToString();

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string mamon = tb_MaMH.Text;
            string masv = tb_maSV.Text;

            if (mamon.Equals("") || masv.Equals(""))
            {
                MessageBox.Show("Mã môn học, tên sinh viên đang để trống");
            }
            else
            {
                if (checkDS())
                {
                    MessageBox.Show("Sinh viên đã học môn này");
                }
                else
                {
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string sql = String.Format("insert into Diem (MaSV,MaMH,Lan,Diem) values('{0}','{1}',1,0)", masv, mamon);
                    string sql2 = String.Format("insert into checkNhapDiem (MaSV,MaMH) values('{0}','{1}')", masv, mamon);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlCommand command2 = new SqlCommand(sql2, cnn);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    cnn.Close();
                    LoadForm();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string mamon = tb_MaMH.Text;
            string masv = tb_maSV.Text;

            if (mamon.Equals("") || masv.Equals(""))
            {
                MessageBox.Show("Mã môn học, tên sinh viên đang để trống");
            }
            else
            {
                if (checkDS())
                {
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string sql = String.Format("update Diem set MaSV ='{1}',MaMH ='{0}',Lan=1,Diem=0 where MaMH='{0}'and MaSV='{1}'", mamon, masv);
                    string sql2 = String.Format("update checkNhapDiem set MaSV ='{1}',MaMH ='{0}',DaNhap=0 where MaMH='{0}'and MaSV='{1}'", mamon, masv);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlCommand command2 = new SqlCommand(sql2, cnn);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    cnn.Close();
                    LoadForm();
                }
                else
                {
                    MessageBox.Show("Sinh viên chưa học môn này vui lòng nhấn thêm nếu cần.");
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string mamon = tb_MaMH.Text;
            string masv = tb_maSV.Text;

            if (mamon.Equals("") || masv.Equals(""))
            {
                MessageBox.Show("Mã môn học, tên sinh viên đang để trống");
            }
            else
            {
                if (checkDS())
                {
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string sql = String.Format("delete from Diem where MaMH='{0}' and MaSV ='{1}'", mamon,masv);
                    string sql2 = String.Format("delete from checkNhapDiem where MaMH='{0}' and MaSV ='{1}'", mamon, masv);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlCommand command2 = new SqlCommand(sql2, cnn);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    cnn.Close();
                    LoadForm();
                }
                else
                {
                    MessageBox.Show("Sinh viên hoặc mã môn không tồn tại.");
                }
            }
        }
    }
}
