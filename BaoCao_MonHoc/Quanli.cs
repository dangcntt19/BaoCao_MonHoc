using DevExpress.XtraBars;
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
    public partial class Quanli : DevExpress.XtraEditors.XtraForm
    {
        public Quanli()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private Form KiemTraForm (Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType) //neus form ddc truyen vai da dc mo
                {
                    return f;
                }
            }return null;
        }

      

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraForm(typeof(Nhanvien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Nhanvien f = new Nhanvien();
                f.MdiParent = this;
                f.Show();
            }
        }

      

       

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraForm(typeof(KhachHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                KhachHang f = new KhachHang();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            RB_chung f = new RB_chung();
            f.ShowDialog();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            
                XuatEX f = new XuatEX();
                
                f.Show();
            
        }

        private void btndangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            DangNhap r = new DangNhap();
            r.ShowDialog();
        
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult kq = MessageBox.Show("BẠN MUỐN THOÁT RA?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (kq == DialogResult.OK)
              
            Application.Exit();
        }
    }
}