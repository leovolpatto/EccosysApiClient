using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Leovolpatto.Eccosys.Proxy.Estoques.RequestArguments;
using Leovolpatto.Eccosys.Proxy.Estoques.Responses;

namespace Leovolpatto.Eccosys.Proxy.Estoques
{
    public class EstoquesProxy : ProxyBase<bool>
    {
        public EstoquesProxy(HttpClient client) : base(client)
        {
        }

        protected override string Endpoint => "estoques";

        public async Task<Response<DefaultPostResponse>> InserirRegistroDeEstoque(InsertRegistroEstoqueRequest request)
        {
            HttpResponseMessage httpResponse = await this.Client.PostAsJsonAsync(String.Format("{0}/{1}", this.Endpoint, request.codigo), request.Body);

            return new Response<DefaultPostResponse>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = httpResponse.Content.ReadAsAsync<DefaultPostResponse>().Result
            };
        }

        public async Task<Response<List<GetQuantityInStockByCodigoResponse>>> GetQuantityInStockByCodigo(GetQuantityInStockByCodigoRequest request)
        {
            HttpResponseMessage httpResponse = await this.Client.GetAsync(String.Format("{0}/{1}", this.Endpoint, request.codigo));
            List<GetQuantityInStockByCodigoResponse> response = null;
            if (httpResponse.IsSuccessStatusCode)
            {
                response = await httpResponse.Content.ReadAsAsync<List<GetQuantityInStockByCodigoResponse>>();
            }
            return new Response<List<GetQuantityInStockByCodigoResponse>>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = response
            };
        }

    }
}