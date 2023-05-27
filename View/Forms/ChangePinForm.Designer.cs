namespace ATMSimulator.View.Forms
{
    partial class ChangePinForm
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
            this.btnChangePIN = new System.Windows.Forms.Button();
            this.tbNewPIN = new System.Windows.Forms.TextBox();
            this.tbCurrentPIN = new System.Windows.Forms.TextBox();
            this.lbNewPIN = new System.Windows.Forms.Label();
            this.lbCurrentPIN = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangePIN
            // 
            this.btnChangePIN.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnChangePIN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePIN.ForeColor = System.Drawing.Color.White;
            this.btnChangePIN.Location = new System.Drawing.Point(328, 250);
            this.btnChangePIN.Name = "btnChangePIN";
            this.btnChangePIN.Size = new System.Drawing.Size(320, 53);
            this.btnChangePIN.TabIndex = 15;
            this.btnChangePIN.Text = "Change PIN";
            this.btnChangePIN.UseVisualStyleBackColor = false;
            this.btnChangePIN.Click += new System.EventHandler(this.btnChangePIN_Click);
            // 
            // tbNewPIN
            // 
            this.tbNewPIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNewPIN.Location = new System.Drawing.Point(328, 182);
            this.tbNewPIN.Name = "tbNewPIN";
            this.tbNewPIN.PasswordChar = '*';
            this.tbNewPIN.Size = new System.Drawing.Size(320, 38);
            this.tbNewPIN.TabIndex = 13;
            // 
            // tbCurrentPIN
            // 
            this.tbCurrentPIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCurrentPIN.Location = new System.Drawing.Point(328, 106);
            this.tbCurrentPIN.Name = "tbCurrentPIN";
            this.tbCurrentPIN.Size = new System.Drawing.Size(320, 38);
            this.tbCurrentPIN.TabIndex = 14;
            // 
            // lbNewPIN
            // 
            this.lbNewPIN.AutoSize = true;
            this.lbNewPIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNewPIN.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbNewPIN.Location = new System.Drawing.Point(153, 185);
            this.lbNewPIN.Name = "lbNewPIN";
            this.lbNewPIN.Size = new System.Drawing.Size(102, 31);
            this.lbNewPIN.TabIndex = 10;
            this.lbNewPIN.Text = "New PIN";
            // 
            // lbCurrentPIN
            // 
            this.lbCurrentPIN.AutoSize = true;
            this.lbCurrentPIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCurrentPIN.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCurrentPIN.Location = new System.Drawing.Point(153, 109);
            this.lbCurrentPIN.Name = "lbCurrentPIN";
            this.lbCurrentPIN.Size = new System.Drawing.Size(132, 31);
            this.lbCurrentPIN.TabIndex = 11;
            this.lbCurrentPIN.Text = "Current PIN";
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCancel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCancel.Location = new System.Drawing.Point(441, 317);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(69, 28);
            this.lbCancel.TabIndex = 12;
            this.lbCancel.Text = "Cancel";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // ChangePinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangePIN);
            this.Controls.Add(this.tbNewPIN);
            this.Controls.Add(this.tbCurrentPIN);
            this.Controls.Add(this.lbNewPIN);
            this.Controls.Add(this.lbCurrentPIN);
            this.Controls.Add(this.lbCancel);
            this.Name = "ChangePinForm";
            this.Text = "ChangePinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnChangePIN;
        private TextBox tbNewPIN;
        private TextBox tbCurrentPIN;
        private Label lbNewPIN;
        private Label lbCurrentPIN;
        private Label lbCancel;
    }
}