﻿using Microsoft.AspNetCore.Mvc;
using MusicCast.Responses;

namespace Swimbait.Server.Controllers
{


    [Route("MusicCastNetwork")]
    public class MusicCastNetworkController : Controller
    {
        public MusicCastNetworkController()
        {

        }
        
        [HttpGet("InitialJoinComplete")]
        public IActionResult InitialJoinComplete()
        {
            var response = new BasicResponse();
            return new ObjectResult(response);
        }

    }

}
