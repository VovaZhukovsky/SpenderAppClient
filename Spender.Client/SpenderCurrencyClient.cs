using Spender.Client.Interfaces;
using Spender.ViewModel;

namespace Spender.Client;

public class SpenderCurrencyClient : BaseClient, ISpenderCurrencyClient
{
    readonly string routeUri = "Currency";
    public SpenderCurrencyClient(HttpClient httpClient) : base(httpClient) { }

    public async Task<CurrencyViewModel> GetAsync(Guid id)
    {
        return await GetAsync<CurrencyViewModel>($"{routeUri}/{id}");
    }
    
    public async Task<CurrencyViewModel> PostAsync(CurrencyViewModel currencyInfo)
    {
        return await PostAsync<CurrencyViewModel, CurrencyViewModel>($"{routeUri}", currencyInfo);
    }

    public async Task DeleteAsync(Guid id)
    {
        await DeleteAsync($"{routeUri}/{id}");
    }
}