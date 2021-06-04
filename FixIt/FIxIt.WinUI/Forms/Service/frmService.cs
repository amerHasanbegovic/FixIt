﻿using System.Windows.Forms;

namespace FixIt.WinUI.Forms.Service
{
    public partial class frmService: Form
    {
        public frmService()
        {
            InitializeComponent();
        }

        private void btnAddService_Click(object sender, System.EventArgs e)
        {
            var form = new frmAddService();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Clear();
            this.Controls.Add(form);
            form.Show();
        }
    }
}
