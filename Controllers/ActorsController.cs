using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult AddActor(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
            return View();
        }
        public IActionResult AllActors() 
        {
           var actors = _context.Actors.ToList();
            return View(actors);
        }
        public IActionResult DeleteActor(Actor actor)
        {
            _context.Actors.Remove(actor);
            _context.SaveChanges();
            return View();
        }
    }
}
