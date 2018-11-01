using System.Net.Http;
using Leovolpatto.Eccosys.Models;

namespace Leovolpatto.Eccosys.Proxy.Clientes
{
    public class ClientesProxy : ProxyBase<Cliente>
    {
        protected override string Endpoint => "https://limelife.eccosys.com.br/api/clientes";
        public ClientesProxy(HttpClient client) : base(client)
        {
        }
    }
}