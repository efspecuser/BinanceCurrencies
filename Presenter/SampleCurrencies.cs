using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceView
{
    internal static class SampleCurrencies
    {
        internal static List<string> Get()
        {
            return new List<string> {"USDT", "BTC", "XRP", "XMR", "DASH" };
        }
    }
}
