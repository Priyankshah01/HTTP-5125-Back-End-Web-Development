using Microsoft.AspNetCore.Mvc;

namespace Priyank_WebAPI.Controllers
{
    [ApiController]
    [Route("api/q8")]
    public class Q8controller : ControllerBase
    {
        /// <summary>
        /// Returns a checkout summary for an order of SquashFellows plushies.
        /// </summary>
        /// <param name="small">The number of small plushies ordered.</param>
        /// <param name="large">The number of large plushies ordered.</param>
        /// <returns>A summary of the checkout.</returns>
        /// <example>POST: /api/q8/squashfellows</example>
        [HttpPost("squashfellows")]
        public string PostSquashFellows(double small, double large)
        {
            const double smallPrice = 25.50;
            const double largePrice = 40.50;
            const double taxRate = 0.13;

            double subtotal = (small * smallPrice) + (large * largePrice);
            double tax = Math.Round(subtotal * taxRate, 2);
            double total = subtotal + tax;

            string summary = $"{small} Small @ ${smallPrice} = ${small * smallPrice}; {large} Large @ ${largePrice} = ${large * largePrice}; " +
                             $"Subtotal = ${subtotal}; Tax = ${tax} HST; Total = ${total}";

            return summary;
        }
    }
}

