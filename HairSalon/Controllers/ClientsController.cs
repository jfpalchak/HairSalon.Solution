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

    public ActionResult Create(int? defaultStylistId)
    {
      List<Stylist> stylists = _db.Stylists.ToList();
      // if adding a Client from a Stylist's page, set the default selection to that Stylist
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