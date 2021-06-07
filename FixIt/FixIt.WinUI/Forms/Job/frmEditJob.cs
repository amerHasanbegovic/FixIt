using FixIt.Models.Models.Employee;
using FixIt.Models.Models.Job;
using FixIt.Models.Models.JobStatus;
using FixIt.WinUI.API;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Job
{
    public partial class frmEditJob : Form
    {
        private APIService _employeeService = new APIService("Employee");
        private APIService _jobStatusService = new APIService("JobStatus");
        private APIService _jobService = new APIService("Job");

        private JobViewModel job;

        public frmEditJob()
        {
            InitializeComponent();
        }

        public frmEditJob(JobViewModel job) : this()
        {
            this.job = job;
        }

        private void frmEditJob_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async Task LoadJobStatuses()
        {
            var list = await _jobStatusService.Get<List<JobStatusViewModel>>();
            list.Insert(0, new JobStatusViewModel());
            comboBox2.DataSource = list;
            comboBox2.DisplayMember = "Status";
            comboBox2.ValueMember = "Id";
        }

        private void LoadJobData()
        {
            if(job != null)
            {
                if (job.EmployeeId != 0)
                    comboBox1.SelectedValue = job.EmployeeId;
                if (job.JobStatusId != 0)
                    comboBox2.SelectedValue = job.JobStatusId;
                if (job.Paid == true)
                {
                    checkBox1.Checked = true;
                    checkBox1.Enabled = false;
                }
                else checkBox1.Checked = false;
            }
        }

        private async void LoadData()
        {
            await LoadEmployees();
            await LoadJobStatuses();
            LoadJobData();
        }

        private async Task LoadEmployees()
        {
            var list = await _employeeService.Get<List<EmployeeViewModel>>();
            list.Insert(0, new EmployeeViewModel());
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "EmployeeFullNameAndProfession";
            comboBox1.ValueMember = "Id";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                JobUpdateModel jobUpdateModel = new JobUpdateModel() {};
                jobUpdateModel.EmployeeId = int.Parse(comboBox1.SelectedValue.ToString());
                jobUpdateModel.JobStatusId = int.Parse(comboBox2.SelectedValue.ToString());
                if (checkBox1.Checked)
                {
                    jobUpdateModel.Paid = true;
                    if(job != null && job.FinishedDate != null)
                    jobUpdateModel.FinishedDate = DateTime.Now;
                }
                await _jobService.Update<JobUpdateModel>(job.Id, jobUpdateModel);
                MessageBox.Show("Uspješno ste uredili posao!");
                this.Close();
            }
        }

        private bool Validation()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                errorProvider1.SetError(comboBox1, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            if (comboBox2.SelectedIndex == 0)
            {
                errorProvider1.SetError(comboBox2, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();

            return true;
        }
    }
}
