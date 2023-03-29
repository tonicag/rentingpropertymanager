namespace assignment_1.View
{
    partial class AddNewRentalProperty
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
            locationTextBox = new TextBox();
            priceTextBox = new TextBox();
            typeTextBox = new TextBox();
            roomsTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(215, 97);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(195, 23);
            locationTextBox.TabIndex = 0;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(215, 126);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(195, 23);
            priceTextBox.TabIndex = 0;
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(215, 155);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(195, 23);
            typeTextBox.TabIndex = 0;
            // 
            // roomsTextBox
            // 
            roomsTextBox.Location = new Point(215, 184);
            roomsTextBox.Name = "roomsTextBox";
            roomsTextBox.Size = new Size(195, 23);
            roomsTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 100);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 129);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 158);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 1;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 187);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 1;
            label4.Text = "Rooms";
            // 
            // button1
            // 
            button1.Location = new Point(278, 213);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Add new";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddNewRentalProperty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 339);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roomsTextBox);
            Controls.Add(typeTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(locationTextBox);
            Name = "AddNewRentalProperty";
            Text = "AddNewRentalProperty";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox locationTextBox;
        private TextBox priceTextBox;
        private TextBox typeTextBox;
        private TextBox roomsTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}