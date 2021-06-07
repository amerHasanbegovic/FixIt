using FixIt.Models.Models.Employee;
using FixIt.Models.Models.Job;
using FixIt.Models.Models.ServiceRequest;
using FixIt.WinUI.API;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.ServiceRequests
{
    public partial class frmServiceRequestDetails : Form
    {
        private APIService _employeeService = new APIService("Employee");
        private APIService _jobService = new APIService("Job");
        private APIService _serviceRequestService = new APIService("ServiceRequest");

        private ServiceRequestViewModel request;

        public frmServiceRequestDetails()
        {
            InitializeComponent();
        }

        public frmServiceRequestDetails(ServiceRequestViewModel request) : this()
        {
            this.request = request;
        }

        private void frmServiceRequestDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            await LoadEmployees();
            LoadRequestData();
        }

        private async Task LoadEmployees()
        {
            var list = await _employeeService.Get<List<EmployeeViewModel>>();
            list.Insert(0, new EmployeeViewModel());
            cmbEmployees.DataSource = list;
            cmbEmployees.DisplayMember = "EmployeeFullNameAndProfession";
            cmbEmployees.ValueMember = "Id";
        }

        private void LoadRequestData()
        {
            if (request != null && request.Processed == true)
                panel1.Hide();

            if (request != null)
            {
                txtUserFullName.Text = request.UserFullName;
                txtEmail.Text = request?.User.Email;
                txtAddress.Text = request?.User.Address;

                txtServiceName.Text = request?.Service.Name;
                txtServicePrice.Text = request?.Service.Price.ToString() + "KM";

                txtPaymentType.Text = request?.PaymentTypeName;

                txtRequestDate.Text = request.RequestDate.ToString("dd/MM/yyyy");

                txtJobDesc.Text = request.JobDescription;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //create job
            if (request != null)
            {
                if (Validation())
                {
                    JobInsertModel jobInsertModel = new JobInsertModel()
                    {
                        CreatedAt = DateTime.Now,
                        JobDescription = request.JobDescription,
                        ServiceRequestId = request.Id,
                        JobStatusId = 1
                    };
                    if (request.Payment.PaymentTypeId == 1)
                        jobInsertModel.Paid = true;
                    var employeeId = cmbEmployees.SelectedValue;
                    if(int.TryParse(employeeId.ToString(), out int id))
                        jobInsertModel.EmployeeId = id;

                    await _jobService.Insert<JobInsertModel>(jobInsertModel);
                    ServiceRequestUpdateModel serviceRequestUpdateModel = new ServiceRequestUpdateModel()
                    {
                        Processed = true
                    };
                    await _serviceRequestService.Update<ServiceRequestUpdateModel>(request.Id, serviceRequestUpdateModel);
                    MessageBox.Show("Uspješno ste obradili zahtjev!");
                    this.Close();
                }
            }
        }

        private bool Validation()
        {
            if (cmbEmployees.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbEmployees, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            return true;
        }
    }
}
