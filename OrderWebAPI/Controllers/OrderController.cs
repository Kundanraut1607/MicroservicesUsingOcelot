using Microsoft.AspNetCore.Mvc;

namespace OrderWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly static string[] orderName = { "fan", "bulb", "ceiling lights", "iron" };

        [HttpGet]
        [Route("GetOrderName")]
        public ActionResult<string[]> GetOrderName()
        {
            return orderName;
        }
    }
}
