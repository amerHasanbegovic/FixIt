using FixIt.Models.Models.ServiceRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixIt.Mobile.ViewModels
{
    public class HistoryItemViewModel : BaseViewModel
    {
        public ServiceRequestViewModel ServiceRequest { get; set; }
    }
}
