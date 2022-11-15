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
    public partial class KetQuaHocTap : Form
    {
        public KetQuaHocTap()
        {
            InitializeComponent();
        }

        private dbDKHLDataContext db;
        public string taikhoan;
        private void KetQuaHocTap_Load(object sender, EventArgs e)
        {
            db = new dbDKHLDataContext();
            DGV.DataSource = from a in db.SinhViens
                             from b in db.Diems
                             from c in db.MonHocs
                             where a.MaSV == b.MaSV
                             where b.MaMH == c.MaMH
                             select new
                             {
                                 b.MaMH,
                                 c.TenMH,
                                 b.DiemQT,
                                 b.DiemThi,
                                 KQ = Math.Round( Convert.ToDouble(b.DiemQT * 0.3 + b.DiemThi * 0.7), 2, MidpointRounding.AwayFromZero)
                                 // Math.Round(phép tính, số sau dấu phẩy) -- Phép tính trên xem như kiểu Boolean nên cần chuyển sang dạng double để có thể làm tròn -- phép tính trên sql nên vế cuối bắt buộc, ko sẽ lỗi
                             };

            DGV.Columns["MaMH"].HeaderText = "Mã môn học";
            DGV.Columns["TenMH"].HeaderText = "Tên môn học";
            DGV.Columns["DiemQT"].HeaderText = "Điểm quá trình";
            DGV.Columns["DiemThi"].HeaderText = "Điểm thi";
            DGV.Columns["KQ"].HeaderText = "Điểm tổng kết";
        }
    }
}
