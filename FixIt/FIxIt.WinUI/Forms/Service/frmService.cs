using FixIt.Models.Models.Service;
using FixIt.WinUI.API;
using System;
using System.Collections.Generic;
using System.Linq;
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
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        }

        private void btnAddService_Click(object sender, System.EventArgs e)
        {
            var form = new frmAddService();
            LoadForm(form);
        }

        private void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Clear();
            this.Controls.Add(form);
            form.Show();
        }
        private void DisplayPanel(string serviceName, double servicePrice, double serviceRating)
        {
            Panel p = new Panel();
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Width = 300;
            p.Height = 130;

            //labels
            Label name = new Label();
            name.AutoSize = true;
            name.Text = $"Naziv: {serviceName}";
            name.Left = 10;
            name.Top = 20;

            Label price = new Label();
            price.AutoSize = true;
            price.Text = $"Cijena: {servicePrice}KM";
            price.Left = 10;
            price.Top = 50;

            //button
            Label rating = new Label();
            rating.AutoSize = true;
            rating.Top = 80;
            rating.Left = 10;
            rating.Text = $"Rating: {Math.Round(serviceRating, 1)}/5";
            //details.Click += new System.EventHandler(this.btn_Click)


            p.Controls.Add(name);
            p.Controls.Add(price);
            p.Controls.Add(rating);
            flowLayoutPanel1.Controls.Add(p);
        }
        private async void frmService_Load(object sender, System.EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadServices();
            await LoadTopThree();
        }

        private async Task LoadTopThree()
        {
            var list = await _serviceService.Get<IEnumerable<ServiceViewModel>>();
            var res = list.AsQueryable();
            res = res.OrderByDescending(x => x.TimesRequested);
            int count = 0;
            if(res.Count() > 3)
            foreach(var x in res)
            {
                count++;
                DisplayPanel(x.Name, x.Price, x.Rating);
                if (count == 3)
                    break;
            }
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

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var service = dgvServices.SelectedRows[0].DataBoundItem as ServiceViewModel;
            var form = new frmAddService(service);
            LoadForm(form);
        }
    }
}
