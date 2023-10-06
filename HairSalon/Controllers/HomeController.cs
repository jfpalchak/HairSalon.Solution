using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    // private readonly HairSalonContext _db;

    // public HomeController(HairSalonContext db)
    // {
    //   _db = db;
    // }

    public ActionResult Index()
    {
      return View();
    }
  }
}