namespace Leovolpatto.Eccosys.Proxy.Estoques.Responses
{
    public class GetQuantityInStockByCodigoResponse
    {
        public string estoqueReal { get; set; }
        public string estoqueDisponivel { get; set; }
        public string codigo { get; set; }
        public string nome { get; set; }
    }
}