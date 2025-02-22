using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class J3Controller : ControllerBase
{
    /// <summary>
    /// Determines the bronze level score and how many participants achieved it.
    /// </summary>
    /// <param name="n">Number of participants.</param>
    /// <param name="scores">Array of participant scores.</param>
    /// <returns>The third highest score and its count.</returns>

    [HttpPost("BronzeCount")]
    public IActionResult FindBronzeCount([FromForm] int n, [FromForm] int[] scores)
    {
        // Step 1: Sort scores in descending order and remove duplicates
        var uniqueScores = scores.Distinct().OrderByDescending(x => x).ToList();

        // Step 2: Find the third highest score (bronze)
        int bronzeScore = uniqueScores[2]; // Since at least 3 distinct scores are guaranteed

        // Step 3: Count how many participants achieved this score
        int bronzeCount = scores.Count(score => score == bronzeScore);

        return Ok(new { bronzeScore, count = bronzeCount });
    }
}
