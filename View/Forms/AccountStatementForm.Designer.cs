namespace ATMSimulator.View.Forms
{
    partial class AccountStatementForm
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
            this.lbCancel = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.btnExportXlsx = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCancel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCancel.Location = new System.Drawing.Point(736, 395);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(52, 28);
            this.lbCancel.TabIndex = 5;
            this.lbCancel.Text = "Back";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnReceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.Location = new System.Drawing.Point(501, 390);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(175, 39);
            this.btnReceipt.TabIndex = 4;
            this.btnReceipt.Text = "Print Receipt";
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.RowHeadersWidth = 51;
            this.dataGridViewTransactions.RowTemplate.Height = 29;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(776, 364);
            this.dataGridViewTransactions.TabIndex = 20;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportPdf.Location = new System.Drawing.Point(12, 390);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(157, 39);
            this.btnExportPdf.TabIndex = 1;
            this.btnExportPdf.Text = "Export to pdf";
            this.btnExportPdf.UseVisualStyleBackColor = false;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // btnExportXlsx
            // 
            this.btnExportXlsx.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExportXlsx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportXlsx.ForeColor = System.Drawing.Color.White;
            this.btnExportXlsx.Location = new System.Drawing.Point(175, 390);
            this.btnExportXlsx.Name = "btnExportXlsx";
            this.btnExportXlsx.Size = new System.Drawing.Size(157, 39);
            this.btnExportXlsx.TabIndex = 2;
            this.btnExportXlsx.Text = "Export to xlsx";
            this.btnExportXlsx.UseVisualStyleBackColor = false;
            this.btnExportXlsx.Click += new System.EventHandler(this.btnExportXlsx_Click);
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExportCsv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportCsv.ForeColor = System.Drawing.Color.White;
            this.btnExportCsv.Location = new System.Drawing.Point(338, 390);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(157, 39);
            this.btnExportCsv.TabIndex = 3;
            this.btnExportCsv.Text = "Export to csv";
            this.btnExportCsv.UseVisualStyleBackColor = false;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // AccountStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.btnExportXlsx);
            this.Controls.Add(this.dataGridViewTransactions);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.lbCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "AccountStatementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Statement";
            this.Load += new System.EventHandler(this.AccountStatementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbCancel;
        private Button btnReceipt;
        private DataGridView dataGridViewTransactions;
        private Button btnExportPdf;
        private Button btnExportXlsx;
        private Button btnExportCsv;
    }
}