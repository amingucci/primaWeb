using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aurora.mingucci._5I.primaWeb.Models;

namespace aurora.mingucci._5I.primaWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Book()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Book(Prenotazione p)
    {
        return View(p);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}