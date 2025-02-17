using Microsoft.AspNetCore.Mvc;
using Miljöboven.Models;
using Miljoboven4.Infrastructure;

namespace Miljöboven.Controllers;

public class CoordinatorController : Controller
{
	// GET
	private readonly IEnvironmentRepository repository;

	public CoordinatorController(IEnvironmentRepository repo)
	{
		repository = repo;
	}

	public ViewResult CrimeCoordinator(int id)
    {
		ViewBag.Id = id;
		return View(repository.Departments);
    }
    
    public ViewResult ReportCrime()
    {
        var myErrand = HttpContext.Session.Get<Errand>("NewCoordErrand");
        if (myErrand == null)
        {
            return View();
        }
        else
        {
            return View(myErrand);
        }
    }
    
    public ViewResult StartCoordinator()
    {
        return View(repository);
    }
    
    public ViewResult Thanks()
    {
        var errand = HttpContext.Session.Get<Errand>("NewCoordErrand");
        if (errand != null)
        {
            repository.SaveErrand(errand);
            ViewBag.RefNumber = errand.RefNumber;
            HttpContext.Session.Remove("NewCoordErrand");
        }
        return View();
    }
    
    public ViewResult Validate(Errand errand)
    {
        HttpContext.Session.Set<Errand>("NewCoordErrand", errand);
        return View(errand);
    }
}