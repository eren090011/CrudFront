using FrontCrudEmpleados.Entities;

namespace FrontCrudEmpleados.Repositorios
{
    public interface IRepositorio{
        Task<HttpResponseWrapper<T>> Get<T>(string url);

        Task<HttpResponseWrapper<T>> GetById<T>(string url);    
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar);
    }

}