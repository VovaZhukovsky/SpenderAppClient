using Spender.ViewModel;

namespace Spender.Client.Interfaces;

public interface ISpenderClientClient
{
    Task<ClientViewModel> GetByMailAsync(string mail);
    Task<ClientViewModel> GetAsync(Guid id);
    Task<ClientViewModel> PostAsync(ClientViewModel clientInfo);
    Task DeleteAsync(Guid id);
}