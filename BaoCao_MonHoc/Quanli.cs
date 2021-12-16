﻿using DevExpress.XtraBars;
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

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTraForm(typeof(DienThoai));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                DienThoai f1 = new DienThoai();
                f1.MdiParent = this;
                f1.Show();
            }
        }
    }
}