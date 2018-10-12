using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BinanceRestClient
{
    public class CurrencyPricesRepository
    {
        private readonly HttpClient client = new HttpClient();
        private readonly string _binanceRestApi = @"https://api.binance.com/api/v3/ticker/price";

        public Dictionary<string, decimal> Currencies { get; private set; }

        public CurrencyPricesRepository()
        {
            PullCurrencies();
        }

        private void PullCurrencies()
        {
            var stringTask = this.client.GetStringAsync(this._binanceRestApi);
            var jsonResponse = stringTask.Result;
            this.Currencies = ProcessJson(jsonResponse);
        }

        private Dictionary<string, decimal> ProcessJson(string jsonString)
        {
            var priceArray = JsonConvert.DeserializeObject<CurrencyPrice[]>(jsonString);

            var result = new Dictionary<string, decimal>();
            foreach (var currencyPrice in priceArray)
            {
                result.Add(currencyPrice.symbol, currencyPrice.price);
            }
            return result;
        }

        
    }

    internal class CurrencyPrice
    {
        [JsonProperty("symbol")]
        internal string symbol;
        [JsonProperty("price")]
        internal decimal price;
    }
}
