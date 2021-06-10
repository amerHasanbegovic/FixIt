
namespace FixIt.WinUI.Forms.Service
{
    partial class frmService
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1196, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usluge";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-3, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1232, 2);
            this.label2.TabIndex = 2;
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddService.Location = new System.Drawing.Point(14, 138);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(336, 61);
            this.btnAddService.TabIndex = 3;
            this.btnAddService.Text = "Dodaj novu uslugu";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // dgvServices
            // 
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.ServiceType,
            this.Price});
            this.dgvServices.Location = new System.Drawing.Point(14, 281);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 29;
            this.dgvServices.Size = new System.Drawing.Size(702, 377);
            this.dgvServices.TabIndex = 4;
            this.dgvServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellDoubleClick);
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceName.DataPropertyName = "Name";
            this.ServiceName.HeaderText = "Naziv usluge";
            this.ServiceName.MinimumWidth = 6;
            this.ServiceName.Name = "ServiceName";
            // 
            // ServiceType
            // 
            this.ServiceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceType.DataPropertyName = "ServiceTypeName";
            this.ServiceType.HeaderText = "Tip";
            this.ServiceType.MinimumWidth = 6;
            this.ServiceType.Name = "ServiceType";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Cijena (KM)";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(14, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Duplim klikom na neku od usluge možete vidjeti sve detalje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(755, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Najtraženije usluge";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(758, 171);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(318, 487);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 669);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmService";
            this.Load += new System.EventHandler(this.frmService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}