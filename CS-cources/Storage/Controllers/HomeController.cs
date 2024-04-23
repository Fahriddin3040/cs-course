using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Storage.Models;
using Storage.Utils.Abstractions.Services;

namespace Storage.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly  IUserService _userService;

    public HomeController(ILogger<HomeController> logger, IUserService    userService)
    {
        _logger = logger;
        _userService = userService;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult IsAuthentificationIser(string login, string password)
    {
       if( _userService.IsAuthentificationIser(login, password)){
            return Ok();
       }
       else
            return Unauthorized();
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
