namespace Formprueba
{
    partial class Form4
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
            dataGridViewClima = new DataGridView();
            lblClima = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClima).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClima
            // 
            dataGridViewClima.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClima.Location = new Point(12, 52);
            dataGridViewClima.Name = "dataGridViewClima";
            dataGridViewClima.RowHeadersWidth = 51;
            dataGridViewClima.Size = new Size(541, 199);
            dataGridViewClima.TabIndex = 0;
            // 
            // lblClima
            // 
            lblClima.AutoSize = true;
            lblClima.Location = new Point(12, 19);
            lblClima.Name = "lblClima";
            lblClima.Size = new Size(47, 20);
            lblClima.TabIndex = 4;
            lblClima.Text = "Clima";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 42);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 19);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 298);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblClima);
            Controls.Add(dataGridViewClima);
            Name = "Form4";
            Text = "clima";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClima).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClima;
        private Label lblClima;
        private Label label1;
        private Label label2;
    }
}