using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  [Route("/stylists")]
  public class StylistController : Controller
  {
    private readonly DatabaseContext _db;

    public StylistController (DatabaseContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult Index ()
    {
      return View(_db.Stylists.ToList());
    }

    [HttpPost]
    public ActionResult Create (Stylist item)
    {
      _db.Stylists.Add(item);
      _db.SaveChanges();

      return RedirectToAction("Index");
    }

    [HttpGet("{stylistId}/delete")]
    public ActionResult Delete (int stylistId)
    {
      Stylist item = _db.Stylists.FirstOrDefault(item => item.Id == stylistId);
      _db.Stylists.Remove(item);
      _db.SaveChanges();

      return RedirectToAction("Index");
    }
  }
}