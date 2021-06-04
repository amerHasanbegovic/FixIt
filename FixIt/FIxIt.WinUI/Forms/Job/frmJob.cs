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

        private async Task LoadJobs()
        {
            var list = await _jobService.Get<IEnumerable<JobViewModel>>();
            dataGridView1.DataSource = list;
        }
    }
}
