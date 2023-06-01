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
            this.lvAccountStatement = new System.Windows.Forms.ListView();
            this.lbCancel = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAccountStatement
            // 
            this.lvAccountStatement.Location = new System.Drawing.Point(12, 39);
            this.lvAccountStatement.Name = "lvAccountStatement";
            this.lvAccountStatement.Size = new System.Drawing.Size(776, 337);
            this.lvAccountStatement.TabIndex = 0;
            this.lvAccountStatement.UseCompatibleStateImageBehavior = false;
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCancel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCancel.Location = new System.Drawing.Point(440, 385);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(106, 41);
            this.lbCancel.TabIndex = 18;
            this.lbCancel.Text = "Cancel";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnReceipt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.Location = new System.Drawing.Point(552, 382);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(236, 53);
            this.btnReceipt.TabIndex = 19;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // AccountStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.lbCancel);
            this.Controls.Add(this.lvAccountStatement);
            this.Name = "AccountStatementForm";
            this.Text = "AccountStatementForm";
            this.Load += new System.EventHandler(this.AccountStatementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvAccountStatement;
        private Label lbCancel;
        private Button btnReceipt;
    }
}