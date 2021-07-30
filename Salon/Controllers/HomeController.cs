using Microsoft.AspNetCore.Mvc;

namespace Salon.Controllers
{
  [Route("")]
  public class HomeController : Controller
  {
    [HttpGet]
    public ActionResult Index ()
    {
      return View();
    }
  }
}