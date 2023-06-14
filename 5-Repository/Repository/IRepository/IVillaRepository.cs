using _5_Repository.Models;

namespace _5_Repository.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {

        Task<Villa> UpdateAsync(Villa entity);

    }
}
