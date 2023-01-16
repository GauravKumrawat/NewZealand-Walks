using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models.Domains;

namespace WebApplication1.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;

        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }
        public Task<Region> AddAsync(Region region)
        {
            /*region.Id = Guid.NewGuid();
            await nZWalksDbContext.Regions.AddAsync(region);
            await nZWalksDbContext.SaveChangesAsync();
            return region;*/
            throw new NotImplementedException();
        }

        public Task<Region> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Region> GetAll()
        {
            return nZWalksDbContext.Regions.ToList();
        }

        public Region Get(Guid id)
        {
            return nZWalksDbContext.Regions.FirstOrDefault(x => x.Id == id);
        }

        public Task<Region> UpdateAsync(Guid id, Region region)
        {
            throw new NotImplementedException();
        }
    }
}
