using Microsoft.AspNetCore.Mvc;

namespace Priyank_WebAPI.Controllers
{
    [ApiController]
    [Route("api/q6")]
    public class Q6controller : ControllerBase
    {
        /// <summary>
        /// Returns the area of a regular hexagon with side length double the input.
        /// </summary>
        /// <param name="side">The side length of the hexagon.</param>
        /// <returns>The area of the hexagon.</returns>
        /// <example>GET: /api/q6/hexagon?side=1.5</example>
        [HttpGet("hexagon")]
        public double GetHexagonArea(double side)
        {
            var area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return area;
        }
    }

}