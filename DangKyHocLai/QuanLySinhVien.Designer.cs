
namespace DangKyHocLai
{
    partial class QuanLySinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFind = new System.Windows.Forms.Button();
            this.groupTool = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.dataFind = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataNgSinh = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dataEmail = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.dataDiaChi = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.dataSex = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.Label();
            this.txtNgSinh = new System.Windows.Forms.Label();
            this.dataHoTen = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.dataMaSV = new System.Windows.Forms.TextBox();
            this.groupInfor = new System.Windows.Forms.GroupBox();
            this.dataTK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.Label();
            this.dataSDT = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.Label();
            this.groupDS = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupTool.SuspendLayout();
            this.groupInfor.SuspendLayout();
            this.groupDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFind.Location = new System.Drawing.Point(944, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 27);
            this.btnFind.TabIndex = 45;
            this.btnFind.Text = "Tìm mã sinh viên";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // groupTool
            // 
            this.groupTool.Controls.Add(this.btnXem);
            this.groupTool.Controls.Add(this.btnFind);
            this.groupTool.Controls.Add(this.dataFind);
            this.groupTool.Controls.Add(this.btnSua);
            this.groupTool.Controls.Add(this.btnXoa);
            this.groupTool.Controls.Add(this.btnThem);
            this.groupTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTool.Location = new System.Drawing.Point(0, 370);
            this.groupTool.Name = "groupTool";
            this.groupTool.Size = new System.Drawing.Size(1124, 53);
            this.groupTool.TabIndex = 12;
            this.groupTool.TabStop = false;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXem.Location = new System.Drawing.Point(36, 15);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(150, 27);
            this.btnXem.TabIndex = 46;
            this.btnXem.Text = "Xem danh sách";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dataFind
            // 
            this.dataFind.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataFind.Location = new System.Drawing.Point(758, 18);
            this.dataFind.Name = "dataFind";
            this.dataFind.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataFind.Size = new System.Drawing.Size(170, 23);
            this.dataFind.TabIndex = 44;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(382, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 27);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(555, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 27);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(209, 15);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 27);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataNgSinh
            // 
            this.dataNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNgSinh.Location = new System.Drawing.Point(598, 28);
            this.dataNgSinh.Name = "dataNgSinh";
            this.dataNgSinh.Size = new System.Drawing.Size(170, 26);
            this.dataNgSinh.TabIndex = 48;
            this.dataNgSinh.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClear.Location = new System.Drawing.Point(987, 68);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 27);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Làm sạch";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan.Location = new System.Drawing.Point(987, 28);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(119, 27);
            this.btnXacNhan.TabIndex = 46;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dataEmail
            // 
            this.dataEmail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataEmail.Location = new System.Drawing.Point(213, 76);
            this.dataEmail.Name = "dataEmail";
            this.dataEmail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataEmail.Size = new System.Drawing.Size(170, 23);
            this.dataEmail.TabIndex = 43;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtEmail.Location = new System.Drawing.Point(210, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(42, 16);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.Text = "Email:";
            // 
            // dataDiaChi
            // 
            this.dataDiaChi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataDiaChi.Location = new System.Drawing.Point(791, 31);
            this.dataDiaChi.Name = "dataDiaChi";
            this.dataDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataDiaChi.Size = new System.Drawing.Size(170, 23);
            this.dataDiaChi.TabIndex = 41;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtDiaChi.Location = new System.Drawing.Point(788, 12);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(51, 16);
            this.txtDiaChi.TabIndex = 40;
            this.txtDiaChi.Text = "Địa chỉ:";
            // 
            // dataSex
            // 
            this.dataSex.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataSex.Location = new System.Drawing.Point(406, 31);
            this.dataSex.Name = "dataSex";
            this.dataSex.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataSex.Size = new System.Drawing.Size(170, 23);
            this.dataSex.TabIndex = 39;
            // 
            // txtSex
            // 
            this.txtSex.AutoSize = true;
            this.txtSex.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtSex.Location = new System.Drawing.Point(403, 12);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(60, 16);
            this.txtSex.TabIndex = 38;
            this.txtSex.Text = "Giới tính:";
            // 
            // txtNgSinh
            // 
            this.txtNgSinh.AutoSize = true;
            this.txtNgSinh.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtNgSinh.Location = new System.Drawing.Point(595, 12);
            this.txtNgSinh.Name = "txtNgSinh";
            this.txtNgSinh.Size = new System.Drawing.Size(68, 16);
            this.txtNgSinh.TabIndex = 36;
            this.txtNgSinh.Text = "Ngày sinh:";
            // 
            // dataHoTen
            // 
            this.dataHoTen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataHoTen.Location = new System.Drawing.Point(213, 31);
            this.dataHoTen.Name = "dataHoTen";
            this.dataHoTen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataHoTen.Size = new System.Drawing.Size(170, 23);
            this.dataHoTen.TabIndex = 35;
            // 
            // txtHoTen
            // 
            this.txtHoTen.AutoSize = true;
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtHoTen.Location = new System.Drawing.Point(210, 12);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(65, 16);
            this.txtHoTen.TabIndex = 34;
            this.txtHoTen.Text = "Họ và tên:";
            // 
            // dataMaSV
            // 
            this.dataMaSV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataMaSV.Location = new System.Drawing.Point(20, 31);
            this.dataMaSV.Name = "dataMaSV";
            this.dataMaSV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataMaSV.Size = new System.Drawing.Size(170, 23);
            this.dataMaSV.TabIndex = 33;
            // 
            // groupInfor
            // 
            this.groupInfor.Controls.Add(this.dataTK);
            this.groupInfor.Controls.Add(this.txtTK);
            this.groupInfor.Controls.Add(this.dataSDT);
            this.groupInfor.Controls.Add(this.txtSDT);
            this.groupInfor.Controls.Add(this.dataNgSinh);
            this.groupInfor.Controls.Add(this.btnClear);
            this.groupInfor.Controls.Add(this.btnXacNhan);
            this.groupInfor.Controls.Add(this.dataEmail);
            this.groupInfor.Controls.Add(this.txtEmail);
            this.groupInfor.Controls.Add(this.dataDiaChi);
            this.groupInfor.Controls.Add(this.txtDiaChi);
            this.groupInfor.Controls.Add(this.dataSex);
            this.groupInfor.Controls.Add(this.txtSex);
            this.groupInfor.Controls.Add(this.txtNgSinh);
            this.groupInfor.Controls.Add(this.dataHoTen);
            this.groupInfor.Controls.Add(this.txtHoTen);
            this.groupInfor.Controls.Add(this.dataMaSV);
            this.groupInfor.Controls.Add(this.txtMaSV);
            this.groupInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupInfor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupInfor.Location = new System.Drawing.Point(0, 423);
            this.groupInfor.Name = "groupInfor";
            this.groupInfor.Size = new System.Drawing.Size(1124, 107);
            this.groupInfor.TabIndex = 11;
            this.groupInfor.TabStop = false;
            // 
            // dataTK
            // 
            this.dataTK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataTK.Location = new System.Drawing.Point(406, 76);
            this.dataTK.Name = "dataTK";
            this.dataTK.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataTK.Size = new System.Drawing.Size(170, 23);
            this.dataTK.TabIndex = 52;
            // 
            // txtTK
            // 
            this.txtTK.AutoSize = true;
            this.txtTK.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtTK.Location = new System.Drawing.Point(403, 57);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(67, 16);
            this.txtTK.TabIndex = 51;
            this.txtTK.Text = "Tài khoản:";
            // 
            // dataSDT
            // 
            this.dataSDT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataSDT.Location = new System.Drawing.Point(20, 76);
            this.dataSDT.Name = "dataSDT";
            this.dataSDT.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataSDT.Size = new System.Drawing.Size(170, 23);
            this.dataSDT.TabIndex = 50;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtSDT.Location = new System.Drawing.Point(17, 57);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(84, 16);
            this.txtSDT.TabIndex = 49;
            this.txtSDT.Text = "Số điện thoại:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.AutoSize = true;
            this.txtMaSV.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtMaSV.Location = new System.Drawing.Point(17, 12);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(83, 16);
            this.txtMaSV.TabIndex = 32;
            this.txtMaSV.Text = "Mã sinh viên:";
            // 
            // groupDS
            // 
            this.groupDS.Controls.Add(this.DGV);
            this.groupDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupDS.Location = new System.Drawing.Point(0, 0);
            this.groupDS.Name = "groupDS";
            this.groupDS.Size = new System.Drawing.Size(1124, 370);
            this.groupDS.TabIndex = 10;
            this.groupDS.TabStop = false;
            this.groupDS.Text = "Danh sách sinh viên";
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(0, 24);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(1124, 345);
            this.DGV.TabIndex = 1;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 530);
            this.Controls.Add(this.groupTool);
            this.Controls.Add(this.groupInfor);
            this.Controls.Add(this.groupDS);
            this.MaximumSize = new System.Drawing.Size(1140, 569);
            this.MinimumSize = new System.Drawing.Size(1140, 569);
            this.Name = "QuanLySinhVien";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.QuanLySinhVien_Load);
            this.groupTool.ResumeLayout(false);
            this.groupTool.PerformLayout();
            this.groupInfor.ResumeLayout(false);
            this.groupInfor.PerformLayout();
            this.groupDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupTool;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox dataFind;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dataNgSinh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox dataEmail;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox dataDiaChi;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.TextBox dataSex;
        private System.Windows.Forms.Label txtSex;
        private System.Windows.Forms.Label txtNgSinh;
        private System.Windows.Forms.TextBox dataHoTen;
        private System.Windows.Forms.Label txtHoTen;
        private System.Windows.Forms.TextBox dataMaSV;
        private System.Windows.Forms.GroupBox groupInfor;
        private System.Windows.Forms.Label txtMaSV;
        private System.Windows.Forms.GroupBox groupDS;
        private System.Windows.Forms.TextBox dataTK;
        private System.Windows.Forms.Label txtTK;
        private System.Windows.Forms.TextBox dataSDT;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.DataGridView DGV;
    }
}