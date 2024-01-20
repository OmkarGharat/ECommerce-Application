using ECommerce_Application.Data.Services;
using ECommerce_Application.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ECommerce_Application.Controllers
{
    public class ActorsController : Controller
    {
        // injecting AppDbContext to work with database
        private readonly IActorService _service;

        public ActorsController(IActorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, ProfilePictureURL, Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }

            await _service.Add(actor);
            return RedirectToAction("Index");

            //return View("Create");
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var actorDetails = await _service.GetById(id);

            if (actorDetails == null)
            {
                return View();
            }
            else
            {
                return View(actorDetails);
            }
        }


    }
}
