using FixIt.Mobile.ViewModels;
using FixIt.Models.Models.City;
using FixIt.Models.Models.Sex;
using Plugin.FilePicker;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FixIt.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProfilePage : ContentPage
    {
        EditProfileViewModel model = null;
        public EditProfilePage()
        {
            InitializeComponent();
            BindingContext = model = new EditProfileViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.OnAppearing();
        }

        private void cityPicker_BindingContextChanged(object sender, System.EventArgs e)
        {
            var picker = sender as Picker;
            model.Cities.Insert(0, new CityViewModel());
            picker.ItemsSource = model.Cities;
            picker.SelectedItem = model.UserCity;
        }

        private void sexPicker_BindingContextChanged(object sender, System.EventArgs e)
        {
            var picker = sender as Picker;
            model.Sexes.Insert(0, new SexViewModel());
            picker.ItemsSource = model.Sexes;
            picker.SelectedItem = model.UserSex;
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            var file = await CrossFilePicker.Current.PickFile();
            string fileName;
            if (file != null)
            {
                fileName = file.FileName;
                var image = File.ReadAllBytes(fileName);
                model.Image = image;
            }

        }

        private void cityPicker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var picker = sender as Picker;
            var value = picker.SelectedItem as CityViewModel;
            model.CityId = value.Id;
        }

        private void sexPicker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var picker = sender as Picker;
            var value = picker.SelectedItem as SexViewModel;
            model.SexId = value.Id;
        }
    }
}