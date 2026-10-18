using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HospitalMDI
{
    public partial class frmHospitalMain : Form
    {
        public frmHospitalMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm<T>() where T : Form, new()
        {
            Form child = this.MdiChildren.FirstOrDefault(f => f is T);
            if (child != null)
            {
                child.Activate();
            }
            else
            {
                child = new T { MdiParent = this };
                child.Show();
            }
        }

        private void menuPatients_Click(object sender, EventArgs e) => OpenChildForm<frmPatientProfiles>();
        private void menuDoctors_Click(object sender, EventArgs e) => OpenChildForm<frmDoctorSchedule>();
    }

    // FORM CON 1: HỒ SƠ BỆNH NHÂN (Giao diện thẻ Card & Grid)
    public class frmPatientProfiles : Form
    {
        public frmPatientProfiles()
        {
            this.Text = "Quản lý Hồ sơ Bệnh nhân";
            this.Size = new Size(650, 420);
            this.BackColor = Color.White;

            Panel pnlHeader = new Panel { Dock = DockStyle.Top, Height = 50, BackColor = Color.FromArgb(37, 99, 235) };
            Label lblTitle = new Label
            {
                Text = "👤 DANH SÁCH BỆNH NHÂN ĐANG ĐIỀU TRỊ",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlHeader.Controls.Add(lblTitle);

            DataGridView dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ReadOnly = true,
                RowHeadersVisible = false
            };
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            dgv.Columns.Add("ID", "Mã BN");
            dgv.Columns.Add("Name", "Họ và Tên");
            dgv.Columns.Add("Age", "Tuổi");
            dgv.Columns.Add("Dept", "Khoa Điều Trị");
            dgv.Columns.Add("Status", "Tình Trạng");

            dgv.Rows.Add("BN001", "Trần Văn Nam", "45", "Khoa Nội", "Ổn định");
            dgv.Rows.Add("BN002", "Lê Thị Hoa", "32", "Khoa Ngoại", "Theo dõi đặc biệt");
            dgv.Rows.Add("BN003", "Phạm Quốc Bảo", "28", "Khoa Cấp Cứu", "Chờ xuất viện");

            this.Controls.Add(dgv);
            this.Controls.Add(pnlHeader);
        }
    }

    // FORM CON 2: LỊCH TRỰC BÁC SĨ
    public class frmDoctorSchedule : Form
    {
        public frmDoctorSchedule()
        {
            this.Text = "Lịch trực Bác sĩ";
            this.Size = new Size(650, 420);
            this.BackColor = Color.White;

            Panel pnlHeader = new Panel { Dock = DockStyle.Top, Height = 50, BackColor = Color.FromArgb(16, 185, 129) };
            Label lblTitle = new Label
            {
                Text = "🩺 LỊCH TRỰC BÁC SĨ TRONG TẦN",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlHeader.Controls.Add(lblTitle);

            DataGridView dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ReadOnly = true,
                RowHeadersVisible = false
            };
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            dgv.Columns.Add("DocID", "Mã BS");
            dgv.Columns.Add("Name", "Họ Tên Bác Sĩ");
            dgv.Columns.Add("Shift", "Ca Trực");
            dgv.Columns.Add("Room", "Phòng Khám");

            dgv.Rows.Add("BS01", "Dr. Nguyễn Văn A", "Sáng (07:00 - 11:30)", "Phòng 101");
            dgv.Rows.Add("BS02", "Dr. Hoàng Thị C", "Chiều (13:00 - 17:00)", "Phòng 204");
            dgv.Rows.Add("BS03", "Dr. Đặng Văn D", "Đêm (21:00 - 06:00)", "Cấp cứu");

            this.Controls.Add(dgv);
            this.Controls.Add(pnlHeader);
        }
    }
}