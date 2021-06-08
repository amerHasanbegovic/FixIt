using FixIt.Models.Models.User;
using FixIt.WinUI.Forms.Service;
using FixIt.WinUI.Helper;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Users
{
    public partial class frmUserDetails : Form
    {
        private UserViewModel user;

        public frmUserDetails()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        public frmUserDetails(UserViewModel user) : this()
        {
            this.user = user;
        }

        private void frmUserDetails_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadUserDetails();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new frmUsers();
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

        private void LoadUserDetails()
        {
            if(user != null)
            {
                label1.Text = user.Firstname + ' ' + user.Lastname;
                txtFullName.Text = user.Email;
                txtAddress.Text = user.Address;
                txtMemberSince.Text = user.MemberSince.ToString("dd/MM/yyyy");
                if(user.Sex != null)
                txtSex.Text = user.Sex.Name;
                if(user.City != null)
                txtCity.Text = user.City.Name;
                if (user.Photo.Length > 0)
                    pictureBox1.Image = ImageHelper.FromByteToImage(user.Photo);
                if (user.ServiceRequests != null)
                    dataGridView1.DataSource = user.ServiceRequests;
            }
        }
    }
}
