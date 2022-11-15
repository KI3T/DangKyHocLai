
namespace DangKyHocLai
{
    partial class QuanLyDangKyMon
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dataMaMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.Label();
            this.groupInfor = new System.Windows.Forms.GroupBox();
            this.dataMaKS = new System.Windows.Forms.TextBox();
            this.txtMaKS = new System.Windows.Forms.Label();
            this.dataMaGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.Label();
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
            this.btnFind.Location = new System.Drawing.Point(757, 15);
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
            this.groupTool.Controls.Add(this.btnXoa);
            this.groupTool.Controls.Add(this.btnThem);
            this.groupTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTool.Location = new System.Drawing.Point(0, 370);
            this.groupTool.Name = "groupTool";
            this.groupTool.Size = new System.Drawing.Size(937, 54);
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
            // dataMaMH
            // 
            this.dataMaMH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataMaMH.Location = new System.Drawing.Point(223, 31);
            this.dataMaMH.Name = "dataMaMH";
            this.dataMaMH.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataMaMH.Size = new System.Drawing.Size(170, 23);
            this.dataMaMH.TabIndex = 33;
            // 
            // txtMaMH
            // 
            this.txtMaMH.AutoSize = true;
            this.txtMaMH.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtMaMH.Location = new System.Drawing.Point(220, 12);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(83, 16);
            this.txtMaMH.TabIndex = 32;
            this.txtMaMH.Text = "Mã môn học:";
            // 
            // groupInfor
            // 
            this.groupInfor.Controls.Add(this.dataMaKS);
            this.groupInfor.Controls.Add(this.txtMaKS);
            this.groupInfor.Controls.Add(this.btnClear);
            this.groupInfor.Controls.Add(this.btnXacNhan);
            this.groupInfor.Controls.Add(this.dataMaGV);
            this.groupInfor.Controls.Add(this.txtMaGV);
            this.groupInfor.Controls.Add(this.dataMaMH);
            this.groupInfor.Controls.Add(this.txtMaMH);
            this.groupInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupInfor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupInfor.Location = new System.Drawing.Point(0, 424);
            this.groupInfor.Name = "groupInfor";
            this.groupInfor.Size = new System.Drawing.Size(937, 74);
            this.groupInfor.TabIndex = 11;
            this.groupInfor.TabStop = false;
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
            // dataMaGV
            // 
            this.dataMaGV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataMaGV.Location = new System.Drawing.Point(425, 31);
            this.dataMaGV.Name = "dataMaGV";
            this.dataMaGV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataMaGV.Size = new System.Drawing.Size(170, 23);
            this.dataMaGV.TabIndex = 35;
            // 
            // txtMaGV
            // 
            this.txtMaGV.AutoSize = true;
            this.txtMaGV.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtMaGV.Location = new System.Drawing.Point(422, 12);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(90, 16);
            this.txtMaGV.TabIndex = 34;
            this.txtMaGV.Text = "Mã giảng viên:";
            // 
            // DGV
            // 
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(0, 25);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(937, 345);
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
            this.groupDS.Size = new System.Drawing.Size(937, 370);
            this.groupDS.TabIndex = 10;
            this.groupDS.TabStop = false;
            this.groupDS.Text = "Danh sách đăng ký";
            // 
            // QuanLyDangKyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 498);
            this.Controls.Add(this.groupTool);
            this.Controls.Add(this.groupInfor);
            this.Controls.Add(this.groupDS);
            this.MaximumSize = new System.Drawing.Size(953, 537);
            this.MinimumSize = new System.Drawing.Size(953, 537);
            this.Name = "QuanLyDangKyMon";
            this.Text = "Quản Lý Danh Sách Đăng Ký";
            this.Load += new System.EventHandler(this.QuanLyDangKyMon_Load);
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
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox dataMaMH;
        private System.Windows.Forms.Label txtMaMH;
        private System.Windows.Forms.GroupBox groupInfor;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox groupDS;
        private System.Windows.Forms.TextBox dataMaKS;
        private System.Windows.Forms.Label txtMaKS;
        private System.Windows.Forms.TextBox dataMaGV;
        private System.Windows.Forms.Label txtMaGV;
    }
}