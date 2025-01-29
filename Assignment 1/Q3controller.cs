using Microsoft.AspNetCore.Mvc;

namespace Priyank_WebAPI.Controllers
{

    [ApiController]
    [Route("api/q3")]
    public class Q3controller : ControllerBase
    {
        /// <summary>
        /// Returns the cube of the given integer base.
        /// </summary>
        /// <param name="base">The integer base value.</param>
        /// <returns>The cube of the integer base.</returns>
        /// <example>GET: /api/q3/cube/4</example>
        [HttpGet("cube/base")]
        public int GetCube(int @base)
        {
            return (int)Math.Pow(@base, 3);
        }
    }
}