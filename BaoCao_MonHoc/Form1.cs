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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }


        DataSet Data = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            string connstr = @"Data Source=DangNguyen;Initial Catalog = QuanLy_DienThoai; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            Loadsql();

            string strsp = "Select * from nhanvien";
            DataSet datasp = new DataSet(" nv");
            SqlDataAdapter adapsp = new SqlDataAdapter(strsp, conn);
            adapsp.Fill(datasp, "nv");// TODO: This line of code loads data into the 'quanLy_DienThoaiDataSet1.khachhang' table. You can move, or remove it, as needed.
          
        }
        private void Loadsql()
        {
            string connstr = @"Data Source=DangNguyen;Initial Catalog = QuanLy_DienThoai; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            //Load dữ liệu vào lưới
            string strcommand = "SELECT * FROM nhanvien";
            // DataSet Data = new DataSet("nhanvienquan");
            SqlDataAdapter readwrite = new
            SqlDataAdapter(strcommand, conn);
            readwrite.Fill(Data, "nhanvien");
            dataGridView1.DataSource = Data.Tables["nhanvien"];
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
             string connstr = @"Data Source=DangNguyen;Initial Catalog = QuanLy_DienThoai; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            //Loadsql();

            exClass1 excel = new exClass1();
            DataTable dt = Data.Tables[0];
            // xuatEX.ReferenceEquals(dt, "danhsa")
            excel.Export(dt, "danh sach ", "Danh sách nhân viên");
            conn.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            XuatEX f = new XuatEX();
            f.ShowDialog();
        }
    }
}
