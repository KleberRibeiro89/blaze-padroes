using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blaze.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BController : ControllerBase
    {
		
		const string url = "https://blaze1.space/api/roulette_games/history?startDate=2024-02-28T23:28:30.897Z&endDate=2024-03-29T23:28:30.897Z&page=2";
        public BController()
        {
               
        }

        [HttpGet]
        public IActionResult Sincronizar()
        {

        }
    }
}
