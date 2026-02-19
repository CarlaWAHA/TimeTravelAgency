using Microsoft.AspNetCore.Mvc;
using TimeTravelAgency.Models;
using TimeTravelAgency.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TimeTravelAgency.Controllers;

public class BookingController : Controller
{
    private readonly DestinationService _service;

    public BookingController(DestinationService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Destinations = new SelectList(_service.GetAll(), "Id", "Name");
        return View();
    }

    [HttpPost]
    public IActionResult Create(Booking booking)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Destinations = new SelectList(_service.GetAll(), "Id", "Name");
            return View(booking);
        }

        return RedirectToAction("Success");
    }

    public IActionResult Success()
    {
        return View();
    }
}
