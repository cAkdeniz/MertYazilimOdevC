
namespace MertYazilim.DesktopUI.Forms
{
    partial class FrmProductAdd
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
            this.txtSupplierId = new System.Windows.Forms.ComboBox();
            this.txtCategoryId = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplierId.FormattingEnabled = true;
            this.txtSupplierId.Location = new System.Drawing.Point(545, 21);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(225, 28);
            this.txtSupplierId.TabIndex = 35;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategoryId.FormattingEnabled = true;
            this.txtCategoryId.Location = new System.Drawing.Point(164, 54);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(220, 28);
            this.txtCategoryId.TabIndex = 34;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(164, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 27);
            this.txtName.TabIndex = 33;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnitsInStock.Location = new System.Drawing.Point(545, 87);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(225, 27);
            this.txtUnitsInStock.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(424, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Units In Stock : ";
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(164, 87);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(220, 27);
            this.txtQuantityPerUnit.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(18, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "Quantity Per Unit : ";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnitPrice.Location = new System.Drawing.Point(545, 54);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(225, 27);
            this.txtUnitPrice.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(451, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Unit Price : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(61, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Category Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(447, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Supplier Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name :";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(316, 149);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(169, 43);
            this.btnEkle.TabIndex = 37;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 216);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSupplierId);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProductAdd";
            this.Text = "Product Add";
            this.Load += new System.EventHandler(this.FrmProductAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtSupplierId;
        private System.Windows.Forms.ComboBox txtCategoryId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
    }
}