using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceRestClient
{
    public class Portfolio
    {
        private string _portfolioMainCurrency;
        public Dictionary<string, decimal> CurrencyBalances { get; }
        public CurrencyPricesRepository CurrencyPricesRepo { get; }

        public Portfolio()
        {
            this.CurrencyPricesRepo = new CurrencyPricesRepository();
            this.CurrencyBalances = new Dictionary<string, decimal>();
        }

        public Portfolio(Dictionary<string, decimal> currencyBalances, string mainCurrency)
            : this()
        {
            this.CurrencyBalances = currencyBalances;
            this._portfolioMainCurrency = mainCurrency;
        }

        public decimal BtcBalance
        {
            get
            {
                decimal btcBalance = 0;
                foreach (var currencyBalance in this.CurrencyBalances)
                {
                    string currencyName = currencyBalance.Key;
                    var currencyPrice = GetCurrencyPrice(currencyName);

                    btcBalance += currencyBalance.Value * currencyPrice;
                }
                return btcBalance;
            }
        }

        public decimal GetBalanceInCurrency(string currency)
        {
            var currencyPriceInBtc = GetCurrencyPrice(currency);
            return this.BtcBalance / currencyPriceInBtc;
        }

        private decimal GetCurrencyPrice(string cur)
        {
            if (cur == _portfolioMainCurrency)
                return 1;

            var exchangeRate = this.CurrencyPricesRepo.Currencies.FirstOrDefault(p => p.Key == $"{cur}{_portfolioMainCurrency}");
            if (exchangeRate.Key != null)
                return exchangeRate.Value;

            var exchangeRateReverse = this.CurrencyPricesRepo.Currencies.FirstOrDefault(p => p.Key == $"{_portfolioMainCurrency}{cur}");
            if (exchangeRateReverse.Key != null)
            {
                return 1 / exchangeRateReverse.Value;
            }
            throw new ArgumentException("Invalid currency");
        }
    }
}
