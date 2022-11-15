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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private dbDKHLDataContext db;
        public string tk;
        private void Main_Load(object sender, EventArgs e)
        {
            var signin = new DangNhap();
            signin.ShowDialog();
            tk = signin.taikhoan;
            db = new dbDKHLDataContext();
            var s = db.TaiKhoanDangNhaps.Where(c => c.TaiKhoan == tk).SingleOrDefault();
            if (s.Quyen == "admin")
            {
                groupInfo.Visible = false;
                btnKQHT.Visible = false;
                btnDKHP.Visible = false;
                groupInfo.Dock = DockStyle.None;
                this.Size = new Size(777, 304); 
            }
            else
            {
                btnQLGV.Visible = false;
                btnQLMH.Visible = false;
                btnQLSV.Visible = false;
                btnQLDKM.Visible = false;
                btnQLSV.Visible = false;
                btnQLD.Visible = false;
                btnQLL.Visible = false;

                var sv = db.SinhViens.SingleOrDefault(c => c.TaiKhoan == tk);
                dataMaSV.Text = sv.MaSV;
                HoTen.Text = sv.HoTen;
                Sex.Text = sv.GioiTinh;
                NgaySinh.Text = Convert.ToDateTime(sv.NgaySinh).ToString("dd/MM/yyyy");
                Lop.Text = (from a in db.SinhViens
                            join b in db.Lops
                            on a.MaSV equals b.MaSV
                            select b.MaLop ).FirstOrDefault(); ;
                DiaChi.Text = sv.DiaChi;
                Phone.Text = sv.DienThoai;
                Email.Text = sv.Email;

            }          
        }

        private void btnKQHT_Click(object sender, EventArgs e)
        {
            KetQuaHocTap f = new KetQuaHocTap();
            f.taikhoan = tk;
            f.ShowDialog();
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            DangKyHocPhan f = new DangKyHocPhan();
            f.taikhoan = tk;
            f.ShowDialog();
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            QuanLyGiangVien f = new QuanLyGiangVien();
            f.ShowDialog();
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            QuanLyMonHoc f = new QuanLyMonHoc();
            f.ShowDialog();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            QuanLySinhVien f = new QuanLySinhVien();
            f.ShowDialog();
        }

        private void btnQLDKM_Click(object sender, EventArgs e)
        {
            QuanLyDangKyMon f = new QuanLyDangKyMon();
            f.ShowDialog();
        }

        private void btnQLD_Click(object sender, EventArgs e)
        {
            QuanLyDiem f = new QuanLyDiem();
            f.ShowDialog();
        }

        private void btnQLL_Click(object sender, EventArgs e)
        {
            QuanLyLop f = new QuanLyLop();
            f.ShowDialog();
        }
    }
}
