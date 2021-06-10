using FixIt.Models.Models.Employee;
using FixIt.WinUI.API;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Report.EmployeeReport
{
    public partial class frmEmployeeReport : Form
    {
        private int employeeId;
        private DateTimePicker dtpEmployeeFrom;
        private DateTimePicker dtpEmployeeTo;
        private APIService _employeeService = new APIService("Employee");

        public frmEmployeeReport()
        {
            InitializeComponent();
        }

        public frmEmployeeReport(int employeeId, DateTimePicker dtpEmployeeFrom, DateTimePicker dtpEmployeeTo) : this()
        {
            this.employeeId = employeeId;
            this.dtpEmployeeFrom = dtpEmployeeFrom;
            this.dtpEmployeeTo = dtpEmployeeTo;
        }

        private async void frmEmployeeReport_Load(object sender, System.EventArgs e)
        {
            var employee = await _employeeService.GetById<EmployeeViewModel>(employeeId);
            double profit = 0;

            List<object> datasource = new List<object>();

            if (employee.Jobs != null)
                foreach (var x in employee.Jobs)
                {
                    if (x.CreatedAt >= dtpEmployeeFrom.Value && x.CreatedAt <= dtpEmployeeTo.Value)
                    {
                        string paid = "NE";
                        if (x.Paid == true)
                            paid = "DA";
                        datasource.Add(new
                        {
                            Id = x.Id,
                            JobDesc = x.JobDescription,
                            ServiceName = x.ServiceName,
                            ServicePrice = x.ServicePrice,
                            JobStartDate = x.CreatedAt.ToString("dd/MM/yyyy"),
                            JobEndDate = x.FinishedDate.ToString("dd/MM/yyyy"),
                            JobStatus = x.JobStatus,
                            JobPaid = paid,
                        });
                        profit += int.Parse(x.Price); //input string not i correct format
                    }
                }
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DateFrom", dtpEmployeeFrom.Value.ToString("dd/MM/yyyy")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DateTo", dtpEmployeeTo.Value.ToString("dd/MM/yyyy")));

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Employee", employee.Firstname + " " + employee.Lastname));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BirthDate", employee.BirthDate.ToString("dd/MM/yyyy")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Profession", employee.Profession.Name));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Address", employee.Address));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Bio", employee.Biography));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("PhoneNumber", employee.PhoneNumber));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Profit", profit.ToString()));

            string base64 = Convert.ToBase64String(employee.Photo);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Image", base64));


            var rds = new ReportDataSource()
            {
                Name = "dsEmployee",
                Value = datasource
            };
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
