using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace Formprueba
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private async void Form4_Load(object sender, EventArgs e)
        {
            // Llamada al método que carga los datos de la API
            await CargarDatosClimaAsync();
        }

        private async Task CargarDatosClimaAsync()
        {
            // La URL API
            string apiUrl = "https://localhost:7027/WeatherForecast";

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            // Usamos HttpClient para hacer la solicitud web
            HttpClient client = new HttpClient(handler);

            try
            {
                // Hacemos la solicitud GET y esperamos la respuesta
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Leemos el contenido JSON como un string
                    string jsonString = await response.Content.ReadAsStringAsync();

                    // Convertimos (deserializamos) el JSON a una Lista de WeatherForecast
                    var pronosticos = JsonConvert.DeserializeObject<List<WeatherForecast>>(jsonString);

                    // Asignamos esa lista como la fuente de datos de nuestra cuadrícula
                    dataGridViewClima.DataSource = pronosticos;
                }
                else
                {
                    // Mostramos un error si la API no respondió bien
                    MessageBox.Show("Error al conectar con la API: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otro error 
                MessageBox.Show("No se pudo conectar a la API. \nError: " + ex.Message);
            }
            finally
            {

                client.Dispose();
                handler.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}