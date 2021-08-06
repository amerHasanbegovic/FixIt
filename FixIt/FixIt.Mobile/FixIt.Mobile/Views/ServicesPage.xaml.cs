using FixIt.Mobile.Services;
using FixIt.Mobile.ViewModels;
using FixIt.Models.Models.Service;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FixIt.Mobile.Views
{
    public partial class ServicesPage : ContentPage
    {
        ServicesViewModel _viewModel;
        private APIService _apiService = new APIService("Service");
        public ServicesPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ServicesViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        private async void ServicesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                ServiceViewModel service = e.CurrentSelection[0] as ServiceViewModel;
                await Navigation.PushAsync(new ServiceDetailsPage(service));
            }
        }

        private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            ServiceSearchModel model = new ServiceSearchModel
            {
                Name = searchBar.Text
            };
            ServicesListView.ItemsSource = await _apiService.Get<IEnumerable<ServiceViewModel>>(model);
        }
    }
}