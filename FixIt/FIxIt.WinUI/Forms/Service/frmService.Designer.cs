
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescrition1 = new System.Windows.Forms.Label();
            this.lblCijena1 = new System.Windows.Forms.Label();
            this.lblNaziv1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDescrition2 = new System.Windows.Forms.Label();
            this.lblCijena2 = new System.Windows.Forms.Label();
            this.lblNaziv2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDescription3 = new System.Windows.Forms.Label();
            this.lblCijena3 = new System.Windows.Forms.Label();
            this.lblNaziv3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Pretraga usluga po nazivu";
            this.textBox1.Size = new System.Drawing.Size(1064, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usluge";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-3, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1095, 2);
            this.label2.TabIndex = 2;
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(12, 154);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(299, 67);
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
            this.dgvServices.Location = new System.Drawing.Point(12, 312);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 29;
            this.dgvServices.Size = new System.Drawing.Size(624, 334);
            this.dgvServices.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usluge";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblDescrition1);
            this.groupBox1.Controls.Add(this.lblCijena1);
            this.groupBox1.Controls.Add(this.lblNaziv1);
            this.groupBox1.Location = new System.Drawing.Point(712, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblDescrition1
            // 
            this.lblDescrition1.AutoSize = true;
            this.lblDescrition1.Location = new System.Drawing.Point(6, 84);
            this.lblDescrition1.Name = "lblDescrition1";
            this.lblDescrition1.Size = new System.Drawing.Size(50, 20);
            this.lblDescrition1.TabIndex = 10;
            this.lblDescrition1.Text = "label6";
            // 
            // lblCijena1
            // 
            this.lblCijena1.AutoSize = true;
            this.lblCijena1.Location = new System.Drawing.Point(6, 53);
            this.lblCijena1.Name = "lblCijena1";
            this.lblCijena1.Size = new System.Drawing.Size(50, 20);
            this.lblCijena1.TabIndex = 1;
            this.lblCijena1.Text = "label6";
            // 
            // lblNaziv1
            // 
            this.lblNaziv1.AutoSize = true;
            this.lblNaziv1.Location = new System.Drawing.Point(6, 23);
            this.lblNaziv1.Name = "lblNaziv1";
            this.lblNaziv1.Size = new System.Drawing.Size(50, 20);
            this.lblNaziv1.TabIndex = 0;
            this.lblNaziv1.Text = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDescrition2);
            this.groupBox2.Controls.Add(this.lblCijena2);
            this.groupBox2.Controls.Add(this.lblNaziv2);
            this.groupBox2.Location = new System.Drawing.Point(712, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 137);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // lblDescrition2
            // 
            this.lblDescrition2.AutoSize = true;
            this.lblDescrition2.Location = new System.Drawing.Point(6, 83);
            this.lblDescrition2.Name = "lblDescrition2";
            this.lblDescrition2.Size = new System.Drawing.Size(50, 20);
            this.lblDescrition2.TabIndex = 4;
            this.lblDescrition2.Text = "label5";
            // 
            // lblCijena2
            // 
            this.lblCijena2.AutoSize = true;
            this.lblCijena2.Location = new System.Drawing.Point(6, 53);
            this.lblCijena2.Name = "lblCijena2";
            this.lblCijena2.Size = new System.Drawing.Size(50, 20);
            this.lblCijena2.TabIndex = 3;
            this.lblCijena2.Text = "label7";
            // 
            // lblNaziv2
            // 
            this.lblNaziv2.AutoSize = true;
            this.lblNaziv2.Location = new System.Drawing.Point(6, 23);
            this.lblNaziv2.Name = "lblNaziv2";
            this.lblNaziv2.Size = new System.Drawing.Size(50, 20);
            this.lblNaziv2.TabIndex = 2;
            this.lblNaziv2.Text = "label8";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDescription3);
            this.groupBox3.Controls.Add(this.lblCijena3);
            this.groupBox3.Controls.Add(this.lblNaziv3);
            this.groupBox3.Location = new System.Drawing.Point(712, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 144);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // lblDescription3
            // 
            this.lblDescription3.AutoSize = true;
            this.lblDescription3.Location = new System.Drawing.Point(6, 82);
            this.lblDescription3.Name = "lblDescription3";
            this.lblDescription3.Size = new System.Drawing.Size(50, 20);
            this.lblDescription3.TabIndex = 12;
            this.lblDescription3.Text = "label5";
            // 
            // lblCijena3
            // 
            this.lblCijena3.AutoSize = true;
            this.lblCijena3.Location = new System.Drawing.Point(6, 53);
            this.lblCijena3.Name = "lblCijena3";
            this.lblCijena3.Size = new System.Drawing.Size(50, 20);
            this.lblCijena3.TabIndex = 11;
            this.lblCijena3.Text = "label9";
            // 
            // lblNaziv3
            // 
            this.lblNaziv3.AutoSize = true;
            this.lblNaziv3.Location = new System.Drawing.Point(6, 23);
            this.lblNaziv3.Name = "lblNaziv3";
            this.lblNaziv3.Size = new System.Drawing.Size(58, 20);
            this.lblNaziv3.TabIndex = 10;
            this.lblNaziv3.Text = "label10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(712, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Najtraženije usluge";
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
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 669);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MinimizeBox = false;
            this.Name = "frmService";
            this.Load += new System.EventHandler(this.frmService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCijena1;
        private System.Windows.Forms.Label lblNaziv1;
        private System.Windows.Forms.Label lblCijena2;
        private System.Windows.Forms.Label lblNaziv2;
        private System.Windows.Forms.Label lblCijena3;
        private System.Windows.Forms.Label lblNaziv3;
        private System.Windows.Forms.Label lblDescrition1;
        private System.Windows.Forms.Label lblDescrition2;
        private System.Windows.Forms.Label lblDescription3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}