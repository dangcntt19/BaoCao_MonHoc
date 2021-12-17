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
    public partial class RB_chung : Form
    {
        public RB_chung()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rp_NV nv = new Rp_NV();
            nv.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rp_KH kh = new Rp_KH();
            kh.Show();
        }
    }
}
