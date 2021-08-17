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
    public partial class ServiceDetailsPage : ContentPage
    {
        ServiceDetailsViewModel model = null;

        public ServiceDetailsPage(ServiceViewModel service)
        {
            InitializeComponent();
            BindingContext = model = new ServiceDetailsViewModel() { Service = service };
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ServiceRequestPage(model.Service));
        }
    }
}