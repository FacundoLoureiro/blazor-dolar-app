using System.Text.Json.Serialization;

namespace BlazorDolarApp.Models
{
    public class Monedas
    {
        [JsonPropertyName("moneda")]
        public string Moneda { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("compra")]
        public decimal Compra { get; set; }

        [JsonPropertyName("venta")]
        public decimal Venta { get; set; }

        [JsonPropertyName("fechaActualizacion")]
        public string FechaActualizacion { get; set; }
    }
}
