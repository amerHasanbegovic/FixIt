using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Service
{
    public partial class frmAddService : Form
    {
        public frmAddService()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new frmService();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Clear();
            this.Controls.Add(form);
            form.Show();
        }
    }
}
