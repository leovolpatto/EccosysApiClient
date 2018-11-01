namespace Leovolpatto.Eccosys.Proxy.RequestParameters
{
    public class NotaFiscalParameters: RequestParameter
    {
        private NotaFiscalParameters(){}

        public NotaFiscalParameters SetTipoNota(string tipo)
        {
            this._parameters.Add("$tipoNota", tipo);
            return this;
        }

        public NotaFiscalParameters SetSituacao(string situacao)
        {
            this._parameters.Add("$situacao", situacao);
            return this;
        }

        public NotaFiscalParameters SetIdOperacaoFiscal(string id)
        {
            this._parameters.Add("idOperacaoFiscal", id);
            return this;
        }

        public NotaFiscalParameters SetLancarEstoque(string lancarEstoque)
        {
            this._parameters.Add("lancarEstoque", lancarEstoque);
            return this;
        }

        public static NotaFiscalParameters Create()
        {
            return new NotaFiscalParameters();
        }        
    }
}