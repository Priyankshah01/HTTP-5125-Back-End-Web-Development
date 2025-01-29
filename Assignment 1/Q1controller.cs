using Microsoft.AspNetCore.Mvc;

namespace Priyank_WebAPI.Controllers
{

    [ApiController]
    [Route("api/q1")]
    public class Q1controller : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message.
        /// </summary>
        /// <returns>A welcome message string.</returns>
        /// <example>GET: /api/q1/welcome</example>
        [HttpGet("welcome")]
        public string GetWelcome()
        {
            return "Welcome to 5125!";
        }
    }
}