using System.Net.Http;
using Leovolpatto.Eccosys.Models;

namespace Leovolpatto.Eccosys.Proxy.Fornecedores
{
    public class FornecedoresProxy : ProxyBase<Fornecedor>
    {
        protected override string Endpoint => "https://limelife.eccosys.com.br/api/fornecedores";
        public FornecedoresProxy(HttpClient client) : base(client)
        {
        }
    }
}