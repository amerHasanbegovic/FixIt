using FixIt.Models.Models.Service;
using FixIt.WinUI.API;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Service
{
    public partial class frmService: Form
    {
        private APIService _serviceService = new APIService("Service");
        public frmService()
        {
            InitializeComponent();
            dgvServices.AutoGenerateColumns = false;
        }

        private void btnAddService_Click(object sender, System.EventArgs e)
        {
            var form = new frmAddService();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Clear();
            this.Controls.Add(form);
            form.Show();
        }

        private async void frmService_Load(object sender, System.EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadServices();
        }

        private async Task LoadServices()
        {
            ServiceSearchModel serviceSearchModel = new ServiceSearchModel()
            {
                Name = textBox1.Text
            };

            var list = await _serviceService.Get<IEnumerable<ServiceViewModel>>(serviceSearchModel);
            dgvServices.DataSource = list;
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvServices.DataSource = null;
            await LoadServices();
        }
    }
}
