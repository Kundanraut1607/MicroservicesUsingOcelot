using Microsoft.AspNetCore.Mvc;

namespace ProductWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly static string[] productName = { "fan", "bulb", "ceiling lights", "iron" };

        [HttpGet]
        [Route("GetProductName")]
        public ActionResult<string[]> GetProductName()
        {
            return productName;
        }
    }
}
