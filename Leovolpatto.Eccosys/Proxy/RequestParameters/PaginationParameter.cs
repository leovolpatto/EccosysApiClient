using System;
using System.Collections.Generic;
using System.Text;

namespace Leovolpatto.Eccosys.Proxy.RequestParameters
{
    public class PaginationParameter : RequestParameter
    {
        private PaginationParameter(){}

        public PaginationParameter SetCount(int count)
        {
            this._parameters.Add("$count", count.ToString());
            return this;
        }

        public PaginationParameter SetOffset(int offset)
        {
            this._parameters.Add("$offset", offset.ToString());
            return this;
        }

        public static PaginationParameter Create()
        {
            return new PaginationParameter();
        }
    }
}
