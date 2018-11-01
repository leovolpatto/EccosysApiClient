using System.Collections.Generic;

namespace Leovolpatto.Eccosys.Proxy
{
    public class UpdatePedidoStatusPostResponse : DefaultPostResponse
    {
        public new ResultString result { get; set; }
    }
    public class ResultString : Result
    {
        public new List<string> success { get; set; }
    }

}
