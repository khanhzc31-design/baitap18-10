using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadingApp
{
    public partial class frmRevenueAnalytics : Form
    {
        private CancellationTokenSource _cts;

        public frmRevenueAnalytics()
        {
            InitializeComponent();
        }

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            btnAnalyze.Enabled = false;
            btnCancel.Enabled = true;
            pgbLoading.Value = 0;
            lblProcessingStatus.Text = "Đang truy xuất CSDL lớn (không khóa UI)...";

           
            var progress = new Progress<int>(p => pgbLoading.Value = p);

            try
            {
              
                DataTable data = await Task.Run(() => FetchRevenueDataDataSimulated(_cts.Token, progress), _cts.Token);

                dgvRevenueData.DataSource = data;
                lblProcessingStatus.Text = "Thống kê hoàn tất thành công!";
            }
            catch (OperationCanceledException)
            {
                lblProcessingStatus.Text = "Đã hủy thao tác!";
                pgbLoading.Value = 0;
            }
            finally
            {
                btnAnalyze.Enabled = true;
                btnCancel.Enabled = false;
            }
        }

        private DataTable FetchRevenueDataDataSimulated(CancellationToken token, IProgress<int> progress)
        {
            for (int i = 1; i <= 10; i++)
            {
                token.ThrowIfCancellationRequested();
                Thread.Sleep(500);
                progress.Report(i * 10);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Giao Dịch");
            dt.Columns.Add("Ngày GD");
            dt.Columns.Add("Doanh Thu (VNĐ)");

            dt.Rows.Add("GD001", DateTime.Now.ToShortDateString(), "15,000,000");
            dt.Rows.Add("GD002", DateTime.Now.ToShortDateString(), "28,500,000");
            dt.Rows.Add("GD003", DateTime.Now.ToShortDateString(), "42,000,000");

            return dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }
    }
}