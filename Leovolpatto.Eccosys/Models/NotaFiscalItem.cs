using Newtonsoft.Json;

namespace Leovolpatto.Eccosys.Models
{
    public class NotaFiscalItem
    {
        public string id { get; set; }
        public string idNotaFiscal { get; set; }
        public string idProduto { get; set; }
        public string codigo { get; set; }
        public string cf { get; set; }
        public string cest { get; set; }
        public string codigoANP { get; set; }
        [JsonProperty("st_old")]
        public string stOld { get; set; }
        public string un { get; set; }
        public string quantidade { get; set; }
        public string valorUnitario { get; set; }
        public string valorTotal { get; set; }
        public string icms { get; set; }
        public string ipi { get; set; }
        public string consumidorFinal { get; set; }
        [JsonProperty("base_icms")]
        public string baseIcms { get; set; }
        [JsonProperty("base_ipi")]
        public string baseIpi { get; set; }
        public string valorIpi { get; set; }
        public string valorIpiTotal { get; set; }
        public string valorIcms { get; set; }
        public string descricao { get; set; }
        [JsonProperty("tributacao_icms")]
        public string tributacaoIcms { get; set; }
        [JsonProperty("tributacao_ipi")]
        public string tributacaoIpi { get; set; }
        public string valorIpiFixo { get; set; }
        public string idOperacaoFiscal { get; set; }
        public string cfop { get; set; }
        public string faturada { get; set; }
        public string valorFrete { get; set; }
        public string valorDesconto { get; set; }
        public string valorSeguro { get; set; }
        public string origem { get; set; }
        public string tipo { get; set; }
        public string obs { get; set; }
        public string outrasDespesas { get; set; }
        public string somaImpostosTotalNota { get; set; }
        public string pesoLiq { get; set; }
        public string pesoBruto { get; set; }
        public string alqFunrural { get; set; }
        public string valorFunrural { get; set; }
        [JsonProperty("base_comissao")]
        public string baseComissao { get; set; }
        [JsonProperty("alq_comissao")]
        public string alqComissao { get; set; }
        [JsonProperty("vlr_comissao")]
        public string vlrComissao { get; set; }
        public string precoLista { get; set; }
        public string equivalenteTipo { get; set; }
        public string equivalenteUn { get; set; }
        public string equivalenteQuantidade { get; set; }
        public string codigoNoFabricante { get; set; }
        public string impostoRetido { get; set; }
        public string retBaseIR { get; set; }
        public string retValorIR { get; set; }
        public string retAliquotaIR { get; set; }
        public string retValorCSLL { get; set; }
        public string retAliquotaCSLL { get; set; }
        public string pvCustoUnitario { get; set; }
        public string pvMarkup { get; set; }
        public string pvPrecoVenda { get; set; }
        public string pvFrete { get; set; }
        public string descricaoComplementar { get; set; }
        public string gtin { get; set; }
        public string gtinEmbalagem { get; set; }
        public string spedTipoItem { get; set; }
        public string numeroLote { get; set; }
        public string dataFabricacao { get; set; }
        public string dataValidade { get; set; }
        public string valorAproximadoImpostos { get; set; }
        public string numeroPedidoCompra { get; set; }
        public string percentualDevolvido { get; set; }
    }
}