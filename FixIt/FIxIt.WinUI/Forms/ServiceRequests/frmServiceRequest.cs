﻿using FixIt.Models.Models.ServiceRequest;
using FixIt.WinUI.API;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.Forms.ServiceRequests
{
    public partial class frmServiceRequest : Form
    {
        private APIService _serviceRequestService = new APIService("ServiceRequest");
        public frmServiceRequest()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private async void frmServiceRequest_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadServiceRequests();
        }

        private async Task LoadServiceRequests()
        {
            var list = await _serviceRequestService.Get<IEnumerable<ServiceRequestViewModel>>();
            dataGridView1.DataSource = list;
        }
    }
}
