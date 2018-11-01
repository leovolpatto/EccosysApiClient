using System;
using System.Collections.Generic;
using System.Text;

namespace Leovolpatto.Eccosys.Proxy{
    public class Response<T> : IModelProxyResult<T>
    {        
        public bool IsSuccess { get; set; }
        public T Data { get; set; }

    }
}