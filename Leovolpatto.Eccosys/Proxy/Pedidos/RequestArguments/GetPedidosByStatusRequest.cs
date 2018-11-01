using Leovolpatto.Eccosys.Models;

namespace Leovolpatto.Eccosys.Proxy.Pedidos.RequestArguments
{
    public class GetPedidosByStatusRequest : Request
    {
        public string status { get; set; }
    }
}