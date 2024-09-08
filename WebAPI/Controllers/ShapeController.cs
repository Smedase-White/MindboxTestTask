using CoreLib.Shapes;

using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ShapeController : Controller
{
    [HttpGet]
    [Route("[action]")]
    public IActionResult CalcArea(string shape, [FromQuery] double[] values)
    {
        AreaManager.CalcAreaFunc? calc = AreaManager.AreaCalcs!.GetValueOrDefault(shape, null);
        if (calc == null)
            return Content($"Shape doesn't exist.");

        try
        {
            return Content($"Shape area: {calc(values)}");
        }
        catch (Exception e)
        {
            return Content($"{e.Message}");
        }
    }
}
