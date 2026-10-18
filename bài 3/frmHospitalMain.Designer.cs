namespace HospitalMDI
{
    partial class frmHospitalMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();

            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // MenuStrip Styling
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem, this.menuManage, this.menuWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 33);

            // Menu System
            this.menuSystem.ForeColor = System.Drawing.Color.White;
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuLogout, this.menuExit });
            this.menuSystem.Text = "⚙️ Hệ thống";
            this.menuLogout.Text = "Đăng xuất";
            this.menuExit.Text = "Thoát ứng dụng";
            this.menuExit.Click += (s, e) => Application.Exit();

            // Menu Manage
            this.menuManage.ForeColor = System.Drawing.Color.White;
            this.menuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuPatients, this.menuDoctors });
            this.menuManage.Text = "📋 Quản lý Chuyên môn";
            this.menuPatients.Text = "👤 Hồ sơ Bệnh nhân";
            this.menuPatients.Click += new System.EventHandler(this.menuPatients_Click);
            this.menuDoctors.Text = "🩺 Lịch trực Bác sĩ";
            this.menuDoctors.Click += new System.EventHandler(this.menuDoctors_Click);

            // Menu Window
            this.menuWindow.ForeColor = System.Drawing.Color.White;
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuCascade, this.menuTileH, this.menuTileV, this.menuCloseAll });
            this.menuWindow.Text = "🪟 Điều hướng Cửa sổ";
            this.menuCascade.Text = "Xếp tầng (Cascade)";
            this.menuCascade.Click += (s, e) => this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            this.menuTileH.Text = "Chia ngang (Tile Horizontal)";
            this.menuTileH.Click += (s, e) => this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            this.menuTileV.Text = "Chia dọc (Tile Vertical)";
            this.menuTileV.Click += (s, e) => this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
            this.menuCloseAll.Text = "❌ Đóng tất cả cửa sổ";
            this.menuCloseAll.Click += (s, e) => { foreach (var child in MdiChildren) child.Close(); };

            // StatusStrip
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
            this.statusStrip1.Location = new System.Drawing.Point(0, 625);
            this.statusStrip1.Size = new System.Drawing.Size(1000, 25);

            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblStatus.Text = "🟢 Phiên làm việc: Dr. Nguyễn Văn A | Trạng thái: Sẵn sàng kết nối MDI Server";

            // Main Form
            this.IsMdiContainer = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHospitalMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BỆNH VIỆN ĐA KHOA - HỆ THỐNG MDI CHUYÊN NGHIỆP";
            this.menuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem, menuLogout, menuExit, menuManage, menuPatients, menuDoctors, menuWindow, menuCascade, menuTileH, menuTileV, menuCloseAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}