using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;

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
        public ActionResult CreateForm()
        {
          return View();
        }

        [HttpPost("/places")]
        public ActionResult Create()
        {
          Place newPlace = new Place (Request.Form["new-place"]);
          newPlace.Save();
          List<Place> allPlaces = Place.GetAll();
          return View("Index", allPlaces);
        }

        [HttpPost("/places/delete")]
        public ActionResult DeleteAll()
        {
            Place.ClearAll();
            return View();
        }
    }
}
