
namespace MertYazilim.DesktopUI.Forms
{
    partial class FrmEmployee
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHireDate = new System.Windows.Forms.MaskedTextBox();
            this.txtBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReportsTo = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitleOfCourtesy = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwEmployee = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleOfCourtesy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportsTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(206, 224);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(139, 35);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(351, 224);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(139, 35);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(496, 224);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 35);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtHireDate);
            this.groupBox1.Controls.Add(this.txtBirthDate);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtReportsTo);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTitleOfCourtesy);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 206);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHireDate.Location = new System.Drawing.Point(545, 88);
            this.txtHireDate.Mask = "00/00/0000 90:00";
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(225, 27);
            this.txtHireDate.TabIndex = 22;
            this.txtHireDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirthDate.Location = new System.Drawing.Point(164, 88);
            this.txtBirthDate.Mask = "00/00/0000 90:00";
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(220, 27);
            this.txtBirthDate.TabIndex = 21;
            this.txtBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCountry.Location = new System.Drawing.Point(545, 154);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(225, 27);
            this.txtCountry.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(466, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Country :";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCity.Location = new System.Drawing.Point(164, 154);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(220, 27);
            this.txtCity.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(110, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "City : ";
            // 
            // txtReportsTo
            // 
            this.txtReportsTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReportsTo.Location = new System.Drawing.Point(545, 121);
            this.txtReportsTo.Name = "txtReportsTo";
            this.txtReportsTo.Size = new System.Drawing.Size(225, 27);
            this.txtReportsTo.TabIndex = 16;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotes.Location = new System.Drawing.Point(164, 121);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(220, 27);
            this.txtNotes.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(449, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Reports To :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(100, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Notes :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(457, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "HireDate : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(72, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "BirthDate : ";
            // 
            // txtTitleOfCourtesy
            // 
            this.txtTitleOfCourtesy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitleOfCourtesy.Location = new System.Drawing.Point(545, 55);
            this.txtTitleOfCourtesy.Name = "txtTitleOfCourtesy";
            this.txtTitleOfCourtesy.Size = new System.Drawing.Size(225, 27);
            this.txtTitleOfCourtesy.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(164, 55);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(220, 27);
            this.txtTitle.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(402, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title Of Courtesy : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(110, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Title : ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(36, 63);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 15);
            this.lblId.TabIndex = 4;
            this.lblId.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(545, 22);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(225, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(164, 22);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 27);
            this.txtFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(448, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // dgwEmployee
            // 
            this.dgwEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Title,
            this.TitleOfCourtesy,
            this.BirthDate,
            this.HireDate,
            this.Notes,
            this.ReportsTo,
            this.City,
            this.Country});
            this.dgwEmployee.Location = new System.Drawing.Point(13, 265);
            this.dgwEmployee.Name = "dgwEmployee";
            this.dgwEmployee.RowTemplate.Height = 25;
            this.dgwEmployee.Size = new System.Drawing.Size(864, 276);
            this.dgwEmployee.TabIndex = 15;
            this.dgwEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEmployee_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // TitleOfCourtesy
            // 
            this.TitleOfCourtesy.HeaderText = "Title Of Courtesy";
            this.TitleOfCourtesy.Name = "TitleOfCourtesy";
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            // 
            // HireDate
            // 
            this.HireDate.HeaderText = "HireDate";
            this.HireDate.Name = "HireDate";
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            // 
            // ReportsTo
            // 
            this.ReportsTo.HeaderText = "ReportsTo";
            this.ReportsTo.Name = "ReportsTo";
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(889, 553);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwEmployee);
            this.Name = "FrmEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitleOfCourtesy;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwEmployee;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReportsTo;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtHireDate;
        private System.Windows.Forms.MaskedTextBox txtBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleOfCourtesy;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportsTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
    }
}