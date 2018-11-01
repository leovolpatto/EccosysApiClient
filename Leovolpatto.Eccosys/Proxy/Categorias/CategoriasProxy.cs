using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Leovolpatto.Eccosys.Models;
namespace Leovolpatto.Eccosys.Proxy.Categorias
{
    public class CategoriasProxy : ProxyBase<Departamento>
    {
        public CategoriasProxy(HttpClient client) : base(client)
        {
        }

        protected override string Endpoint => "departamentos";

        public async Task<Response<List<Departamento>>> GetArvoreDeCategorias()
        {
            HttpResponseMessage httpResponse = await this.Client.GetAsync(this.Endpoint);

            List<Departamento> departamentos = null;
            if (httpResponse.IsSuccessStatusCode) {
                DepartamentosResponse response = httpResponse.Content.ReadAsAsync<DepartamentosResponse>().Result;
                departamentos = response.departamentos;
            }
            return new Response<List<Departamento>>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = departamentos
            };
        }
    }
}