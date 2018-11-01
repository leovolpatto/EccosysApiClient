namespace Leovolpatto.Eccosys.Proxy.Estoques.RequestArguments
{
    public class InsertRegistroEstoqueRequest : PayloadRequest<InsertRegistroEstoqueRequestBody>
    {
        public string codigo { get; set; }
    }

    public class InsertRegistroEstoqueRequestBody
    {

        public int idOrigem { get; set; }
        public int idDeposito { get; set; }
        public string data { get; set; }
        public int quantidade { get; set; }
        public double preco { get; set; }
        public EstoqueType es { get; set; }
        public double custoLancamento { get; set; }
        public EntradaType tipoEntrada { get; set; }
        public int idLote { get; set; }
        public Consignacao consignacao { get; set; }
        public int idConferencia { get; set; }
    }

    public enum EstoqueType
    {
        Balanco = 'B',
        Saida = 'S',
        Entrada = 'E'
    }

    public enum EntradaType
    {
        Normal = 'N',
        Devolucao = 'D'
    }

    public enum Consignacao
    {
        Sim = 'S',
        Nao = 'N'
    }

}