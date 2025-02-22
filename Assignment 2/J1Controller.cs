using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class J1Controller : ControllerBase
{
    /// <summary>
    /// Calculates the final score for the Deliv-e-droid game.
    /// </summary>
    /// <param name="collisions">The number of collisions with obstacles.</param>
    /// <param name="deliveries">The number of packages delivered.</param>
    /// <returns>The final game score.</returns>

    [HttpPost("Delivedroid")]
    public int CalculateScore(int collisions, int deliveries)
    {
        int score = (deliveries * 50) - (collisions * 10);
        if (deliveries > collisions)
        {
            score =+ 500;
        }
        return score;
    }
}