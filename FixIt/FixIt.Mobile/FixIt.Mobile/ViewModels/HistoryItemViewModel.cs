using FixIt.Mobile.Services;
using FixIt.Models.Models.Job;
using FixIt.Models.Models.ServiceRequest;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixIt.Mobile.ViewModels
{
    public class HistoryItemViewModel : BaseViewModel
    {
        private APIService _apiService = new APIService("Job");
        public ServiceRequestViewModel ServiceRequest { get; set; }

        private JobViewModel _job;
        public JobViewModel Job
        {
            get { return _job; }
            set { SetProperty(ref _job, value); }
        }

        public HistoryItemViewModel(ServiceRequestViewModel serviceRequest)
        {
            ServiceRequest = serviceRequest;
            if(ServiceRequest != null)
                GetJobByServiceRequestId(ServiceRequest.Id);
        }

        private async void GetJobByServiceRequestId(int id)
        {
            var result = await _apiService.GetJobByServiceRequestId<JobViewModel>(id);
            if (result != null)
                Job = result;
        }
    }
}
