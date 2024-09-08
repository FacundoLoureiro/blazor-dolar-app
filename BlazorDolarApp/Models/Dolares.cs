namespace BlazorDolarApp.Models
{
    public class Dolares
    {
        public string Moneda { get; set; }
        public string Casa { get; set; }
        public string Nombre { get; set; }
        public decimal Compra { get; set; }
        public decimal Venta { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
