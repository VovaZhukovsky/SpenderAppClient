using Spender.Client.Interfaces;
using Spender.ViewModel;

namespace Spender.Client;

public class SpenderCategoryClient : BaseClient, ISpenderCategoryClient
{
    readonly string routeUri = "Category";
    public SpenderCategoryClient(HttpClient httpClient) : base(httpClient) { }

    public async Task<CategoryViewModel> GetAsync(Guid id)
    {
        return await GetAsync<CategoryViewModel>($"{routeUri}/{id}");
    }
    
    public async Task<List<CategoryViewModel>> GetByClientAsync(Guid clientId)
    {
        return await GetAsync<List<CategoryViewModel>>($"{routeUri}/{clientId}/client");
    }
    
    public async Task<CategoryViewModel> PostAsync(CategoryViewModel categotyInfo)
    {
        return await PostAsync<CategoryViewModel, CategoryViewModel>($"{routeUri}", categotyInfo);
    }

    public async Task DeleteAsync(Guid id)
    {
        await DeleteAsync($"{routeUri}/{id}");
    }
}