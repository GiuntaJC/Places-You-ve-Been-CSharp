using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string city, string durationOfStay, string travelBuddy, string journalEntry)
    {
      Place newPlace = new Place(city, durationOfStay, travelBuddy, journalEntry);
      return RedirectToAction("Index");
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }
  }
}