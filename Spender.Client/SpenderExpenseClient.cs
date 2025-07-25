using Spender.Client.Interfaces;
using Spender.ViewModel;

namespace Spender.Client;

public class SpenderExpenseClient : BaseClient, ISpenderExpenseClient
{
    readonly string routeUri = "Expense";
    public SpenderExpenseClient(HttpClient httpClient) : base(httpClient){ }

    public async Task<ExpenseViewModel> GetAsync(Guid id)
    {
        return await GetAsync<ExpenseViewModel>($"{routeUri}/{id}");
    }

    public async Task<List<ExpenseViewModel>> GetByClientAsync(Guid clientId)
    {
        return await GetAsync<List<ExpenseViewModel>>($"{routeUri}/{clientId}/client");
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