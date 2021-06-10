using FixIt.Models.Models.Job;
using FixIt.WinUI.API;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Report.JobReport
{
    public partial class frmJobReport : Form
    {
        private DateTimePicker dtpJobFrom;
        private DateTimePicker dtpJobTo;

        private APIService _jobService = new APIService("Job");
        public frmJobReport()
        {
            InitializeComponent();
        }

        public frmJobReport(DateTimePicker dtpJobFrom, DateTimePicker dtpJobTo) : this()
        {
            this.dtpJobFrom = dtpJobFrom;
            this.dtpJobTo = dtpJobTo;
        }

        private async void frmJobReport_Load(object sender, System.EventArgs e)
        {
            var list = await _jobService.Get<IEnumerable<JobViewModel>>();

            var res = list.AsQueryable();

            List<object> datasource = new List<object>();

            foreach(var x in res)
            {
                if(x.CreatedAt >= dtpJobFrom.Value && x.CreatedAt <= dtpJobTo.Value)
                {
                    string paid = "NE";
                    if (x.Paid == true)
                        paid = "DA";
                    datasource.Add(new
                    {
                        Id = x.Id,
                        EmployeeFullName = x.EmployeeFullName,
                        ServiceName = x.ServiceName,
                        JobDesc = x.JobDescription,
                        CreatedAt = x.CreatedAt.ToString("dd/MM/yyyy"),
                        Paid = paid,
                        FinishedDate = x.FinishedDate.ToString("dd/MM/yyyy"),
                        JobStatus = x.JobStatus,
                        UserFullName = x.UserFullName,
                        ServicePrice = x.ServicePrice
                    });
                }
            }

            double total = 0;
            foreach(var x in res)
            {
                total += x.ServiceRequest.Service.Price;
            }
            var rds = new ReportDataSource();
            rds.Name = "dsJob";
            rds.Value = datasource;

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DateFrom", dtpJobFrom.Value.ToString("dd/MM/yyyy")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DateTo", dtpJobTo.Value.ToString("dd/MM/yyyy")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Total", total.ToString()));

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
