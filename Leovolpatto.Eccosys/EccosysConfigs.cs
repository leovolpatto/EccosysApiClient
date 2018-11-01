using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Middleware.Integration.Data;

namespace Leovolpatto.Eccosys
{
    public static class EccosysConfigs
    {

        public static string GetApiKey()
        {
            using (var context = new IntegrationDataContext())
            {
                return context.EccosysSettings.First().ApiKey;
            }
        }

        public static string GetSecret()
        {
            using (var context = new IntegrationDataContext())
            {
                return context.EccosysSettings.First().ApiSecret;
            }
        }

        public static string GetIdOperacaoFiscal()
        {
            using (var context = new IntegrationDataContext())
            {
                return context.EccosysSettings.First().IdOperacaoFiscalBeautyGuide;
            }
        }

        public static string GetApiURI()
        {
            using (var context = new IntegrationDataContext())
            {
                return context.EccosysSettings.First().ApiUri;
            }
        }
    }
}
