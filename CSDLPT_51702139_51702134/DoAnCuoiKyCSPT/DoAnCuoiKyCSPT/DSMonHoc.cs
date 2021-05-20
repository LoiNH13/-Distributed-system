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
    public partial class DSMonHoc : Form
    {
        private string connect;

        public DSMonHoc()
        {
            InitializeComponent();
        }

        public DSMonHoc(string connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void btn_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadForm()
        {
            //throw new NotImplementedException();
            try
            {
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                string sql = String.Format("select MaMH as 'Mã môn học', TenMH as 'Tên môn học' from MonHoc");
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

        private void DSMonHoc_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dtGrid_dsMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGrid_dsMH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                tb_maMH.Text = (dtGrid_dsMH.Rows[e.RowIndex].Cells[0].Value).ToString();
                tb_tenMH.Text = (dtGrid_dsMH.Rows[e.RowIndex].Cells[1].Value).ToString();
               
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tb_maMH.Text.Equals(""))
            {
                MessageBox.Show("Nhập mã môn học");
            }
            else
            {
                if (checkMHCode())
                {
                    MessageBox.Show("Mã môn đã tồn tại");
                }
                else
                {
                    MessageBox.Show("Mã môn chưa tồn tại");
                }

            }
        }

        private bool checkMHCode()
        {
            //throw new NotImplementedException();
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string sql = String.Format("select * from MonHoc where MaMH='{0}'", tb_maMH.Text);
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            string mamon = tb_maMH.Text;
            string tenmon = tb_tenMH.Text;
       
            if (mamon.Equals("") || tenmon.Equals("") )
            {
                MessageBox.Show("Mã môn học, tên môn học đang để trống");
            }
            else
            {
                if (checkMHCode())
                {
                    MessageBox.Show("Mã lớp đã tồn tại");
                }
                else
                {
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string sql = String.Format("insert into MonHoc (MaMH,TenMH) values('{0}','{1}')", mamon, tenmon);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    LoadForm();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string mamon = tb_maMH.Text;
            string tenmon = tb_tenMH.Text;

            if (mamon.Equals("") || tenmon.Equals(""))
            {
                MessageBox.Show("Mã môn học, tên môn học đang để trống");
            }
            else
            {
                if (checkMHCode())
                {
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string sql = String.Format("update MonHoc set TenMH ='{1}' where MaMH='{0}'", mamon, tenmon);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    LoadForm();
                }
                else
                {
                    MessageBox.Show("Mã môn học không tồn tại vui lòng nhấn thêm nếu cần.");
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string mamon = tb_maMH.Text;
            if (mamon.Equals(""))
            {
                MessageBox.Show("Chọn một môn để xóa");
            }
            else
            {
                if (checkMHCode())
                {
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string sql = String.Format("delete from MonHoc where MaMH='{0}'", mamon);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    LoadForm();

                }
                else
                {
                    MessageBox.Show("Mã môn không tồn tại.");
                }
            }

        }
    }
}
