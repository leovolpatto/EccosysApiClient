using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Leovolpatto.Eccosys.Models;
using Leovolpatto.Eccosys.Proxy.Pedidos.RequestArguments;

namespace Leovolpatto.Eccosys.Proxy.Pedidos
{
    /// <summary>
    /// Pedidos Proxy
    /// </summary>
    /// <remarks>
    /// pedidos = orders
    /// </remarks>
    /// <seealso cref="Leovolpatto.Eccosys.Proxy.ProxyBase{Leovolpatto.Eccosys.Models.Pedido}" />
    public class PedidosProxy : ProxyBase<Pedido>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PedidosProxy"/> class.
        /// </summary>
        /// <param name="client">The client.</param>
        public PedidosProxy(HttpClient client) : base(client)
        {
        }

        protected override string Endpoint => "https://limelife.eccosys.com.br/api/pedidos";

        public async Task<Response<List<Pedido>>> GetPedidosByStatus(GetPedidosByStatusRequest request)
        {
            HttpResponseMessage httpResponse = await this.Client.GetAsync(String.Format("{0}/{1}/{2}", this.Endpoint, "status", request.status));

            List<Pedido> salesOrders = null;
            if (httpResponse.IsSuccessStatusCode)
            {
                salesOrders = await httpResponse.Content.ReadAsAsync<List<Pedido>>();
            }

            return new Response<List<Pedido>>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = salesOrders
            };
        }

        public async Task<Response<Pedido>> GetPedidoByNumeroOC(GetByNumeroOCRequest request)
        {
            HttpResponseMessage httpResponse = await this.Client.GetAsync(String.Format("{0}/{1}", this.Endpoint, $"numeroOC={request.numeroOC}"));

            List<Pedido> salesOrders = null;
            if (httpResponse.IsSuccessStatusCode)
            {
                salesOrders = await httpResponse.Content.ReadAsAsync<List<Pedido>>();
            }

            return new Response<Pedido>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = salesOrders.Find(p => p.numeroDaOrdemDeCompra == request.numeroOC)
            };
        }

        public async Task<Response<UpdatePedidoStatusPostResponse>> UpdatePedidoStatus(UpdatePedidoStatusRequest request)
        {
            HttpResponseMessage httpResponse = await this.Client.PostAsJsonAsync(String.Format("{0}/{1}/{2}", this.Endpoint, request.id, "situacao"), request.Body);
            UpdatePedidoStatusPostResponse response = httpResponse.Content.ReadAsAsync<UpdatePedidoStatusPostResponse>().Result;
            return new Response<UpdatePedidoStatusPostResponse>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = response
            };
        }

        public async Task<Response<List<PedidoItemGet>>> GetItensPedido(Request request, int idPedido)
        {
            HttpResponseMessage httpResponse = await this.Client.GetAsync(String.Format("{0}/{1}/{2}", this.Endpoint, idPedido, "items"));
            List<PedidoItemGet> itensPedido = null;
            if (httpResponse.IsSuccessStatusCode)
            {
                itensPedido = httpResponse.Content.ReadAsAsync<List<PedidoItemGet>>().Result;
            }
            return new Response<List<PedidoItemGet>>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = itensPedido
            };
        }

        public async Task<Response<Transportadora>> GetTransportadoraPedido(Request request, int idPedido)
        {
            HttpResponseMessage httpResponse = await this.Client.GetAsync(String.Format("{0}/{1}/{2}", this.Endpoint, idPedido, "transportadora"));
            Transportadora transportadora = null;
            if (httpResponse.IsSuccessStatusCode)
            {
                transportadora = httpResponse.Content.ReadAsAsync<Transportadora>().Result;
            }
            return new Response<Transportadora>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = transportadora
            };
        }

        public async Task<Response<DefaultPostResponse>> SetPedidoAsEnviadoParaLogistica(SetPedidoAsEnviadoParaLogisticaRequest request)
        {
            HttpResponseMessage httpResponse = await this.Client.PutAsync($"{this.Endpoint}/{request.pedidoId}/picking/envioLogistica", default(HttpContent));
            DefaultPostResponse responseBody = httpResponse.Content.ReadAsAsync<DefaultPostResponse>().Result;
            return new Response<DefaultPostResponse>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = responseBody
            };
        }

        public async Task<Response<DefaultPostResponse>> SetPedidoAsConfirmadoPelaLogistica(SetPedidoAsConfirmadoPelaLogisticaRequest request)
        {
            HttpResponseMessage httpResponse = await this.Client.PutAsJsonAsync($"{this.Endpoint}/{request.pedidoId}/picking/confirmacaoLogistica", request.Body);
            DefaultPostResponse responseBody = httpResponse.Content.ReadAsAsync<DefaultPostResponse>().Result;
            return new Response<DefaultPostResponse>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = responseBody
            };
        }
    }
}