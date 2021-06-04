using FixIt.Data.Models;
using FixIt.Models.Models.Employee;
using FixIt.Models.Models.Profession;
using FixIt.WinUI.API;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Employee
{
    public partial class frmEmployee : Form
    {
        private APIService _professionService = new APIService("Profession");
        private APIService _employeeService = new APIService("Employee");
        public frmEmployee()
        {
            InitializeComponent();
        }

        private async void frmEmployee_Load(object sender, System.EventArgs e)
        {
            await LoadData();
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.AutoScroll = true;
        }

        private async Task LoadData()
        {
            await LoadProfessions();
            await LoadEmployees();
        }

        private async Task LoadEmployees(int professionId = 0)
        {
            EmployeeSearchModel employeeSearchModel = new EmployeeSearchModel()
            {
                FirstOrLastName = textBox1.Text,
            };
            if (professionId != 0)
                employeeSearchModel.ProfessionId = professionId;


            var list = await _employeeService.Get<List<EmployeeViewModel>>(employeeSearchModel);
            foreach (var x in list)
                DisplayPanel(x.Firstname, x.Lastname, x.Photo, x.Profession.Name);
        }

        private void DisplayPanel(string firstName, string lastName, byte[] photo, string professionName)
        {
            Panel p = new Panel();
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Width = 320;
            p.Height = 420;
            
            //picture box
            PictureBox pbx = new PictureBox();
            //pbx.Image = 
            pbx.BorderStyle = BorderStyle.FixedSingle;
            pbx.Left = 10;
            pbx.Top = 10;
            pbx.Width = 180;
            pbx.Height = 200;

            //labels
            Label name = new Label();
            name.AutoSize = true;
            name.Text = $"Ime i prezime:\r\n{firstName} {lastName}";
            name.Left = 10;
            name.Top = 230;

            Label profession = new Label();
            profession.AutoSize = true;
            profession.Text = $"Profesija:\r\n{professionName}";
            profession.Left = 10;
            profession.Top = 280;

            //button
            Button details = new Button();
            details.Top = 350;
            details.Left = 10;
            details.Height = 40;
            details.Width = 100;
            details.Text = "Detalji";
            //details.Click += new System.EventHandler(this.btn_Click)


            p.Controls.Add(pbx);
            p.Controls.Add(name);
            p.Controls.Add(profession);
            p.Controls.Add(details);
            flowLayoutPanel1.Controls.Add(p);
        }

        private async Task LoadProfessions()
        {
            var list = await _professionService.Get<List<ProfessionViewModel>>();
            list.Insert(0, new ProfessionViewModel());
            cmbProfession.DataSource = list;
            cmbProfession.DisplayMember = "Name";
            cmbProfession.ValueMember = "Id";
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            await LoadEmployees();
        }

        private async void cmbProfession_SelectedIndexChanged(object sender, EventArgs e)
        {
            var profid = cmbProfession.SelectedValue;
            if (int.TryParse(profid.ToString(), out int id))
            {
                flowLayoutPanel1.Controls.Clear();
                await LoadEmployees(id);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var form = new frmAddEmployee();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Clear();
            this.Controls.Add(form);
            form.Show();
        }
    }
}
