
namespace FixIt.WinUI.Forms.Employee
{
    partial class frmAddEmployee
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblfirstName = new System.Windows.Forms.Label();
            this.lbllastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cbProfession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.Location = new System.Drawing.Point(742, 624);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(13, 138);
            this.pbImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(291, 342);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-3, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1095, 2);
            this.label2.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linkLabel1.Location = new System.Drawing.Point(13, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 18);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nazad";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddImage.Location = new System.Drawing.Point(16, 484);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(291, 34);
            this.btnAddImage.TabIndex = 7;
            this.btnAddImage.Text = "Dodaj sliku";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtName.Location = new System.Drawing.Point(546, 138);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 24);
            this.txtName.TabIndex = 8;
            // 
            // lblfirstName
            // 
            this.lblfirstName.AutoSize = true;
            this.lblfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblfirstName.Location = new System.Drawing.Point(332, 141);
            this.lblfirstName.Name = "lblfirstName";
            this.lblfirstName.Size = new System.Drawing.Size(36, 18);
            this.lblfirstName.TabIndex = 9;
            this.lblfirstName.Text = "Ime:";
            // 
            // lbllastName
            // 
            this.lbllastName.AutoSize = true;
            this.lbllastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbllastName.Location = new System.Drawing.Point(331, 172);
            this.lbllastName.Name = "lbllastName";
            this.lbllastName.Size = new System.Drawing.Size(67, 18);
            this.lbllastName.TabIndex = 11;
            this.lbllastName.Text = "Prezime:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtLastName.Location = new System.Drawing.Point(546, 169);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(289, 24);
            this.txtLastName.TabIndex = 10;
            // 
            // cbProfession
            // 
            this.cbProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbProfession.FormattingEnabled = true;
            this.cbProfession.Location = new System.Drawing.Point(546, 203);
            this.cbProfession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProfession.Name = "cbProfession";
            this.cbProfession.Size = new System.Drawing.Size(289, 26);
            this.cbProfession.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(332, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Profesija:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAddress.Location = new System.Drawing.Point(332, 243);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 18);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Adresa:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtAddress.Location = new System.Drawing.Point(546, 240);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(289, 24);
            this.txtAddress.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(332, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Grad:";
            // 
            // cmbCity
            // 
            this.cmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(547, 274);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(289, 26);
            this.cmbCity.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(332, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Datum rođenja:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimePicker1.Location = new System.Drawing.Point(547, 311);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(289, 24);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(332, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Broj telefona:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPhone.Location = new System.Drawing.Point(547, 345);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(289, 24);
            this.txtPhone.TabIndex = 21;
            // 
            // cbSex
            // 
            this.cbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(547, 379);
            this.cbSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(288, 26);
            this.cbSex.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(335, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Spol:";
            // 
            // txtBio
            // 
            this.txtBio.Location = new System.Drawing.Point(331, 439);
            this.txtBio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(504, 118);
            this.txtBio.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(332, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Biografija:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPath.Location = new System.Drawing.Point(16, 522);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(291, 35);
            this.txtPath.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 79);
            this.panel1.TabIndex = 27;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProfession);
            this.Controls.Add(this.lbllastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblfirstName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblfirstName;
        private System.Windows.Forms.Label lbllastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cbProfession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}