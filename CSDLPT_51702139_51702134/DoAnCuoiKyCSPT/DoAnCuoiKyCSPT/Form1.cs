using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKyCSPT
{
    
    public partial class Form1 : Form
    {
        public String user;
        public int state;
        public string pass;
        public string khoa;
        private string connect;
        private string[] tenlop;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            if (state == 1)
            {
                user = null;
                state = 0;
                txt_user.Text = "Chưa đăng nhập";
                btn_login.Text = "Đăng nhập";

            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        public void load_Data()
        {
            cbbox_malop.Items.Clear();
            try
            {
                SqlConnection cnn = new SqlConnection(connect);
                cnn.Open();
                string sql = String.Format("select * from Lop");
                SqlCommand command = new SqlCommand(sql, cnn);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);
                
                tenlop = new string[dataTable.Rows.Count];
                
                for (int i = 0;i< dataTable.Rows.Count;i++)
                {
                    cbbox_malop.Items.Add(dataTable.Rows[i][0].ToString());
                    tenlop[i] = dataTable.Rows[i][1].ToString();
                    
                }
                
                //DataTable dataTable = new DataTable();
                //dataTable.Columns.Add("Mã Lớp");
                //dataTable.Columns.Add("Tên Lớp");
                //dataTable.Load(sqlDataReader);

                //cbbox_malop.ValueMember = "Mã Lớp";
                //cbbox_malop.DisplayMember = "Tên Lớp";
                //cbbox_malop.DataSource = dataTable;
                cnn.Close();
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("OKE!");
            if (user is null)
            {
                this.state = 0;
                txt_user.Text = "Chưa đăng nhập";
            }
            else
            {
                this.state = 1;
                txt_user.Text = user;
                btn_login.Text = "Đăng Xuất";
                if (khoa.Equals("CNTT")){
                    connect = String.Format(@"Data Source=ERP-LOINH\MSSQLSERVER_CNTT;Initial Catalog=QLSV;User ID={0};Password={1}",user,pass);
                }else if (khoa.Equals("VT"))
                {
                   
                    connect = String.Format(@"Data Source=ERP-LOINH\MSSQLSERVER_VT;Initial Catalog=QLSV;User ID={0};Password={1}", user, pass);
                }
                else
                {
                    connect= String.Format(@"Data Source=ERP-LOINH;Initial Catalog=QLSV;User ID={0};Password={1}", "sa", "123");
                }
                load_Data();
            }
            
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            NhapDiem nhapDiem = new NhapDiem(connect);
            nhapDiem.malop = cbbox_malop.Text;
            nhapDiem.monhoc = tb_monhoc.Text;
            nhapDiem.lanthi = tb_lanthi.Text;
            nhapDiem.tenlop = tb_tenlop.Text;
            nhapDiem.Show();
        }
      

        private void cbbox_malop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int row = cbbox_malop.SelectedIndex;
            tb_tenlop.Text = tenlop[row];
        }

        private void btn_DsLop_Click(object sender, EventArgs e)
        {
            if (checkLogin()) {
                DsLop ds = new DsLop(connect);
                ds.FormClosed += delegate { load_Data(); };
                ds.ShowDialog();
              
                
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập");
            }
        }
           

        private bool checkLogin()
        {
            if (state == 1)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkLogin())
            {
                DSMonHoc dSMonHoc = new DSMonHoc(connect);
                dSMonHoc.Show();
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập");
            }

        }

        private void btn_dssv_Click(object sender, EventArgs e)
        {
            if (checkLogin())
            {
                DSSinhVien dSSinhVien = new DSSinhVien(connect);
                dSSinhVien.Show();
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập");
            }
        }

        private void btn_addSV_MH_Click(object sender, EventArgs e)
        {
            if (checkLogin())
            {
                AddMHforSV addMHforSV = new AddMHforSV(connect);
                addMHforSV.Show();
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập");
            }
        }
    }
}
