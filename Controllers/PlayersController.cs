using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appfutbol.Controllers
{
    public class PlayersController
    {
        public IActionResult Create()
            {
                ViewBag.Teams = new SelectList(_context.Teams.ToList(), "TeamId", "Name");
                return View();
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Player player)
            {
                if (ModelState.IsValid)
                    {
                        _context.Add(player);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }

            ViewBag.Teams = new SelectList(_context.Teams.ToList(), "TeamId", "Name");
            return View(player);
            }

    
    }
}