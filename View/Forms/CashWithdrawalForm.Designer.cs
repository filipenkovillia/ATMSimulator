namespace ATMSimulator.View.Forms
{
    partial class CashWithdrawalForm
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
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbCancel = new System.Windows.Forms.Label();
            this.btnFast10 = new System.Windows.Forms.Button();
            this.btnFast50 = new System.Windows.Forms.Button();
            this.btnFast20 = new System.Windows.Forms.Button();
            this.btnFast100 = new System.Windows.Forms.Button();
            this.lbDollar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(270, 213);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(236, 53);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAmount.Location = new System.Drawing.Point(270, 155);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(236, 38);
            this.tbAmount.TabIndex = 1;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCancel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCancel.Location = new System.Drawing.Point(352, 269);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(69, 28);
            this.lbCancel.TabIndex = 7;
            this.lbCancel.Text = "Cancel";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // btnFast10
            // 
            this.btnFast10.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFast10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFast10.ForeColor = System.Drawing.Color.White;
            this.btnFast10.Location = new System.Drawing.Point(12, 89);
            this.btnFast10.Name = "btnFast10";
            this.btnFast10.Size = new System.Drawing.Size(236, 53);
            this.btnFast10.TabIndex = 3;
            this.btnFast10.Text = "10 $";
            this.btnFast10.UseVisualStyleBackColor = false;
            this.btnFast10.Click += new System.EventHandler(this.btnFast10_Click);
            // 
            // btnFast50
            // 
            this.btnFast50.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFast50.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFast50.ForeColor = System.Drawing.Color.White;
            this.btnFast50.Location = new System.Drawing.Point(552, 89);
            this.btnFast50.Name = "btnFast50";
            this.btnFast50.Size = new System.Drawing.Size(236, 53);
            this.btnFast50.TabIndex = 5;
            this.btnFast50.Text = "50 $";
            this.btnFast50.UseVisualStyleBackColor = false;
            this.btnFast50.Click += new System.EventHandler(this.btnFast50_Click);
            // 
            // btnFast20
            // 
            this.btnFast20.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFast20.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFast20.ForeColor = System.Drawing.Color.White;
            this.btnFast20.Location = new System.Drawing.Point(12, 276);
            this.btnFast20.Name = "btnFast20";
            this.btnFast20.Size = new System.Drawing.Size(236, 53);
            this.btnFast20.TabIndex = 4;
            this.btnFast20.Text = "20 $";
            this.btnFast20.UseVisualStyleBackColor = false;
            this.btnFast20.Click += new System.EventHandler(this.btnFast20_Click);
            // 
            // btnFast100
            // 
            this.btnFast100.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFast100.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFast100.ForeColor = System.Drawing.Color.White;
            this.btnFast100.Location = new System.Drawing.Point(552, 276);
            this.btnFast100.Name = "btnFast100";
            this.btnFast100.Size = new System.Drawing.Size(236, 53);
            this.btnFast100.TabIndex = 6;
            this.btnFast100.Text = "100 $";
            this.btnFast100.UseVisualStyleBackColor = false;
            this.btnFast100.Click += new System.EventHandler(this.btnFast100_Click);
            // 
            // lbDollar
            // 
            this.lbDollar.AutoSize = true;
            this.lbDollar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDollar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbDollar.Location = new System.Drawing.Point(512, 150);
            this.lbDollar.Name = "lbDollar";
            this.lbDollar.Size = new System.Drawing.Size(34, 41);
            this.lbDollar.TabIndex = 16;
            this.lbDollar.Text = "$";
            // 
            // CashWithdrawalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDollar);
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.btnFast20);
            this.Controls.Add(this.btnFast100);
            this.Controls.Add(this.btnFast50);
            this.Controls.Add(this.btnFast10);
            this.Controls.Add(this.btnWithdraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "CashWithdrawalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Withdrawal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnWithdraw;
        private TextBox tbAmount;
        private Label lbCancel;
        private Button btnFast10;
        private Button btnFast50;
        private Button btnFast20;
        private Button btnFast100;
        private Label lbDollar;
    }
}