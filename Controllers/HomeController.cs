using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
//using AmazonProject.Models;

namespace AmazonProject.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
