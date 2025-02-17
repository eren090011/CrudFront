﻿using System.Text.Json;
using System.Text;
using FrontCrudEmpleados.Entities;

namespace FrontCrudEmpleados.Repositorios
{
    public class Repositorio : IRepositorio
    {
        private readonly HttpClient httpClient;
        public Repositorio(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


        public async Task<HttpResponseWrapper<object>> Delete(string url)
        {
            var responseHTTP = await httpClient.DeleteAsync(url);
            return new HttpResponseWrapper<object>(null,
                !responseHTTP.IsSuccessStatusCode, responseHTTP);
        }
        private JsonSerializerOptions OpcionesPorDefectoJSON => new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var respuestaHTTP = await httpClient.GetAsync(url);
            if (respuestaHTTP.IsSuccessStatusCode)
            {
                var respuesta = await DeserializarRespuesta<T>(respuestaHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(respuesta, error: false, respuestaHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, error: true, respuestaHTTP);
            }
        }
        



        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse,
            JsonSerializerOptions jsonSerializerOptions)
        {
            var respuestaString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(respuestaString, jsonSerializerOptions);
        }
        
       
        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }


        public async Task<HttpResponseWrapper<T>> GetById<T>(string url)
        {
            var respuestaHTTP = await httpClient.GetAsync(url);

            if (respuestaHTTP.IsSuccessStatusCode)
            {
                var respuesta = await DeserializarRespuesta<T>(respuestaHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(respuesta, error: false, respuestaHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, error: true, respuestaHTTP);
            }
        }

        public async Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PutAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }
        public async Task<HttpResponseWrapper<object>> PutFoto<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PutAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }
        public async Task<HttpResponseWrapper<object>> DeleteEmpleado<T>(string url)
        {

            var responseHttp = await httpClient.PutAsync(url, null);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

    }
}
