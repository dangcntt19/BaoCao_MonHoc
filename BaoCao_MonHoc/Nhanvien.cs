using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_MonHoc
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

       
        private void Nhanvien_Load(object sender, EventArgs e)
        {
            loadData();
            combo1();
            combo2();
        }
        nhanvien nv = new nhanvien();
      private string manv;
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
           // People.Add("Giới tính khác");
            comboBoxEdit1.Properties.Items.AddRange(People);
        }
        private void combo2()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("bangcap", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                comboBoxEdit2.Properties.Items.Add(row["bangcap"]);
            }

            //ds comboedit2
            List<string> BC = new List<string>();
            BC.Add("BC001");
            BC.Add("BC002");
            BC.Add("BC003");
            BC.Add("BC004");
            comboBoxEdit2.Properties.Items.AddRange(BC);
        }
        private void update()
        {
            DataQLDTDataContext db = new DataQLDTDataContext();
            var dsnhanvien = db.nhanviens.Where(a => a.manv == manv).SingleOrDefault();
            if(dsnhanvien != null)
            {
                textEdit1.Text = dsnhanvien.manv;
                textEdit2.EditValue = dsnhanvien.hotennv;
                comboBoxEdit1.EditValue = dsnhanvien.gioitinh;
                textEdit3.EditValue = dsnhanvien.quequan;
                dateEdit1.EditValue = dsnhanvien.ngaysinh;
                dateEdit2.EditValue = dsnhanvien.ngayvaolam;
                textEdit4.EditValue = dsnhanvien.cccd;
                comboBoxEdit2.EditValue = dsnhanvien.bangcap;
            }
        }
        private void loadData()
        {
            DataQLDTDataContext db = new DataQLDTDataContext();
            var dsnhanvien = db.nhanviens.ToList();
            gridControl1.DataSource = dsnhanvien;
        }
        private bool save()
        {
            String _manv = "";
            String _tennv = "";
            String _gioitinh = "";
            String _quequan = "";
            DateTime _ngaysinh;
            DateTime _ngayvl ;
            String _cccd = "";
            String _mabc = "";
            if (textEdit1.EditValue != null)
            {
                _manv = textEdit1.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit1.Focus();
            }
            if (textEdit2.EditValue != null)
            {
                _tennv = textEdit2.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit2.Focus();
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
            if (textEdit3.EditValue != null)
            {
                _quequan   = textEdit3.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                textEdit3.Focus();
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
            if (dateEdit2.EditValue != null)
            {
                _ngayvl = dateEdit2.DateTime.Date;
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                dateEdit2.Focus();
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
            if (comboBoxEdit2.EditValue != null)
            {
                _mabc = comboBoxEdit2.EditValue.ToString();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                comboBoxEdit2.Focus();
            }
            try
            {
                DataQLDTDataContext db = new DataQLDTDataContext();
                nhanvien _nv = null;
                _nv = new nhanvien();
                _nv.manv = _manv;
                _nv.hotennv = _tennv;
                _nv.gioitinh = _gioitinh;
                _nv.quequan = _quequan;
                _nv.ngaysinh = _ngaysinh;
                _nv.ngayvaolam = _ngayvl;
                _nv.cccd = _cccd;
                _nv.mabc = _mabc;
                db.nhanviens.InsertOnSubmit(_nv);
                db.SubmitChanges();
                loadData();
                XtraMessageBox.Show("Đã thêm thành công nhân viên" + _manv, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
      
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá dòng đã chọn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gridView1.FocusedRowHandle;
                String col_name = "manv";
                object value = gridView1.GetRowCellValue(row_index, col_name);
                if (value != null)
                {
                    DataQLDTDataContext db = new DataQLDTDataContext();
                    var _nhanvien = db.nhanviens.Where(a => a.manv == value).SingleOrDefault();
                    if(_nhanvien != null)
                    {
                        db.nhanviens.DeleteOnSubmit(_nhanvien);
                        db.SubmitChanges();
                        XtraMessageBox.Show("Đã xoá thành công", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                        loadData();
                    }
                    
                }
                else
                {
                    XtraMessageBox.Show("Bạn có chắc chắn muốn xoá dòng đã chọn không?", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            save();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            DataQLDTDataContext db = new DataQLDTDataContext();

            nv = db.nhanviens.Where(s => s.manv == textEdit1.Text).Single();
            nv.manv = textEdit1.Text;
            nv.hotennv = textEdit2.Text;
            nv.gioitinh = comboBoxEdit1.Text;
            nv.quequan = textEdit3.Text;
            nv.ngaysinh = dateEdit1.DateTime.Date;
            nv.ngayvaolam = dateEdit2.DateTime.Date;
            nv.cccd = textEdit4.Text;
            nv.mabc = comboBoxEdit2.Text;
            db.SubmitChanges();
            XtraMessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
        }

       

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string s = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "manv").ToString();
            string s1 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "hotennv").ToString();
            string s2 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "gioitinh").ToString(); //lấy chuỗi ra Chỗi "masv" là cell , có thể thay đổi
            string s3= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "quequan").ToString();
            string s4 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ngaysinh").ToString();
            string s5= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ngayvaolam").ToString();
            string s6 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "cccd").ToString();
            string s7 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "mabc").ToString();
            textEdit1.Text = s;
            textEdit2.Text = s1;
            comboBoxEdit1.Text = s2;
            textEdit3.Text = s3;
            dateEdit1.Text = s4;
            dateEdit2.Text = s5;
            textEdit4.Text = s6;
            comboBoxEdit2.Text = s7;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
           // textEdit1 = " ";
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}