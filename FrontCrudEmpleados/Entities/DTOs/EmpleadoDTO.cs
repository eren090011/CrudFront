namespace FrontCrudEmpleados.Entities.DTOs
{
    public class EmpleadoDTO
    {
        public string Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Cargo { get; set; }
        public int Edad { get; set; }
        public string? UrlFoto { get; set; }
        public DireccionDTO Direccion { get; set; }
        public bool Active { get; set; }
    }
}
