using App2Blazor.Shared;
using Microsoft.AspNetCore.Mvc;

namespace App2Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        public static List<Comic> comics = new List<Comic> {


            new Comic {Id =1, Name= "Marvel"},
            new Comic {Id=2 , Name= "DC"},

        };

        public static List<SuperHero> superHeroes = new List<SuperHero> {


            new SuperHero {
                Id =1,
                FirstName = "Med",
                LastName = "Katakuri",
                HeroName = "Spiderman",
                Comic = comics[0]
            },

            new SuperHero {
                Id =2,
                FirstName = "Sekana",
                LastName = "Doumb",
                HeroName = "Batman",
                Comic = comics[1]
            },


        };

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
            return Ok(GetSuperHeroes);
        }
        [HttpGet]
        public async Task<ActionResult<SuperHero>> GetSigleHero(int id)
        {
            var hero = superHeroes.FirstOrDefault(h => h.Id == id);
            if(hero == null)
            {
                return NotFound("Sorry, no here. :");
            }
            return Ok(hero);
        }
    }
}
