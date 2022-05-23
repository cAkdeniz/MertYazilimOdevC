
namespace MertYazilim.DesktopUI.Forms
{
    partial class FrmCustomer
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
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwSupplier = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(206, 156);
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
            this.btnGuncelle.Location = new System.Drawing.Point(351, 156);
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
            this.btnSil.Location = new System.Drawing.Point(496, 156);
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
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtContactTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtContactName);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 143);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCountry.Location = new System.Drawing.Point(142, 99);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(220, 27);
            this.txtCountry.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(63, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Country :";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCity.Location = new System.Drawing.Point(523, 56);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(225, 27);
            this.txtCity.TabIndex = 8;
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContactTitle.Location = new System.Drawing.Point(142, 56);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(220, 27);
            this.txtContactTitle.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(473, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "City :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contact Title :";
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
            // txtContactName
            // 
            this.txtContactName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContactName.Location = new System.Drawing.Point(523, 17);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(225, 27);
            this.txtContactName.TabIndex = 3;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCompanyName.Location = new System.Drawing.Point(142, 17);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(220, 27);
            this.txtCompanyName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(401, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name :";
            // 
            // dgwSupplier
            // 
            this.dgwSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.CompanyName,
            this.ContactName,
            this.ContactTitle,
            this.City,
            this.Country});
            this.dgwSupplier.Location = new System.Drawing.Point(12, 211);
            this.dgwSupplier.Name = "dgwSupplier";
            this.dgwSupplier.RowTemplate.Height = 25;
            this.dgwSupplier.Size = new System.Drawing.Size(775, 276);
            this.dgwSupplier.TabIndex = 15;
            this.dgwSupplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSupplier_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Company Name";
            this.CompanyName.Name = "CompanyName";
            // 
            // ContactName
            // 
            this.ContactName.HeaderText = "Contact Name";
            this.ContactName.Name = "ContactName";
            // 
            // ContactTitle
            // 
            this.ContactTitle.HeaderText = "Contact Title";
            this.ContactTitle.Name = "ContactTitle";
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
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwSupplier);
            this.Name = "FrmCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
    }
}