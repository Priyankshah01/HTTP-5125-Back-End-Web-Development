using Microsoft.AspNetCore.Mvc;

namespace Priyank_WebAPI.Controllers
{
    [ApiController]
    [Route("api/q7")]
    public class Q7controller : ControllerBase
    {
        /// <summary>
        /// Returns the current date adjusted by the specified number of days.
        /// </summary>
        /// <param name="days">The number of days to adjust the date by.</param>
        /// <returns>The adjusted date as a string.</returns>
        /// <example>GET: /api/q7/timemachine?days=5</example>
        [HttpGet("timemachine")]
        public string GetTimeMachine(int days)
        {
            var adjustedDate = DateTime.Today.AddDays(days).ToString("yyyy-MM-dd");
            return adjustedDate;
        }
    }
}
