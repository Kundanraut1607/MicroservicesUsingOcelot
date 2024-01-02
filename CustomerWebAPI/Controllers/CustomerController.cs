using Microsoft.AspNetCore.Mvc;

namespace CustomerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly static string[] custName = { "Kishan", "kundan", "Ahishs", "Mayank" };

        [HttpGet]
        [Route("GetCustomerName")]
        public ActionResult<string[]> GetCustomerName()
        {
            return custName;
        }
    }
}
