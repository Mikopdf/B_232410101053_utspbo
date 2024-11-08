namespace UTS_PBO.Tugas
{
    partial class Form1
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Tugas1 = new DataGridViewTextBoxColumn();
            Tugas2 = new DataGridViewTextBoxColumn();
            Tugas3 = new DataGridViewTextBoxColumn();
            Tugas4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 18);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 0;
            label1.Text = "Daftar Tugas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tugas1, Tugas2, Tugas3, Tugas4, Column1 });
            dataGridView1.Location = new Point(-1, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(803, 225);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Tugas1
            // 
            Tugas1.HeaderText = "Tugas 1";
            Tugas1.MinimumWidth = 8;
            Tugas1.Name = "Tugas1";
            Tugas1.Width = 150;
            // 
            // Tugas2
            // 
            Tugas2.HeaderText = "Tugas 2";
            Tugas2.MinimumWidth = 8;
            Tugas2.Name = "Tugas2";
            Tugas2.Width = 150;
            // 
            // Tugas3
            // 
            Tugas3.HeaderText = "Tugas 3";
            Tugas3.MinimumWidth = 8;
            Tugas3.Name = "Tugas3";
            Tugas3.Width = 150;
            // 
            // Tugas4
            // 
            Tugas4.HeaderText = "Tugas 4";
            Tugas4.MinimumWidth = 8;
            Tugas4.Name = "Tugas4";
            Tugas4.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tugas 5";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Tugas1;
        private DataGridViewTextBoxColumn Tugas2;
        private DataGridViewTextBoxColumn Tugas3;
        private DataGridViewTextBoxColumn Tugas4;
        private DataGridViewTextBoxColumn Column1;
    }
}