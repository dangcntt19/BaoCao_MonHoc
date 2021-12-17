using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BaoCao_MonHoc
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
           CenterToScreen();
            //CenterToParent();
           InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DangNguyen;Initial Catalog = QuanLy_DienThoai; Integrated Security=True");
            try
            {
                con.Open();
                string tk = textBox1.Text;
                string mk = textBox2.Text;
                string sql = "select * from TKQUANTRI where Username ='"+tk+ "' and Pass ='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader da = cmd.ExecuteReader();
                if(da.Read()== true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    DN f = new DN();
                    f.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("đăng nhập thất bại");
                }
            }catch(Exception ex)
            { MessageBox.Show("lỗi kết nối");
            }
         }

        
    }
}
