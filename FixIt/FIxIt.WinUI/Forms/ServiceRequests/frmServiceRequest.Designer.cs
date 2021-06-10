
namespace FixIt.WinUI.Forms.ServiceRequests
{
    partial class frmServiceRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRequested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Početna";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserFullName,
            this.ServiceName,
            this.PaymentName,
            this.DateRequested,
            this.Processed});
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 447);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Redni br.";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // UserFullName
            // 
            this.UserFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserFullName.DataPropertyName = "UserFullName";
            this.UserFullName.HeaderText = "Klijent";
            this.UserFullName.MinimumWidth = 6;
            this.UserFullName.Name = "UserFullName";
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "Naziv usluge";
            this.ServiceName.MinimumWidth = 6;
            this.ServiceName.Name = "ServiceName";
            // 
            // PaymentName
            // 
            this.PaymentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaymentName.DataPropertyName = "PaymentTypeName";
            this.PaymentName.HeaderText = "Način plaćanja";
            this.PaymentName.MinimumWidth = 6;
            this.PaymentName.Name = "PaymentName";
            // 
            // DateRequested
            // 
            this.DateRequested.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateRequested.DataPropertyName = "RequestDate";
            this.DateRequested.HeaderText = "Datum zahtjeva";
            this.DateRequested.MinimumWidth = 6;
            this.DateRequested.Name = "DateRequested";
            // 
            // Processed
            // 
            this.Processed.DataPropertyName = "Processed";
            this.Processed.HeaderText = "Obrađen";
            this.Processed.MinimumWidth = 6;
            this.Processed.Name = "Processed";
            this.Processed.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pristigli zahtjevi za usluge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(9, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Klikom na zahjtev možete vidjeti detalje samog zahtjeva i kreirati posao";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1095, 2);
            this.label4.TabIndex = 6;
            // 
            // frmServiceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 669);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmServiceRequest";
            this.Text = "frmServiceRequest";
            this.Load += new System.EventHandler(this.frmServiceRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRequested;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Processed;
    }
}