
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Password1 = new System.Windows.Forms.MaskedTextBox();
            this.Password2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(79, 45);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(208, 20);
            this.NameBox.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(79, 92);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(208, 20);
            this.LastName.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(94, 261);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(113, 51);
            this.Login.TabIndex = 2;
            this.Login.Text = "Sign Up!";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_click);
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(79, 140);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(208, 20);
            this.Mail.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 52);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name:";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            // 
            // Password1
            // 
            this.Password1.Location = new System.Drawing.Point(79, 189);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(208, 20);
            this.Password1.TabIndex = 11;
            this.Password1.PasswordChar = '*';
            // 
            // Password2
            // 
            this.Password2.Location = new System.Drawing.Point(79, 230);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(208, 20);
            this.Password2.TabIndex = 12;
            this.Password2.PasswordChar = '*';
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 324);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.Password1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.NameBox);
            this.Name = "SignUpPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Password1;
        private System.Windows.Forms.MaskedTextBox Password2;
    }
}

