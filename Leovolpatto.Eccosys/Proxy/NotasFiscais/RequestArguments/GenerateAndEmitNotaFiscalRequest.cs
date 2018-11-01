using Leovolpatto.Eccosys.Models;

namespace Leovolpatto.Eccosys.Proxy.NotasFiscais.RequestArguments
{
    public class GenerateAndEmitNotaFiscalRequest : Request
    {
        public string numeroPedido { get; set; }
    }
}