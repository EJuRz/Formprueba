using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using operaciones;

namespace Formprueba
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = double.Parse(txtNum1.Text);
                double numero2 = double.Parse(txtNum2.Text);
                double resultado = 0;

                string operacion = cmbOperacion.SelectedItem.ToString();

                switch (operacion)
                {
                    case "Suma":
                        resultado = Calculadora.Sumar(numero1, numero2);
                        break;
                    case "Resta":
                        resultado = Calculadora.Restar(numero1, numero2);
                        break;
                    case "Multiplicacion":
                        resultado = Calculadora.Multiplicar(numero1, numero2);
                        break;
                    case "Division":
                        if (numero2 != 0)
                            resultado = Calculadora.Divide(numero1, numero2);;
                        break;
                    default:
                        MessageBox.Show("Seleccione una operación válida");
                        break;
                }

                lblResultado.Text = "Resultado: " + resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese números válidos");
            }
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
