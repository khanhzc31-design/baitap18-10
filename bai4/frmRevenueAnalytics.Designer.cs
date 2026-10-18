namespace MultiThreadingApp
{
    partial class frmRevenueAnalytics
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            lblBranch = new Label();
            cboBranch = new ComboBox();
            btnAnalyze = new Button();
            btnCancel = new Button();
            pgbLoading = new ProgressBar();
            lblProcessingStatus = new Label();
            dgvRevenueData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).BeginInit();
            SuspendLayout();
            // 
            // lblFrom
            // 
            lblFrom.Location = new Point(0, 10);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(100, 23);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "Từ ngày:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(106, 10);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(199, 27);
            dtpFrom.TabIndex = 1;
            dtpFrom.ValueChanged += this.dtpFrom_ValueChanged;
            // 
            // lblTo
            // 
            lblTo.Location = new Point(325, 13);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(100, 23);
            lblTo.TabIndex = 2;
            lblTo.Text = "Đến ngày:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(431, 10);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(120, 27);
            dtpTo.TabIndex = 3;
            // 
            // lblBranch
            // 
            lblBranch.Location = new Point(581, 11);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(100, 23);
            lblBranch.TabIndex = 4;
            lblBranch.Text = "Chi nhánh:";
            lblBranch.Click += this.lblBranch_Click;
            // 
            // cboBranch
            // 
            cboBranch.Items.AddRange(new object[] { "Chi nhánh 1", "Chi nhánh 2", "Chi nhánh 3" });
            cboBranch.Location = new Point(687, 10);
            cboBranch.Name = "cboBranch";
            cboBranch.Size = new Size(120, 28);
            cboBranch.TabIndex = 5;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(15, 45);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(150, 30);
            btnAnalyze.TabIndex = 6;
            btnAnalyze.Text = "Thống Kê Doanh Thu";
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(185, 45);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 30);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy Thao Tác";
            btnCancel.Click += btnCancel_Click;
            // 
            // pgbLoading
            // 
            pgbLoading.Location = new Point(12, 115);
            pgbLoading.Name = "pgbLoading";
            pgbLoading.Size = new Size(795, 23);
            pgbLoading.TabIndex = 9;
            // 
            // lblProcessingStatus
            // 
            lblProcessingStatus.Location = new Point(12, 90);
            lblProcessingStatus.Name = "lblProcessingStatus";
            lblProcessingStatus.Size = new Size(590, 20);
            lblProcessingStatus.TabIndex = 8;
            lblProcessingStatus.Text = "Trạng thái: Sẵn sàng.";
            lblProcessingStatus.Click += this.lblProcessingStatus_Click;
            // 
            // dgvRevenueData
            // 
            dgvRevenueData.ColumnHeadersHeight = 29;
            dgvRevenueData.Location = new Point(12, 150);
            dgvRevenueData.Name = "dgvRevenueData";
            dgvRevenueData.RowHeadersWidth = 51;
            dgvRevenueData.Size = new Size(795, 240);
            dgvRevenueData.TabIndex = 10;
            // 
            // frmRevenueAnalytics
            // 
            ClientSize = new Size(819, 405);
            Controls.Add(lblFrom);
            Controls.Add(dtpFrom);
            Controls.Add(lblTo);
            Controls.Add(dtpTo);
            Controls.Add(lblBranch);
            Controls.Add(cboBranch);
            Controls.Add(btnAnalyze);
            Controls.Add(btnCancel);
            Controls.Add(lblProcessingStatus);
            Controls.Add(pgbLoading);
            Controls.Add(dgvRevenueData);
            Name = "frmRevenueAnalytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Doanh Thu Multi-Threading";
            Load += this.frmRevenueAnalytics_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblFrom, lblTo, lblBranch, lblProcessingStatus;
        private System.Windows.Forms.DateTimePicker dtpFrom, dtpTo;
        private System.Windows.Forms.ComboBox cboBranch;
        private System.Windows.Forms.Button btnAnalyze, btnCancel;
        private System.Windows.Forms.ProgressBar pgbLoading;
        private System.Windows.Forms.DataGridView dgvRevenueData;
    }
}