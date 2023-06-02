namespace ATMSimulator.View.Forms
{
    partial class MainMenuForm
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
            this.lbLogout = new System.Windows.Forms.Label();
            this.btnAccountStatement = new System.Windows.Forms.Button();
            this.btnChangePin = new System.Windows.Forms.Button();
            this.btnFundTransfer = new System.Windows.Forms.Button();
            this.btnCashWithdrawal = new System.Windows.Forms.Button();
            this.btnBalanceInquiry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLogout.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbLogout.Location = new System.Drawing.Point(374, 336);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(75, 28);
            this.lbLogout.TabIndex = 6;
            this.lbLogout.Text = "Logout";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // btnAccountStatement
            // 
            this.btnAccountStatement.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAccountStatement.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccountStatement.ForeColor = System.Drawing.Color.White;
            this.btnAccountStatement.Location = new System.Drawing.Point(498, 185);
            this.btnAccountStatement.Name = "btnAccountStatement";
            this.btnAccountStatement.Size = new System.Drawing.Size(236, 53);
            this.btnAccountStatement.TabIndex = 5;
            this.btnAccountStatement.Text = "Account statement";
            this.btnAccountStatement.UseVisualStyleBackColor = false;
            this.btnAccountStatement.Click += new System.EventHandler(this.btnAccountStatement_Click);
            // 
            // btnChangePin
            // 
            this.btnChangePin.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnChangePin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePin.ForeColor = System.Drawing.Color.White;
            this.btnChangePin.Location = new System.Drawing.Point(66, 264);
            this.btnChangePin.Name = "btnChangePin";
            this.btnChangePin.Size = new System.Drawing.Size(236, 53);
            this.btnChangePin.TabIndex = 3;
            this.btnChangePin.Text = "Change PIN";
            this.btnChangePin.UseVisualStyleBackColor = false;
            this.btnChangePin.Click += new System.EventHandler(this.btnChangePin_Click);
            // 
            // btnFundTransfer
            // 
            this.btnFundTransfer.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFundTransfer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFundTransfer.ForeColor = System.Drawing.Color.White;
            this.btnFundTransfer.Location = new System.Drawing.Point(66, 185);
            this.btnFundTransfer.Name = "btnFundTransfer";
            this.btnFundTransfer.Size = new System.Drawing.Size(236, 53);
            this.btnFundTransfer.TabIndex = 2;
            this.btnFundTransfer.Text = "Fund transfer";
            this.btnFundTransfer.UseVisualStyleBackColor = false;
            this.btnFundTransfer.Click += new System.EventHandler(this.btnFundTransfer_Click);
            // 
            // btnCashWithdrawal
            // 
            this.btnCashWithdrawal.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnCashWithdrawal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCashWithdrawal.ForeColor = System.Drawing.Color.White;
            this.btnCashWithdrawal.Location = new System.Drawing.Point(498, 94);
            this.btnCashWithdrawal.Name = "btnCashWithdrawal";
            this.btnCashWithdrawal.Size = new System.Drawing.Size(236, 53);
            this.btnCashWithdrawal.TabIndex = 4;
            this.btnCashWithdrawal.Text = "Cash withdrawal";
            this.btnCashWithdrawal.UseVisualStyleBackColor = false;
            this.btnCashWithdrawal.Click += new System.EventHandler(this.btnCashWithdrawal_Click);
            // 
            // btnBalanceInquiry
            // 
            this.btnBalanceInquiry.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnBalanceInquiry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBalanceInquiry.ForeColor = System.Drawing.Color.White;
            this.btnBalanceInquiry.Location = new System.Drawing.Point(66, 94);
            this.btnBalanceInquiry.Name = "btnBalanceInquiry";
            this.btnBalanceInquiry.Size = new System.Drawing.Size(236, 53);
            this.btnBalanceInquiry.TabIndex = 1;
            this.btnBalanceInquiry.Text = "Balance inquiry";
            this.btnBalanceInquiry.UseVisualStyleBackColor = false;
            this.btnBalanceInquiry.Click += new System.EventHandler(this.btnBalanceInquiry_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.btnAccountStatement);
            this.Controls.Add(this.btnChangePin);
            this.Controls.Add(this.btnFundTransfer);
            this.Controls.Add(this.btnCashWithdrawal);
            this.Controls.Add(this.btnBalanceInquiry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbLogout;
        private Button btnAccountStatement;
        private Button btnChangePin;
        private Button btnFundTransfer;
        private Button btnCashWithdrawal;
        private Button btnBalanceInquiry;
    }
}