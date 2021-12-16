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
    public partial class DienThoai : Form
    {
        public DienThoai()
        {
            InitializeComponent();
            loadData();
            combo1();
        }
        private void combo1()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PersonName", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                comboBoxEdit2.Properties.Items.Add(row["PersonName"]);
            }

            //ds comboedit1
            List<string> People = new List<string>();
            People.Add("Nam");
            People.Add("Nữ");
           
            comboBoxEdit2.Properties.Items.AddRange(People);
        }
        private void loadData()
        {
            DataQLDTDataContext db = new DataQLDTDataContext();
            var dskhachhang = db.khachhangs.ToList();
            gridControl1.DataSource = dskhachhang;
        }
        private bool save()
        {
            String _makh = "";
            String _tenkh = "";
            String _gioitinh ="";
            DateTime _ngaysinh;
            String _diachi = "";
            String _sdt = "";
            String _cccd = "";
            if (textEdit5.EditValue != null)
            {
                _makh = textEdit5.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit5.Focus();
            }
            if (textEdit1.EditValue != null)
            {
                _tenkh = textEdit1.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit1.Focus();
            }
            if(comboBoxEdit2.EditValue != null)
            {
                _gioitinh = comboBoxEdit2.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                comboBoxEdit2.Focus();
            }
            if (dateEdit1.EditValue != null)
            {
                _ngaysinh = dateEdit1.DateTime.Date;
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                dateEdit1.Focus();
            }
            if (textEdit2.EditValue != null)
            {
                _diachi = textEdit2.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit2.Focus();
            }
            if (textEdit3.EditValue != null)
            {
                _sdt = textEdit3.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit3.Focus();
            }
            if (textEdit4.EditValue != null)
            {
                _cccd = textEdit4.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit4.Focus();
            }
            
            try
            {
                DataQLDTDataContext db = new DataQLDTDataContext();
                khachhang _kh = null;
                _kh = new khachhang();
                _kh.makh = _makh;
                _kh.hoten = _tenkh;
                _kh.gioitinh = _gioitinh;
                _kh.ngaysinh = _ngaysinh;
                _kh.sodt = _sdt;
                _kh.cccd = _cccd;
                
                db.khachhangs.InsertOnSubmit(_kh);
                db.SubmitChanges();
                loadData();
                XtraMessageBox.Show("Đã thêm thành công Khách hàng" + _makh, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            save();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
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
                else
                {
                    XtraMessageBox.Show("Bạn có chắc chắn muốn xoá dòng đã chọn không?", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DienThoai_Load(object sender, EventArgs e)
        {

        }
    }
}
