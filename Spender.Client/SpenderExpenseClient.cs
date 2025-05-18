using Spender.ViewModel;

namespace Spender.Client;

public class SpenderExpenseClient : BaseClient
{
    readonly string routeUri = "Currency";
    public SpenderExpenseClient(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<ExpenseViewModel> GetAsync(Guid id)
    {
        return await GetAsync<ExpenseViewModel>($"{routeUri}/{id}");
    }
    
    public async Task<ExpenseViewModel> PostAsync(ExpenseViewModel expenseInfo)
    {
        return await PostAsync<ExpenseViewModel, ExpenseViewModel>($"{routeUri}", expenseInfo);
    }

    public async Task DeleteAsync(Guid id)
    {
        await DeleteAsync($"{routeUri}/{id}");
    }

}