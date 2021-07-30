using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  [Route("/")]
  public class HomeController : Controller
  {
    [HttpGet]
    public ActionResult Index ()
    {
      return View();
    }
  }
}