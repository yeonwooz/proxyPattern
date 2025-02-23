using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/data")]
    public class RemoteServiceSkeleton : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<string> GetData(int id)
        {
            return $"Data for ID {id} from server";
        }
    }
}