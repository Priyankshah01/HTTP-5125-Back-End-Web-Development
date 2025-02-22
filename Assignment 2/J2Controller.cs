using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class J2Controller : ControllerBase
{
    Dictionary<string, int> pepperSHU = new Dictionary<string, int>
    {
        { "Poblano", 1500 },
        { "Mirasol", 6000 },
        { "Serrano", 15500 },
        { "Cayenne", 40000 },
        { "Thai", 75000 },
        { "Habanero", 125000 }
    };

    /// <summary>
    /// Calculates the total spiciness of a chili dish.
    /// </summary>
    /// <param name="ingredients">A comma-separated list of pepper names.</param>
    /// <returns>Total Scoville Heat Units (SHU).</returns>

    [HttpGet("ChiliPeppers")]
    public int CalculateSpiciness(string ingredients)
    {
        var peppers = ingredients.Split(',');
        int totalSHU = 0;

        // Loop through each pepper in the list
        foreach (string pepper in peppers)
        {
            if (pepperSHU.ContainsKey(pepper))
            {
                totalSHU += pepperSHU[pepper];
            }
        }

        return totalSHU;
    }
}
