namespace assignment_1.View
{
    partial class ClientView
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
            dataGridRental = new DataGridView();
            typePanel = new FlowLayoutPanel();
            label1 = new Label();
            locationPanel = new FlowLayoutPanel();
            label2 = new Label();
            roomsPanel = new FlowLayoutPanel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridRental).BeginInit();
            SuspendLayout();
            // 
            // dataGridRental
            // 
            dataGridRental.AllowDrop = true;
            dataGridRental.AllowUserToAddRows = false;
            dataGridRental.AllowUserToDeleteRows = false;
            dataGridRental.AllowUserToOrderColumns = true;
            dataGridRental.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRental.Location = new Point(21, 22);
            dataGridRental.Name = "dataGridRental";
            dataGridRental.ReadOnly = true;
            dataGridRental.RowTemplate.Height = 25;
            dataGridRental.Size = new Size(591, 395);
            dataGridRental.TabIndex = 0;
            // 
            // typePanel
            // 
            typePanel.AutoScroll = true;
            typePanel.BackColor = SystemColors.Info;
            typePanel.Location = new Point(620, 45);
            typePanel.Name = "typePanel";
            typePanel.Size = new Size(170, 97);
            typePanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(683, 20);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Type";
            // 
            // locationPanel
            // 
            locationPanel.AutoScroll = true;
            locationPanel.BackColor = SystemColors.Info;
            locationPanel.Location = new Point(623, 173);
            locationPanel.Name = "locationPanel";
            locationPanel.Size = new Size(170, 97);
            locationPanel.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(674, 155);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Location";
            // 
            // roomsPanel
            // 
            roomsPanel.AutoScroll = true;
            roomsPanel.BackColor = SystemColors.Info;
            roomsPanel.Location = new Point(620, 289);
            roomsPanel.Name = "roomsPanel";
            roomsPanel.Size = new Size(170, 97);
            roomsPanel.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(683, 273);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 8;
            label3.Text = "Rooms";
            // 
            // ClientView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(roomsPanel);
            Controls.Add(label1);
            Controls.Add(typePanel);
            Controls.Add(dataGridRental);
            Controls.Add(locationPanel);
            Name = "ClientView";
            Text = "ClientView";
            FormClosed += ClientView_FormClosed;
            Load += ClientView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridRental).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridRental;
        private FlowLayoutPanel typePanel;
        private Label label1;
        private FlowLayoutPanel locationPanel;
        private Label label2;
        private FlowLayoutPanel roomsPanel;
        private Label label3;
    }
}