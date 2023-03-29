namespace assignment_1.View
{
    partial class AdminView
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
            userGridView = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)userGridView).BeginInit();
            SuspendLayout();
            // 
            // userGridView
            // 
            userGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGridView.Location = new Point(12, 12);
            userGridView.Name = "userGridView";
            userGridView.RowTemplate.Height = 25;
            userGridView.Size = new Size(776, 401);
            userGridView.TabIndex = 0;
            userGridView.CellValueChanged += userGridView_CellValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(93, 419);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 419);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(userGridView);
            Name = "AdminView";
            Text = "AdminView";
            Load += AdminView_Load;
            ((System.ComponentModel.ISupportInitialize)userGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userGridView;
        private Button button1;
        private Button button2;
    }
}