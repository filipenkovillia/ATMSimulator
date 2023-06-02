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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(328, 250);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(320, 53);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPIN
            // 
            this.tbPIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPIN.Location = new System.Drawing.Point(328, 182);
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.PasswordChar = '*';
            this.tbPIN.Size = new System.Drawing.Size(320, 38);
            this.tbPIN.TabIndex = 7;
            this.tbPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPIN_KeyPress);
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCardNumber.Location = new System.Drawing.Point(328, 106);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(320, 38);
            this.tbCardNumber.TabIndex = 8;
            this.tbCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCardNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(153, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "PIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(153, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Card number";
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSignUp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbSignUp.Location = new System.Drawing.Point(447, 306);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(87, 28);
            this.lbSignUp.TabIndex = 6;
            this.lbSignUp.Text = "SIGN UP";
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSignUp);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogin;
        private TextBox tbPIN;
        private TextBox tbCardNumber;
        private Label label4;
        private Label label3;
        private Label lbSignUp;
    }
}