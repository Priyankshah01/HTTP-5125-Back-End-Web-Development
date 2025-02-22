using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class J2DecompressController : ControllerBase
{

    /// <summary>
    /// Decodes the compressed message by repeating the given character N times.
    /// </summary>
    /// <param name="l">The number of lines in the message.</param>
    /// <param name="data">An array of strings, each containing a number and a character.</param>
    /// <returns>An array of decoded lines.</returns>

    [HttpPost("Decompress")]
    public IActionResult DecompressMessage([FromForm] int l, [FromForm] string[] data)
    {
        if (l <= 0 || data.Length != l)
            return BadRequest("Invalid input. Ensure L matches the number of data lines.");

        string[] result = new string[l];

        for (int i = 0; i < l; i++)
        {
            string[] parts = data[i].Split(' ');
            if (parts.Length != 2 || !int.TryParse(parts[0], out int repeat) || repeat <= 0 || repeat >= 80)
            {
                return BadRequest("Invalid data format. Each line must contain a number and a single character.");
            }

            char symbol = parts[1][0]; // Extract the character
            result[i] = new string(symbol, repeat); // Repeat the character N times
        }

        return Ok(result);
    }
}