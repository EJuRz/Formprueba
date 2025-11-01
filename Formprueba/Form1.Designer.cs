namespace Formprueba
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAlumnos = new Button();
            btnCalculadora = new Button();
            btnCerrar = new Button();
            btnClima = new Button();
            SuspendLayout();
            // 
            // btnAlumnos
            // 
            btnAlumnos.Location = new Point(375, 91);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(165, 60);
            btnAlumnos.TabIndex = 1;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // btnCalculadora
            // 
            btnCalculadora.Location = new Point(112, 91);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(165, 60);
            btnCalculadora.TabIndex = 2;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = true;
            btnCalculadora.Click += button1_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(472, 331);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(165, 60);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnClima
            // 
            btnClima.Location = new Point(112, 171);
            btnClima.Name = "btnClima";
            btnClima.Size = new Size(165, 60);
            btnClima.TabIndex = 4;
            btnClima.Text = "Clima";
            btnClima.UseVisualStyleBackColor = true;
            btnClima.Click += btnClima_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 403);
            Controls.Add(btnClima);
            Controls.Add(btnCerrar);
            Controls.Add(btnCalculadora);
            Controls.Add(btnAlumnos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlumnos;
        private Button btnCalculadora;
        private Button btnCerrar;
        private Button btnClima;
    }
}
