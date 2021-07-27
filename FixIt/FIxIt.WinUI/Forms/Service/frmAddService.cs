using FixIt.Models.Models.Service;
using FixIt.Models.Models.ServiceType;
using FixIt.WinUI.API;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Service
{
    public partial class frmAddService : Form
    {
        private APIService _serviceTypes = new APIService("ServiceType");
        private APIService _serviceService = new APIService("Service");
        private ServiceViewModel service;

        public frmAddService()
        {
            InitializeComponent();
        }

        public frmAddService(ServiceViewModel service) : this()
        {
            this.service = service;
        }

        private async void frmAddService_Load(object sender, System.EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadTypes();
            if (service != null)
                LoadServiceDetails(service);
            else LoadHeading();
        }

        private void LoadHeading()
        {
            Font myFont = new Font("Segoe UI", 16.0f);
            Label heading = new Label
            {
                Text = "Nova usluga",
                Font = myFont,
                AutoSize = true
            };
            panel2.Controls.Add(heading);
        }

        private void LoadServiceDetails(ServiceViewModel service)
        {
            Font myFont = new Font("Segoe UI", 16.0f);
            Label heading = new Label
            {
                Text = service.Name,
                Font = myFont,
                AutoSize = true
            };
            panel2.Controls.Add(heading);
            textBox1.Text = service.Name;
            textBox2.Text = service.Price.ToString();
            textBox3.Text = service.Description;
            cbTypes.SelectedValue = service.ServiceTypeId;

            Label rating = new Label
            {
                Text = $"Rating: {Math.Round(service.Rating, 1).ToString()}/5",
                AutoSize = true,
                Top = 10
            };
            Label timesRequested = new Label
            {
                Text = $"Ukupan broj zahtjeva: {service.TimesRequested}",
                AutoSize = true,
                Top = 40
            };
            panel1.Controls.Add(rating);
            panel1.Controls.Add(timesRequested);
        }

        private async Task LoadTypes()
        {
            var list = await _serviceTypes.Get<List<ServiceTypeModel>>();
            list.Insert(0, new ServiceTypeModel());
            cbTypes.DataSource = list;
            cbTypes.DisplayMember = "Name";
            cbTypes.ValueMember = "Id";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new frmService();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Clear();
            this.Controls.Add(form);
            form.Show();
        }

        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            if (Validation())
            {
                ServiceInsertModel serviceInsertModel = new ServiceInsertModel()
                {
                    Name = textBox1.Text,
                    Price = int.Parse(textBox2.Text),
                    Description = textBox3.Text,
                    ServiceTypeId = int.Parse(cbTypes.SelectedValue.ToString())
                };
                ServiceUpdateModel serviceUpdatemodel = new ServiceUpdateModel()
                {
                    Name = textBox1.Text,
                    Price = int.Parse(textBox2.Text),
                    Description = textBox3.Text,
                    ServiceTypeId = int.Parse(cbTypes.SelectedValue.ToString())
                };

                //insert vs update
                if (service != null)
                    await _serviceService.Update<ServiceUpdateModel>(service.Id, serviceUpdatemodel);
                else await _serviceService.Insert<ServiceInsertModel>(serviceInsertModel);

                if (service == null)
                {
                    MessageBox.Show("Uspjesno ste dodali novu uslugu!");
                    var form = new frmService();
                    form.TopLevel = false;
                    form.Dock = DockStyle.Fill;
                    form.FormBorderStyle = FormBorderStyle.None;
                    this.Controls.Clear();
                    this.Controls.Add(form);
                    form.Show();
                }
                else MessageBox.Show("Uspjesno ste uredili uslugu!");
            }
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();

            bool number = int.TryParse(textBox2.Text, out int ok);
            if (number == false || ok <= 0)
            {
                errorProvider1.SetError(textBox2, "Obavezno polje! Cijena ne smije biti manja od nula!");
                return false;
            }
            else errorProvider1.Clear();

            if (int.TryParse(cbTypes.SelectedValue.ToString(), out int id))
            {
                if (id == 0)
                {
                    errorProvider1.SetError(cbTypes, "Obavezno polje!");
                    return false;
                }
            }
            else errorProvider1.Clear();
            return true;
        }
    }
}
