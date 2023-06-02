namespace ATMSimulator.View.Forms
{
    partial class BalanceInquiryForm
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
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBalance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbBalance.Location = new System.Drawing.Point(259, 173);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(196, 41);
            this.lbBalance.TabIndex = 0;
            this.lbBalance.Text = "Card Balance:";
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBack.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbBack.Location = new System.Drawing.Point(372, 214);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(52, 28);
            this.lbBack.TabIndex = 1;
            this.lbBack.Text = "Back";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            // 
            // BalanceInquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.lbBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "BalanceInquiryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance Inquiry";
            this.Load += new System.EventHandler(this.BalanceInquiryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbBalance;
        private Label lbBack;
    }
}