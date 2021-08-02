using FixIt.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FixIt.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            this.BindingContext = new RegisterViewModel();
        }
        private async void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}