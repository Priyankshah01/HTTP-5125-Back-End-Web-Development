using Microsoft.AspNetCore.Mvc;

namespace Priyank_WebAPI.Controllers
{
    [ApiController]
    [Route("api/q4")]
    public class Q4controller : ControllerBase
    {
        /// <summary>
        /// Returns the start of a knock-knock joke.
        /// </summary>
        /// <returns>A knock-knock joke starter.</returns>
        /// <example>POST: /api/q4/knockknock</example>
        [HttpPost("knockknock")]
        public string PostKnockKnock()
        {
            return "Who’s there?";
        }
    }
}
