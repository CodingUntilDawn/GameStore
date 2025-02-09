using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockGameStore.Models;

namespace MockGameStore.Controllers
{
    [Route("api/dataUpload")]
    [ApiController]
    public class GameUploadController : ControllerBase
    {

        [HttpPost("addGame")]
        public void AddGame(Game Game)
        {
        
        }

    }
}
