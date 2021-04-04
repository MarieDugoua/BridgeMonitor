using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BridgeMonitor.Models;
using Newtonsoft.Json;

namespace BridgeMonitor.Controllers
{
    public class HomeController : Controller
    {
        public static List<BridgeInfo> infos = new List<BridgeInfo>();
        private static readonly HttpClient client = new HttpClient();
        
        public HomeController()
        {
            var stringResult = client.GetStringAsync("https://api.alexandredubois.com/pont-chaban/api.php");
            var response = stringResult.Result;
            var result = JsonConvert.DeserializeObject<List<BridgeInfo>>(response);
            infos = result.OrderBy(closing =>
                Convert.ToDateTime(closing.ClosingDate)).ToList();
        }
        
        public IActionResult Index()
        {
            return View(infos);
        }

        public IActionResult AllClosing()
        {
            return View(infos);
        }
        [HttpGet]
        [Route("/Home/Details/{Id}")]
        public IActionResult Details(int id)
        {
            return View(infos[id]);
        }
        public IActionResult Privacy()
        {
            return View(infos);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
