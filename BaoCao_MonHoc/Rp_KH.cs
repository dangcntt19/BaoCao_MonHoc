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
    public partial class Rp_KH : Form
    {
        public Rp_KH()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Rp_KH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLy_DienThoaiDataSet.khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.QuanLy_DienThoaiDataSet.khachhang);

            this.reportViewer1.RefreshReport();
        }

       
    }
}
