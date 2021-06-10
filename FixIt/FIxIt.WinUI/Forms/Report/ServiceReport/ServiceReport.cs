using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Report.ServiceReport
{
    public partial class ServiceReport : Form
    {
        public ServiceReport()
        {
            InitializeComponent();
        }

        private void ServiceReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
