
namespace FixIt.WinUI.Forms.Report
{
    partial class frmReport
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtpServiceFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpServiceTo = new System.Windows.Forms.DateTimePicker();
            this.btnServiceReport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpJobFrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpJobTo = new System.Windows.Forms.DateTimePicker();
            this.btnJobReport = new System.Windows.Forms.Button();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEmployeeFrom = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpEmployeeTo = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1095, 2);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izvještaji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izvještaj o uslugama";
            // 
            // dtpServiceFrom
            // 
            this.dtpServiceFrom.Location = new System.Drawing.Point(51, 126);
            this.dtpServiceFrom.Name = "dtpServiceFrom";
            this.dtpServiceFrom.Size = new System.Drawing.Size(250, 27);
            this.dtpServiceFrom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Do:";
            // 
            // dtpServiceTo
            // 
            this.dtpServiceTo.Location = new System.Drawing.Point(358, 126);
            this.dtpServiceTo.Name = "dtpServiceTo";
            this.dtpServiceTo.Size = new System.Drawing.Size(250, 27);
            this.dtpServiceTo.TabIndex = 9;
            // 
            // btnServiceReport
            // 
            this.btnServiceReport.Location = new System.Drawing.Point(639, 126);
            this.btnServiceReport.Name = "btnServiceReport";
            this.btnServiceReport.Size = new System.Drawing.Size(94, 27);
            this.btnServiceReport.TabIndex = 10;
            this.btnServiceReport.Text = "Printaj";
            this.btnServiceReport.UseVisualStyleBackColor = true;
            this.btnServiceReport.Click += new System.EventHandler(this.btnServiceReport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Izvještaj o poslovima";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Od:";
            // 
            // dtpJobFrom
            // 
            this.dtpJobFrom.Location = new System.Drawing.Point(51, 226);
            this.dtpJobFrom.Name = "dtpJobFrom";
            this.dtpJobFrom.Size = new System.Drawing.Size(250, 27);
            this.dtpJobFrom.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Do:";
            // 
            // dtpJobTo
            // 
            this.dtpJobTo.Location = new System.Drawing.Point(358, 226);
            this.dtpJobTo.Name = "dtpJobTo";
            this.dtpJobTo.Size = new System.Drawing.Size(250, 27);
            this.dtpJobTo.TabIndex = 15;
            // 
            // btnJobReport
            // 
            this.btnJobReport.Location = new System.Drawing.Point(639, 225);
            this.btnJobReport.Name = "btnJobReport";
            this.btnJobReport.Size = new System.Drawing.Size(94, 27);
            this.btnJobReport.TabIndex = 16;
            this.btnJobReport.Text = "Printaj";
            this.btnJobReport.UseVisualStyleBackColor = true;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(14, 333);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(267, 28);
            this.cmbEmployee.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(14, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Izvještaj o uposleniku";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Od:";
            // 
            // dtpEmployeeFrom
            // 
            this.dtpEmployeeFrom.Location = new System.Drawing.Point(335, 334);
            this.dtpEmployeeFrom.Name = "dtpEmployeeFrom";
            this.dtpEmployeeFrom.Size = new System.Drawing.Size(250, 27);
            this.dtpEmployeeFrom.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(601, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Do:";
            // 
            // dtpEmployeeTo
            // 
            this.dtpEmployeeTo.Location = new System.Drawing.Point(639, 334);
            this.dtpEmployeeTo.Name = "dtpEmployeeTo";
            this.dtpEmployeeTo.Size = new System.Drawing.Size(250, 27);
            this.dtpEmployeeTo.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(920, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 23;
            this.button1.Text = "Printaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpEmployeeTo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpEmployeeFrom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.btnJobReport);
            this.Controls.Add(this.dtpJobTo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpJobFrom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnServiceReport);
            this.Controls.Add(this.dtpServiceTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpServiceFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpServiceFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpServiceTo;
        private System.Windows.Forms.Button btnServiceReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpJobFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpJobTo;
        private System.Windows.Forms.Button btnJobReport;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEmployeeFrom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpEmployeeTo;
        private System.Windows.Forms.Button button1;
    }
}