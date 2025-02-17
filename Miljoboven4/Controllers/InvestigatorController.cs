using Microsoft.AspNetCore.Mvc;
using Miljöboven.Models;

namespace Miljöboven.Controllers;

public class InvestigatorController : Controller
{
	// GET
	private readonly IEnvironmentRepository repository;

	public InvestigatorController(IEnvironmentRepository repo)
	{
		repository = repo;
	}

	public ViewResult CrimeInvestigator(int id)
    {
		ViewBag.Id = id;
		return View(repository.ErrandStatuses);
    }
    
    public ViewResult StartInvestigator()
    {
        return View(repository);
    }
}