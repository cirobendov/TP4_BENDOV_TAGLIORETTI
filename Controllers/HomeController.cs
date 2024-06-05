using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

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
    public IActionResult SelectPaquete(List<string> destinos, List<string> hoteles, List<string> excursiones)
    {
        ViewBag.destinos = destinos;
        ViewBag.hoteles = hoteles;
        ViewBag.excursiones = excursiones;  
        return View();
    }
    //IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion)
    //{

    //}



}
