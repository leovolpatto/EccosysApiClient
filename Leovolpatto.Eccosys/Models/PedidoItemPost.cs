namespace Leovolpatto.Eccosys.Models
{
    public class PedidoItemPost : PedidoItem
    {
        public Produto _Produto { get; set; }

        public PedidoItemPost() : base() 
        {
            this._Produto = new Produto();
        }
    }
}