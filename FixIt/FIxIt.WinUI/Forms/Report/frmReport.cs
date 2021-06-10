using FixIt.Models.Models.Employee;
using FixIt.WinUI.API;
using FixIt.WinUI.Forms.Report.EmployeeReport;
using FixIt.WinUI.Forms.Report.JobReport;
using FixIt.WinUI.Forms.Report.ServiceReport;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Report
{
    public partial class frmReport : Form
    {
        private APIService _employeeService = new APIService("Employee");
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnServiceReport_Click(object sender, EventArgs e)
        {
            var form = new frmServiceReport(dtpServiceFrom, dtpServiceTo);
            form.Show();
        }

        private void btnJobReport_Click(object sender, EventArgs e)
        {
            var form = new frmJobReport(dtpJobFrom, dtpJobTo);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(cmbEmployee.SelectedValue.ToString(), out int employeeId))
            {
                var form = new frmEmployeeReport(employeeId ,dtpEmployeeFrom, dtpEmployeeTo);
                form.Show();
            }
        }

        private async void frmReport_Load(object sender, EventArgs e)
        {
            await LoadEmployees();
        }

        private async Task LoadEmployees()
        {
            var list = await _employeeService.Get<IEnumerable<EmployeeViewModel>>();
            cmbEmployee.DataSource = list;
            cmbEmployee.ValueMember = "Id";
            cmbEmployee.DisplayMember = "EmployeeFullName";
        }
    }
}
