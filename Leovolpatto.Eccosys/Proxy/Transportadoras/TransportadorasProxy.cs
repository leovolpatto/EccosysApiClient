using System.Net.Http;
using Leovolpatto.Eccosys.Models;

namespace Leovolpatto.Eccosys.Proxy.Transportadoras
{
    public class TransportadorasProxy : ProxyBase<Transportadora>
    {
        protected override string Endpoint => "https://limelife.eccosys.com.br/api/transportadoras";
        public TransportadorasProxy(HttpClient client): base(client)
        { }
    }
}