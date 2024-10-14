using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI_DotNet.Models;

namespace SuperHeroAPI_DotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Batman",
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Place = "Gotham City"
                }
            };
           return Ok(heroes);
        }
    }
}
