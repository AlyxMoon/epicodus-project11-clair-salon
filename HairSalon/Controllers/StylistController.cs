using System.Collections.Generic;
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
      List<Stylist> stylists = _db.Stylists.ToList();
      return View(stylists);
    }

    [HttpPost]
    public ActionResult Create (Stylist item)
    {
      _db.Stylists.Add(item);
      _db.SaveChanges();

      return RedirectToAction("Index");
    }

    [HttpGet("{stylistId}")]
    public ActionResult Details (int stylistId)
    {
      Stylist item = _db.Stylists.FirstOrDefault(item => item.Id == stylistId);
      return View(item);
    }

    [HttpGet("{stylistId}/delete")]
    public ActionResult Delete (int stylistId)
    {
      Stylist item = _db.Stylists.FirstOrDefault(item => item.Id == stylistId);

      item.Clients.ToList().ForEach(client => {
        _db.Clients.Remove(client);
      });

      _db.Stylists.Remove(item);
      _db.SaveChanges();

      return RedirectToAction("Index");
    }
  }
}