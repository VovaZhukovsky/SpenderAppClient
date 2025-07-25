using Spender.ViewModel;

namespace Spender.Client.Interfaces;

public interface ISpenderCurrencyClient
{
    Task<CurrencyViewModel> GetAsync(Guid id);
    Task<CurrencyViewModel> PostAsync(CurrencyViewModel currencyInfo);
    Task DeleteAsync(Guid id);
}