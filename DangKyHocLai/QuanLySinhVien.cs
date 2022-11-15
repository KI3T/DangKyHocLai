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
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }


        private dbDKHLDataContext db;
        private DataGridViewRow r;
        private void Show()
        {
            db = new dbDKHLDataContext();
            DGV.DataSource = db.SinhViens.Select(c => c);
        }
        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            Show();
            DGV.Columns["MaSV"].HeaderText = "Mã sinh viên";
            DGV.Columns["HoTen"].HeaderText = "Họ tên";
            DGV.Columns["GioiTinh"].HeaderText = "Giới tính";
            DGV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            DGV.Columns["DiaChi"].HeaderText = "Địa chỉ";
            DGV.Columns["DienThoai"].HeaderText = "Số điện thoại";
            DGV.Columns["Email"].HeaderText = "Email";
            DGV.Columns["TaiKhoan"].HeaderText = "Tài khoản";
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
            if (string.IsNullOrEmpty(dataMaSV.Text))
            {
                MessageBox.Show("Mã sinhh viên không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataMaSV.Select();
                return;
            }
            else if (string.IsNullOrEmpty(dataHoTen.Text))
            {
                MessageBox.Show("Tên sinh viên không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataHoTen.Select();
                return;
            }
            else if (string.IsNullOrEmpty(dataTK.Text))
            {
                MessageBox.Show("Tài khoản không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataSDT.Select();
                return;
            }
            else
            {
                var s = db.SinhViens.Where(p => p.MaSV == dataMaSV.Text).Count();
                if (s > 0)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataMaSV.Select();
                    return;
                }
            }

            TaiKhoanDangNhap tk = new TaiKhoanDangNhap();
            tk.TaiKhoan = dataTK.Text;
            tk.MatKhau = "123";
            tk.Quyen = "sinhvien";
            db.TaiKhoanDangNhaps.InsertOnSubmit(tk);

            SinhVien sv = new SinhVien();
            sv.MaSV = dataMaSV.Text;
            sv.HoTen = dataHoTen.Text;
            sv.GioiTinh = dataSex.Text;
            sv.NgaySinh = dataNgSinh.Value;
            sv.DiaChi = dataDiaChi.Text;
            sv.DienThoai = dataSDT.Text;
            sv.Email = dataEmail.Text;
            sv.TaiKhoan = dataTK.Text;
            db.SinhViens.InsertOnSubmit(sv);

            db.SubmitChanges();
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show();
            dataMaSV.Text = dataHoTen.Text = dataSex.Text = dataDiaChi.Text = dataSDT.Text = dataEmail.Text =
                dataTK.Text  = null;
            groupInfor.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataMaSV.Text = dataHoTen.Text = dataSex.Text = dataDiaChi.Text = dataSDT.Text = dataEmail.Text =
                dataTK.Text  = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Sinh viên muốn sửa hoặc thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Tài khoản là mặc định sẽ không bị thay đổi", "LƯU Ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                db = new dbDKHLDataContext();
                var s = db.SinhViens.SingleOrDefault(p => p.MaSV == DGV.SelectedCells[0].OwningRow.Cells["MaSV"].Value.ToString());
                string id = DGV.SelectedCells[0].OwningRow.Cells["MaSV"].Value.ToString();
                string name = DGV.SelectedCells[0].OwningRow.Cells["HoTen"].Value.ToString();
                string sex = DGV.SelectedCells[0].OwningRow.Cells["GioiTinh"].Value.ToString();
                DateTime? ngsinh = DGV.SelectedCells[0].OwningRow.Cells["NgaySinh"].Value == null ?
                null : (DateTime?)DGV.SelectedCells[0].OwningRow.Cells["NgaySinh"].Value;
                string diachi = DGV.SelectedCells[0].OwningRow.Cells["DiaChi"].Value.ToString();
                string phone = DGV.SelectedCells[0].OwningRow.Cells["DienThoai"].Value.ToString();
                string email = DGV.SelectedCells[0].OwningRow.Cells["Email"].Value.ToString();
                if (s == null)
                {
                    MessageBox.Show("Xin vui lòng không sửa Mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Show();
                    return;
                }
                s.MaSV = id;
                s.HoTen = name;
                s.GioiTinh = sex;
                s.NgaySinh = ngsinh;
                s.DiaChi = diachi;
                s.DienThoai = phone;
                s.Email = email;
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                r = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã sinh viên không thể sửa hoặc phải chọn sinhh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Sinh viên muốn xóa hoặc thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var s = db.SinhViens.SingleOrDefault(p => p.MaSV == DGV.SelectedCells[0].OwningRow.Cells["MaSV"].Value.ToString());
                var z = db.DangKyMons.Where(p => p.MaSV == DGV.SelectedCells[0].OwningRow.Cells["MaSV"].Value.ToString()).ToList();
                var x = db.TaiKhoanDangNhaps.Where(p => p.TaiKhoan == DGV.SelectedCells[0].OwningRow.Cells["TaiKhoan"].Value.ToString()).ToList();
                foreach (var i in z)
                {
                    db.DangKyMons.DeleteOnSubmit(i);
                }
                foreach (var i in x)
                {
                    db.TaiKhoanDangNhaps.DeleteOnSubmit(i);
                }
                db.SinhViens.DeleteOnSubmit(s);
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
            DGV.DataSource = db.SinhViens.Where(p => p.MaSV.Equals(dataFind.Text));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Show();
        }
    }
}
