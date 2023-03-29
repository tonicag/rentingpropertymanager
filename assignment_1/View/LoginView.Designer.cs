namespace assignment_1.View
{
    partial class LoginView
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
            loginButton = new Button();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            guestButton = new Button();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(307, 278);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(82, 22);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += login_Click;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(224, 98);
            usernameInput.Margin = new Padding(3, 2, 3, 2);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(256, 23);
            usernameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(224, 150);
            passwordInput.Margin = new Padding(3, 2, 3, 2);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(256, 23);
            passwordInput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 100);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 152);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // guestButton
            // 
            guestButton.Location = new Point(535, 19);
            guestButton.Margin = new Padding(3, 2, 3, 2);
            guestButton.Name = "guestButton";
            guestButton.Size = new Size(155, 22);
            guestButton.TabIndex = 4;
            guestButton.Text = "Continue as Guest";
            guestButton.UseVisualStyleBackColor = true;
            guestButton.Click += guestButton_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(guestButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(loginButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginView";
            Text = "LoginView";
            Load += LoginView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Label label1;
        private Label label2;
        private Button guestButton;
    }
}