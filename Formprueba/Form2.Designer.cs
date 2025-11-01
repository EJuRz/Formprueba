namespace Formprueba
{
    partial class Form2
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            cmbOperacion = new ComboBox();
            label1 = new Label();
            lblResultado = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(12, 45);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(192, 27);
            txtNum1.TabIndex = 0;
            txtNum1.Text = "Ingrese el primer Numero";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(12, 78);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(192, 27);
            txtNum2.TabIndex = 1;
            txtNum2.Text = "Ingrese el segundo numero";
            txtNum2.TextChanged += txtNum2_TextChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "Suma", "Resta", "Multiplicacion", "Division" });
            cmbOperacion.Location = new Point(12, 111);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(192, 28);
            cmbOperacion.TabIndex = 2;
            cmbOperacion.Text = "Seleccione la operacion";
            cmbOperacion.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "Calculadora";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(112, 149);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado:";
            lblResultado.Click += lbResultado_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 145);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 234);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(cmbOperacion);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private ComboBox cmbOperacion;
        private Label label1;
        private Label lblResultado;
        private Button btnCalcular;
    }
}