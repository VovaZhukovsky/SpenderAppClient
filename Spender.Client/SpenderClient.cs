using Spender.Client.Interfaces;

namespace Spender.Client;

public class SpenderClient(HttpClient httpClient) : ISpenderClient
{
    public ISpenderClientClient SpenderClientClient { get; } = new SpenderClientClient(httpClient);
    public ISpenderCategoryClient SpenderCategoryClient { get; } = new SpenderCategoryClient(httpClient);
    public ISpenderCurrencyClient SpenderCurrencyClient { get; } = new SpenderCurrencyClient(httpClient);
    public ISpenderExpenseClient SpenderExpenseClient { get; } = new SpenderExpenseClient(httpClient);
    public ISpenderIncomeClient SpenderIncomeClient { get; } = new SpenderIncomeClient(httpClient);
}