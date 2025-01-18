namespace FrontCrudEmpleados.Entities.DTOs
{
    public class EmpleadoDTO
    {
        public string id { get; set; }
        public string nombreCompleto { get; set; }
        public string Cargo { get; set; }
        public int Edad { get; set; }
        public string? UrlFoto { get; set; }
        public string Pais { get; set; }
        public string Linea1 { get; set; }
        public string Linea2 { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
    }
}
