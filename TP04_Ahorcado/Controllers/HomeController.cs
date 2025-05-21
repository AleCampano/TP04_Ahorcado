using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Ahorcado.Models;

namespace TP04_Ahorcado.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
     Partida.inicializarPartida();
     ViewBag.palabra = Partida.palabra;
    return View();
    }

    public IActionResult arriesgarPalabra(bool adivinaste)
    {
        if (adivinaste == true)
        {
            return View("Ganaste");
        }
        else 
        {
            return View("Perdiste");
        }

    }

    public IActionResult remplazarLetra(char l, string palabra) 
    {
      List <char> listaLetras = new List<char>();
    foreach(char letra in palabra)
  {
    if(letra==l)
    {
      listaLetras.Add(l);
    }
    else{
      listaLetras.Add('_');
    }
  }
  ViewBag.listaLetras = listaLetras;
  ViewBag.palabra =palabra;
  return View ("Jugar");

    }



    public IActionResult Jugar()
    {
        
        return View();
    } 
}
