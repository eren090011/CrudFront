namespace FrontCrudEmpleados.Entities
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
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
