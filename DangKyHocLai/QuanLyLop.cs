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
    public partial class QuanLyLop : Form
    {
        public QuanLyLop()
        {
            InitializeComponent();
        }

        private dbDKHLDataContext db;
        private DataGridViewRow r;
        private void Show()
        {
            db = new dbDKHLDataContext();
            DGV.DataSource = db.Lops.Select(c => c);
        }

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            Show();
            DGV.Columns["MaKiemSoat"].HeaderText = "Mã Kiểm Soat";
            DGV.Columns["MaLop"].HeaderText = "Mã lớp";
            DGV.Columns["MaSV"].HeaderText = "Mã sinh viên";
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
            else if (string.IsNullOrEmpty(dataMaLop.Text))
            {
                MessageBox.Show("Mã lớp không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataMaLop.Select();
                return;
            }
            else if (string.IsNullOrEmpty(dataMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên không thể trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataMaSV.Select();
                return;
            }
            else
            {
                var z = db.Lops.Where(p => p.MaSV == dataMaSV.Text).Count();
                if (z > 0)
                {
                    MessageBox.Show("Sinh viên này đã có lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataMaSV.Select();
                    return;
                }

                Lop lp = new Lop();
                lp.MaKiemSoat = dataMaKS.Text;
                lp.MaLop = dataMaLop.Text;
                lp.MaSV = dataMaSV.Text;
                db.Lops.InsertOnSubmit(lp);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Show();
                dataMaKS.Text = dataMaLop.Text = dataMaSV.Text = null;
                groupInfor.Visible = false;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataMaKS.Text = dataMaLop.Text = dataMaSV.Text = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Lớp, Sinh viên muốn xóa hoặc thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var s = db.Lops.SingleOrDefault(p => p.MaKiemSoat == DGV.SelectedCells[0].OwningRow.Cells["MaKiemSoat"].Value.ToString());
                db.Lops.DeleteOnSubmit(s);
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
            DGV.DataSource = db.Lops.Where(p => p.MaLop.Equals(dataFind.Text));
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Show();
        }
    }
}
