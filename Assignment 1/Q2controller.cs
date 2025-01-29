using Microsoft.AspNetCore.Mvc;

namespace Priyank_WebAPI.Controllers
{

    [ApiController]
    [Route("api/q2")]
    public class Q2controller : ControllerBase
    {
        /// <summary>
        /// Returns a greeting to the specified name.
        /// </summary>
        /// <param name="name">The name to greet.</param>
        /// <returns>A greeting string.</returns>
        /// <example>GET: /api/q2/greeting?name=Gary</example>
        [HttpGet("greeting")]
        public string GetGreeting([FromQuery] string name)
        {
            return $"Hi {name}!";
        }
    }
}