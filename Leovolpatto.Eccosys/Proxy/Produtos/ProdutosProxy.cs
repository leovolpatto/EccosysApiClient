using Leovolpatto.Eccosys.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Leovolpatto.Eccosys.Proxy.Produtos
{
    /// <summary>
    /// Product Proxy
    /// </summary>
    /// <remarks>
    /// This class is used to perform product operation
    /// </remarks>
    /// <seealso cref="Leovolpatto.Eccosys.Proxy.ProxyBase{Leovolpatto.Eccosys.Models.Produto}" />
    public class ProdutosProxy : ProxyBase<Produto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProdutosProxy"/> class.
        /// </summary>
        /// <param name="client">The client.</param>
        public ProdutosProxy(HttpClient client) : base(client)
        {
        }

        protected override string Endpoint => "https://limelife.eccosys.com.br/api/produtos";

        /// <summary>
        /// Gets the produtos COM estoque alterado.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<List<Produto>>> GetProdutosComEstoqueAlterado()
        {
            HttpResponseMessage httpResponse = await this.Client.GetAsync(this.Endpoint);

            List<Produto> products = null;
            if (httpResponse.IsSuccessStatusCode)
            {
                products = httpResponse.Content.ReadAsAsync<List<Produto>>().Result;
            }
            return new Response<List<Produto>>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = products
            };
        }

        /// <summary>
        /// Gets the todos produtos alterados.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<List<Produto>>> GetTodosProdutosAlterados()
        {
            HttpResponseMessage httpResponse = await this.Client.GetAsync(this.Endpoint + "/produtosAlterados");

            List<Produto> products = null;
            if (httpResponse.IsSuccessStatusCode)
            {
                products = httpResponse.Content.ReadAsAsync<List<Produto>>().Result;
            }
            return new Response<List<Produto>>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = products
            };
        }

        /// <summary>
        /// Gets the todos produtos pai.
        /// </summary>
        /// <returns></returns>
        public async Task<Response<List<Produto>>> GetTodosProdutosPai()
        {
            HttpResponseMessage httpResponse = await this.Client.GetAsync(this.Endpoint + "/produtosPai");

            List<Produto> products = null;
            if (httpResponse.IsSuccessStatusCode)
            {
                products = httpResponse.Content.ReadAsAsync<List<Produto>>().Result;
            }

            return new Response<List<Produto>>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = products
            };
        }

        public async Task<Response<DefaultPostResponse>> SetProdutosComEstoqueAlterado(PayloadRequest<List<Produto>> request)
        {
            HttpResponseMessage httpResponse = await this.Client.PutAsJsonAsync(this.Endpoint + "produtosComEstoqueAlterado", request.Body);

            DefaultPostResponse response = null;
            if (httpResponse.IsSuccessStatusCode)
            {
                response = httpResponse.Content.ReadAsAsync<DefaultPostResponse>().Result;
            }

            return new Response<DefaultPostResponse>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = response
            };
        }

        public override IModelProxyResult<Produto> GetItem(GetByIdRequest request){ 
            var httpResponse = this.Client.GetAsync(String.Format("{0}/{1}", this.Endpoint, request.id.ToString())).Result;
            Produto produto = new Produto();
                //var reString = httpResponse.Content.ReadAsStringAsync().Result;
                //Debug.WriteLine("Eccosys");
                //Debug.WriteLine(reString);
                            
            if (httpResponse.IsSuccessStatusCode)
            {   
                produto = httpResponse.Content.ReadAsAsync<Produto>().Result;                
            }
            return new Response<Produto>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = produto
            };            
        }
    }
}



/**

ECCOSYS
    estoques (consultar, definir)

 */
