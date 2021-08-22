using FixIt.Mobile.Services;
using FixIt.Mobile.ViewModels;
using FixIt.Models.Models.ServiceRating;
using FixIt.Models.Models.ServiceRequest;
using FixIt.Models.Models.User;
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
    public partial class HistoryItemPage : ContentPage
    {
        HistoryItemViewModel model;
        private AuthService _authService = new AuthService("Auth");
        private APIService _apiService = new APIService("ServiceRating");
        public HistoryItemPage(ServiceRequestViewModel serviceRequest)
        {
            InitializeComponent();
            BindingContext = model = new HistoryItemViewModel(serviceRequest) { ServiceRequest = serviceRequest };
        }

        private async void SfRating_ValueChanged(object sender, Syncfusion.SfRating.XForms.ValueEventArgs e)
        {
            var rating = (int)e.Value;
            var user = await _authService.GetCurrentUser<UserViewModel>();
            if (user != null)
            {
                ServiceRatingInsertModel ratingModel = new ServiceRatingInsertModel()
                {
                    Rating = rating,
                    RatingDate = DateTime.Now,
                    ServiceId = model.ServiceRequest.Service.Id,
                    UserId = user.Id
                };
                await _apiService.Insert<ServiceRatingInsertModel>(ratingModel);
                await DisplayAlert("", "Hvala Vam što ste ocijenili uslugu!", "OK");
                await Navigation.PopAsync();
            }
        }
    }
}