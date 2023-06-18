using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Basics.Models;

namespace Basics.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string message =$"merhaba dunya.{DateTime.Now.ToString()}";
        return View("Index" , message);
    }

    public IActionResult Privacy()
    {
        var names =new String[]{
            "ahmet",
            "mehmet",
            "celal"
        };
        return View(names);
    }

    public IActionResult selman1(){
        var list =new List<selman>()
        {
            new selman (){Id=1, FirstName="ahmet", LastName="can", Age=20 },
            new selman (){Id=2, FirstName="selman", LastName="ağırman", Age=23},


        };
        return View("selman1", list);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
