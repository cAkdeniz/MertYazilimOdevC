
namespace MertYazilim.DesktopUI
{
    partial class FrmAnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnShipper = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(13, 13);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(176, 64);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "CATEGORY";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(195, 13);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(176, 64);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "CUSTOMER";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(559, 13);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(176, 64);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(377, 13);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(176, 64);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "EMPLOYEE";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(377, 83);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(176, 64);
            this.btnSupplier.TabIndex = 6;
            this.btnSupplier.Text = "SUPPLIER";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnShipper
            // 
            this.btnShipper.Location = new System.Drawing.Point(195, 83);
            this.btnShipper.Name = "btnShipper";
            this.btnShipper.Size = new System.Drawing.Size(176, 64);
            this.btnShipper.TabIndex = 5;
            this.btnShipper.Text = "SHIPPER";
            this.btnShipper.UseVisualStyleBackColor = true;
            this.btnShipper.Click += new System.EventHandler(this.btnShipper_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(13, 83);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(176, 64);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(559, 83);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(176, 64);
            this.btnLog.TabIndex = 7;
            this.btnLog.Text = "LOGS";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 270);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnShipper);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnCategory);
            this.Name = "FrmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnShipper;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnLog;
    }
}

