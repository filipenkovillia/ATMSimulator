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
            this.label1 = new System.Windows.Forms.Label();
            this.tbConfirmNewPIN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChangePIN
            // 
            this.btnChangePIN.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnChangePIN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePIN.ForeColor = System.Drawing.Color.White;
            this.btnChangePIN.Location = new System.Drawing.Point(325, 272);
            this.btnChangePIN.Name = "btnChangePIN";
            this.btnChangePIN.Size = new System.Drawing.Size(320, 53);
            this.btnChangePIN.TabIndex = 4;
            this.btnChangePIN.Text = "Change PIN";
            this.btnChangePIN.UseVisualStyleBackColor = false;
            this.btnChangePIN.Click += new System.EventHandler(this.btnChangePIN_Click);
            // 
            // tbNewPIN
            // 
            this.tbNewPIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNewPIN.Location = new System.Drawing.Point(325, 129);
            this.tbNewPIN.Name = "tbNewPIN";
            this.tbNewPIN.PasswordChar = '*';
            this.tbNewPIN.Size = new System.Drawing.Size(320, 38);
            this.tbNewPIN.TabIndex = 2;
            this.tbNewPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNewPIN_KeyPress);
            // 
            // tbCurrentPIN
            // 
            this.tbCurrentPIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCurrentPIN.Location = new System.Drawing.Point(325, 85);
            this.tbCurrentPIN.Name = "tbCurrentPIN";
            this.tbCurrentPIN.PasswordChar = '*';
            this.tbCurrentPIN.Size = new System.Drawing.Size(320, 38);
            this.tbCurrentPIN.TabIndex = 1;
            this.tbCurrentPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentPIN_KeyPress);
            // 
            // lbNewPIN
            // 
            this.lbNewPIN.AutoSize = true;
            this.lbNewPIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNewPIN.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbNewPIN.Location = new System.Drawing.Point(134, 132);
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
            this.lbCurrentPIN.Location = new System.Drawing.Point(134, 88);
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
            this.lbCancel.Location = new System.Drawing.Point(449, 328);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(69, 28);
            this.lbCancel.TabIndex = 5;
            this.lbCancel.Text = "Cancel";
            this.lbCancel.Click += new System.EventHandler(this.lbCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(134, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirm new PIN";
            // 
            // tbConfirmNewPIN
            // 
            this.tbConfirmNewPIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbConfirmNewPIN.Location = new System.Drawing.Point(325, 173);
            this.tbConfirmNewPIN.Name = "tbConfirmNewPIN";
            this.tbConfirmNewPIN.PasswordChar = '*';
            this.tbConfirmNewPIN.Size = new System.Drawing.Size(320, 38);
            this.tbConfirmNewPIN.TabIndex = 3;
            this.tbConfirmNewPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbConfirmNewPIN_KeyPress);
            // 
            // ChangePinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangePIN);
            this.Controls.Add(this.tbConfirmNewPIN);
            this.Controls.Add(this.tbNewPIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCurrentPIN);
            this.Controls.Add(this.lbNewPIN);
            this.Controls.Add(this.lbCurrentPIN);
            this.Controls.Add(this.lbCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ChangePinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change PIN";
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
        private Label label1;
        private TextBox tbConfirmNewPIN;
    }
}