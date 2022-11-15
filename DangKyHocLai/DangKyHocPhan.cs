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
    public partial class DangKyHocPhan : Form
    {
        public DangKyHocPhan()
        {
            InitializeComponent();
        }
        private dbDKHLDataContext db;
        private DataGridViewRow r;
        public string taikhoan;

        private void Show()
        {
            // Load thông tin sinh viên
            db = new dbDKHLDataContext();
            var sv = db.SinhViens.SingleOrDefault(c => c.TaiKhoan == taikhoan);
            MaSV.Text = sv.MaSV;
            HoTen.Text = sv.HoTen;
            Lop.Text = (from a in db.SinhViens
                        join b in db.Lops
                        on a.MaSV equals b.MaSV
                        select b.MaLop).FirstOrDefault();


            db.SubmitChanges();
            // Load các môn có thể đăng ký
            DGV1.DataSource = from a in db.DSDangKies
                              from b in db.MonHocs
                              from c in db.GiangViens
                              where a.MaMH == b.MaMH
                              where a.MaGV == c.MaGV
                              select new
                              {
                                  a.MaMH,
                                  b.TenMH,
                                  a.MaGV,
                                  c.HoTen,
                              };
            DGV1.Columns["MaMH"].HeaderText = "Mã môn học";
            DGV1.Columns["TenMH"].HeaderText = "Tên môn học";
            DGV1.Columns["MaGV"].HeaderText = "Mã giảng viên";
            DGV1.Columns["HoTen"].HeaderText = "Giảng viên";


            // Load các môn không đạt
            DGV2.DataSource = from a in db.SinhViens
                              from b in db.Diems
                              from c in db.MonHocs
                              from d in db.GiangViens
                              where a.MaSV == b.MaSV
                              where b.MaMH == c.MaMH
                              where b.MaGV == d.MaGV
                              where Math.Round(Convert.ToDouble(b.DiemQT * 0.3 + b.DiemThi * 0.7), 2, MidpointRounding.AwayFromZero) <= 4
                              select new
                              {
                                  b.MaMH,
                                  c.TenMH,
                                  d.MaGV,
                                  d.HoTen,
                                  KQ = Math.Round(Convert.ToDouble(b.DiemQT * 0.3 + b.DiemThi * 0.7), 2, MidpointRounding.AwayFromZero)
                              };
            DGV2.Columns["MaMH"].HeaderText = "Mã môn học";
            DGV2.Columns["TenMH"].HeaderText = "Tên môn học";
            DGV2.Columns["MaGV"].HeaderText = "Mã giảng viên";
            DGV2.Columns["HoTen"].HeaderText = "Giảng viên";
            DGV2.Columns["KQ"].HeaderText = "Điểm tổng kết";


            // Load các môn đã đăng ký
            DGV3.DataSource = from a in db.DangKyMons
                              from b in db.MonHocs
                              from c in db.GiangViens
                              where a.MaSV == MaSV.Text && a.MaMH == b.MaMH && a.MaGV == c.MaGV
                              select new
                              {
                                  a.MaDK,
                                  a.MaMH,
                                  b.TenMH,
                                  c.HoTen,
                                  a.MaSV,
                                  date = a.NgayDK.ToString()
                              };
            DGV3.Columns["MaDK"].HeaderText = "Mã đăng ký";
            DGV3.Columns["MaMH"].HeaderText = "Mã môn học";
            DGV3.Columns["TenMH"].HeaderText = "Tên môn học";
            DGV3.Columns["HoTen"].HeaderText = "Giảng viên";
            DGV3.Columns["MaSV"].HeaderText = "Mã sinh viên";
            DGV3.Columns["date"].HeaderText = "Ngày đăng kí";
        }



        // Hàm main
        private void DangKyHocPhan_Load(object sender, EventArgs e)
        {
            Show();
        }



        // Nhập dữ liệu từ môn học có thể đăng ký
        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new dbDKHLDataContext();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV1.Rows[e.RowIndex];
                dataMaMH.Text = row.Cells[0].Value.ToString();
                dataTenMH.Text = row.Cells[1].Value.ToString();
                dataMaGV.Text = row.Cells[2].Value.ToString();
                dataGV.Text = row.Cells[3].Value.ToString();

                dataMaMH.Enabled = false;
                dataTenMH.Enabled = false;
                dataGV.Enabled = false;
                dataMaGV.Enabled = false;
            }    
        }



        // Nhập dữ liệu từ môn học không đạt
        private void DGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DGV2.Rows[e.RowIndex];
            dataMaMH.Text = row.Cells[0].Value.ToString();
            dataTenMH.Text = row.Cells[1].Value.ToString();
            dataMaGV.Text = row.Cells[2].Value.ToString();
            dataGV.Text = row.Cells[3].Value.ToString();

            dataMaMH.Enabled = false;
            dataTenMH.Enabled = false;
            dataGV.Enabled = false;
            dataMaGV.Enabled = false;
        }



        // Nút đăng ký
        private void btnDK_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra ô mã đăng kí có trống hay không
                if (dataMaDK.Text == "")
                {
                    MessageBox.Show("Xin nhập mã đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // Kiểm tra mã đăng kí có trùng hay không
                    var mdk = db.DangKyMons.Where(p => p.MaDK == dataMaDK.Text).Count();
                    if (mdk > 0)
                    {
                        MessageBox.Show("Mã đăng kí đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }    

                    // Thêm dữ liệu
                    DangKyMon dk = new DangKyMon();
                    dk.MaDK = dataMaDK.Text;
                    dk.MaMH = dataMaMH.Text.ToString();
                    dk.MaGV = dataMaGV.Text;
                    dk.MaSV = MaSV.Text;
                    dk.NgayDK = DateTime.Now;
                    db.DangKyMons.InsertOnSubmit(dk);
                    db.SubmitChanges();
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataMaDK.Text = null;
                    Show();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }



        // Nút hủy đăng ký
        private void btnHuyDK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy đăng ký môn này?",
                 "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var mdk = db.DangKyMons.SingleOrDefault(p => p.MaDK == DGV3.SelectedCells[0].OwningRow.Cells["MaDK"].Value.ToString());
                    db.DangKyMons.DeleteOnSubmit(mdk);
                    db.SubmitChanges();
                    MessageBox.Show("Hủy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    Show();
                }
            }
        }



        // Giải thích mã đăng kí
        private void llbTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Liên hệ quản trị viên của bạn để được cấp mã đăng ký, tuyệt đối không được nhập tùy tiện!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
