using Supermarket.API.Domain.Models;

namespace Supermarket.API.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
