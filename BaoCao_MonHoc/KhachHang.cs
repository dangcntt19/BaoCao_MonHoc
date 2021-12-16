using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace BaoCao_MonHoc
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            loadData();
            combo1();
        }
        khachhang kh = new khachhang();
        private void loadData()
        {
            DataQLDTDataContext db = new DataQLDTDataContext();
            var dskhachhang = db.khachhangs.ToList();
            gridControl1.DataSource = dskhachhang;
        }
        private void combo1()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PersonName", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                comboBoxEdit1.Properties.Items.Add(row["PersonName"]);
            }

            //ds comboedit1
            List<string> People = new List<string>();
            People.Add("Nam");
            People.Add("Nữ");

            comboBoxEdit1.Properties.Items.AddRange(People);
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá dòng đã chọn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gridView1.FocusedRowHandle;
                String col_name = "makh";
                object value = gridView1.GetRowCellValue(row_index, col_name);
                if (value != null)
                {
                    DataQLDTDataContext db = new DataQLDTDataContext();
                    var _khachhhang = db.khachhangs.Where(a => a.makh == value).SingleOrDefault();
                    if (_khachhhang != null)
                    {
                        db.khachhangs.DeleteOnSubmit(_khachhhang);
                        db.SubmitChanges();
                        XtraMessageBox.Show("Đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loadData();
                    }
                }
            }
        }
        private bool save()
        {
            String _makh = "";
            String _tenkh = "";
            String _gioitinh = "";
            DateTime _ngaysinh;
            String _diachi = "";
            String _sdt = "";
            String _cccd = "";
            if (textEdit2.EditValue != null)
            {
                _makh = textEdit2.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit2.Focus();
            }
            if (textEdit4.EditValue != null)
            {
                _tenkh = textEdit4.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit4.Focus();
            }
            if (comboBoxEdit1.EditValue != null)
            {
                _gioitinh = comboBoxEdit1.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                comboBoxEdit1.Focus();
            }
            if (dateEdit2.EditValue != null)
            {
                _ngaysinh = dateEdit2.DateTime.Date;
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                dateEdit2.Focus();
            }
            if (textEdit5.EditValue != null)
            {
                _diachi = textEdit5.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit5.Focus();
            }
            if (textEdit6.EditValue != null)
            {
                _sdt = textEdit6.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit6.Focus();
            }
            if (textEdit7.EditValue != null)
            {
                _cccd = textEdit7.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit7.Focus();
            }

            try
            {
                DataQLDTDataContext db = new DataQLDTDataContext();
                khachhang _khachhang = null;
                _khachhang = new khachhang();
                _khachhang.makh = _makh;
                _khachhang.hoten = _tenkh;
                _khachhang.gioitinh = _gioitinh;
                _khachhang.ngaysinh = _ngaysinh;
                _khachhang.sodt = _sdt;
                _khachhang.cccd = _cccd;

                db.khachhangs.InsertOnSubmit(_khachhang);
                db.SubmitChanges();
                XtraMessageBox.Show("Đã thêm thành công Khách hàng" + _makh, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DataQLDTDataContext db = new DataQLDTDataContext();

            kh.makh = textEdit2.Text;
            kh.hoten = textEdit4.Text;
            kh.gioitinh = comboBoxEdit1.Text;
            kh.ngaysinh = dateEdit2.DateTime.Date;
            kh.diachi = textEdit5.Text;
            kh.sodt = textEdit6.Text;
            kh.cccd = textEdit7.Text;
            db.khachhangs.InsertOnSubmit(kh);
            db.SubmitChanges();
            XtraMessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataQLDTDataContext db = new DataQLDTDataContext();

            kh = db.khachhangs.Where(s => s.makh == textEdit2.Text).Single();
            kh.makh = textEdit2.Text;
            kh.hoten = textEdit4.Text;
            kh.gioitinh = comboBoxEdit1.Text;
            kh.ngaysinh = dateEdit2.DateTime.Date;
            kh.diachi = textEdit5.Text;
            kh.sodt = textEdit6.Text;
            kh.cccd = textEdit7.Text;
            db.SubmitChanges();
            XtraMessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
    }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            textEdit2.Text = gridView1.GetFocusedRowCellValue("makh").ToString();
            textEdit4.Text = gridView1.GetFocusedRowCellValue("hoten").ToString();
            comboBoxEdit1.Text = gridView1.GetFocusedRowCellValue("gioitinh").ToString();
            dateEdit2.Text = gridView1.GetFocusedRowCellValue("ngaysinh").ToString();
            textEdit5.Text = gridView1.GetFocusedRowCellValue("diachi").ToString();
            textEdit6.Text = gridView1.GetFocusedRowCellValue("sodt").ToString();
            textEdit7.Text = gridView1.GetFocusedRowCellValue("cccd").ToString();


        }
    }
}