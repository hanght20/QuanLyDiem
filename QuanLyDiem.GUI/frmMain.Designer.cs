
namespace QuanLyDiem.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInAn = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieudiemThi = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngĐiểmMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngĐiểmTổngKếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuInAn,
            this.trợGiúoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(871, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhoa,
            this.mnuLop,
            this.mnuMonHoc,
            this.mnuSinhVien,
            this.mnuDiem});
            this.mnuDanhMuc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("mnuDanhMuc.Image")));
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(135, 29);
            this.mnuDanhMuc.Text = "Danh mục";
            this.mnuDanhMuc.Click += new System.EventHandler(this.mnuDanhMuc_Click);
            // 
            // mnuKhoa
            // 
            this.mnuKhoa.Image = ((System.Drawing.Image)(resources.GetObject("mnuKhoa.Image")));
            this.mnuKhoa.Name = "mnuKhoa";
            this.mnuKhoa.Size = new System.Drawing.Size(161, 30);
            this.mnuKhoa.Text = "Khoa";
            // 
            // mnuLop
            // 
            this.mnuLop.Image = ((System.Drawing.Image)(resources.GetObject("mnuLop.Image")));
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(161, 30);
            this.mnuLop.Text = "Lớp";
            this.mnuLop.Click += new System.EventHandler(this.mnuLop_Click);
            // 
            // mnuMonHoc
            // 
            this.mnuMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("mnuMonHoc.Image")));
            this.mnuMonHoc.Name = "mnuMonHoc";
            this.mnuMonHoc.Size = new System.Drawing.Size(161, 30);
            this.mnuMonHoc.Text = "Môn học";
            this.mnuMonHoc.Click += new System.EventHandler(this.mnuMonHoc_Click);
            // 
            // mnuSinhVien
            // 
            this.mnuSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuSinhVien.Image")));
            this.mnuSinhVien.Name = "mnuSinhVien";
            this.mnuSinhVien.Size = new System.Drawing.Size(161, 30);
            this.mnuSinhVien.Text = "Sinh viên";
            this.mnuSinhVien.Click += new System.EventHandler(this.mnuSinhVien_Click);
            // 
            // mnuDiem
            // 
            this.mnuDiem.Image = ((System.Drawing.Image)(resources.GetObject("mnuDiem.Image")));
            this.mnuDiem.Name = "mnuDiem";
            this.mnuDiem.Size = new System.Drawing.Size(161, 30);
            this.mnuDiem.Text = "Điểm";
            this.mnuDiem.Click += new System.EventHandler(this.mnuDiem_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("mnuTimKiem.Image")));
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(125, 29);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("mnuBaoCao.Image")));
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(116, 29);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuInAn
            // 
            this.mnuInAn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchSinhViênToolStripMenuItem,
            this.mnuPhieudiemThi,
            this.bảngĐiểmMônHọcToolStripMenuItem,
            this.mnuPhieuDiem,
            this.bảngĐiểmTổngKếtToolStripMenuItem});
            this.mnuInAn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuInAn.Image = ((System.Drawing.Image)(resources.GetObject("mnuInAn.Image")));
            this.mnuInAn.Name = "mnuInAn";
            this.mnuInAn.Size = new System.Drawing.Size(91, 29);
            this.mnuInAn.Text = "In ấn";
            // 
            // danhSáchSinhViênToolStripMenuItem
            // 
            this.danhSáchSinhViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("danhSáchSinhViênToolStripMenuItem.Image")));
            this.danhSáchSinhViênToolStripMenuItem.Name = "danhSáchSinhViênToolStripMenuItem";
            this.danhSáchSinhViênToolStripMenuItem.Size = new System.Drawing.Size(262, 32);
            this.danhSáchSinhViênToolStripMenuItem.Text = "Danh sách sinh viên";
            this.danhSáchSinhViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchSinhViênToolStripMenuItem_Click);
            // 
            // mnuPhieudiemThi
            // 
            this.mnuPhieudiemThi.Image = ((System.Drawing.Image)(resources.GetObject("mnuPhieudiemThi.Image")));
            this.mnuPhieudiemThi.Name = "mnuPhieudiemThi";
            this.mnuPhieudiemThi.Size = new System.Drawing.Size(262, 32);
            this.mnuPhieudiemThi.Text = "Phiếu điểm thi";
            this.mnuPhieudiemThi.Click += new System.EventHandler(this.mnuPhieudiemThi_Click);
            // 
            // bảngĐiểmMônHọcToolStripMenuItem
            // 
            this.bảngĐiểmMônHọcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bảngĐiểmMônHọcToolStripMenuItem.Image")));
            this.bảngĐiểmMônHọcToolStripMenuItem.Name = "bảngĐiểmMônHọcToolStripMenuItem";
            this.bảngĐiểmMônHọcToolStripMenuItem.Size = new System.Drawing.Size(262, 32);
            this.bảngĐiểmMônHọcToolStripMenuItem.Text = "Bảng điểm môn học";
            this.bảngĐiểmMônHọcToolStripMenuItem.Click += new System.EventHandler(this.bảngĐiểmMônHọcToolStripMenuItem_Click);
            // 
            // mnuPhieuDiem
            // 
            this.mnuPhieuDiem.Image = ((System.Drawing.Image)(resources.GetObject("mnuPhieuDiem.Image")));
            this.mnuPhieuDiem.Name = "mnuPhieuDiem";
            this.mnuPhieuDiem.Size = new System.Drawing.Size(262, 32);
            this.mnuPhieuDiem.Text = "Phiếu điểm";
            this.mnuPhieuDiem.Click += new System.EventHandler(this.mnuPhieuDiem_Click);
            // 
            // bảngĐiểmTổngKếtToolStripMenuItem
            // 
            this.bảngĐiểmTổngKếtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bảngĐiểmTổngKếtToolStripMenuItem.Image")));
            this.bảngĐiểmTổngKếtToolStripMenuItem.Name = "bảngĐiểmTổngKếtToolStripMenuItem";
            this.bảngĐiểmTổngKếtToolStripMenuItem.Size = new System.Drawing.Size(262, 32);
            this.bảngĐiểmTổngKếtToolStripMenuItem.Text = "Bảng điểm tổng kết";
            this.bảngĐiểmTổngKếtToolStripMenuItem.Click += new System.EventHandler(this.bảngĐiểmTổngKếtToolStripMenuItem_Click);
            // 
            // trợGiúoToolStripMenuItem
            // 
            this.trợGiúoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTroGiup,
            this.đăngKýToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.trợGiúoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trợGiúoToolStripMenuItem.Image")));
            this.trợGiúoToolStripMenuItem.Name = "trợGiúoToolStripMenuItem";
            this.trợGiúoToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.trợGiúoToolStripMenuItem.Text = "Trợ giúp";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(177, 30);
            this.mnuTroGiup.Text = "Đăng nhập";
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(177, 30);
            this.đăngKýToolStripMenuItem.Text = "Đăng ký";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(177, 30);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(871, 468);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoa;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuInAn;
        private System.Windows.Forms.ToolStripMenuItem trợGiúoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieudiemThi;
        private System.Windows.Forms.ToolStripMenuItem bảngĐiểmMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuDiem;
        private System.Windows.Forms.ToolStripMenuItem bảngĐiểmTổngKếtToolStripMenuItem;
    }
}