using Microsoft.AspNetCore.Mvc;
using TimeTravelAgency.Services;

namespace TimeTravelAgency.Controllers;

public class HomeController : Controller
{
    private readonly DestinationService _service;

    public HomeController(DestinationService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        return View(_service.GetAll());
    }
}
