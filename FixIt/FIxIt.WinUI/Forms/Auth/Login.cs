using FixIt.Models.Models.Auth;
using FixIt.WinUI.API;
using System;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Auth
{
    public partial class Login : Form
    {
        private AuthService _authService = new AuthService("Auth");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, System.EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Register();
            form.Show();
        }

        private async void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (Validation())
            {
                LoginModel loginModel = new LoginModel()
                {
                    UserName = textBox1.Text,
                    Password = textBox2.Text
                };

                var response = await _authService.Login<LoginResponseModel>(loginModel);
                if(response != null)
                {
                    APIService.token = response.token;
                    APIService.expiration = response.expiration;
                    var form = new Main();
                    form.Show();
                    this.Hide();
                }
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
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();

            return true;
        }
    }
}
