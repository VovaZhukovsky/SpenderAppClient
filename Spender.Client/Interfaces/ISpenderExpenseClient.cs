using Spender.ViewModel;

namespace Spender.Client.Interfaces;

public interface ISpenderExpenseClient
{
    Task<ExpenseViewModel> GetAsync(Guid id);
    Task<List<ExpenseViewModel>> GetByClientAsync(Guid clientId);
    Task<ExpenseViewModel> PostAsync(ExpenseViewModel expenseInfo);
    Task DeleteAsync(Guid id);
}