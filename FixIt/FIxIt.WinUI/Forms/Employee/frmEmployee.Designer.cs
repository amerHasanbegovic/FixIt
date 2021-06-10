
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
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uposlenici";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox1.Location = new System.Drawing.Point(12, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1064, 33);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-3, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1095, 2);
            this.label2.TabIndex = 4;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 117);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(244, 35);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Dodaj novog uposlenika";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cmbProfession
            // 
            this.cmbProfession.FormattingEnabled = true;
            this.cmbProfession.Location = new System.Drawing.Point(925, 118);
            this.cmbProfession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProfession.Name = "cmbProfession";
            this.cmbProfession.Size = new System.Drawing.Size(151, 24);
            this.cmbProfession.TabIndex = 6;
            this.cmbProfession.SelectedIndexChanged += new System.EventHandler(this.cmbProfession_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(791, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Odaberi profesiju:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 164);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1064, 494);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 669);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProfession);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}