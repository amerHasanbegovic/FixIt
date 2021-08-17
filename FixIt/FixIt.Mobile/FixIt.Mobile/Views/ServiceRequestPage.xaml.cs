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
    public partial class ServiceRequestPage : ContentPage
    {
        private ServiceRequestsViewModel model;

        public ServiceRequestPage(ServiceViewModel service)
        {
            InitializeComponent();
            BindingContext = model = new ServiceRequestsViewModel() { Service = service };
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var radio = sender as RadioButton;
            if (radio.IsChecked)
            {
                model.PaymentTypeId = 2;
                accEntry.IsEnabled = nameEntry.IsEnabled = cvvEntry.IsEnabled = datePicker.IsEnabled = false;
                accEntry.Text = nameEntry.Text = cvvEntry.Text = null;
                datePicker.Date = DateTime.Now;
            }
        }
        private void RadioButton_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
        {
            var radio = sender as RadioButton;
            if (radio.IsChecked)
            {
                model.PaymentTypeId = 1;
                accEntry.IsEnabled = nameEntry.IsEnabled = cvvEntry.IsEnabled = datePicker.IsEnabled = true;
                accEntry.Text = nameEntry.Text = cvvEntry.Text = null;
                datePicker.Date = DateTime.Now;
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.OnAppearing();
        }

    }
}