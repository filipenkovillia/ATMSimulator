namespace ATMSimulator.View.Forms
{
    partial class ReceiptForm
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
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbTransactionType = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAmount.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbAmount.Location = new System.Drawing.Point(238, 97);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(125, 41);
            this.lbAmount.TabIndex = 18;
            this.lbAmount.Text = "Amount";
            // 
            // lbTransactionType
            // 
            this.lbTransactionType.AutoSize = true;
            this.lbTransactionType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTransactionType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbTransactionType.Location = new System.Drawing.Point(238, 161);
            this.lbTransactionType.Name = "lbTransactionType";
            this.lbTransactionType.Size = new System.Drawing.Size(81, 41);
            this.lbTransactionType.TabIndex = 18;
            this.lbTransactionType.Text = "Type";
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCancel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCancel.Location = new System.Drawing.Point(238, 219);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(106, 41);
            this.lbCancel.TabIndex = 19;
            this.lbCancel.Text = "Cancel";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.lbTransactionType);
            this.Controls.Add(this.lbAmount);
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbAmount;
        private Label lbTransactionType;
        private Label lbCancel;
    }
}