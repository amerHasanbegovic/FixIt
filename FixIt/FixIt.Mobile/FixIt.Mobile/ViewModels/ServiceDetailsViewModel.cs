using FixIt.Models.Models.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixIt.Mobile.ViewModels
{
    public class ServiceDetailsViewModel : BaseViewModel
    {
        public ServiceViewModel Service { get; set; }
        //private int Id;
        //private string Name;
        //private string Description;
        //private double Price;
        //private double Rating;
        //private string ServiceTypeName;

        //public int ServiceId
        //{
        //    get
        //    {
        //        return Id;
        //    }
        //    set
        //    {
        //        Id = value;
        //        LoadServiceId(value);
        //    }
        //}

        //private void LoadServiceId(int value)
        //{
        //    //try
        //    //{
        //    //    var item = await DataStore.GetItemAsync(itemId);
        //    //    Id = item.Id;
        //    //    Text = item.Text;
        //    //    Description = item.Description;
        //    //}
        //    //catch (Exception)
        //    //{
        //    //    Debug.WriteLine("Failed to Load Item");
        //    //}
        //}

        //public string ServiceName { get => Name; set => SetProperty(ref Name, value); }
        //public string ServiceDesc { get => Description; set => SetProperty(ref Description, value); }
        //public double ServicePrice { get => Price; set => SetProperty(ref Price, value); }
        //public double ServiceRating { get => Rating; set => SetProperty(ref Rating, value); }
        //public string ServiceServiceTypeName { get => ServiceTypeName; set => SetProperty(ref ServiceTypeName, value); }

    }
}
