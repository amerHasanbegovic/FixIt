using FixIt.Models.Models.City;
using FixIt.Models.Models.Employee;
using FixIt.Models.Models.Profession;
using FixIt.Models.Models.Sex;
using FixIt.WinUI.API;
using FixIt.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Employee
{
    public partial class frmAddEmployee : Form
    {
        private APIService _professionService = new APIService("Profession");
        private APIService _sexService = new APIService("Sex");
        private APIService _cityService = new APIService("City");
        private APIService _employeeService = new APIService("Employee");
        private EmployeeViewModel employee;

        public frmAddEmployee()
        {
            InitializeComponent();
        }

        public frmAddEmployee(EmployeeViewModel employee) : this()
        {
            this.employee = employee;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new frmEmployee();
            LoadForm(form);
        }

        public void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Clear();
            this.Controls.Add(form);
            form.Show();
        }
        private async void frmAddEmployee_Load(object sender, System.EventArgs e)
        {
            txtPath.Hide();
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadProfessions();
            await LoadCities();
            await LoadSex();
            if (employee != null)
            {
                Label edit = new Label();
                Font myFont = new Font("Segoe UI", 14.0f);
                edit.Font = myFont;
                edit.Text = "Uređivanje";
                edit.AutoSize = true;
                edit.Top = 10;

                Button delete = new Button();
                delete.Text = "Obriši uposlenika";
                delete.AutoSize = true;
                delete.Top = 50;
                delete.Click += (sender, e) => DeleteEmployee(employee.Id);

                panel1.Controls.Add(edit);
                panel1.Controls.Add(delete);
                LoadEmployeeDetails();
            }
            else
            {
                Label edit = new Label();
                Font myFont = new Font("Segoe UI", 16.0f);
                edit.Font = myFont;
                edit.Text = "Novi uposlenik";
                edit.AutoSize = true;
                edit.Top = 15;

                panel1.Controls.Add(edit);
            }
        }

        private async void DeleteEmployee(int id)
        {
            await _employeeService.Delete<EmployeeViewModel>(id);
            MessageBox.Show("Uspješno ste obrisali uposlenika!");
            var form = new frmEmployee();
            LoadForm(form);
        }

        private void LoadEmployeeDetails()
        {
            txtName.Text = employee.Firstname;
            txtLastName.Text = employee.Lastname;
            txtBio.Text = employee.Biography;
            txtPhone.Text = employee.PhoneNumber;
            txtAddress.Text = employee.Address;
            if (employee.Photo.Length > 0)
                pbImage.Image = GetEmployeeImage(employee.Photo);
            cmbCity.SelectedValue = employee.CityId;
            cbSex.SelectedValue = employee.SexId;
            cbProfession.SelectedValue = employee.ProfessionId;
            dateTimePicker1.Value = employee.BirthDate;
        }

        private Image GetEmployeeImage(byte[] photo)
        {
            using (MemoryStream ms = new MemoryStream(employee.Photo))
                return Image.FromStream(ms);
        }

        private async Task LoadSex()
        {
            var list = await _sexService.Get<List<SexViewModel>>();
            list.Insert(0, new SexViewModel());
            cbSex.DataSource = list;
            cbSex.ValueMember = "Id";
            cbSex.DisplayMember = "Name";
        }

        private async Task LoadCities()
        {
            var list = await _cityService.Get<List<CityViewModel>>();
            list.Insert(0, new CityViewModel());
            cmbCity.DataSource = list;
            cmbCity.ValueMember = "Id";
            cmbCity.DisplayMember = "Name";
        }

        private async Task LoadProfessions()
        {
            var list = await _professionService.Get<List<ProfessionViewModel>>();
            list.Insert(0, new ProfessionViewModel());
            cbProfession.DataSource = list;
            cbProfession.ValueMember = "Id";
            cbProfession.DisplayMember = "Name";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (employee != null)
                {
                    EmployeeUpdateModel employeeUpdateModel = new EmployeeUpdateModel()
                    {
                        Address = txtAddress.Text,
                        Biography = txtBio.Text,
                        BirthDate = dateTimePicker1.Value,
                        CityId = int.Parse(cmbCity.SelectedValue.ToString()),
                        ProfessionId = int.Parse(cbProfession.SelectedValue.ToString()),
                        Firstname = txtName.Text,
                        Lastname = txtLastName.Text,
                        PhoneNumber = txtPhone.Text,
                        SexId = cbSex.SelectedIndex
                    };
                    if (pbImage.Image != null)
                        employeeUpdateModel.Photo = ImageHelper.FromImageToByte(pbImage.Image);

                    await _employeeService.Update<EmployeeViewModel>(employee.Id, employeeUpdateModel);
                    MessageBox.Show("Uspješno ste uredili podatke o uposleniku!");
                }
                else
                {

                    EmployeeInsertModel employeeInsertModel = new EmployeeInsertModel()
                    {
                        Address = txtAddress.Text,
                        Biography = txtBio.Text,
                        BirthDate = dateTimePicker1.Value,
                        CityId = int.Parse(cmbCity.SelectedValue.ToString()),
                        ProfessionId = int.Parse(cbProfession.SelectedValue.ToString()),
                        Firstname = txtName.Text,
                        Lastname = txtLastName.Text,
                        HireDate = DateTime.Now,
                        PhoneNumber = txtPhone.Text,
                        SexId = cbSex.SelectedIndex
                    };
                    if (pbImage.Image != null)
                        employeeInsertModel.Photo = ImageHelper.FromImageToByte(pbImage.Image);

                    await _employeeService.Insert<EmployeeViewModel>(employeeInsertModel);
                    MessageBox.Show("Uspješno ste dodali uposlenika!");
                    var form = new frmEmployee();
                    form.TopLevel = false;
                    form.Dock = DockStyle.Fill;
                    form.FormBorderStyle = FormBorderStyle.None;
                    this.Controls.Clear();
                    this.Controls.Add(form);
                    form.Show();
                }
            }
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            if (cbProfession.SelectedIndex == 0)
            {
                errorProvider1.SetError(cbProfession, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            if (cbSex.SelectedIndex == 0)
            {
                errorProvider1.SetError(cbSex, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            if (cmbCity.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbCity, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();

            return true;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            var res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                pbImage.Image = Image.FromFile(fileName);
                txtPath.Text = fileName;
            }
        }
    }
}
