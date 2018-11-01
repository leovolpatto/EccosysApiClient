using System;
using Leovolpatto.Eccosys.Proxy.RequestParameters;

namespace Leovolpatto.Eccosys.Proxy.Pedidos.Parameters
{
    public class PaginationAndDateParameter : RequestParameter
    {
        public PaginationAndDateParameter() { }

        public static PaginationAndDateParameter Create()
        {
            return new PaginationAndDateParameter();
        }

        public PaginationAndDateParameter SetCount(int count)
        {
            this._parameters.Add("$count", count.ToString());
            return this;
        }

        public PaginationAndDateParameter SetOffset(int offset)
        {
            this._parameters.Add("$offset", offset.ToString());
            return this;
        }

        public PaginationAndDateParameter SetFromDate(DateTime fromDate)
        {
            this._parameters.Add("$fromDate", fromDate.ToString("yyyy-MM-dd"));
            return this;
        }

        public PaginationAndDateParameter SetToDate(DateTime toDate)
        {
            this._parameters.Add("$toDate", toDate.ToString("yyyy-MM-dd"));
            return this;
        }

    }
}