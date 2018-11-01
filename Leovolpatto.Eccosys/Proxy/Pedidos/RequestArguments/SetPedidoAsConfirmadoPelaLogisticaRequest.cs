namespace Leovolpatto.Eccosys.Proxy.Pedidos.RequestArguments
{
    public class SetPedidoAsConfirmadoPelaLogisticaRequestBody
    {
        public float pesoBruto { get; set; }
        public long quantidadeDeVolumes { get; set; }
    }
    public class SetPedidoAsConfirmadoPelaLogisticaRequest : PayloadRequest<SetPedidoAsConfirmadoPelaLogisticaRequestBody>
    {
        public string pedidoId { get; set; }
    }
}