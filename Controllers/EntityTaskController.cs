using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ScarletAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntityTaskController : ControllerBase
    {
        public EntityTaskController()
        {

        }

        [HttpGet]
        public IEnumerable<EntityTask> Get()
        {
            return new List<EntityTask>()
            {
                new EntityTask
                {
                    Title = "Despertar",
                    Description = "Comece bem o seu dia",
                    Items = new string[] {"Levantar 05:50" , "Beba água", "Tome um banho gelado", "Refeição um" }
                }
            };
        }
    }
}
