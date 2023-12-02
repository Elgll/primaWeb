using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using elena.galli._5i.primaWeb.Models;

namespace elena.galli._5i.primaWeb.Controllers;

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
    public IActionResult Prenota()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Prenota(Prenotazione p)
    {
        ViewData["Nome"] = Prenota.Nome;
        ViewData["Email"] = Prenota.Email;
        
        return view("Prenota", p);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
