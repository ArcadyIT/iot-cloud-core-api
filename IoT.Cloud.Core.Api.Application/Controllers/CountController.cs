using Microsoft.AspNetCore.Mvc;

namespace IoT.Cloud.Core.Api.Application.Controllers
{
    [Route("api/[controller]")]
    public class CountController : Controller
    {
        private static int _count = 1;

        [HttpGet("[action]")]
        public JsonResult Add()
        {
            return Json(new
            {
                message = "Hello World!",
                count = _count++
            });
        }

        [HttpGet("[action]/{number:int}")]
        public JsonResult Add(int number)
        {
            return Json(new
            {
                count = (number + 1)
            });
        }
    }
}
