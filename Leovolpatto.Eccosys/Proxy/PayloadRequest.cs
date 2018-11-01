namespace Leovolpatto.Eccosys.Proxy
{
    public class PayloadRequest<T> : Request
    {

        public T Body { get; set; }

    }
}