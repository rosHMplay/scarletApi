using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ScarletAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskEntityController : ControllerBase
    {
        public TaskEntityController()
        {

        }

        [HttpGet]
        public IEnumerable<TaskEntity> Get()
        {
            return new List<TaskEntity>()
            {
                new TaskEntity
                {
                    Title = "Despertar",
                    Message = "Comece bem o seu dia",
                    Items = new string[] {"Levantar 05:50" , "Beba água", "Tome um banho gelado", "Refeição um" }
                }
                ,
                new TaskEntity
                {
                    Title = "Hora da maromba",
                    Message = "Barriga grande não te sustenta",
                    Items = new string[] {"Supino 4 x 8" , "Remada 4 x 12", "Beba água", "15' cardio" }

                },
                new TaskEntity
                {
                    Title = "Arrume a casa",
                    Message = "Se liberte da bagunça!!",
                    Items = new string[] {"Varrer a sala" , "Lavar a louça"}
                }
            };
        }
    }
}
