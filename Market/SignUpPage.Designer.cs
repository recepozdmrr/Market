
namespace Market
{
    partial class SignUpPage
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Mail = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(262, 68);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(245, 20);
            this.NameBox.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(262, 113);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(245, 20);
            this.LastName.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(349, 280);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 2;
            this.Login.Text = "button1";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_click);
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(262, 161);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(245, 20);
            this.Mail.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(262, 207);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(245, 20);
            this.Password.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.NameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.TextBox Password;
    }
}

