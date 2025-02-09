using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockGameStore.Models;
using System.Net;

namespace MockGameStore.Controllers
{
    [Route("api/dataUpload")]
    [ApiController]
    public class GameUploadController : ControllerBase
    {

        [HttpPost("addGame")]
        public ActionResult AddGame([FromBody] Game Game)
        {
            System.Diagnostics.Debug.WriteLine("Hit main entry point");
            System.Diagnostics.Debug.WriteLine(Game.Title);

            return StatusCode(200);
        }

        [HttpPost("test")]
        public void TestAnything([FromQuery]int dummy)
        {
            System.Diagnostics.Debug.WriteLine("Hit test entry point");
            System.Diagnostics.Debug.WriteLine(dummy);
        }
    }
}
