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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public string taikhoan = "";
        public string quyentk;
        private dbDKHLDataContext db;
        private void btDangNhap_Click(object sender, EventArgs e)
        {

            if (dataTK.Text == "" || dataMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                db = new dbDKHLDataContext();
                var v = (from s in db.TaiKhoanDangNhaps
                         where s.TaiKhoan == dataTK.Text
                         select s).FirstOrDefault();

                if (v == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản!");
                }
                else
                {
                    if (v.MatKhau == dataMK.Text)
                    {
                        taikhoan = dataTK.Text;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    }
                }
            }

        }

        private void lbX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llbTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sinh viên: sv - 123 " + "\n" + "Admin : ad - 123");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ người quản lý trường bạn để tạo tài khoản!");
        }

    }
}
