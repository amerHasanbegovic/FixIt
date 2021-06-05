using FixIt.Models.Models.Job;
using FixIt.WinUI.API;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Job
{
    public partial class frmJob : Form
    {
        private APIService _jobService = new APIService("Job");
        public frmJob()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private async void frmJob_Load(object sender, System.EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadJobs();
        }

        private async Task LoadJobs(int jobStatusId = 0)
        {
            JobSearchModel jobSearchModel = new JobSearchModel()
            {
                Query = textBox1.Text
            };
            if (jobStatusId != 0)
                jobSearchModel.JobStatusId = jobStatusId;

            var list = await _jobService.Get<IEnumerable<JobViewModel>>(jobSearchModel);
            dataGridView1.DataSource = list;
        }

        private async void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (cbActiveJobs.Checked)
                await LoadJobs(1);
            else if (cbFinishedJobs.Checked)
                await LoadJobs(2);
            else await LoadJobs();
        }

        private async void cbActiveJobs_CheckedChanged(object sender, System.EventArgs e)
        {
            bool isChecked = cbActiveJobs.Checked;
            cbFinishedJobs.Enabled = false;
            if (isChecked)
                await LoadJobs(1);
            else
            {
                cbFinishedJobs.Enabled = true;
                await LoadJobs();
            }
        }

        private async void cbFinishedJobs_CheckedChanged(object sender, System.EventArgs e)
        {
            bool isChecked = cbFinishedJobs.Checked;
            cbActiveJobs.Enabled = false;
            if (isChecked)
                await LoadJobs(2);
            else
            {
                cbActiveJobs.Enabled = true;
                await LoadJobs();
            }
        }
    }
}
