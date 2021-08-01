using FixIt.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FixIt.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}