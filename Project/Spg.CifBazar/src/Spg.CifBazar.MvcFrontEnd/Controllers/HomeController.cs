using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Spg.CifBazar.DomainModel.Model;
using Spg.CifBazar.Infrastructure;
using Spg.CifBazar.MvcFrontEnd.Models;

namespace Spg.CifBazar.MvcFrontEnd.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CifBazarContext _db;

    public HomeController(ILogger<HomeController> logger, CifBazarContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        _db.Database.EnsureCreated();
        new DbSeedService(_db).Seed();

        List<Shop> shops = _db.Shops.ToList();

        return View(shops);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
