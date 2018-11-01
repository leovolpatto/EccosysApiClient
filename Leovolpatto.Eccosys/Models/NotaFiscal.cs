using Newtonsoft.Json;

namespace Leovolpatto.Eccosys.Models
{
    public class NotaFiscal
    {
        public string id { get; set; }
        public string numero { get; set; }
        public string idContato { get; set; }
        public string idTipoNota { get; set; }
        public string idOrigem { get; set; }
        public string contato { get; set; }
        public string cnpj { get; set; }
        public string identificadorEstrangeiro { get; set; }
        public string ie { get; set; }
        public string identificadorIE { get; set; }
        public string tipoPessoa { get; set; }
        public string endereco { get; set; }
        public string enderecoNro { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string idMunicipio { get; set; }
        public string municipio { get; set; }
        public string fone { get; set; }
        public string uf { get; set; }
        public string cfop { get; set; }
        public string natureza { get; set; }
        [JsonProperty("cfop_servicos")]
        public string cfopServicos { get; set; }
        public string naturezaServicos { get; set; }
        public string tipo { get; set; }
        public string dataEmissao { get; set; }
        public string dtEmissaoDANFE { get; set; }
        public string dataSaidaEntrada { get; set; }
        public string horaSaidaEntrada { get; set; }
        public string baseICMS { get; set; }
        public string valorICMS { get; set; }
        public string baseICMSSubst { get; set; }
        public string valorICMSSubst { get; set; }
        public string frete { get; set; }
        public string seguro { get; set; }
        public string outrasDespesas { get; set; }
        public string valorIPI { get; set; }
        public string valorProdutos { get; set; }
        public string valorNota { get; set; }
        public string transportador { get; set; }
        public string fretePorConta { get; set; }
        public string placa { get; set; }
        public string ufVeiculo { get; set; }
        public string cnpjTransportador { get; set; }
        public string enderecoTransportador { get; set; }
        public string municipioTransportador { get; set; }
        public string ufTransportador { get; set; }
        public string ieTransportador { get; set; }
        public string qtdVolumes { get; set; }
        public string especie { get; set; }
        public string marca { get; set; }
        public string nroDosVolumes { get; set; }
        public string pesoBruto { get; set; }
        public string pesoLiquido { get; set; }
        public string situacao { get; set; }
        public string desconto { get; set; }
        public string tipoDesconto { get; set; }
        public string valorDesconto { get; set; }
        public string obsSistema { get; set; }
        public string observacoes { get; set; }
        public string pedidos { get; set; }
        public string representante { get; set; }
        public string portador { get; set; }
        public string condicao { get; set; }
        public string baseISS { get; set; }
        public string baseCalculoISS { get; set; }
        public string percentualISS { get; set; }
        public string valorISS { get; set; }
        public string valorServicos { get; set; }
        public string serie { get; set; }
        public string totalFaturado { get; set; }
        public string inscricaoSuframa { get; set; }
        public string complemento { get; set; }
        public string valorISSQN { get; set; }
        public string tipoPagamento { get; set; }
        public string finalidade { get; set; }
        public string idPais { get; set; }
        public string nomePais { get; set; }
        public string sisdeclaraOperacao { get; set; }
        public string sisdeclaraTipoNota { get; set; }
        public string sisdeclaraNumeroGuia { get; set; }
        public string sisdeclaraCadastroViticultor { get; set; }
        public string valorII { get; set; }
        public string notaTipo { get; set; }
        public string diNumero { get; set; }
        public string diData { get; set; }
        public string diLocalDesembaraco { get; set; }
        public string diUFDesembaraco { get; set; }
        public string diDataDesembaraco { get; set; }
        public string diCodigoExportador { get; set; }
        public string diNumeroAdicao { get; set; }
        public string diSequencialAdicao { get; set; }
        public string diCodigoFabricante { get; set; }
        public string diValorDescontoAdicao { get; set; }
        public string diTipoTransporte { get; set; }
        public string diTipoIntermedio { get; set; }
        public string diNFCI { get; set; }
        public string diCnpjAdquirinte { get; set; }
        public string diUfAdquirinte { get; set; }
        public string valorDespesaAduaneira { get; set; }
        public string localEmbarque { get; set; }
        public string ufEmbarque { get; set; }
        public string valorBaseDiferimento { get; set; }
        public string valorPresumido { get; set; }
        public string simples { get; set; }
        public string alqSimples { get; set; }
        public string valorSimples { get; set; }
        public string valorFunrural { get; set; }
        public string email { get; set; }
        public string idCategoria { get; set; }
        public string idVendedor { get; set; }
        public string tipoAmbiente { get; set; }
        [JsonProperty("nfe_msg")]
        public string nfeMsg { get; set; }
        public string calculaImpostos { get; set; }
        public string idMagento { get; set; }
        public string valorRetPIS { get; set; }
        public string valorRetCOFINS { get; set; }
        public string valorRetCSLL { get; set; }
        public string valorRetBaseIR { get; set; }
        public string valorRetIR { get; set; }
        public string valorMinimoParaRetencao { get; set; }
        public string valorUnitarioComII { get; set; }
        public string crt { get; set; }
        public string custoAtualizado { get; set; }
        public string pvFrete { get; set; }
        public string hashXML { get; set; }
        public string pickingRealizado { get; set; }
        public string idOrdemColeta { get; set; }
        public string opcEnderecoDiferente { get; set; }
        public string integradoLogistica { get; set; }
        public string confirmacaoLogistica { get; set; }
        public string dapiXREF { get; set; }
        public string idDeposito { get; set; }
        public string considerarNoEstoqueDisponivel { get; set; }
        public string protocoloLogistica { get; set; }
        public string servicoContratado { get; set; }
        public string tipoEntrega { get; set; }
        public string formaFrete { get; set; }
        public string codigoRastreamento { get; set; }
        public string dataCodigoRastreamento { get; set; }
        public string valorAproximadoImpostosTotal { get; set; }
        public string pesoTransportadora { get; set; }
        public string avisoRecebimento { get; set; }
        public string maoPropria { get; set; }
        public string possuiValorDeclarado { get; set; }
        public string valorDeclarado { get; set; }
        public string possuiListaPostagem { get; set; }
        public string tipoObjeto { get; set; }
        public string dimensaoDiametro { get; set; }
        public string dimensaoAltura { get; set; }
        public string dimensaoLargura { get; set; }
        public string dimensaoComprimento { get; set; }
        public string valorTotalICMSPartilhaDestino { get; set; }
        public string valorTotalICMSPartilhaOrigem { get; set; }
        public string percentualICMSPartilhaDestino { get; set; }
        public string valorTotalICMSFCPDestino { get; set; }
        public string exportacaoNumeroRegistro { get; set; }
        public string idReferenciaExportacao { get; set; }
        public string valorTotalFCP { get; set; }
        public string totalIpiDevolvido { get; set; }
        [JsonProperty("id_nota")]
        public string idNota { get; set; }
        [JsonProperty("id_lote")]
        public string idLote { get; set; }
        [JsonProperty("chave_acesso")]
        public string chaveAcesso { get; set; }
        [JsonProperty("xml_nfe")]
        public string xmlNfe { get; set; }
        [JsonProperty("xml_prot_nfe")]
        public string xmlProtNfe { get; set; }
        [JsonProperty("xml_cancelamento_envio")]
        public string xmlCancelamentoEnvio { get; set; }
        [JsonProperty("xml_cancelamento")]
        public string xmlCancelamento { get; set; }
        [JsonProperty("numero_protocolo")]
        public string numeroProtocolo { get; set; }
        public string dataHoraEnvio { get; set; }
    }
}