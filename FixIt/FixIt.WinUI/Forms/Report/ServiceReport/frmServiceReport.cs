using FixIt.Models.Models.Service;
using FixIt.WinUI.API;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Report.ServiceReport
{
    public partial class frmServiceReport : Form
    {
        private APIService _serviceService = new APIService("Service");
        private DateTimePicker dtpServiceFrom;
        private DateTimePicker dtpServiceTo;

        public frmServiceReport()
        {
            InitializeComponent();
        }

        public frmServiceReport(DateTimePicker dtpServiceFrom, DateTimePicker dtpServiceTo) : this()
        {
            this.dtpServiceFrom = dtpServiceFrom;
            this.dtpServiceTo = dtpServiceTo;
        }

        private async void ServiceReport_Load(object sender, EventArgs e)
        {
            var list = await _serviceService.Get<IEnumerable<ServiceViewModel>>();

            var res = list.AsQueryable();

            List<object> datasource = new List<object>();
            foreach (var x in res)
            {
                int count = 0;
                double profit = 0;
                if (x.ServiceRequests != null)
                    foreach (var y in x.ServiceRequests)
                    {
                        if (y != null)
                        {
                            if(y.RequestDate >= dtpServiceFrom.Value && y.RequestDate <= dtpServiceTo.Value)
                            {
                                if (y.ServiceId == x.Id)
                                {
                                    count++;
                                    profit += x.Price;
                                }
                            }
                        }
                    }

                datasource.Add(new
                {
                    Id = x.Id,
                    ServiceName = x.Name,
                    ServicePrice = x.Price.ToString() + "KM",
                    ServiceDesc = x.Description,
                    Count = count.ToString(),
                    Profit = profit.ToString() + "KM"
                });
            }

            var rds = new ReportDataSource();
            rds.Name = "dsServices";
            rds.Value = datasource;

            this.reportViewer2.LocalReport.SetParameters(new ReportParameter("DateFrom", dtpServiceFrom.Value.ToString("dd/MM/yyyy")));
            this.reportViewer2.LocalReport.SetParameters(new ReportParameter("DateTo", dtpServiceTo.Value.ToString("dd/MM/yyyy")));


            this.reportViewer2.LocalReport.DataSources.Add(rds);
            this.reportViewer2.RefreshReport();
        }
    }
}
