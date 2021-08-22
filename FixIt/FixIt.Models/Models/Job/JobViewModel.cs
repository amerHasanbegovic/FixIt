using FixIt.Models.Models.Employee;
using FixIt.Models.Models.JobStatus;
using FixIt.Models.Models.ServiceRequest;
using System;

namespace FixIt.Models.Models.Job
{
    public class JobViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public virtual EmployeeViewModel? Employee { get; set; }
        public int ServiceRequestId { get; set; }
        public virtual ServiceRequestViewModel? ServiceRequest { get; set; }
        public string? JobDescription { get; set; }
        public int JobStatusId { get; set; }
        public virtual JobStatusViewModel? Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? Paid { get; set; }
        public DateTime FinishedDate { get; set; }

        public string EmployeeFullName => $"{Employee?.Firstname} {Employee?.Lastname}";
        public string? ServiceName => ServiceRequest?.Service?.Name;
        public string UserFullName => $"{ServiceRequest?.User?.Firstname} {ServiceRequest?.User?.Lastname}";
        public string ServicePrice => $"{ServiceRequest?.Service?.Price.ToString()} KM";
        public string Price => $"{ServiceRequest?.Service?.Price.ToString()}";
        public string? JobStatus => Status?.Status;
        public string? FinishedDateFormated => FinishedDate.ToString("dd/MM/yyyy");
    }
}

