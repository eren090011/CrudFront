namespace FrontCrudEmpleados.Entities.DTOs
{
    public class EmpleadosDTO
    {
        public string Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Cargo { get; set; }
        public int Edad { get; set; }
        public string? UrlFoto { get; set; }
        public DireccionDTO Direccion { get; set; }
        public bool Active { get; set; }
    }

    public class DireccionDTO
    {
        public string Pais { get; set; }
        public string Linea1 { get; set; }
        public string Linea2 { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
    }
}
