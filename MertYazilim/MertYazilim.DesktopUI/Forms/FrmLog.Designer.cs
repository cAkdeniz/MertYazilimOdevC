
namespace MertYazilim.DesktopUI.Forms
{
    partial class FrmLog
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
            this.dgwLog = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Query = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwLog
            // 
            this.dgwLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Method,
            this.Path,
            this.Query,
            this.CreatedTime});
            this.dgwLog.Location = new System.Drawing.Point(13, 13);
            this.dgwLog.Name = "dgwLog";
            this.dgwLog.RowTemplate.Height = 25;
            this.dgwLog.Size = new System.Drawing.Size(948, 363);
            this.dgwLog.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Method
            // 
            this.Method.HeaderText = "Method";
            this.Method.Name = "Method";
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            // 
            // Query
            // 
            this.Query.HeaderText = "Query";
            this.Query.Name = "Query";
            // 
            // CreatedTime
            // 
            this.CreatedTime.HeaderText = "Created Time";
            this.CreatedTime.Name = "CreatedTime";
            // 
            // FrmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(973, 388);
            this.Controls.Add(this.dgwLog);
            this.Name = "FrmLog";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.FrmLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Query;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedTime;
    }
}