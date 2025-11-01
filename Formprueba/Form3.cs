using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formprueba
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbPais.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today; 
            lblEdad.Text = "Edad: ";
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dtpFecha.Value;
            int edad = CalcularEdad(fechaNacimiento, DateTime.Today);
            lblEdad.Text = $"Edad: {edad}";
        }

        private int CalcularEdad(DateTime nacimiento, DateTime hoy)
        {
            int edad = hoy.Year - nacimiento.Year;
            if (hoy.Month < nacimiento.Month || (hoy.Month == nacimiento.Month && hoy.Day < nacimiento.Day))
                edad--;
            return edad;
        }
    }
}
