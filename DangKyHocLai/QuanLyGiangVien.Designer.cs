
namespace DangKyHocLai
{
    partial class QuanLyGiangVien
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
            this.groupDS = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupInfor = new System.Windows.Forms.GroupBox();
            this.dataNgSinh = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dataSDT = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.Label();
            this.dataSex = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.Label();
            this.txtNgSinh = new System.Windows.Forms.Label();
            this.dataHoTen = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.dataMaGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataFind = new System.Windows.Forms.TextBox();
            this.groupTool = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.Label();
            this.dataEmail = new System.Windows.Forms.TextBox();
            this.groupDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupInfor.SuspendLayout();
            this.groupTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDS
            // 
            this.groupDS.Controls.Add(this.DGV);
            this.groupDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupDS.Location = new System.Drawing.Point(0, 0);
            this.groupDS.Name = "groupDS";
            this.groupDS.Size = new System.Drawing.Size(1124, 370);
            this.groupDS.TabIndex = 0;
            this.groupDS.TabStop = false;
            this.groupDS.Text = "Danh sách giảng viên";
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(0, 25);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(1124, 345);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // groupInfor
            // 
            this.groupInfor.Controls.Add(this.dataNgSinh);
            this.groupInfor.Controls.Add(this.btnClear);
            this.groupInfor.Controls.Add(this.btnXacNhan);
            this.groupInfor.Controls.Add(this.dataEmail);
            this.groupInfor.Controls.Add(this.txtEmail);
            this.groupInfor.Controls.Add(this.dataSDT);
            this.groupInfor.Controls.Add(this.txtSDT);
            this.groupInfor.Controls.Add(this.dataSex);
            this.groupInfor.Controls.Add(this.txtSex);
            this.groupInfor.Controls.Add(this.txtNgSinh);
            this.groupInfor.Controls.Add(this.dataHoTen);
            this.groupInfor.Controls.Add(this.txtHoTen);
            this.groupInfor.Controls.Add(this.dataMaGV);
            this.groupInfor.Controls.Add(this.txtMaGV);
            this.groupInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupInfor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupInfor.Location = new System.Drawing.Point(0, 423);
            this.groupInfor.Name = "groupInfor";
            this.groupInfor.Size = new System.Drawing.Size(1124, 107);
            this.groupInfor.TabIndex = 8;
            this.groupInfor.TabStop = false;
            // 
            // dataNgSinh
            // 
            this.dataNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNgSinh.Location = new System.Drawing.Point(406, 28);
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
            // dataSDT
            // 
            this.dataSDT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataSDT.Location = new System.Drawing.Point(791, 31);
            this.dataSDT.Name = "dataSDT";
            this.dataSDT.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataSDT.Size = new System.Drawing.Size(170, 23);
            this.dataSDT.TabIndex = 41;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtSDT.Location = new System.Drawing.Point(788, 12);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(84, 16);
            this.txtSDT.TabIndex = 40;
            this.txtSDT.Text = "Số điện thoại:";
            // 
            // dataSex
            // 
            this.dataSex.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataSex.Location = new System.Drawing.Point(598, 31);
            this.dataSex.Name = "dataSex";
            this.dataSex.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataSex.Size = new System.Drawing.Size(170, 23);
            this.dataSex.TabIndex = 39;
            // 
            // txtSex
            // 
            this.txtSex.AutoSize = true;
            this.txtSex.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtSex.Location = new System.Drawing.Point(595, 12);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(60, 16);
            this.txtSex.TabIndex = 38;
            this.txtSex.Text = "Giới tính:";
            // 
            // txtNgSinh
            // 
            this.txtNgSinh.AutoSize = true;
            this.txtNgSinh.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtNgSinh.Location = new System.Drawing.Point(403, 12);
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
            // dataMaGV
            // 
            this.dataMaGV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataMaGV.Location = new System.Drawing.Point(20, 31);
            this.dataMaGV.Name = "dataMaGV";
            this.dataMaGV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataMaGV.Size = new System.Drawing.Size(170, 23);
            this.dataMaGV.TabIndex = 33;
            // 
            // txtMaGV
            // 
            this.txtMaGV.AutoSize = true;
            this.txtMaGV.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtMaGV.Location = new System.Drawing.Point(17, 12);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(90, 16);
            this.txtMaGV.TabIndex = 32;
            this.txtMaGV.Text = "Mã giảng viên:";
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
            // dataFind
            // 
            this.dataFind.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataFind.Location = new System.Drawing.Point(758, 18);
            this.dataFind.Name = "dataFind";
            this.dataFind.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataFind.Size = new System.Drawing.Size(170, 23);
            this.dataFind.TabIndex = 44;
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
            this.groupTool.TabIndex = 9;
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
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFind.Location = new System.Drawing.Point(944, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 27);
            this.btnFind.TabIndex = 45;
            this.btnFind.Text = "Tìm mã giảng viên";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtEmail.Location = new System.Drawing.Point(17, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(42, 16);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.Text = "Email:";
            // 
            // dataEmail
            // 
            this.dataEmail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataEmail.Location = new System.Drawing.Point(20, 78);
            this.dataEmail.Name = "dataEmail";
            this.dataEmail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataEmail.Size = new System.Drawing.Size(170, 23);
            this.dataEmail.TabIndex = 43;
            // 
            // QuanLyGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 530);
            this.Controls.Add(this.groupTool);
            this.Controls.Add(this.groupInfor);
            this.Controls.Add(this.groupDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1140, 569);
            this.MinimumSize = new System.Drawing.Size(1140, 569);
            this.Name = "QuanLyGiangVien";
            this.Text = "Quản lý giảng viên";
            this.Load += new System.EventHandler(this.QuanLyGiangVien_Load);
            this.groupDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupInfor.ResumeLayout(false);
            this.groupInfor.PerformLayout();
            this.groupTool.ResumeLayout(false);
            this.groupTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDS;
        private System.Windows.Forms.GroupBox groupInfor;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox dataSDT;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.TextBox dataSex;
        private System.Windows.Forms.Label txtSex;
        private System.Windows.Forms.Label txtNgSinh;
        private System.Windows.Forms.TextBox dataHoTen;
        private System.Windows.Forms.Label txtHoTen;
        private System.Windows.Forms.TextBox dataMaGV;
        private System.Windows.Forms.Label txtMaGV;
        private System.Windows.Forms.TextBox dataFind;
        private System.Windows.Forms.GroupBox groupTool;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker dataNgSinh;
        private System.Windows.Forms.TextBox dataEmail;
        private System.Windows.Forms.Label txtEmail;
    }
}