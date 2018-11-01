using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Leovolpatto.Eccosys.Models;
using Leovolpatto.Eccosys.Proxy.NotasFiscais.RequestArguments;

namespace Leovolpatto.Eccosys.Proxy.NotasFiscais
{
    public class NotasFiscaisProxy : ProxyBase<NotaFiscal>
    {
        public NotasFiscaisProxy(HttpClient client) : base(client)
        {
        }

        protected override string Endpoint => "https://limelife.eccosys.com.br/api/nfes";
        
        public virtual Response<DefaultPostResponse> GenerateNfe(GenerateAndEmitNotaFiscalRequest request)
        {
            HttpResponseMessage httpResponse = this.Client.PostAsJsonAsync($"{this.Endpoint}/{request.numeroPedido}" + request.GetParametersString(), string.Empty).Result;
            string dbgres = httpResponse.Content.ReadAsStringAsync().Result;
            try
            {
                var resultData = httpResponse.Content.ReadAsAsync<Result>().Result;
                return new Response<DefaultPostResponse>()
                {
                    IsSuccess = httpResponse.IsSuccessStatusCode,
                    Data = new DefaultPostResponse()
                    {
                        result = resultData
                    }
                };
            }
            catch (Exception exp)
            {
                return new Response<DefaultPostResponse>()
                {
                    IsSuccess = false,
                    Data = null
                };
            }
        }

        public async Task<Response<List<NotaFiscalItem>>> GetItemsNotaFiscal(GetItemsNotaFiscalRequest request)
        {
            HttpResponseMessage httpResponse = await this.Client.GetAsync(String.Format("{0}/{1}/{2}", this.Endpoint, request.NumeroNota, "items"));
            return new Response<List<NotaFiscalItem>>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = await httpResponse.Content.ReadAsAsync<List<NotaFiscalItem>>()
            };
        }
    }
}