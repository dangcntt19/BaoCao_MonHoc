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

namespace BaoCao_MonHoc
{
    public partial class DN : Form
    {
        public DN()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void DN_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                this.Hide();
            }
            
            Quanli f = new Quanli();
            f.ShowDialog();
            this.Hide();
            
        }
    }
}
