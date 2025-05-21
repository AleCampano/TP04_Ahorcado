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
    return View();
    }

    public IActionResult Jugar()
        {
            if (Partida.juegoFinalizado == true)
            {
                return View("Fin");
            }
            ViewBag.palabra = Partida.ObtenerPalabra();
            ViewBag.intento = Partida.intentos;
            ViewBag.letras = Partida.letrasIngresadas;

            return View("Jugar");
        }

    [HttpPost]
        public IActionResult Arriesgar(string palabra)
        {
            if (palabra != null && palabra != "")
            {
                string palabraA = "";
                for (int i = 0; i < palabra.Length; i++)
                {
                    char letra = palabra[i];
                    if (letra >= 'a' && letra <= 'z')
                    {
                        palabraA += letra;
                    }
                }
                Partida.arriesgarPalabra(palabraA);
                ViewBag.ganoP = Partida.gano;
            }
            return View("Fin");
        }

    [HttpPost]
    public IActionResult remplazarLetra(char letra, string palabra) 
    {
      if (letra != null && letra != "")
            {
                char caracter = letra[0];

                if (caracter >= 'a' && caracter <= 'z')
                {
                    Partida.IngresarLetra(caracter);
                }
  ViewBag.letras = Partida.letrasIngeresadas;
  ViewBag.intento = Partida.intentos;
  ViewBag.palabra = Partida.palabra;
  return View ("Jugar");

    }
    }
    public IActionResult Fin()
    {
        return View();
    } 
}
