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
    public partial class QuanLyMonHoc : Form
    {
        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        private dbDKHLDataContext db;
        private DataGridViewRow r;
        private void Show()
        {
            db = new dbDKHLDataContext();
            DGV.DataSource = db.MonHocs.Select(c => c);
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            Show();
            DGV.Columns["MaMH"].HeaderText = "Mã môn học";
            DGV.Columns["TenMH"].HeaderText = "Tên môn học";
            DGV.Columns["TinChi"].HeaderText = "Tín chỉ";
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
            if (string.IsNullOrEmpty(dataMaMH.Text))
            {
                MessageBox.Show("Mã môn học không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataMaMH.Select();
                return;
            }
            else if (string.IsNullOrEmpty(dataTenMH.Text))
            {
                MessageBox.Show("Tên môn học không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataTenMH.Select();
                return;
            }
            else if (string.IsNullOrEmpty(dataTinChi.Text))
            {
                MessageBox.Show("Tín chỉ không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataTinChi.Select();
                return;
            }
            else
            {
                var s = db.MonHocs.Where(p => p.MaMH == dataMaMH.Text).Count();
                if (s > 0)
                {
                    MessageBox.Show("Mã môn học đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataMaMH.Select();
                    return;
                }
            }

            MonHoc mh = new MonHoc();
            mh.MaMH = dataMaMH.Text;
            mh.TenMH = dataTenMH.Text;
            mh.TinChi = Convert.ToInt32(dataTinChi.Text);
            db.MonHocs.InsertOnSubmit(mh);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show();
            dataMaMH.Text = dataTenMH.Text = dataTinChi.Text = null;
            groupInfor.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataMaMH.Text = dataTenMH.Text = dataTinChi.Text = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Môn học muốn sửa hoặc thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                db = new dbDKHLDataContext();
                var s = db.MonHocs.SingleOrDefault(p => p.MaMH == DGV.SelectedCells[0].OwningRow.Cells["MaMH"].Value.ToString());
                string id = DGV.SelectedCells[0].OwningRow.Cells["MaMH"].Value.ToString();
                string name = DGV.SelectedCells[0].OwningRow.Cells["TenMH"].Value.ToString();
                int tc = (int)DGV.SelectedCells[0].OwningRow.Cells["TinChi"].Value;
                if (s == null)
                {
                    MessageBox.Show("Xin vui lòng không sửa Mã môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Show();
                    return;
                }
                s.MaMH = id;
                s.TenMH = name;
                s.TinChi = tc;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                r = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phải chọn môn học để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn môn học muốn xóa hoặc thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Xóa môn học sẽ ảnh hưởng đến bảng đăng ký môn và điểm", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            try
            {
                var s = db.MonHocs.SingleOrDefault(p => p.MaMH == DGV.SelectedCells[0].OwningRow.Cells["MaMH"].Value.ToString());
                var dkm = db.DangKyMons.Where(p => p.MaMH == DGV.SelectedCells[0].OwningRow.Cells["MaMH"].Value.ToString()).ToList();
                var diem = db.Diems.Where(p => p.MaMH == DGV.SelectedCells[0].OwningRow.Cells["MaMH"].Value.ToString()).ToList();
                foreach (var i in dkm)
                {
                    db.DangKyMons.DeleteOnSubmit(i);
                }
                foreach (var i in diem)
                {
                    db.Diems.DeleteOnSubmit(i);
                }
                db.MonHocs.DeleteOnSubmit(s);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                r = null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            db = new dbDKHLDataContext();
            DGV.DataSource = db.MonHocs.Where(p => p.MaMH.Equals(dataFind.Text));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Show();
        }
    }
}
