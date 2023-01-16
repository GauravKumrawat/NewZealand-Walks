using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Domains;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionController : Controller
    {
        private readonly IRegionRepository regionRepository;
        public RegionController(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }
        [HttpGet]
        public ActionResult GetAllRegions()
        {
            var regions=regionRepository.GetAll();
            return Ok(regions);
        }

        [HttpPost]
        public async Task<Region> AddRegion(Region region)
        {
            return await regionRepository.AddAsync(region);
        }
        [HttpGet]
        [Route("{id:Guid}")]
        public ActionResult GetRegion(Guid Id)
        {
            return Ok(regionRepository.Get(Id));
        }
    }
}
