namespace Spender.Client.Interfaces;

public interface ISpenderClient
{
    ISpenderClientClient SpenderClientClient { get; }
    ISpenderCategoryClient SpenderCategoryClient { get; }
    ISpenderCurrencyClient SpenderCurrencyClient { get; }
    ISpenderExpenseClient SpenderExpenseClient { get; }
    ISpenderIncomeClient SpenderIncomeClient { get; }
}