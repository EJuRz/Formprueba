namespace Formprueba
{
    partial class Form3
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            cmbPais = new ComboBox();
            dtpFecha = new DateTimePicker();
            lblEdad = new Label();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 24);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Formulario de alumnos";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(13, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(13, 104);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 2;
            txtApellido.Text = "Apellido";
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Items.AddRange(new object[] { "Argentina", "Uruguay", "Chile", "Colombia", "Peru", "Paraguay" });
            cmbPais.Location = new Point(13, 190);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(151, 28);
            cmbPais.TabIndex = 3;
            cmbPais.Text = "Pais";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(13, 147);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 4;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(13, 241);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(50, 20);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad: ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(9, 275);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(109, 275);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 353);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblEdad);
            Controls.Add(dtpFecha);
            Controls.Add(cmbPais);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private ComboBox cmbPais;
        private DateTimePicker dtpFecha;
        private Label lblEdad;
        private Button btnLimpiar;
        private Button btnGuardar;
    }
}