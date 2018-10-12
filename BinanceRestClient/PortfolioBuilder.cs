using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceRestClient
{
    public static class PortfolioBuilder
    {
        public static Portfolio GetSamplePortfolio()
        {
            var currencyBalances = new Dictionary<string, decimal>()
            {
                {"BTC", 1},
                {"XRP" , 15000},
                {"XMR" , 50},
                {"DASH" , 30}
            };
            return new Portfolio(currencyBalances, "BTC");
        }
    }
}
