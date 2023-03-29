namespace assignment_1.View
{
    partial class EmployeeView
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
            dataGridViewRental = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            locationPanel = new FlowLayoutPanel();
            label1 = new Label();
            typePanel = new FlowLayoutPanel();
            roomsPanel = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRental).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRental
            // 
            dataGridViewRental.AllowUserToAddRows = false;
            dataGridViewRental.AllowUserToDeleteRows = false;
            dataGridViewRental.AllowUserToOrderColumns = true;
            dataGridViewRental.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRental.Location = new Point(12, 12);
            dataGridViewRental.Name = "dataGridViewRental";
            dataGridViewRental.Size = new Size(633, 403);
            dataGridViewRental.TabIndex = 0;
            dataGridViewRental.CellContentClick += dataGridView1_CellContentClick;
            dataGridViewRental.CellValueChanged += dataGridViewRental_CellValueChanged;
            dataGridViewRental.RowHeaderMouseDoubleClick += dataGridViewRental_RowHeaderMouseDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 421);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += createProperty;
            // 
            // button3
            // 
            button3.Location = new Point(93, 421);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // locationPanel
            // 
            locationPanel.AutoScroll = true;
            locationPanel.BackColor = SystemColors.Info;
            locationPanel.Location = new Point(651, 21);
            locationPanel.Name = "locationPanel";
            locationPanel.Size = new Size(137, 122);
            locationPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(692, 3);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Location";
            // 
            // typePanel
            // 
            typePanel.AutoScroll = true;
            typePanel.BackColor = SystemColors.Info;
            typePanel.Location = new Point(651, 175);
            typePanel.Name = "typePanel";
            typePanel.Size = new Size(137, 122);
            typePanel.TabIndex = 3;
            // 
            // roomsPanel
            // 
            roomsPanel.AutoScroll = true;
            roomsPanel.BackColor = SystemColors.Info;
            roomsPanel.Location = new Point(651, 316);
            roomsPanel.Name = "roomsPanel";
            roomsPanel.Size = new Size(137, 122);
            roomsPanel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(704, 157);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 5;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(701, 300);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 6;
            label3.Text = "Rooms";
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(roomsPanel);
            Controls.Add(typePanel);
            Controls.Add(label1);
            Controls.Add(locationPanel);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridViewRental);
            Name = "EmployeeView";
            Text = "Form1";
            Load += EmployeeView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRental).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRental;
        private Button button1;
        private Button button3;
        private FlowLayoutPanel locationPanel;
        private Label label1;
        private FlowLayoutPanel typePanel;
        private FlowLayoutPanel roomsPanel;
        private Label label2;
        private Label label3;
    }
}