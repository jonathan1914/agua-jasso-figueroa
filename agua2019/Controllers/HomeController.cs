using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using agua2019.Models;

namespace agua2019.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Calcular(DateTime ProximoCumple, int minutos)
        {
    
            /// Aquí tienen que hacer todo
            /// La fecha que y los minutos vienen del formulario 
            /// Investigar Model Binding 
            int minutos , botellas;
            botellas= minutos * 12; 
           TimeSpan Dias;
           Dias= ProximoCumple - DateTime.Today;
           ViewBag.Dias= Dias.Days;
            var aguaViewModel = new AguaViewModel();

            return View(aguaViewModel);
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
}
