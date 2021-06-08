using FixIt.Models.Models.User;
using FixIt.WinUI.API;
using FixIt.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Service
{
    public partial class frmUsers : Form
    {
        private APIService _userService = new APIService("User");
        public frmUsers()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
        }

        private async void frmUsers_Load(object sender, System.EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadUsers();
        }

        private async Task LoadUsers(DateTime dateFrom = default, DateTime dateTo = default)
        {
            UserSearchModel userSearchModel = new UserSearchModel()
            {
                FirstOrLastName = textBox1.Text
            };
            if (dateFrom != default)
                userSearchModel.RegisterDateFrom = dateFrom.Date;
            if (dateTo != default)
                userSearchModel.RegisterDateTo = dateTo.Date;

            var list = await _userService.Get<IEnumerable<UserViewModel>>(userSearchModel);
            foreach (var x in list)
                DisplayPanel(x.Firstname, x.Lastname, x.Photo, x.MemberSince);
        }

        private void DisplayPanel(string firstName, string lastName, byte[] photo, DateTime memberSince)
        {
            Panel p = new Panel();
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Width = 320;
            p.Height = 400;

            //picture box
            PictureBox pbx = new PictureBox();
            if (photo.Length > 0)
            {
                pbx.Image = ImageHelper.FromByteToImage(photo);
            }
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
            profession.Text = $"Aktivan od:\r\n{memberSince.ToString("dd/MM/yyyy")}";
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

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            await LoadUsers();
        }

        private async void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value != default && dtpTo.Value != default)
            {
                flowLayoutPanel1.Controls.Clear();
                await LoadUsers(dtpFrom.Value, dtpTo.Value);
            }
            else await LoadUsers(dtpFrom.Value, default);
        }

        private async void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTo.Value != default && dtpFrom.Value != default)
            {
                flowLayoutPanel1.Controls.Clear();
                await LoadUsers(dtpFrom.Value, dtpTo.Value);
            }
            else await LoadUsers(default, dtpTo.Value);
        }

        private async void btnShowAll_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            flowLayoutPanel1.Controls.Clear();
            await LoadUsers();
        }
    }
}
