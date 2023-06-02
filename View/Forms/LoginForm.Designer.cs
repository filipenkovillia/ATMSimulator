namespace ATMSimulator.View.Forms
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.lbPIN = new System.Windows.Forms.Label();
            this.lbCardNumber = new System.Windows.Forms.Label();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(320, 237);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(320, 53);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPIN
            // 
            this.tbPIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPIN.Location = new System.Drawing.Point(320, 161);
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.PasswordChar = '*';
            this.tbPIN.Size = new System.Drawing.Size(320, 38);
            this.tbPIN.TabIndex = 2;
            this.tbPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPIN_KeyPress);
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCardNumber.Location = new System.Drawing.Point(320, 117);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(320, 38);
            this.tbCardNumber.TabIndex = 1;
            this.tbCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCardNumber_KeyPress);
            // 
            // lbPIN
            // 
            this.lbPIN.AutoSize = true;
            this.lbPIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPIN.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbPIN.Location = new System.Drawing.Point(145, 164);
            this.lbPIN.Name = "lbPIN";
            this.lbPIN.Size = new System.Drawing.Size(50, 31);
            this.lbPIN.TabIndex = 0;
            this.lbPIN.Text = "PIN";
            // 
            // lbCardNumber
            // 
            this.lbCardNumber.AutoSize = true;
            this.lbCardNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCardNumber.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbCardNumber.Location = new System.Drawing.Point(145, 120);
            this.lbCardNumber.Name = "lbCardNumber";
            this.lbCardNumber.Size = new System.Drawing.Size(148, 31);
            this.lbCardNumber.TabIndex = 0;
            this.lbCardNumber.Text = "Card number";
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSignUp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbSignUp.Location = new System.Drawing.Point(440, 293);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(82, 28);
            this.lbSignUp.TabIndex = 4;
            this.lbSignUp.Text = "Sign Up";
            this.lbSignUp.Click += new System.EventHandler(this.lbSignUp_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPIN);
            this.Controls.Add(this.tbCardNumber);
            this.Controls.Add(this.lbPIN);
            this.Controls.Add(this.lbCardNumber);
            this.Controls.Add(this.lbSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogin;
        private TextBox tbPIN;
        private TextBox tbCardNumber;
        private Label lbPIN;
        private Label lbCardNumber;
        private Label lbSignUp;
    }
}