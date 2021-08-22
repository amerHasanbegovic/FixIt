using FixIt.Mobile.ViewModels;
using FixIt.Models.Models.ServiceRequest;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FixIt.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        HistoryViewModel model;
        public HistoryPage()
        {
            InitializeComponent();
            BindingContext = model = new HistoryViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.OnAppearing();
        }

        private async void dataGrid_SelectionChanged(object sender, Syncfusion.SfDataGrid.XForms.GridSelectionChangedEventArgs e)
        {
            if(e.AddedItems.Count > 0)
            {
                ServiceRequestViewModel item = e.AddedItems[0] as ServiceRequestViewModel;
                await Navigation.PushAsync(new HistoryItemPage(item));
            }
        }
    }
}