using Spender.ViewModel;

namespace Spender.Client;

public class SpenderIncomeClient : BaseClient
{
    readonly string routeUri = "Currency";
    public SpenderIncomeClient(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<IncomeViewModel> GetAsync(Guid id)
    {
        return await GetAsync<IncomeViewModel>($"{routeUri}/{id}");
    }
    
    public async Task<IncomeViewModel> PostAsync(IncomeViewModel incomeInfo)
    {
        return await PostAsync<IncomeViewModel, IncomeViewModel>($"{routeUri}", incomeInfo);
    }

    public async Task DeleteAsync(Guid id)
    {
        await DeleteAsync($"{routeUri}/{id}");
    }

}