using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Leovolpatto.Eccosys.Models
{
    public class Produto : IModel
    {
        public int id { get; set; }
        public int idCatProd { get; set; }
        public int isSubCatProd { get; set; }
        public string nome { get; set; }
        public string codigo { get; set; }
        public string unidade { get; set; }
        public string unPorCaixa { get; set; }
        public string cf { get; set; }
        public float preco { get; set; }
        public string origem { get; set; }
        public string obs { get; set; }
        public string situacao { get; set; }
        public float valorIpiFixo { get; set; }
        public string tipo { get; set; }
        public string tipoFrete { get; set; }
        public string classeEnquadIpi { get; set; }
        public string calcAutomEstoque { get; set; }
        public float? estoqueMinimo { get; set; }
        public float? estoqueMaximo { get; set; }
        public int? diasCoberturaMin { get; set; }
        public int? diasCoberturaMax { get; set; }
        public float peso { get; set; }
        public string medidas { get; set; }
        public float pesoLiq { get; set; }
        public float pesoBruto { get; set; }
        public string codigoNoFabricante { get; set; }
        public string idFornecedor { get; set; }
        public string localizacao { get; set; }
        public string tipoProducao { get; set; }
        public float precoCusto { get; set; }
        public float precoCustoUss { get; set; }
        public int? idLinhaProduto { get; set; }
        public string gtin { get; set; }
        public string gtinEmbalagem { get; set; }
        public string descricaoComplementar { get; set; }
        public string descricaoEcommerce { get; set; }
        public string spedTipoItem { get; set; }
        public string opcEcommerce { get; set; }
        public string opcEstoqueEcommerce { get; set; }
        public float comprimento { get; set; }
        public float altura { get; set; }
        public float largura { get; set; }
        public float comprimentoReal { get; set; }
        public float alturaReal { get; set; }
        public float larguraReal { get; set; }
        public float pesoReal { get; set; }
        public int idProdutoMaster { get; set; }
        public int idTagDepartamentoArvore { get; set; }
        public int idTagCategoriaArvore { get; set; }
        public int idTagSubcategoriaArvore { get; set; }
        public int idTagMarcaArvore { get; set; }
        public string tituloPagina { get; set; }
        public string urlEcommerce { get; set; }
        public string keyword { get; set; }
        public string metatagDescription { get; set; }
        public string adwordsRmkCode { get; set; }
        public string cpgnCode { get; set; }
        public float? precoDe { get; set; }
        public float? valorFidelidade { get; set; }
        public int? loteMinimo { get; set; }
        public string situacaoVenda { get; set; }
        public string situacaoCompra { get; set; }
        public string produtoAlterado { get; set; }
        public int? coberturaIdeal { get; set; }
        public string idLojaVirtual { get; set; }
        public string dtCriacao { get; set; }
        public string ipiCodigoEnquadramento { get; set; }
        public string cest { get; set; }
        //public string virtual { get; set; }
        public string unidadeTributavel { get; set; }
        public float? fatorQtdeTributavel { get; set; }
        public string tipoObjeto { get; set; }
        public DateTime? data { get; set; }
        public int? idProprietario { get; set; }
        public DateTime? dataAlteracao { get; set; }
        public string excluido { get; set; }
    }
}