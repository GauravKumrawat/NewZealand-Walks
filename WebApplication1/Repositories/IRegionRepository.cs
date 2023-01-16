using WebApplication1.Models.Domains;

namespace WebApplication1.Repositories
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();

        Region Get(Guid id);

        Task<Region> AddAsync(Region region);

        Task<Region> DeleteAsync(Guid id);

        Task<Region> UpdateAsync(Guid id, Region region);
    }
}