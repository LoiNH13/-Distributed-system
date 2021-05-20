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
    public partial class NhapDiem : Form
    {
        public string malop;
        public string monhoc;
        private string hocky;
        public string lanthi;
        public string tenlop;
        private string connect;
        

        public NhapDiem(string malop, string monhoc, string hocky, string lanthi, string tenlop)
        {
            InitializeComponent();
            this.malop = malop;
            this.monhoc = monhoc;
            this.hocky = hocky;
            this.lanthi = lanthi;
            this.tenlop = tenlop;

        }

        public NhapDiem(string connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            txt_tenlop.Text += this.tenlop;
            txt_monhoc.Text += this.monhoc;
            txt_hocky.Text += this.hocky;
            txt_lanthi.Text += this.lanthi;

            LoadForm();

        }

        private void LoadForm()
        {

            try
            {
                string sql;
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                if (lanthi.Equals("1"))
                {
                    sql = String.Format("SELECT SV.MaSV,CONCAT( SV.Ho,' ',SV.Ten) HoTen, D.Diem,Lan from SinhVien SV INNER JOIN Lop L ON L.MaLop=SV.MaLop INNER JOIN DIEM D ON D.MaSV=SV.MaSV INNER JOIN checkNhapDiem C ON C.MaSV=D.MaSV AND C.MaMH=D.MaMH WHERE L.MaLop ='{0}' AND D.MaMH='{1}' AND C.DaNhap <> 2", malop, monhoc);
                }
                else
                {
                    sql = String.Format("SELECT SV.MaSV,CONCAT( SV.Ho,' ',SV.Ten) HoTen, D.Diem,Lan from SinhVien SV INNER JOIN Lop L ON L.MaLop=SV.MaLop INNER JOIN DIEM D ON D.MaSV=SV.MaSV INNER JOIN checkNhapDiem C ON C.MaSV=D.MaSV AND C.MaMH=D.MaMH WHERE L.MaLop ='{0}' AND D.MaMH='{1}' AND C.DaNhap <> 0", malop, monhoc);
                }
                //string sql = String.Format("SELECT SV.MaSV,CONCAT( SV.Ho,' ',SV.Ten) HoTen, D.Diem from SinhVien SV INNER JOIN Lop L ON L.MaLop=SV.MaLop INNER JOIN DIEM D ON D.MaSV=SV.MaSV WHERE L.MaLop ='{0}' AND D.MaMH='{1}' AND D.Lan={2}",malop,monhoc,lanthi);
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                
                dtGrid_nhapdiem.DataSource = ds.Tables[0];
                dtGrid_nhapdiem.Columns[0].ReadOnly = true;
                dtGrid_nhapdiem.Columns[1].ReadOnly = true;
                dtGrid_nhapdiem.Columns[3].Visible = false;
                dtGrid_nhapdiem.BackgroundColor = Color.White;
                dtGrid_nhapdiem.RowHeadersVisible = false;
                
                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lanthi.Equals("1"))
            {
                Update1();
            }
            else
            {
                UPDATE2();
            }

        }

        private void UPDATE2()
        {
            //throw new NotImplementedException();
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            for (int i = 0; i < dtGrid_nhapdiem.Rows.Count - 1; i++)
            {
                if (dtGrid_nhapdiem.Rows[i].Cells[3].Value.ToString().Equals("1")) {
                    string MSV = dtGrid_nhapdiem.Rows[i].Cells[0].Value.ToString();

                    string diem = dtGrid_nhapdiem.Rows[i].Cells[2].Value.ToString();

                    string sql = String.Format("INSERT into Diem (MaSV,MaMH,Diem,Lan) Values('{0}','{1}','{2}',2)", MSV, monhoc, diem);
                    string sql2 = String.Format("update checkNhapDiem set DaNhap=2 where MaSV='{0}' and MaMH='{1}'", MSV, monhoc);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlCommand command2 = new SqlCommand(sql2, cnn);
                    try { 
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    }
                    catch
                    {
                        continue;
                    }
                }
                else
                {
                    string MSV = dtGrid_nhapdiem.Rows[i].Cells[0].Value.ToString();

                    string diem = dtGrid_nhapdiem.Rows[i].Cells[2].Value.ToString();

                    string sql = String.Format("update Diem set Diem={2} where MaSV='{0}' and MaMH='{1}'", MSV, monhoc, diem);
                    string sql2 = String.Format("update checkNhapDiem set DaNhap=2 where MaSV='{0}' and MaMH='{1}'", MSV, monhoc);
                    SqlCommand command = new SqlCommand(sql, cnn);
                    SqlCommand command2 = new SqlCommand(sql2, cnn);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                }
                
            }
            cnn.Close();
            LoadForm2();
        }

        private void LoadForm2()
        {
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();

            //throw new NotImplementedException();
            string sql = String.Format("SELECT SV.MaSV,CONCAT( SV.Ho,' ',SV.Ten) HoTen, D.Diem,Lan from SinhVien SV INNER JOIN Lop L ON L.MaLop=SV.MaLop INNER JOIN DIEM D ON D.MaSV=SV.MaSV INNER JOIN checkNhapDiem C ON C.MaSV=D.MaSV AND C.MaMH=D.MaMH WHERE L.MaLop ='{0}' AND D.MaMH='{1}' AND C.DaNhap = 2 AND LAN =2", malop, monhoc);
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);


            dtGrid_nhapdiem.DataSource = ds.Tables[0];
            dtGrid_nhapdiem.Columns[0].ReadOnly = true;
            dtGrid_nhapdiem.Columns[1].ReadOnly = true;
            dtGrid_nhapdiem.Columns[3].Visible = false;
            dtGrid_nhapdiem.BackgroundColor = Color.White;
            dtGrid_nhapdiem.RowHeadersVisible = false;

        }

        private void Update1()
        {
            //throw new NotImplementedException();
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            for (int i = 0; i< dtGrid_nhapdiem.Rows.Count-1; i++)
            {
                string MSV = dtGrid_nhapdiem.Rows[i].Cells[0].Value.ToString();
              
                string diem = dtGrid_nhapdiem.Rows[i].Cells[2].Value.ToString();

                string sql = String.Format("update Diem set Diem={2} where MaSV='{0}' and MaMH='{1}'", MSV, monhoc, diem);
                string sql2 = String.Format("update checkNhapDiem set DaNhap=1 where MaSV='{0}' and MaMH='{1}'", MSV, monhoc);
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlCommand command2 = new SqlCommand(sql2, cnn);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                
            }
            cnn.Close();
            LoadForm();
        }
    }
}
