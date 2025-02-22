using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class J1CupcakeController : ControllerBase
{
    /// <summary>
    /// Calculates the number of leftover cupcakes after distributing to 28 students.
    /// </summary>
    /// <param name="regularBoxes">The number of regular boxes (each contains 8 cupcakes).</param>
    /// <param name="smallBoxes">The number of small boxes (each contains 3 cupcakes).</param>
    /// <returns>The number of leftover cupcakes.</returns>

    [HttpGet("Cupcakes")]
    public int CalculateLeftoverCupcakes( int regularBoxes, int smallBoxes)
    {
        // Calculate total cupcakes
        int totalCupcakes = (regularBoxes * 8) + (smallBoxes * 3);

        // Calculate leftover cupcakes after distributing to 28 students
        int leftover = totalCupcakes - 28;

        return leftover;
    }
}
