namespace FrontCrudEmpleados.Entities
{
    public class Empleado
    {
        public Empleado(string id, string nombre, string apellido, string cargo, int edad, string? urlFoto, string pais, string linea1, string linea2, string ciudad, string departamento)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Cargo = cargo;
            Edad = edad;
            UrlFoto = urlFoto;
            Pais = pais;
            Linea1 = linea1;
            Linea2 = linea2;
            Ciudad = ciudad;
            Departamento = departamento;
        }

        public String Id {  get; set; }
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
