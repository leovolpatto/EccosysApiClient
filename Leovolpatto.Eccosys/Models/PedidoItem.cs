namespace Leovolpatto.Eccosys.Models
{
    public class PedidoItem
    {
        public string id { get; set; }
        public string idVenda { get; set; }
        public string idProduto { get; set; }
        public string quantidade{ get; set; }
        public decimal valor{ get; set; }
        public string descricao{ get; set; }
        public string base_comissao{ get; set; }
        public string alq_comissao{ get; set; }
        public string vlr_comissao{ get; set; }
        public string precoLista{ get; set; }
        public string codigoCupom{ get; set; }
        public string unidadeCupom{ get; set; }
        public string ipptCupom{ get; set; }
        public string itemCanceladoCupom{ get; set; }
        public string numItemCupom{ get; set; }
        public string itemBonificacao{ get; set; }
        public string valorComImpostos{ get; set; }
        public decimal valorFrete{ get; set; }
        public string descontoItem{ get; set; }
        public string observacao{ get; set; }
        public string desconto_adm{ get; set; }
        
    }
}