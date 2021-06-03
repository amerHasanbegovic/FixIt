using FixIt.WinUI.Forms.Employee;
using FixIt.WinUI.Forms.Service;
using FixIt.WinUI.Forms.ServiceRequests;
using System.Windows.Forms;

namespace FixIt.WinUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            var form = new frmServiceRequest();
            LoadForm(form);
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            var form = new frmService();
            LoadForm(form);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            var form = new frmUsers();
            LoadForm(form);
        }

        private void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var form = new frmServiceRequest();
            LoadForm(form);
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            var form = new frmEmployee();
            LoadForm(form);
        }
    }
}
