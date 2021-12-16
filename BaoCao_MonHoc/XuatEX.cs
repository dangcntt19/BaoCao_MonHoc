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
    public partial class XuatEX : Form
    {
        public XuatEX()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f = new Form2();
            f.Show();

        }
    }
}
