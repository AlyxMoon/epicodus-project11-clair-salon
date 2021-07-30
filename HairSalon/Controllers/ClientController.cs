using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  [Route("/clients")]
  public class RestaurantController : Controller
  {
    private readonly DatabaseContext _db;

    public RestaurantController(DatabaseContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult Index ()
    {
      ViewBag.Stylists = new SelectList(_db.Stylists, "Id", "Name");
      
      List<Client> Clients = _db.Clients
        .Include(item => item.Stylist)
        .ToList();

      return View(Clients);
    }

    [HttpPost]
    public ActionResult Create (Client item)
    {
      _db.Clients.Add(item);
      _db.SaveChanges();

      return RedirectToAction("Index");
    }

    [HttpGet("{clientId}/delete")]
    public ActionResult Delete (int clientId)
    {
      Client item = _db.Clients.FirstOrDefault(item => item.Id == clientId);
      _db.Clients.Remove(item);
      _db.SaveChanges();

      return RedirectToAction("Index");
    }
  }
}