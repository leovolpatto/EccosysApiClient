namespace Leovolpatto.Eccosys.Models
{
    public class PedidoParcela
    {
        public string id { get; set; }
        public string idVenda { get; set; }
        public string nroDias{ get; set; }
        public string dataVencimento{ get; set; }
        public string valor{ get; set; }
        public string obs{ get; set; }
        public string formaPagamento{ get; set; }
        public string codigoFormaPagamento{ get; set; }
    }
}