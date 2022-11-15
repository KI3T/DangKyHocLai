using DangKyHocLai.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocLai
{
    public partial class QuanLyDiem : Form
    {
        public QuanLyDiem()
        {
            InitializeComponent();
        }

        private dbDKHLDataContext db;
        private DataGridViewRow r;
        private void Show()
        {
            db = new dbDKHLDataContext();
            DGV.DataSource = db.Diems.Select(c => c);
        }

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {
            Show();
            DGV.Columns["MaDiem"].HeaderText = "Mã điểm";
            DGV.Columns["MaMH"].HeaderText = "Mã môn học";
            DGV.Columns["MaGV"].HeaderText = "Mã giảng viên";
            DGV.Columns["MaSV"].HeaderText = "Mã sinh viên";
            DGV.Columns["DiemQT"].HeaderText = "Điểm quá trình";
            DGV.Columns["DiemThi"].HeaderText = "Điểm thi";
            groupInfor.Visible = false;
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = DGV.Rows[e.RowIndex];
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            groupInfor.Visible = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dataMaDM.Text))
            {
                MessageBox.Show("Mã kiểm soát không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataMaDM.Select();
                return;
            }
            else if (string.IsNullOrEmpty(dataMaMH.Text))
            {
                MessageBox.Show("Mã môn học không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataMaMH.Select();
                return;
            }
            else if (string.IsNullOrEmpty(dataMaGV.Text))
            {
                MessageBox.Show("Mã giảng viên không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataMaGV.Select();
                return;
            }
            else if (string.IsNullOrEmpty(dataMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataMaSV.Select();
                return;
            }

            Diem dm = new Diem();
            dm.MaDiem = dataMaDM.Text;
            dm.MaMH = dataMaMH.Text;
            dm.MaGV = dataMaGV.Text;
            dm.MaSV = dataMaSV.Text;
            dm.DiemQT = float.Parse(dataDiemQT.Text);
            dm.DiemThi = float.Parse(dataDiemThi.Text);
            db.Diems.InsertOnSubmit(dm);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show();
            dataMaDM.Text = dataMaMH.Text = dataMaGV.Text = dataMaSV.Text = dataDiemQT.Text = dataDiemThi.Text = null;
            groupInfor.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataMaDM.Text = dataMaMH.Text = dataMaGV.Text = dataMaSV.Text = dataDiemQT.Text = dataDiemThi.Text = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Môn học, Giảng viên, Sinh viên muốn sửa hoặc thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                db = new dbDKHLDataContext();
                var s = db.Diems.SingleOrDefault(p => p.MaDiem == DGV.SelectedCells[0].OwningRow.Cells["MaDiem"].Value.ToString());
                string id = DGV.SelectedCells[0].OwningRow.Cells["MaDiem"].Value.ToString();
                string mh = DGV.SelectedCells[0].OwningRow.Cells["MaMH"].Value.ToString();
                string gv = DGV.SelectedCells[0].OwningRow.Cells["MaGV"].Value.ToString();
                string sv = DGV.SelectedCells[0].OwningRow.Cells["MaSV"].Value.ToString();
                double QT = (double)DGV.SelectedCells[0].OwningRow.Cells["DiemQT"].Value;
                double Thi = (double)DGV.SelectedCells[0].OwningRow.Cells["DiemThi"].Value;
                if (s == null)
                {
                    MessageBox.Show("Xin vui lòng không sửa Mã điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Show();
                    return;
                }
                s.MaDiem = id;
                s.MaMH = mh;
                s.MaGV = gv;
                s.MaSV = sv;
                s.DiemQT = QT;
                s.DiemThi = Thi;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                r = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Phải chọn Môn học, Giảng viên, Sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Môn học, Giảng viên, Sinh viên muốn xóa hoặc thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var s = db.Diems.SingleOrDefault(p => p.MaDiem == DGV.SelectedCells[0].OwningRow.Cells["MaDiem"].Value.ToString());
                db.Diems.DeleteOnSubmit(s);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                r = null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            db = new dbDKHLDataContext();
            DGV.DataSource = db.Diems.Where(p => p.MaMH.Equals(dataFind.Text));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Show();
        }
    }
}
