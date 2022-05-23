
namespace MertYazilim.DesktopUI.Forms
{
    partial class FrmEmployeeAdd
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHireDate
            // 
            this.txtHireDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHireDate.Location = new System.Drawing.Point(511, 84);
            this.txtHireDate.Mask = "00/00/0000 90:00";
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(225, 27);
            this.txtHireDate.TabIndex = 42;
            this.txtHireDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirthDate.Location = new System.Drawing.Point(130, 84);
            this.txtBirthDate.Mask = "00/00/0000 90:00";
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(220, 27);
            this.txtBirthDate.TabIndex = 41;
            this.txtBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCountry.Location = new System.Drawing.Point(511, 150);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(225, 27);
            this.txtCountry.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(432, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Country :";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCity.Location = new System.Drawing.Point(130, 150);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(220, 27);
            this.txtCity.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(76, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "City : ";
            // 
            // txtReportsTo
            // 
            this.txtReportsTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReportsTo.Location = new System.Drawing.Point(511, 117);
            this.txtReportsTo.Name = "txtReportsTo";
            this.txtReportsTo.Size = new System.Drawing.Size(225, 27);
            this.txtReportsTo.TabIndex = 36;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotes.Location = new System.Drawing.Point(130, 117);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(220, 27);
            this.txtNotes.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(415, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Reports To :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(66, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 33;
            this.label10.Text = "Notes :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(423, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "HireDate : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "BirthDate : ";
            // 
            // txtTitleOfCourtesy
            // 
            this.txtTitleOfCourtesy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitleOfCourtesy.Location = new System.Drawing.Point(511, 51);
            this.txtTitleOfCourtesy.Name = "txtTitleOfCourtesy";
            this.txtTitleOfCourtesy.Size = new System.Drawing.Size(225, 27);
            this.txtTitleOfCourtesy.TabIndex = 30;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(130, 51);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(220, 27);
            this.txtTitle.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(368, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Title Of Courtesy : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(76, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Title : ";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(511, 18);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(225, 27);
            this.txtLastName.TabIndex = 26;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(130, 18);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 27);
            this.txtFirstName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(414, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "First Name :";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(319, 220);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(169, 43);
            this.btnEkle.TabIndex = 43;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmEmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 286);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReportsTo);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitleOfCourtesy);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmployeeAdd";
            this.Text = "Employee Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtHireDate;
        private System.Windows.Forms.MaskedTextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReportsTo;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitleOfCourtesy;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
    }
}