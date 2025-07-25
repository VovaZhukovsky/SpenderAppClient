using Spender.Client.Interfaces;
using Spender.ViewModel;

namespace Spender.Client;

public class SpenderIncomeClient : BaseClient, ISpenderIncomeClient
{
    readonly string routeUri = "Income";
    public SpenderIncomeClient(HttpClient httpClient) : base(httpClient) { }

    public async Task<IncomeViewModel> GetAsync(Guid id)
    {
        return await GetAsync<IncomeViewModel>($"{routeUri}/{id}");
    }
    public async Task<List<IncomeViewModel>> GetByClientAsync(Guid clientId)
    {
        return await GetAsync<List<IncomeViewModel>>($"{routeUri}/{clientId}/client");
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