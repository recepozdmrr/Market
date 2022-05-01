
namespace Market
{
    partial class Login
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
            this.Mail = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.LoginMail = new System.Windows.Forms.TextBox();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(118, 131);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(36, 13);
            this.Mail.TabIndex = 0;
            this.Mail.Text = "E-Mail";
            this.Mail.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(118, 223);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginMail
            // 
            this.LoginMail.Location = new System.Drawing.Point(57, 156);
            this.LoginMail.Name = "LoginMail";
            this.LoginMail.Size = new System.Drawing.Size(173, 20);
            this.LoginMail.TabIndex = 2;
            // 
            // LoginPassword
            // 
            this.LoginPassword.Location = new System.Drawing.Point(57, 250);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(173, 20);
            this.LoginPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Location = new System.Drawing.Point(92, 320);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(103, 47);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login !";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_click);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(286, 453);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginMail);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Mail);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox LoginMail;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginButton;
    }
}