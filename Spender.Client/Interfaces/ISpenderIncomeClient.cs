using Spender.ViewModel;

namespace Spender.Client.Interfaces;

public interface ISpenderIncomeClient
{
    Task<IncomeViewModel> GetAsync(Guid id);
    Task<List<IncomeViewModel>> GetByClientAsync(Guid clientId);
    Task<IncomeViewModel> PostAsync(IncomeViewModel incomeInfo);
    Task DeleteAsync(Guid id);
}