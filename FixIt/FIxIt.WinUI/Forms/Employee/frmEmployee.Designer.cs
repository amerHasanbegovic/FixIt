
namespace FixIt.WinUI.Forms.Employee
{
    partial class frmEmployee
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cmbProfession = new System.Windows.Forms.ComboBox();
            this.btnListOfEmployees = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uposlenici";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Pretraga uposlenika po imenu i prezimenu";
            this.textBox1.Size = new System.Drawing.Size(1064, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1095, 2);
            this.label2.TabIndex = 4;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 146);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(244, 29);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Dodaj novog uposlenika";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // cmbProfession
            // 
            this.cmbProfession.FormattingEnabled = true;
            this.cmbProfession.Location = new System.Drawing.Point(766, 147);
            this.cmbProfession.Name = "cmbProfession";
            this.cmbProfession.Size = new System.Drawing.Size(151, 28);
            this.cmbProfession.TabIndex = 6;
            this.cmbProfession.SelectedIndexChanged += new System.EventHandler(this.cmbProfession_SelectedIndexChanged);
            // 
            // btnListOfEmployees
            // 
            this.btnListOfEmployees.Location = new System.Drawing.Point(923, 147);
            this.btnListOfEmployees.Name = "btnListOfEmployees";
            this.btnListOfEmployees.Size = new System.Drawing.Size(153, 28);
            this.btnListOfEmployees.TabIndex = 7;
            this.btnListOfEmployees.Text = "Lista uposlenika";
            this.btnListOfEmployees.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Odaberi profesiju:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 205);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1064, 452);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 669);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnListOfEmployees);
            this.Controls.Add(this.cmbProfession);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cmbProfession;
        private System.Windows.Forms.Button btnListOfEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}