using FixIt.Models.Models.Job;
using FixIt.WinUI.API;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Job
{
    public partial class frmJobDetails : Form
    {
        private APIService _jobService = new APIService("Job");
        private JobViewModel job;

        public frmJobDetails()
        {
            InitializeComponent();
        }

        public frmJobDetails(JobViewModel job) : this()
        {
            this.job = job;
        }

        private async void frmJobDetails_Load(object sender, System.EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            if(job != null)
            {
                this.Text = "Detalji";
                var res = await _jobService.GetById<JobViewModel>(job.Id);
                job = res;
                LoadJobDetails(job);
            }
        }

        private void LoadJobDetails(JobViewModel job)
        {
            //job
            txtStart.Text = job.CreatedAt.ToString("dd/MM/yyyy");
            //txtEnd.Text = job.FinishedDate.ToString();
            txtJobStatus.Text = job?.Status?.Status;
            txtJobDesc.Text = job?.ServiceRequest?.JobDescription;
            if (job.Paid == true)
                cbPaid.Checked = true;

            //user
            txtFullName.Text = job?.UserFullName;
            txtEmail.Text = job?.ServiceRequest?.User?.Email;
            txtPhoneNumber.Text = job?.ServiceRequest?.User?.Address;

            //service
            txtServiceName.Text = job?.ServiceName;
            txtServicePrice.Text = job?.ServiceRequest?.Service?.Price.ToString() + " KM";
            txtServiceRequestDate.Text = job?.ServiceRequest?.RequestDate.ToString("dd/MM/yyyy");

            //employee
            txtEmployeeFullName.Text = job.EmployeeFullName;
            txtProfessionName.Text = job?.Employee?.Profession?.Name;

            //payment type
            txtPaymentType.Text = job.ServiceRequest?.Payment?.PaymentType.Name;
            txtPaymentDate.Text = job.ServiceRequest?.Payment?.PaymentDate.ToString("dd/MM/yyyy");
        }

        private void btnEditJob_Click(object sender, System.EventArgs e)
        {
            if (job != null)
            {
                var form = new frmEditJob(job);
                form.Show();
            }
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {
            await LoadData();
        }
    }
}
