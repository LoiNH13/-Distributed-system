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
    public partial class DsLop : Form
    {
        private string connect;
       

        public DsLop()
        {
            InitializeComponent();
        }

        public DsLop(string connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void DsLop_Load(object sender, EventArgs e) 
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
                string sql = String.Format("select * from Lop");
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dtGrid_dsLop.DataSource = ds.Tables[0];
                dtGrid_dsLop.BackgroundColor = Color.White;
                dtGrid_dsLop.RowHeadersVisible = false;
                dtGrid_dsLop.Columns[3].Visible = false;
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void dtGrid_dsLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGrid_dsLop.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
               tb_maLop.Text=(dtGrid_dsLop.Rows[e.RowIndex].Cells[0].Value).ToString();
               tb_tenlop.Text = (dtGrid_dsLop.Rows[e.RowIndex].Cells[1].Value).ToString();
               tb_khoa.Text = (dtGrid_dsLop.Rows[e.RowIndex].Cells[2].Value).ToString();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            if (tb_maLop.Text.Equals(""))
            {
                MessageBox.Show("Nhập mã lớp");
            }
            else
            {
                if (checkClassCode())
                {
                    MessageBox.Show("Mã lớp đã tồn tại");
                }
                else
                {
                    MessageBox.Show("Mã lớp chưa tồn tại");
                }
                
            }
        }

        private bool checkClassCode()
        {
            //throw new NotImplementedException();
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string sql = String.Format("DECLARE	@return_value int EXEC	@return_value = [dbo].[sp_KiemTraMaLop] @MaLop = N'{0}' SELECT	'Return Value' = @return_value", tb_maLop.Text);
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataReader sqlData = command.ExecuteReader();

            sqlData.Read();
            int i = (int)sqlData.GetValue(0);
            cnn.Close();
            if (i == 0)
            {
                return false;
            }
            else
            {
                return true;
            } 
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string malop = tb_maLop.Text;
            string tenlop = tb_tenlop.Text;
            string khoa = tb_khoa.Text;
            if (malop.Equals("")|| tenlop.Equals("")|| khoa.Equals(""))
            {
                MessageBox.Show("Mã lớp, tên lớp hoặc khoa đang để trống");
            }
            else
            {
                if (checkClassCode())
                {
                    MessageBox.Show("Mã lớp đã tồn tại");
                }
                else
                {
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string sql = String.Format("insert into Lop (MaLop,TenLop,MaKhoa) values('{0}','{1}','{2}')", malop,tenlop,khoa );
                    SqlCommand command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    LoadForm();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string malop = tb_maLop.Text;
            string tenlop = tb_tenlop.Text;
            string khoa = tb_khoa.Text;

            if (malop.Equals("") || tenlop.Equals("") || khoa.Equals(""))
            {
                MessageBox.Show("Mã lớp, tên lớp hoặc khoa đang để trống");
            }
            else
            {
                if (checkClassCode())
                {
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string sql = String.Format("update Lop set TenLop='{1}',MaKhoa='{2}' where MaLop='{0}'", malop, tenlop, khoa);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    LoadForm();
                    tb_maLop.Text="";
                    tb_tenlop.Text="";
                    tb_khoa.Text="";
                }
                else
                {
                    MessageBox.Show("Mã lớp không tồn tại vui lòng nhấn thêm nếu cần.");
                }
            }
        }

        private void btn_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string malop = tb_maLop.Text;
            if (malop.Equals(""))
            {
                MessageBox.Show("Chọn một lớp để xóa");
            }
            else
            {
                if (checkClassCode())
                {
                    SqlConnection cnn = new SqlConnection(connect);
                    cnn.Open();
                    string sql = String.Format("delete from Lop where MaLop='{0}'", malop);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    LoadForm();
                    
                }
                else
                {
                    MessageBox.Show("Mã lớp không tồn tại.");
                }
            }
        }
    }
}
