using Spender.ViewModel;

namespace Spender.Client.Interfaces;

public interface ISpenderCategoryClient
{
    Task<CategoryViewModel> GetAsync(Guid id);
    Task<List<CategoryViewModel>> GetByClientAsync(Guid clientId);
    Task<CategoryViewModel> PostAsync(CategoryViewModel categoryInfo);
    Task DeleteAsync(Guid id);
}