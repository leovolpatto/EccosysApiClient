using System;
using System.Collections.Generic;
using System.Text;

namespace Leovolpatto.Eccosys.Proxy
{
    public class Request
    {

        public List<RequestParameters.RequestParameter> Parameters { get; set; }

        public Request()
        {
            this.Parameters = new List<RequestParameters.RequestParameter>();
        }

        public string GetParametersString()
        {
            if (this.Parameters.Count == 0)
                return "";
            StringBuilder sb = new StringBuilder();
            sb.Append("?");
            for (int i = 0; i < this.Parameters.Count; i++)
            {
                if (i > 0)
                    sb.Append("&");
                sb.Append(this.Parameters[i].ToString());
            }

            return sb.ToString();
        }

    }
}