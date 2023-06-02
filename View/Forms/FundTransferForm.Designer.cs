namespace ATMSimulator.View.Forms
{
    partial class FundTransferForm
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
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbRecipientCard = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lbCancel = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbCardNumber = new System.Windows.Forms.Label();
            this.lbDollar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAmount.Location = new System.Drawing.Point(379, 133);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(236, 38);
            this.tbAmount.TabIndex = 1;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // tbRecipientCard
            // 
            this.tbRecipientCard.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRecipientCard.Location = new System.Drawing.Point(379, 177);
            this.tbRecipientCard.Name = "tbRecipientCard";
            this.tbRecipientCard.Size = new System.Drawing.Size(236, 38);
            this.tbRecipientCard.TabIndex = 2;
            this.tbRecipientCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRecipientCard_KeyPress);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(379, 221);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(236, 53);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCancel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCancel.Location = new System.Drawing.Point(464, 277);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(69, 28);
            this.lbCancel.TabIndex = 4;
            this.lbCancel.Text = "Cancel";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAmount.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbAmount.Location = new System.Drawing.Point(120, 136);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(96, 31);
            this.lbAmount.TabIndex = 18;
            this.lbAmount.Text = "Amount";
            // 
            // lbCardNumber
            // 
            this.lbCardNumber.AutoSize = true;
            this.lbCardNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCardNumber.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCardNumber.Location = new System.Drawing.Point(120, 180);
            this.lbCardNumber.Name = "lbCardNumber";
            this.lbCardNumber.Size = new System.Drawing.Size(253, 31);
            this.lbCardNumber.TabIndex = 18;
            this.lbCardNumber.Text = "Recipient Card Number";
            // 
            // lbDollar
            // 
            this.lbDollar.AutoSize = true;
            this.lbDollar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDollar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbDollar.Location = new System.Drawing.Point(621, 136);
            this.lbDollar.Name = "lbDollar";
            this.lbDollar.Size = new System.Drawing.Size(26, 31);
            this.lbDollar.TabIndex = 19;
            this.lbDollar.Text = "$";
            // 
            // FundTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDollar);
            this.Controls.Add(this.lbCardNumber);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.tbRecipientCard);
            this.Controls.Add(this.tbAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FundTransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fund Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbAmount;
        private TextBox tbRecipientCard;
        private Button btnTransfer;
        private Label lbCancel;
        private Label lbAmount;
        private Label lbCardNumber;
        private Label lbDollar;
    }
}