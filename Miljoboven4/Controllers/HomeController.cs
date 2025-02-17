using Microsoft.AspNetCore.Mvc;
using Miljöboven.Models;
using Miljoboven4.Infrastructure;



namespace Miljöboven.Controllers;

public class HomeController : Controller
{
    // GET
    public ViewResult Index()
    {
        var myErrand = HttpContext.Session.Get<Errand>("NewErrand");
        if (myErrand == null)
        {
            return View();
        }
        else
        { 
            return View(myErrand);
        }
    }
    
    public ViewResult Login()
    {
        return View();
    }
}