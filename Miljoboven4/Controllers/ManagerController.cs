using Microsoft.AspNetCore.Mvc;
using Miljöboven.Models;

namespace Miljöboven.Controllers;

public class ManagerController : Controller
{
	// GET
	private readonly IEnvironmentRepository repository;

    public ManagerController(IEnvironmentRepository repo)
    {
        repository = repo;
    }
    
    public ViewResult CrimeManager(int id)
    {
        ViewBag.Id = id;
        return View(repository.Employees);
    }
    
    public ViewResult StartManager()
    {
        return View(repository);
    }
}