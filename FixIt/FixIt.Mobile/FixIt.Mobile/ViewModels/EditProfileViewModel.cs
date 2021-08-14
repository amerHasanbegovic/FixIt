using FixIt.Mobile.Services;
using FixIt.Mobile.Views;
using FixIt.Models.Models.City;
using FixIt.Models.Models.Sex;
using FixIt.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FixIt.Mobile.ViewModels
{
    public class EditProfileViewModel : BaseViewModel
    {
        private AuthService _authService = new AuthService("Auth");
        private APIService _cityService = new APIService("City");
        private APIService _sexService = new APIService("Sex");
        private APIService _userService = new APIService("User");

        public ObservableCollection<UserViewModel> Profile { get; set; }
        public ObservableCollection<SexViewModel> Sexes { get; set; }
        public ObservableCollection<CityViewModel> Cities { get; set; }

        public Command SaveChangesCommand { get; set; }

        public string _userId = string.Empty;
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _address = string.Empty;
        private string _userCity = string.Empty;
        private string _userSex = string.Empty;
        private int _sexId;
        private int _cityId;
        private byte[] _image = null;
        public EditProfileViewModel()
        {
            Profile = new ObservableCollection<UserViewModel>();
            Cities = new ObservableCollection<CityViewModel>();
            Sexes = new ObservableCollection<SexViewModel>();
            SaveChangesCommand = new Command(async () => await SaveChanges());
            Load();
        }

        public string UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        public string UserCity
        {
            get { return _userCity; }
            set { SetProperty(ref _userCity, value); }
        }
        public string UserSex
        {
            get { return _userSex; }
            set { SetProperty(ref _userSex, value); }
        }
        public byte[] Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value); }
        }
        public int CityId
        {
            get { return _cityId; }
            set { SetProperty(ref _cityId, value); }
        }
        public int SexId
        {
            get { return _sexId; }
            set { SetProperty(ref _sexId, value); }
        }

        private async void Load()
        {
            await ExecuteLoadProfileCommand();
        }

        public async Task ExecuteLoadProfileCommand()
        {
            IsBusy = true;
            try
            {
                Profile.Clear();
                Cities.Clear();
                Sexes.Clear();
                var profile = await _authService.GetCurrentUser<UserViewModel>();
                var user = await _userService.GetById<UserViewModel>(profile.Id);
                var cities = await _cityService.Get<List<CityViewModel>>();
                var sexes = await _sexService.Get<List<SexViewModel>>();

                Profile.Add(user);
                foreach (var c in cities)
                    Cities.Add(c);
                foreach (var s in sexes)
                    Sexes.Add(s);

                UserId = user.Id;
                if (user.City != null)
                {
                    UserCity = user.City.Name;
                    CityId = user.City.Id;
                }
                if (user.Sex != null)
                {
                    UserSex = user.Sex.Name;
                    SexId = user.Sex.Id;
                }
                FirstName = user.Firstname;
                LastName = user.Lastname;
                Address = user.Address;
                if (user.Photo != null)
                    Image = user.Photo;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        public void OnAppearing()
        {
            IsBusy = true;
        }

        public async Task SaveChanges()
        {
            //firstname
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                await Application.Current.MainPage.DisplayAlert("", "Ime je obavezno polje", "OK");
                return;
            }
            bool firstNameContainsInt = FirstName.Any(char.IsDigit);
            if (firstNameContainsInt)
            {
                await Application.Current.MainPage.DisplayAlert("", "Brojevi u imenu nisu dozovljeni!", "OK");
                return;
            }

            //lastname
            if (string.IsNullOrWhiteSpace(LastName))
            {
                await Application.Current.MainPage.DisplayAlert("", "Prezime je obavezno polje", "OK");
                return;
            }
            bool lastNameContainsInt = LastName.Any(char.IsDigit);
            if (lastNameContainsInt)
            {
                await Application.Current.MainPage.DisplayAlert("", "Brojevi u prezimenu nisu dozovljeni!", "OK");
                return;
            }

            var updateModel = new UserUpdateModel()
            {
                Firstname = FirstName,
                Lastname = LastName,
                Address = Address,
                Photo = Image
            };
            if (SexId != 0)
                updateModel.SexId = SexId;
            if (CityId != 0)
                updateModel.CityId = CityId;

            var update = await _userService.Update<UserUpdateModel>(UserId, updateModel);
            if (update != null)
            {
                await Application.Current.MainPage.DisplayAlert("", "Uspješno ste uredili profil!", "OK");
                await Application.Current.MainPage.Navigation.PopToRootAsync();
            }
        }

    }
}
