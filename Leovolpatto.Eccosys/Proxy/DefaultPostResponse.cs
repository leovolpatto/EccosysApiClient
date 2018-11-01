using System;
using System.Collections.Generic;
using System.Text;

namespace Leovolpatto.Eccosys.Proxy
{
    public class DefaultPostResponse
    {
        public Result result { get; set; }
        public bool hasError { get { return this.result.error.Count > 0; } set { } }
    }

    public class Result
    {
        public List<SuccessDetails> success { get; set; }
        public List<ErrorDetails> error { get; set; }
    }

    public class SuccessDetails
    {
        public string id { get; set; }
        public string codigo { get; set; }
        public string msg { get; set; }
    }
    public class ErrorDetails
    {
        public string id { get; set; }
        public string codigo { get; set; }
        public string erro { get; set; }
    }
}