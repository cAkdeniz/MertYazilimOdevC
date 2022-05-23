
namespace MertYazilim.DesktopUI.Forms
{
    partial class FrmOrderAdd
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.txtRequiredDate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtEmployee
            // 
            this.txtEmployee.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployee.FormattingEnabled = true;
            this.txtEmployee.Location = new System.Drawing.Point(527, 23);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(225, 28);
            this.txtEmployee.TabIndex = 35;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomer.FormattingEnabled = true;
            this.txtCustomer.Location = new System.Drawing.Point(146, 23);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(220, 28);
            this.txtCustomer.TabIndex = 34;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCountry.Location = new System.Drawing.Point(527, 123);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(225, 27);
            this.txtCountry.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(448, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Country :";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCity.Location = new System.Drawing.Point(146, 123);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(220, 27);
            this.txtCity.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(92, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 30;
            this.label8.Text = "City : ";
            // 
            // txtShipVia
            // 
            this.txtShipVia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtShipVia.Location = new System.Drawing.Point(527, 57);
            this.txtShipVia.Name = "txtShipVia";
            this.txtShipVia.Size = new System.Drawing.Size(225, 27);
            this.txtShipVia.TabIndex = 29;
            // 
            // txtShipName
            // 
            this.txtShipName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtShipName.Location = new System.Drawing.Point(146, 57);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(220, 27);
            this.txtShipName.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(451, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "ShipVia :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ship Name :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(18, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 15);
            this.lblId.TabIndex = 25;
            this.lblId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(436, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Employee :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer :";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(313, 176);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(169, 43);
            this.btnEkle.TabIndex = 36;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(401, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Required Date : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(46, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Order Date :";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderDate.Location = new System.Drawing.Point(147, 89);
            this.txtOrderDate.Mask = "00/00/0000 90:00";
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(219, 27);
            this.txtOrderDate.TabIndex = 40;
            this.txtOrderDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRequiredDate.Location = new System.Drawing.Point(527, 90);
            this.txtRequiredDate.Mask = "00/00/0000 90:00";
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(225, 27);
            this.txtRequiredDate.TabIndex = 41;
            this.txtRequiredDate.ValidatingType = typeof(System.DateTime);
            // 
            // FrmOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtShipVia);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmOrderAdd";
            this.Text = "Order Add";
            this.Load += new System.EventHandler(this.FrmOrderAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtEmployee;
        private System.Windows.Forms.ComboBox txtCustomer;
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
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtOrderDate;
        private System.Windows.Forms.MaskedTextBox txtRequiredDate;
    }
}