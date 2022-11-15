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
    public partial class QuanLyGiangVien : Form
    {
        public QuanLyGiangVien()
        {
            InitializeComponent();
        }

        private dbDKHLDataContext db;
        private DataGridViewRow r;
        private void Show()
        {
            db = new dbDKHLDataContext();
            DGV.DataSource = db.GiangViens.Select(c => c);
        }

        private void QuanLyGiangVien_Load(object sender, EventArgs e)
        {
            Show();
            DGV.Columns["MaGV"].HeaderText = "Mã giảng viên";
            DGV.Columns["HoTen"].HeaderText = "Họ tên";
            DGV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            DGV.Columns["GioiTinh"].HeaderText = "Giới tính";
            DGV.Columns["DienThoai"].HeaderText = "Số điện thoại";
            DGV.Columns["Email"].HeaderText = "Email";
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
            if (string.IsNullOrEmpty(dataMaGV.Text))
            {
                MessageBox.Show("Mã giảng viên không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataMaGV.Select();
                return;
            }
            else if (string.IsNullOrEmpty(dataHoTen.Text))
            {
                MessageBox.Show("Tên giảng viên không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataHoTen.Select();
                return;
            }
            else if (string.IsNullOrEmpty(dataSDT.Text))
            {
                MessageBox.Show("Số điện thoại không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataSDT.Select();
                return;
            }
            else if (string.IsNullOrEmpty(dataEmail.Text))
            {
                MessageBox.Show("Email không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataEmail.Select();
                return;
            }
            else
            {
                var s = db.GiangViens.Where(p => p.MaGV == dataMaGV.Text).Count();
                if (s>0)
                {
                    MessageBox.Show("Mã giảng viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataMaGV.Select();
                    return;
                }    
            }

            GiangVien gv = new GiangVien();
            gv.MaGV = dataMaGV.Text;
            gv.HoTen = dataHoTen.Text;
            gv.NgaySinh = dataNgSinh.Value;
            gv.GioiTinh = dataSex.Text;
            gv.DienThoai = dataSDT.Text;
            gv.Email = dataEmail.Text;
            db.GiangViens.InsertOnSubmit(gv);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show();
            dataMaGV.Text = dataHoTen.Text = dataSex.Text = dataSDT.Text = dataEmail.Text = null;
            groupInfor.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataMaGV.Text = dataHoTen.Text = dataSex.Text = dataSDT.Text = dataEmail.Text = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Giảng viên muốn sửa hoặc thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                db = new dbDKHLDataContext();
                var s = db.GiangViens.SingleOrDefault(p => p.MaGV == DGV.SelectedCells[0].OwningRow.Cells["MaGV"].Value.ToString());
                string id = DGV.SelectedCells[0].OwningRow.Cells["MaGV"].Value.ToString();
                string name = DGV.SelectedCells[0].OwningRow.Cells["HoTen"].Value.ToString();
                DateTime? ngsinh = DGV.SelectedCells[0].OwningRow.Cells["NgaySinh"].Value == null ?
                null : (DateTime?)DGV.SelectedCells[0].OwningRow.Cells["NgaySinh"].Value;
                string sex = DGV.SelectedCells[0].OwningRow.Cells["GioiTinh"].Value.ToString();
                string phone = DGV.SelectedCells[0].OwningRow.Cells["DienThoai"].Value.ToString();
                string email = DGV.SelectedCells[0].OwningRow.Cells["Email"].Value.ToString();
                if (s == null)
                {
                    MessageBox.Show("Xin vui lòng không sửa Mã giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Show();
                    return;
                }    
                s.MaGV = id;
                s.HoTen = name;
                s.NgaySinh = ngsinh;
                s.GioiTinh = sex;
                s.DienThoai = phone;
                s.Email = email;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                r = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phải chọn Giảng viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Giảng viên muốn xóa hoặc thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var s = db.GiangViens.SingleOrDefault(p => p.MaGV == DGV.SelectedCells[0].OwningRow.Cells["MaGV"].Value.ToString());
                db.GiangViens.DeleteOnSubmit(s);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                r = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Giảng viên này có lịch dạy không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            db = new dbDKHLDataContext();
            DGV.DataSource = db.GiangViens.Where(p => p.MaGV.Equals(dataFind.Text));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Show();
        }

    }
}
