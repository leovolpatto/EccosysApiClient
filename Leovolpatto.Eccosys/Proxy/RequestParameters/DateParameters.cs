using System;

namespace Leovolpatto.Eccosys.Proxy.RequestParameters
{
    public class DateParameters : RequestParameter
    {
        private DateParameters(){}

        public DateParameters SetTo(DateTime to)
        {
            this._parameters.Add("$toDate", to.ToString("yyyy-MM-dd"));
            return this;
        }

        public DateParameters SetFrom(DateTime from)
        {
            this._parameters.Add("$fromDate", from.ToString("yyyy-MM-dd"));
            return this;
        }

        public static DateParameters Create()
        {
            return new DateParameters();
        }        
    }
}