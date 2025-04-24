using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP3_Arias.Models;

namespace TP3_Arias.Controllers;

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
}
