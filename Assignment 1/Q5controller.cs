using Microsoft.AspNetCore.Mvc;

namespace Priyank_WebAPI.Controllers
{
    [ApiController]
    [Route("api/q5")]
    public class Q5controller : ControllerBase
    {
        /// <summary>
        /// Returns an acknowledgment of the secret integer.
        /// </summary>
        /// <param name="secret">The secret integer.</param>
        /// <returns>An acknowledgment message.</returns>
        /// <example>POST: /api/q5/secret</example>
        [HttpPost("secret")]
        public string PostSecret(int secret)
        {
            return $"Shh.. the secret is {secret}";
        }
    }
}
