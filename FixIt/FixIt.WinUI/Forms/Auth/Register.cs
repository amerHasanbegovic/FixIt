using FixIt.Models.Models.Auth;
using FixIt.WinUI.API;
using System;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Auth
{
    public partial class Register : Form
    {
        private AuthService _authService = new AuthService("Auth");
        public Register()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (Validation())
            {
                RegisterAdminModel registerAdminModel = new RegisterAdminModel()
                {
                    UserName = textBox1.Text,
                    Password = textBox2.Text
                };
                var res = await _authService.Register<ResponseModel>(registerAdminModel);
                if (res != null && res.Status.Contains("Success"))
                {
                    MessageBox.Show("Uspješno ste se registrovali!");
                    this.Close();
                }
            };
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
