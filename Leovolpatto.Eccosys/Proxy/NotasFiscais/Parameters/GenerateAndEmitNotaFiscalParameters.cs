using Leovolpatto.Eccosys.Proxy.RequestParameters;

namespace Leovolpatto.Eccosys.Proxy.NotasFiscais.Parameters
{
    public class GenerateAndEmitNotaFiscalParameters: RequestParameter
    {
        public static GenerateAndEmitNotaFiscalParameters Create()
        {
            return new GenerateAndEmitNotaFiscalParameters();
        }

        public GenerateAndEmitNotaFiscalParameters SetTipo(string tipo)
        {
            if (tipo == "S" || tipo == "E")
                this._parameters.Add("tipo", tipo);
            return this;
        }

        public GenerateAndEmitNotaFiscalParameters SetEnviarEmailNota(bool sendEmail)
        {
            string sendString = sendEmail ? "S" : "N";
            this._parameters.Add("enviarEmailNota", sendString);
            return this;
        }

        public GenerateAndEmitNotaFiscalParameters SetIdOperacaoFiscal(int eccosysOperacaoFiscalId)
        {
            this._parameters.Add("idOperacaoFiscal", eccosysOperacaoFiscalId.ToString());
            return this;
        }

        public GenerateAndEmitNotaFiscalParameters SetMustDropStock(bool dropStock)
        {
            string dropString = dropStock ? "S" : "N";
            this._parameters.Add("lancarEstoque", dropString);
            return this;
        }
    }
}