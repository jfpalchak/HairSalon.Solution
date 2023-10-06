using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients
                              .Include(client => client.Stylist)
                              .ToList();
      return View(model);
    }

    // ! Does this need to be in Stylist controller?
    public ActionResult Create(int? defaultStylistId)
    {
      List<Stylist> stylists = _db.Stylists.ToList();
      ViewBag.StylistId = new SelectList(stylists, "StylistId", "Name", defaultStylistId);
      ViewBag.NoStylistsBool = (stylists.Count == 0) ? true : false;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Client thisClient = _db.Clients
                              .Include(client => client.Stylist)
                              .FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }
  }
}