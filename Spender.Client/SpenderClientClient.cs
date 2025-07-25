using Spender.Client.Interfaces;
using Spender.ViewModel;

namespace Spender.Client;

public class SpenderClientClient : BaseClient, ISpenderClientClient
{
    readonly string routeUri = "Client";
    public SpenderClientClient(HttpClient httpClient) : base(httpClient) { }

    public async Task<ClientViewModel> GetByMailAsync(string mail)
    {
        return await GetAsync<ClientViewModel>($"{routeUri}/{mail}/mail");
    }

    public async Task<ClientViewModel> GetAsync(Guid id)
    {
        return await GetAsync<ClientViewModel>($"{routeUri}/{id}");
    }
    
    public async Task<ClientViewModel> PostAsync(ClientViewModel clientInfo)
    {
        return await PostAsync<ClientViewModel, ClientViewModel>($"{routeUri}", clientInfo);
    }

    public async Task DeleteAsync(Guid id)
    {
        await DeleteAsync($"{routeUri}/{id}");
    }
}