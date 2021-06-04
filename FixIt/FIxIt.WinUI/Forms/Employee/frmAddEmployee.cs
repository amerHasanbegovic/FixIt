using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Employee
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new frmEmployee();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Clear();
            this.Controls.Add(form);
            form.Show();
        }
    }
}
