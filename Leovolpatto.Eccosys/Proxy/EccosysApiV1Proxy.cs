using Leovolpatto.Eccosys.Models;
using Leovolpatto.Eccosys.Proxy.RequestParameters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Leovolpatto.Eccosys.Proxy.Produtos;
using Leovolpatto.Eccosys.Proxy.Pedidos;
using Leovolpatto.Eccosys.Proxy.Clientes;
using Leovolpatto.Eccosys.Proxy.Transportadoras;
using Leovolpatto.Eccosys.Proxy.Fornecedores;
using Leovolpatto.Eccosys.Proxy.NotasFiscais;

namespace Leovolpatto.Eccosys.Proxy
{
    public class EccosysApiV1Proxy
    {
        private HttpClient client;
        private static EccosysApiV1Proxy _instance;

        public ProdutosProxy Produtos { get; private set; }

        public PedidosProxy Pedidos { get; private set; }

        public ClientesProxy Clientes { get; private set; }

        public TransportadorasProxy Transportadoras { get; private set; }

        public FornecedoresProxy Fornecedores { get; private set; }
        public NotasFiscaisProxy NotasFiscais { get; private set; }

        public static EccosysApiV1Proxy GetInstance()
        {
            if (_instance == null)
                _instance = new EccosysApiV1Proxy();

            return _instance;
        }

        public EccosysApiV1Proxy()
        {
            this.InitializeClient();
            this.Produtos = new ProdutosProxy(this.client);
            this.Pedidos = new PedidosProxy(this.client);
            this.Clientes = new ClientesProxy(this.client);
            this.Transportadoras = new TransportadorasProxy(this.client);
            this.Fornecedores = new FornecedoresProxy(this.client);
            this.NotasFiscais = new NotasFiscaisProxy(this.client);

        }

        private void InitializeClient()
        {
            this.client = new HttpClient();
            client.BaseAddress = new Uri(EccosysConfigs.GetApiURI());
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("apikey", EccosysConfigs.GetApiKey());
            string signature = Helpers.ApiAuthHelper.GenerateSignature(EccosysConfigs.GetSecret());
            client.DefaultRequestHeaders.Add("signature", signature);
        }
    }
}
