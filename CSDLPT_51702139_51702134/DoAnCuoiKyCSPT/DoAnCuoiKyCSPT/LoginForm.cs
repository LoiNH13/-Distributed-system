using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DoAnCuoiKyCSPT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void btn_login2_Click(object sender, EventArgs e)
        {
            string user = txt_TK.Text;
            string pass = txt_MK.Text;
            string connectionString = String.Format(@"Data Source=ERP-LOINH;Initial Catalog=QLSV;User ID={0};Password={1}", "sa", "123");
            
            try {
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                string sql = String.Format("select * from TaiKhoan where USER_LOGIN='{0}' AND PASS='{1}'", user, pass);
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader sqlDataReader = command.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    Form1 form = new Form1();
                    form.user = user;
                    form.pass = pass;
                    form.state = 1;
                    sqlDataReader.Read();
                    form.khoa = sqlDataReader.GetSqlValue(3).ToString();
                    form.Show();
                    sqlDataReader.Close();
                    command.Dispose();
                    cnn.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mất khẩu không đúng");
                    txt_TK.Text = "";
                    txt_MK.Text = "";
                }

            }
            catch 
            {
                MessageBox.Show("Lỗi kết nối");
            }

        }
    }
}
