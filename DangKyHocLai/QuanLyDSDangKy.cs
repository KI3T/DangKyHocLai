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
    public partial class QuanLyDangKyMon : Form
    {
        public QuanLyDangKyMon()
        {
            InitializeComponent();
        }

        private dbDKHLDataContext db;
        private DataGridViewRow r;
        private void Show()
        {
            db = new dbDKHLDataContext();
            DGV.DataSource = db.DSDangKies.Select(c => c);
        }

        private void QuanLyDangKyMon_Load(object sender, EventArgs e)
        {
            Show();
            DGV.Columns["MaKiemSoat"].HeaderText = "Mã Kiểm Soat";
            DGV.Columns["MaMH"].HeaderText = "Mã môn học";
            DGV.Columns["MaGV"].HeaderText = "Mã giảng viên";
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
            if (string.IsNullOrEmpty(dataMaKS.Text))
            {
                MessageBox.Show("Mã kiểm soát không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataMaKS.Select();
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

            DSDangKy dsdk = new DSDangKy();
            dsdk.MaKiemSoat = dataMaKS.Text;
            dsdk.MaMH = dataMaMH.Text;
            dsdk.MaGV = dataMaGV.Text;
            db.DSDangKies.InsertOnSubmit(dsdk);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show();
            dataMaKS.Text = dataMaMH.Text = dataMaGV.Text = null;
            groupInfor.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataMaKS.Text = dataMaMH.Text = dataMaGV.Text = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Môn học, Giảng viên muốn xóa hoặc thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var s = db.DSDangKies.SingleOrDefault(p => p.MaKiemSoat == DGV.SelectedCells[0].OwningRow.Cells["MaKiemSoat"].Value.ToString());
                db.DSDangKies.DeleteOnSubmit(s);
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
            DGV.DataSource = db.DSDangKies.Where(p => p.MaMH.Equals(dataFind.Text));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Show();
        }

    }
}
