using System;
using System.Collections.Generic;
using System.Text;

namespace Leovolpatto.Eccosys.Proxy.RequestParameters
{
    public abstract class RequestParameter
    {
        protected Dictionary<string, string> _parameters;

        public RequestParameter()
        {
            this._parameters = new Dictionary<string, string>();            
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            int counter = 0;
            foreach (KeyValuePair<string, string> entry in this._parameters)
            {
                if (counter++ > 0)
                    builder.Append("&");
                builder.Append(entry.Key);
                builder.Append("=");
                builder.Append(entry.Value);
            }

            return builder.ToString();
        }
    }
}
