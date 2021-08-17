using FixIt.Mobile.Services;
using FixIt.Mobile.ViewModels;
using Plugin.FilePicker;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FixIt.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        ProfileViewModel model;
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = model = new ProfileViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.OnAppearing();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditProfilePage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //logout
            var result = await DisplayAlert("Odjava", "Da li ste sigurni da se želite odjaviti?", "Da", "Otkaži");
            if (result)
            {
                APIService.token = null;
                APIService.expiration = DateTime.Now;
                Application.Current.MainPage = new LoginPage();
            }
        }
    }
}