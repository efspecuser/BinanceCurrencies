namespace Contracts
{
    public interface IPortfolio
    {
        decimal GetBalanceInCurrency(string currency);
    }
}