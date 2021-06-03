
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 345);
            this.dataGridView1.TabIndex = 8;
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
            // frmJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 669);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbFinishedJobs);
            this.Controls.Add(this.cbActiveJobs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmJob";
            this.Text = "frmJob";
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}