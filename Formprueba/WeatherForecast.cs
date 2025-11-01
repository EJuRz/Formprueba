// WeatherForecast.cs

using System;

namespace Formprueba
{
    public class WeatherForecast
    {
        // Los nombres deben coincidir con tu JSON
        public DateTime date { get; set; }
        public int temperatureC { get; set; }
        public int temperatureF { get; set; }
        public string summary { get; set; }
    }
}