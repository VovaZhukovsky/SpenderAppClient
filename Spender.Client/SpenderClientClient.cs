using Spender.ViewModel;

namespace Spender.Client;

public class SpenderClientClient : BaseClient
{
    readonly string routeUri = "Client";
    public SpenderClientClient(HttpClient httpClient): base(httpClient)
    {

    }
    public async Task<ClientViewModel> GetAsync(string clientId)
    {
        string uri = $"{routeUri}?id={clientId}";

        return await GetAsync<ClientViewModel>(uri);
    }

}