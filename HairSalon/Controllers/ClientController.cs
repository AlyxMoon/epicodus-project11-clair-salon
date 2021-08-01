using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {
    private readonly DatabaseContext _db;

    public ClientController(DatabaseContext db)
    {
      _db = db;
    }

    [HttpGet("/clients")]
    public ActionResult Index ()
    {
      ViewBag.Stylists = new SelectList(_db.Stylists, "Id", "Name");
      
      List<Client> Clients = _db.Clients
        .Include(item => item.Stylist)
        .ToList();

      return View(Clients);
    }

    [HttpGet("stylists/{stylistId}/clients")]
    public ActionResult IndexByStylist (int stylistId)
    {
      ViewBag.Stylists = new SelectList(_db.Stylists, "Id", "Name");

      List<Client> Clients = _db.Clients
        .Where(item => item.Id_Stylist == stylistId)
        .Include(item => item.Stylist)
        .ToList();

      return View("Index", Clients);
    }

    [HttpGet("/clients/new")]
    public ActionResult AddNew ()
    {
      return View(new Client());
    }

    [HttpGet("/stylists/{stylistId}/clients/new")]
    public ActionResult AddNewToStylist (int stylistId)
    {
      ViewBag.Stylists = new SelectList(_db.Stylists, "Id", "Name");
      return View("AddNew", new Client() { Id_Stylist = stylistId });
    }

    [HttpGet("/clients/{clientId}")]
    public ActionResult Details (int clientId)
    {
      Client item = _db.Clients.FirstOrDefault(item => item.Id == clientId);
      return View(item);
    }

    [HttpPost("/clients")]
    public ActionResult Create (Client item)
    {
      _db.Clients.Add(item);
      _db.SaveChanges();

      return RedirectToAction("Index");
    }

    [HttpGet("/clients/{clientId}/delete")]
    public ActionResult Delete (int clientId)
    {
      Client item = _db.Clients.FirstOrDefault(item => item.Id == clientId);
      _db.Clients.Remove(item);
      _db.SaveChanges();

      return RedirectToAction("Index");
    }
  }
}