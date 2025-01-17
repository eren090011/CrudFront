using FrontCrudEmpleados.Entities;

namespace FrontCrudEmpleados.Repositorios
{
    public interface IRepositorio{
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        List<Empleado> ObtenerPeliculas();
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar);
    }

}