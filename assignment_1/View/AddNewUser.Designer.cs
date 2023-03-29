namespace assignment_1.View
{
    partial class AddNewUser
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
            usernameTextBox = new TextBox();
            paswwordTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            roleComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(166, 64);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(212, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // paswwordTextBox
            // 
            paswwordTextBox.Location = new Point(166, 93);
            paswwordTextBox.Name = "paswwordTextBox";
            paswwordTextBox.Size = new Size(212, 23);
            paswwordTextBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(166, 122);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(212, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(166, 151);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(212, 23);
            lastNameTextBox.TabIndex = 0;
            // 
            // roleComboBox
            // 
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(166, 180);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(212, 23);
            roleComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 67);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 96);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 125);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 154);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 2;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(384, 183);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 2;
            label5.Text = "Role";
            // 
            // button1
            // 
            button1.Location = new Point(166, 209);
            button1.Name = "button1";
            button1.Size = new Size(212, 23);
            button1.TabIndex = 3;
            button1.Text = "Add new user";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddNewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 329);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roleComboBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(paswwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "AddNewUser";
            Text = "AddNewUser";
            Load += AddNewUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox paswwordTextBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private ComboBox roleComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}