
namespace MertYazilim.DesktopUI.Forms
{
    partial class FrmOrder
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
            this.txtEmployee = new System.Windows.Forms.ComboBox();
            this.txtCustomer = new System.Windows.Forms.ComboBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtShipVia = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwOrder = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipVia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(205, 171);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(139, 35);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(350, 171);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(139, 35);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(495, 171);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 35);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtEmployee);
            this.groupBox1.Controls.Add(this.txtCustomer);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtShipVia);
            this.groupBox1.Controls.Add(this.txtShipName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 142);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployee.FormattingEnabled = true;
            this.txtEmployee.Location = new System.Drawing.Point(545, 21);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(225, 28);
            this.txtEmployee.TabIndex = 22;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomer.FormattingEnabled = true;
            this.txtCustomer.Location = new System.Drawing.Point(164, 21);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(220, 28);
            this.txtCustomer.TabIndex = 21;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCountry.Location = new System.Drawing.Point(545, 88);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(225, 27);
            this.txtCountry.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(466, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Country :";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCity.Location = new System.Drawing.Point(164, 88);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(220, 27);
            this.txtCity.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(110, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "City : ";
            // 
            // txtShipVia
            // 
            this.txtShipVia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtShipVia.Location = new System.Drawing.Point(545, 55);
            this.txtShipVia.Name = "txtShipVia";
            this.txtShipVia.Size = new System.Drawing.Size(225, 27);
            this.txtShipVia.TabIndex = 8;
            // 
            // txtShipName
            // 
            this.txtShipName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtShipName.Location = new System.Drawing.Point(164, 55);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(220, 27);
            this.txtShipName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(469, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "ShipVia :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ship Name :";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(454, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer :";
            // 
            // dgwOrder
            // 
            this.dgwOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerId,
            this.EmployeeId,
            this.ShipName,
            this.ShipVia,
            this.OrderDate,
            this.RequiredDate,
            this.City,
            this.Country});
            this.dgwOrder.Location = new System.Drawing.Point(4, 212);
            this.dgwOrder.Name = "dgwOrder";
            this.dgwOrder.RowTemplate.Height = 25;
            this.dgwOrder.Size = new System.Drawing.Size(864, 328);
            this.dgwOrder.TabIndex = 20;
            this.dgwOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOrder_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Customer";
            this.CustomerId.Name = "CustomerId";
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "Employee";
            this.EmployeeId.Name = "EmployeeId";
            // 
            // ShipName
            // 
            this.ShipName.HeaderText = "Ship Name";
            this.ShipName.Name = "ShipName";
            // 
            // ShipVia
            // 
            this.ShipVia.HeaderText = "ShipVia";
            this.ShipVia.Name = "ShipVia";
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            // 
            // RequiredDate
            // 
            this.RequiredDate.HeaderText = "Required Date";
            this.RequiredDate.Name = "RequiredDate";
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
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(872, 552);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwOrder);
            this.Name = "FrmOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtShipVia;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipVia;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.ComboBox txtCustomer;
        private System.Windows.Forms.ComboBox txtEmployee;
    }
}