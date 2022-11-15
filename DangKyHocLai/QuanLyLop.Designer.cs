
namespace DangKyHocLai
{
    partial class QuanLyLop
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
            this.btnXem = new System.Windows.Forms.Button();
            this.dataFind = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupTool = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupDS = new System.Windows.Forms.GroupBox();
            this.txtMaLop = new System.Windows.Forms.Label();
            this.dataMaLop = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.Label();
            this.dataMaSV = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMaKS = new System.Windows.Forms.Label();
            this.dataMaKS = new System.Windows.Forms.TextBox();
            this.groupInfor = new System.Windows.Forms.GroupBox();
            this.groupTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupDS.SuspendLayout();
            this.groupInfor.SuspendLayout();
            this.SuspendLayout();
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
            this.dataFind.Location = new System.Drawing.Point(571, 18);
            this.dataFind.Name = "dataFind";
            this.dataFind.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataFind.Size = new System.Drawing.Size(170, 23);
            this.dataFind.TabIndex = 44;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(383, 14);
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
            // groupTool
            // 
            this.groupTool.Controls.Add(this.btnXem);
            this.groupTool.Controls.Add(this.btnFind);
            this.groupTool.Controls.Add(this.dataFind);
            this.groupTool.Controls.Add(this.btnXoa);
            this.groupTool.Controls.Add(this.btnThem);
            this.groupTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTool.Location = new System.Drawing.Point(0, 380);
            this.groupTool.Name = "groupTool";
            this.groupTool.Size = new System.Drawing.Size(937, 118);
            this.groupTool.TabIndex = 15;
            this.groupTool.TabStop = false;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFind.Location = new System.Drawing.Point(757, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 27);
            this.btnFind.TabIndex = 45;
            this.btnFind.Text = "Tìm mã lớp";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(0, 25);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(937, 355);
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
            this.groupDS.Size = new System.Drawing.Size(937, 380);
            this.groupDS.TabIndex = 13;
            this.groupDS.TabStop = false;
            this.groupDS.Text = "Danh sách đăng ký";
            // 
            // txtMaLop
            // 
            this.txtMaLop.AutoSize = true;
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtMaLop.Location = new System.Drawing.Point(220, 12);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(50, 16);
            this.txtMaLop.TabIndex = 32;
            this.txtMaLop.Text = "Mã lớp:";
            // 
            // dataMaLop
            // 
            this.dataMaLop.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataMaLop.Location = new System.Drawing.Point(223, 31);
            this.dataMaLop.Name = "dataMaLop";
            this.dataMaLop.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataMaLop.Size = new System.Drawing.Size(170, 23);
            this.dataMaLop.TabIndex = 33;
            // 
            // txtMaSV
            // 
            this.txtMaSV.AutoSize = true;
            this.txtMaSV.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtMaSV.Location = new System.Drawing.Point(422, 12);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(83, 16);
            this.txtMaSV.TabIndex = 34;
            this.txtMaSV.Text = "Mã sinh viên:";
            // 
            // dataMaSV
            // 
            this.dataMaSV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataMaSV.Location = new System.Drawing.Point(425, 31);
            this.dataMaSV.Name = "dataMaSV";
            this.dataMaSV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataMaSV.Size = new System.Drawing.Size(170, 23);
            this.dataMaSV.TabIndex = 35;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan.Location = new System.Drawing.Point(636, 28);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(119, 27);
            this.btnXacNhan.TabIndex = 46;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClear.Location = new System.Drawing.Point(788, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 27);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Làm sạch";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtMaKS
            // 
            this.txtMaKS.AutoSize = true;
            this.txtMaKS.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtMaKS.Location = new System.Drawing.Point(27, 12);
            this.txtMaKS.Name = "txtMaKS";
            this.txtMaKS.Size = new System.Drawing.Size(87, 16);
            this.txtMaKS.TabIndex = 48;
            this.txtMaKS.Text = "Mã kiểm soát:";
            // 
            // dataMaKS
            // 
            this.dataMaKS.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataMaKS.Location = new System.Drawing.Point(30, 31);
            this.dataMaKS.Name = "dataMaKS";
            this.dataMaKS.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataMaKS.Size = new System.Drawing.Size(170, 23);
            this.dataMaKS.TabIndex = 49;
            // 
            // groupInfor
            // 
            this.groupInfor.Controls.Add(this.dataMaKS);
            this.groupInfor.Controls.Add(this.txtMaKS);
            this.groupInfor.Controls.Add(this.btnClear);
            this.groupInfor.Controls.Add(this.btnXacNhan);
            this.groupInfor.Controls.Add(this.dataMaSV);
            this.groupInfor.Controls.Add(this.txtMaSV);
            this.groupInfor.Controls.Add(this.dataMaLop);
            this.groupInfor.Controls.Add(this.txtMaLop);
            this.groupInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupInfor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupInfor.Location = new System.Drawing.Point(0, 428);
            this.groupInfor.Name = "groupInfor";
            this.groupInfor.Size = new System.Drawing.Size(937, 70);
            this.groupInfor.TabIndex = 14;
            this.groupInfor.TabStop = false;
            // 
            // QuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 498);
            this.Controls.Add(this.groupInfor);
            this.Controls.Add(this.groupTool);
            this.Controls.Add(this.groupDS);
            this.MaximumSize = new System.Drawing.Size(953, 537);
            this.MinimumSize = new System.Drawing.Size(953, 537);
            this.Name = "QuanLyLop";
            this.Text = "Quản Lý Lớp";
            this.Load += new System.EventHandler(this.QuanLyLop_Load);
            this.groupTool.ResumeLayout(false);
            this.groupTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupDS.ResumeLayout(false);
            this.groupInfor.ResumeLayout(false);
            this.groupInfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox dataFind;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupTool;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox groupDS;
        private System.Windows.Forms.Label txtMaLop;
        private System.Windows.Forms.TextBox dataMaLop;
        private System.Windows.Forms.Label txtMaSV;
        private System.Windows.Forms.TextBox dataMaSV;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label txtMaKS;
        private System.Windows.Forms.TextBox dataMaKS;
        private System.Windows.Forms.GroupBox groupInfor;
    }
}