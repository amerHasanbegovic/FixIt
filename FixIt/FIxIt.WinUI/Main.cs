using FixIt.Data.Models;
using FixIt.Models.Models.Service;
using FixIt.WinUI.API;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI
{
    public partial class Main : Form
    {
        public APIService _serviceService = new APIService("Service");
        public Main()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, System.EventArgs e)
        {
            //await LoadData();
        }

        //private async Task LoadData()
        //{
        //    ServiceSearchModel serviceSearchModel = new ServiceSearchModel() { };
        //    var list = await _serviceService.Get<IEnumerable<Service>>(serviceSearchModel);
        //    dataGridView1.DataSource = list;
        //}
    }
}
