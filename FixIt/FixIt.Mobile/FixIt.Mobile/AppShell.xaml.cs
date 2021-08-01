using FixIt.Mobile.ViewModels;
using FixIt.Mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FixIt.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
