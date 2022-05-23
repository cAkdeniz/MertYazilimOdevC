
namespace MertYazilim.DesktopUI.Forms
{
    partial class FrmProduct
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
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(220, 172);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(139, 35);
            this.btnEkle.TabIndex = 29;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(365, 172);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(139, 35);
            this.btnGuncelle.TabIndex = 28;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(510, 172);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 35);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtSupplierId);
            this.groupBox1.Controls.Add(this.txtCategoryId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtUnitsInStock);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtQuantityPerUnit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 142);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplierId.FormattingEnabled = true;
            this.txtSupplierId.Location = new System.Drawing.Point(545, 22);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(225, 28);
            this.txtSupplierId.TabIndex = 23;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategoryId.FormattingEnabled = true;
            this.txtCategoryId.Location = new System.Drawing.Point(164, 55);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(220, 28);
            this.txtCategoryId.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(164, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 27);
            this.txtName.TabIndex = 21;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnitsInStock.Location = new System.Drawing.Point(545, 88);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(225, 27);
            this.txtUnitsInStock.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(424, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Units In Stock : ";
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(164, 88);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(220, 27);
            this.txtQuantityPerUnit.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(18, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantity Per Unit : ";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnitPrice.Location = new System.Drawing.Point(545, 55);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(225, 27);
            this.txtUnitPrice.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(451, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unit Price : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(61, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category Id :";
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
            this.label2.Location = new System.Drawing.Point(447, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.SupplierId,
            this.CategoryId,
            this.UnitPrice,
            this.QuantityPerUnit,
            this.UnitsInStock});
            this.dgwProduct.Location = new System.Drawing.Point(19, 227);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowTemplate.Height = 25;
            this.dgwProduct.Size = new System.Drawing.Size(864, 343);
            this.dgwProduct.TabIndex = 25;
            this.dgwProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // SupplierId
            // 
            this.SupplierId.HeaderText = "Supplier Id";
            this.SupplierId.Name = "SupplierId";
            // 
            // CategoryId
            // 
            this.CategoryId.HeaderText = "Category Id";
            this.CategoryId.Name = "CategoryId";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // QuantityPerUnit
            // 
            this.QuantityPerUnit.HeaderText = "Quantity Per Unit";
            this.QuantityPerUnit.Name = "QuantityPerUnit";
            // 
            // UnitsInStock
            // 
            this.UnitsInStock.HeaderText = "Units In Stock";
            this.UnitsInStock.Name = "UnitsInStock";
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(902, 582);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwProduct);
            this.Text = "Product";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantityPerUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox txtSupplierId;
        private System.Windows.Forms.ComboBox txtCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsInStock;
    }
}