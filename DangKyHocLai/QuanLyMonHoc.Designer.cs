
namespace DangKyHocLai
{
    partial class QuanLyMonHoc
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtTinChi = new System.Windows.Forms.Label();
            this.dataTenMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.Label();
            this.dataMaMH = new System.Windows.Forms.TextBox();
            this.groupInfor = new System.Windows.Forms.GroupBox();
            this.dataTinChi = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupDS = new System.Windows.Forms.GroupBox();
            this.groupTool.SuspendLayout();
            this.groupInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFind.Location = new System.Drawing.Point(944, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 27);
            this.btnFind.TabIndex = 45;
            this.btnFind.Text = "Tìm mã môn học";
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
            this.groupTool.Size = new System.Drawing.Size(1124, 52);
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
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClear.Location = new System.Drawing.Point(776, 28);
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
            this.btnXacNhan.Location = new System.Drawing.Point(640, 28);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(119, 27);
            this.btnXacNhan.TabIndex = 46;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtTinChi
            // 
            this.txtTinChi.AutoSize = true;
            this.txtTinChi.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtTinChi.Location = new System.Drawing.Point(403, 12);
            this.txtTinChi.Name = "txtTinChi";
            this.txtTinChi.Size = new System.Drawing.Size(52, 16);
            this.txtTinChi.TabIndex = 36;
            this.txtTinChi.Text = "Tín chỉ:";
            // 
            // dataTenMH
            // 
            this.dataTenMH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataTenMH.Location = new System.Drawing.Point(213, 31);
            this.dataTenMH.Name = "dataTenMH";
            this.dataTenMH.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataTenMH.Size = new System.Drawing.Size(170, 23);
            this.dataTenMH.TabIndex = 35;
            // 
            // txtTenMH
            // 
            this.txtTenMH.AutoSize = true;
            this.txtTenMH.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtTenMH.Location = new System.Drawing.Point(210, 12);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(87, 16);
            this.txtTenMH.TabIndex = 34;
            this.txtTenMH.Text = "Tên môn học:";
            // 
            // dataMaMH
            // 
            this.dataMaMH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataMaMH.Location = new System.Drawing.Point(20, 31);
            this.dataMaMH.Name = "dataMaMH";
            this.dataMaMH.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataMaMH.Size = new System.Drawing.Size(170, 23);
            this.dataMaMH.TabIndex = 33;
            // 
            // groupInfor
            // 
            this.groupInfor.Controls.Add(this.dataTinChi);
            this.groupInfor.Controls.Add(this.btnClear);
            this.groupInfor.Controls.Add(this.btnXacNhan);
            this.groupInfor.Controls.Add(this.txtTinChi);
            this.groupInfor.Controls.Add(this.dataTenMH);
            this.groupInfor.Controls.Add(this.txtTenMH);
            this.groupInfor.Controls.Add(this.dataMaMH);
            this.groupInfor.Controls.Add(this.txtMaMH);
            this.groupInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupInfor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupInfor.Location = new System.Drawing.Point(0, 422);
            this.groupInfor.Name = "groupInfor";
            this.groupInfor.Size = new System.Drawing.Size(1124, 69);
            this.groupInfor.TabIndex = 11;
            this.groupInfor.TabStop = false;
            // 
            // dataTinChi
            // 
            this.dataTinChi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataTinChi.Location = new System.Drawing.Point(406, 31);
            this.dataTinChi.Name = "dataTinChi";
            this.dataTinChi.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataTinChi.Size = new System.Drawing.Size(170, 23);
            this.dataTinChi.TabIndex = 48;
            // 
            // txtMaMH
            // 
            this.txtMaMH.AutoSize = true;
            this.txtMaMH.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtMaMH.Location = new System.Drawing.Point(17, 12);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(83, 16);
            this.txtMaMH.TabIndex = 32;
            this.txtMaMH.Text = "Mã môn học:";
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(0, 25);
            this.DGV.MaximumSize = new System.Drawing.Size(1124, 345);
            this.DGV.MinimumSize = new System.Drawing.Size(1124, 345);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(1124, 345);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
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
            this.groupDS.Text = "Danh sách môn học";
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 491);
            this.Controls.Add(this.groupTool);
            this.Controls.Add(this.groupInfor);
            this.Controls.Add(this.groupDS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1140, 530);
            this.MinimumSize = new System.Drawing.Size(1140, 530);
            this.Name = "QuanLyMonHoc";
            this.Text = "Quản Lý Môn Học";
            this.Load += new System.EventHandler(this.QuanLyMonHoc_Load);
            this.groupTool.ResumeLayout(false);
            this.groupTool.PerformLayout();
            this.groupInfor.ResumeLayout(false);
            this.groupInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupDS.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label txtTinChi;
        private System.Windows.Forms.TextBox dataTenMH;
        private System.Windows.Forms.Label txtTenMH;
        private System.Windows.Forms.TextBox dataMaMH;
        private System.Windows.Forms.GroupBox groupInfor;
        private System.Windows.Forms.Label txtMaMH;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox groupDS;
        private System.Windows.Forms.TextBox dataTinChi;
    }
}