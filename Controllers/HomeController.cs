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
    public IActionResult GuardarPaquete (int Destino, int Hotel, int Aereo, int Excursion)
    {
        if(Destino < 0 || Destino >= ORTWorld.ListaDestinos.Count || 
        Hotel < 0 || Hotel >= ORTWorld.ListaHoteles.Count || 
        Aereo < 0 || Aereo >= ORTWorld.ListaAereos.Count || 
        Excursion < 0 || Excursion >= ORTWorld.ListaExcursiones.Count)
        {
            ViewBag.Error = ("Todos los parametros deben ser completados");
            
            ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
            ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
            ViewBag.ListaAereos = ORTWorld.ListaAereos;
            ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;

            return View ("SelectPaquete");
        }

        Paquete paqueteNuevo = new Paquete (hotel : ORTWorld.ListaHoteles[Hotel], aereo : ORTWorld.ListaAereos[Aereo], excursion : ORTWorld.ListaExcursiones[Excursion]);

        string destinoSeleccionado = ORTWorld.ListaDestinos[Destino];
        if(ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino-1], paqueteNuevo))
        {
            return RedirectToAction("Index");
        }
        else
        {
            ViewBag.Error = ("El destino ya ha sido seleccionado");
            
            ViewBag.ListaDestinos = ORTWorld.ListaDestinos;
            ViewBag.ListaHoteles = ORTWorld.ListaHoteles;
            ViewBag.ListaAereos = ORTWorld.ListaAereos;
            ViewBag.ListaExcursiones = ORTWorld.ListaExcursiones;

            return View ("SelectPaquete");
        }
    }



}
