using FixIt.Mobile.ViewModels;
using FixIt.Models.Models.Service;
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
    public partial class HomePage : ContentPage
    {
        HomeViewModel _model;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = _model = new HomeViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _model.OnAppearing();
        }

        private async void ServicesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                ServiceViewModel service = e.CurrentSelection[0] as ServiceViewModel;
                await Navigation.PushAsync(new ServiceDetailsPage(service));
            }
        }
    }
}