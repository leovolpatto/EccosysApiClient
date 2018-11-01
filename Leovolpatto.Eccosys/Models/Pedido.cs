using System.Collections.Generic;
using Newtonsoft.Json;

namespace Leovolpatto.Eccosys.Models
{

    public enum PedidoStatuses
    {
        AguardandoPagamento = -1,
        EmAberto,
        Atendido,
        Cancelado,
        ProntoParaPicking,
        PagamentoEmAnalise
    }

    public class Pedido
    {
        public Pedido()
        {
            this._Cliente = new Cliente();
            this._Itens = new List<PedidoItemPost>();
            this._Ocorrencias = new List<PedidoOcorrencia>();
            this._Parcelas = new List<PedidoParcela>();
        }

        public int id { get; set; }
        public string idContato { get; set; }
        public string data { get; set; }
        public string situacao { get; set; }
        public string situacaoSecundaria { get; set; }
        public string desconto { get; set; }
        public string condicao { get; set; }
        public string observacoes { get; set; }
        public decimal totalProdutos { get; set; }
        public decimal totalVenda { get; set; }
        public string idOrigem { get; set; }
        public string idPedidoOrigem { get; set; }
        public object tipoPagamento { get; set; }
        public string numeroPedido { get; set; }
        public string dataPrevista { get; set; }
        public string idVendedor { get; set; }
        public string idCategoria { get; set; }
        public decimal frete { get; set; }
        public object primeiraCompra { get; set; }
        public string observacaoInterna { get; set; }
        public object dataFaturamento { get; set; }
        public string numeroDaOrdemDeCompra { get; set; }
        public string idNotaFiscalRef { get; set; }
        public string transportador { get; set; }
        public string fretePorConta { get; set; }
        public string valorIPI { get; set; }
        public string valorST { get; set; }
        public string opcEnderecoDiferente { get; set; }
        public string paymentOrderID { get; set; }
        public string codigoRastreamento { get; set; }
        public string dataCodigoRastreamento { get; set; }
        public string rastreamentoConcluido { get; set; }
        public string pickingRealizado { get; set; }
        public string qtdVolumes { get; set; }
        public string pesoLiquido { get; set; }
        public string pesoBruto { get; set; }
        public string especieVolume { get; set; }
        public string situacaoDescricao { get; set; }
        public string dataPagamento { get; set; }
        public string formaFrete { get; set; }
        public string pesoTransportadora { get; set; }
        public string avisoRecebimento { get; set; }
        public string maoPropria { get; set; }
        public string possuiValorDeclarado { get; set; }
        public string valorDeclarado { get; set; }
        public string statusAlterado { get; set; }
        public string syncLogistica { get; set; }
        public string confirmacaoLogistica { get; set; }
        public string dtCriacaoVenda { get; set; }
        public string tipoObjeto { get; set; }
        public string dimensaoDiametro { get; set; }
        public string dimensaoAltura { get; set; }
        public string dimensaoLargura { get; set; }
        public string dimensaoComprimento { get; set; }
        public string idLojaVirtual { get; set; }
        public object dataEnvioLogistica { get; set; }
        public object dataRecebimentoLogistica { get; set; }
        public string servicePlatformOrigin { get; set; }
        public string pedidoDeServico { get; set; }
        public string idMarketplaceIntegrado { get; set; }
        public object idMarketplacePedidoMaster { get; set; }
        public string dataEntrega { get; set; }
        public object numeroNotaFiscal { get; set; }
        public string canalDeVenda { get; set; }
        public bool pedidoColetado { get; set; }
        public List<PedidoOcorrencia> _Ocorrencias { get; set; }
        public Cliente _Cliente { get; set; }
        public List<PedidoItemPost> _Itens { get; set; }
        public List<PedidoParcela> _Parcelas { get; set; }
        public PedidoEndereco _OutroEndereco { get; set; }
        public Transportadora _Transportadora { get; set; }
    }
}