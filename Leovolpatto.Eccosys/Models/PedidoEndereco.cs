namespace Leovolpatto.Eccosys.Models
{
    public class PedidoEndereco
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string enderecoNro { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string nomePais { get; set; }
    }
}