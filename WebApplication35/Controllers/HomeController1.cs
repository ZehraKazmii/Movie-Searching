using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json.Nodes;

namespace WebApplication35.Controllers
{
    public class HomeController1 : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
            public IActionResult Index(string search)
        {

            string encodedSearch = Uri.EscapeDataString(search);

            WebClient web = new WebClient();
            string url = web.DownloadString($"https://www.omdbapi.com/?t={encodedSearch}&apikey=746026c4");
            JsonNode data = JsonNode.Parse(url);
            var neww = data["Year"];
            var newe = data["Title"];
            var newee = data["Actors"];
            var new1 = data["Runtime"];
            var new2 = data["Poster"];

            ViewBag.y = neww;
            ViewBag.z = newe;
            ViewBag.x = newee;
            ViewBag.a = new1;
            ViewBag.b = new2;
         
            return View();
           
        }
    }
}
