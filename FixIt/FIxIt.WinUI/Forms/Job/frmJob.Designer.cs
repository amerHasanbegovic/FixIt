
namespace FixIt.WinUI.Forms.Job
{
    partial class frmJob
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbActiveJobs = new System.Windows.Forms.CheckBox();
            this.cbFinishedJobs = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-3, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1095, 2);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Poslovi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Pretraga poslova";
            this.textBox1.Size = new System.Drawing.Size(1064, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbActiveJobs
            // 
            this.cbActiveJobs.AutoSize = true;
            this.cbActiveJobs.Location = new System.Drawing.Point(12, 143);
            this.cbActiveJobs.Name = "cbActiveJobs";
            this.cbActiveJobs.Size = new System.Drawing.Size(76, 24);
            this.cbActiveJobs.TabIndex = 6;
            this.cbActiveJobs.Text = "Aktivni";
            this.cbActiveJobs.UseVisualStyleBackColor = true;
            this.cbActiveJobs.CheckedChanged += new System.EventHandler(this.cbActiveJobs_CheckedChanged);
            // 
            // cbFinishedJobs
            // 
            this.cbFinishedJobs.AutoSize = true;
            this.cbFinishedJobs.Location = new System.Drawing.Point(94, 143);
            this.cbFinishedJobs.Name = "cbFinishedJobs";
            this.cbFinishedJobs.Size = new System.Drawing.Size(86, 24);
            this.cbFinishedJobs.TabIndex = 7;
            this.cbFinishedJobs.Text = "Završeni";
            this.cbFinishedJobs.UseVisualStyleBackColor = true;
            this.cbFinishedJobs.CheckedChanged += new System.EventHandler(this.cbFinishedJobs_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pregled poslova";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Service,
            this.User,
            this.EmployeeFullName,
            this.Price,
            this.Paid,
            this.CreatedAt,
            this.JobStatus});
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 345);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Redni br.";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 97;
            // 
            // Service
            // 
            this.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Service.DataPropertyName = "ServiceName";
            this.Service.HeaderText = "Usluga";
            this.Service.MinimumWidth = 6;
            this.Service.Name = "Service";
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User.DataPropertyName = "UserFullName";
            this.User.HeaderText = "Klijent";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            // 
            // EmployeeFullName
            // 
            this.EmployeeFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeFullName.DataPropertyName = "EmployeeFullName";
            this.EmployeeFullName.HeaderText = "Zaposlenik";
            this.EmployeeFullName.MinimumWidth = 6;
            this.EmployeeFullName.Name = "EmployeeFullName";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Price.DataPropertyName = "ServicePrice";
            this.Price.HeaderText = "Cijena";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 79;
            // 
            // Paid
            // 
            this.Paid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Paid.DataPropertyName = "Paid";
            this.Paid.HeaderText = "Plaćen";
            this.Paid.MinimumWidth = 6;
            this.Paid.Name = "Paid";
            this.Paid.Width = 58;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Datum nastanka";
            this.CreatedAt.MinimumWidth = 6;
            this.CreatedAt.Name = "CreatedAt";
            // 
            // JobStatus
            // 
            this.JobStatus.DataPropertyName = "JobStatus";
            this.JobStatus.HeaderText = "Status";
            this.JobStatus.MinimumWidth = 6;
            this.JobStatus.Name = "JobStatus";
            this.JobStatus.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Osvježi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbFinishedJobs);
            this.Controls.Add(this.cbActiveJobs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmJob";
            this.Text = "frmJob";
            this.Load += new System.EventHandler(this.frmJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbActiveJobs;
        private System.Windows.Forms.CheckBox cbFinishedJobs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobStatus;
        private System.Windows.Forms.Button button1;
    }
}