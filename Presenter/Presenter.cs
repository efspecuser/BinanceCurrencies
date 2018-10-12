using System.Collections.Generic;
using BinanceRestClient;
using Contracts;

namespace BinanceView
{
    public class Presenter
    {
        public IBinanceViewer Viewer { get; }
        public Portfolio Portfolio { get; set; }

        public Presenter(IBinanceViewer viewer)
        {
            this.Viewer = viewer;
            this.Portfolio = PortfolioBuilder.GetSamplePortfolio();
            DisplayBalanceInDifferentCurrencies();
        }

        private void DisplayBalanceInDifferentCurrencies()
        {
            var sampleCurrencies = SampleCurrencies.Get();
            var currencyBalances = new Dictionary<string, decimal>();
            foreach (var sampleCurrency in sampleCurrencies)
            {
                var balanceInThatCurrency = this.Portfolio.GetBalanceInCurrency(sampleCurrency);
                currencyBalances.Add(sampleCurrency, balanceInThatCurrency);
            }

            this.Viewer.PortfolioBalances = currencyBalances;
        }
    }
}
