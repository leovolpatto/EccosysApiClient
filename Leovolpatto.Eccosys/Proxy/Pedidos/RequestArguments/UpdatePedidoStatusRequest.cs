using Leovolpatto.Eccosys.Models;

namespace Leovolpatto.Eccosys.Proxy.Pedidos.RequestArguments
{
    public class UpdatePedidoStatusRequestBody
    {
        public string situacao { get; set; }
        public string historico { get; set; }
    }
    public class UpdatePedidoStatusRequest : PayloadRequest<UpdatePedidoStatusRequestBody>
    {
        public int id { get; set; }
    }
}