using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_MonHoc
{
    public partial class Rp_NV : Form
    {
        public Rp_NV()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Rp_NV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLy_DienThoaiDataSet.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.QuanLy_DienThoaiDataSet.nhanvien);

            this.reportViewer1.RefreshReport();
        }

       

       
    }
}
