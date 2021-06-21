using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using zabolotnyi_zpi_zp_92_lab_kpi_3.Models;

namespace zabolotnyi_zpi_zp_92_lab_kpi_3.Controllers
{
    public class HomeController : Controller
    {
    /// <summary>
    /// /
    /// </summary>
        //public string Index()
        //{
        //    return "Hello World";
        //}
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View("MyView");
        //}
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult PlayerForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult PlayerForm(Player player)
        {
            if (ModelState.IsValid)
            {
                Repository.AddPlayers(player);
            return View("Added", player);
            }
            else
            {
                // Обнаружена ошибка проверки достоверности,
                return View();
                }
        }
        public IActionResult Privacy()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ViewResult ListPlayers()//r => r.WillAttend = true
        {
            return View(Repository.Players.Where(p => p.RedCard == false));
        }
    }
}
