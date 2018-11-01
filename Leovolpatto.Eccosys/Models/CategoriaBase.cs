namespace Leovolpatto.Eccosys.Models
{
    public class CategoriaBase : IModel
    {
        public int id { get; set; }
        public string idExterno { get; set; }
        public string nome { get; set; }
        public string tituloPagina { get; set; }
        public string descricao { get; set; }
        public string keywords { get; set; }
        public int idGrupoTag { get; set; }
    }
}