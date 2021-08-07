using FixIt.Mobile.Services;
using FixIt.Mobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FixIt.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("" +
                "NDg0OTI0QDMxMzkyZTMyMmUzMFREdEhOdW9RK1FEUkQzVDBZTmxKOHF6ekJkU3lVWmhTUzdMSlUySFRiTHM9;" +
                "NDg0OTI1QDMxMzkyZTMyMmUzMFVJOC9VYlN2SUxLT2owUXlGSFI0bmc2RVREaEo0SndFNjVSOXdFV3NCdVU9;" +
                "NDg0OTI2QDMxMzkyZTMyMmUzMFVIakMwUnZjR3BmMEFJdzJaVWdiSnhlNTd3ejZUWFVKdVk5RVpseVdnak09;" +
                "NDg0OTI3QDMxMzkyZTMyMmUzMExhTUw4WUUzbXhxMGtFaWFKLzd6R2o3S0pqR1FGM2pXb0c4QUxLejRabVE9;" +
                "NDg0OTI4QDMxMzkyZTMyMmUzMFNWNkJTUkdGZDQ2M2JMTlBnd2txM2VEb2JmbFdrVkVQanFUUi93T1JCSms9;" +
                "NDg0OTI5QDMxMzkyZTMyMmUzMG5Jc2hLbTFBZjEwOGxpZ0lhcGpUVncrbEtGb1RJV0p2Mk1wTExwMGlYS0E9;" +
                "NDg0OTMwQDMxMzkyZTMyMmUzMFNhcjJYQTdvUTltMUZ6R0l2bWFtcVFxZ1JKditVV1hZdDFnWnNyTG93aXM9;" +
                "NDg0OTMxQDMxMzkyZTMyMmUzMFozMFBvVjBHS2hJUDFTaGFzZGd2em9MU29iWkJ5MVY4ZGxpQm9RNkpIOTA9;" +
                "NDg0OTMyQDMxMzkyZTMyMmUzMEhFTTluTFlYV2dFZ0F6NXNiRGI3R21FS0pPRUFzVTZ0dnNsSVkvT0NRRjA9;" +
                "NDg0OTMzQDMxMzkyZTMyMmUzMGs0Q0JDNUZNd0NuSTA2RmVtOWhYTWtTYmIzYkRXd1ZmTm13NDdyZmdIN0k9");
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
