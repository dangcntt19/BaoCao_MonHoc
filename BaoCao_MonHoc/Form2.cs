using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace BaoCao_MonHoc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CenterToScreen();
        }
        DataSet Data = new DataSet();
      
        private void Loadsql()
        {
            string connstr = @"Data Source=DangNguyen;Initial Catalog = QuanLy_DienThoai; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            //Load dữ liệu vào lưới
            string strcommand = "SELECT * FROM khachhang";
            // DataSet Data = new DataSet("nhanvienquan");
            SqlDataAdapter readwrite = new
            SqlDataAdapter(strcommand, conn);
            readwrite.Fill(Data, "khachhang");
            dataGridView1.DataSource = Data.Tables["khachhang"];
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string connstr = @"Data Source=DangNguyen;Initial Catalog = QuanLy_DienThoai; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            //Loadsql();

            EX_kh excel = new EX_kh();
            DataTable dt = Data.Tables[0];
            // xuatEX.ReferenceEquals(dt, "danhsa")
            excel.Export(dt, "danh sach ", "Danh sách khách hàng");
            conn.Close();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            string connstr = @"Data Source=DangNguyen;Initial Catalog = QuanLy_DienThoai; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            Loadsql();

            string strsp = "Select * from khachhang";
            DataSet datasp = new DataSet(" kh");
            SqlDataAdapter adapsp = new SqlDataAdapter(strsp, conn);
            adapsp.Fill(datasp, "kh");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("BẠN MUỐN THOÁT RA?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (kq == DialogResult.OK)
                Close();
        }
    }
}
