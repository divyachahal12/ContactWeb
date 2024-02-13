using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContactWebModels;
using MyContactManagerData;
using MyContactManagerServices;
using Microsoft.Extensions.Caching.Memory;
using ContactWeb.Models;
using Microsoft.AspNetCore.Authorization;
using ContactWeb.Data;

namespace ContactWeb.Controllers
{
    [Authorize(Roles = UserRolesService.ADMIN_ROLE_NAME)]
    //[Authorize(Roles = "Admin")]
    public class StatesController : Controller
    {
        //private readonly MyContactManagerDbContext _context;
        private readonly IStatesService _statesService;
        private IMemoryCache _cache;

        /*
        public StatesController(MyContactManagerDbContext context)
        {
            _context = context;
        }
        */
        public StatesController(IStatesService statesService, IMemoryCache cache)
        {
            _statesService = statesService;
            _cache = cache;
        }

        // GET: States
        public async Task<IActionResult> Index()
        {
           // var roles = await UserRolesService.ADMIN_ROLE_NAME; // where 'user' is the ApplicationUser

            var allStates = new List<State>();
            if (!_cache.TryGetValue(ContactCacheConstants.ALL_STATES, out allStates))
            {
                var allStatesData = await _statesService.GetAllAsync() as List<State>;

                _cache.Set(ContactCacheConstants.ALL_STATES, allStatesData, TimeSpan.FromDays(1));
                return View(allStatesData);
            }

            return View(allStates);
            //return View(await _context.States.ToListAsync());
        }

        // GET: States/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var state = await _context.States
            //   .FirstOrDefaultAsync(m => m.Id == id);
            var state = await _statesService.GetAsync((int)id);
            if (state == null)
            {
                return NotFound();
            }

            return View(state);
        }

        // GET: States/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: States/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Abbreviation")] State state)
        {
            if (ModelState.IsValid)
            {
                // _context.Add(state);
                //await _context.SaveChangesAsync();
                await _statesService.AddOrUpdateAsync(state);
                _cache.Remove(ContactCacheConstants.ALL_STATES);
                return RedirectToAction(nameof(Index));
            }
            return View(state);
        }

        // GET: States/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var state = await _context.States.FindAsync(id);
            var state = await _statesService.GetAsync((int)id);
            if (state == null)
            {
                return NotFound();
            }
            return View(state);
        }

        // POST: States/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Abbreviation")] State state)
        {
            if (id != state.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _statesService.AddOrUpdateAsync(state);
                    _cache.Remove(ContactCacheConstants.ALL_STATES);

                    //_context.Update(state);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StateExists(state.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(state);
        }

        // GET: States/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var state = await _context.States
            //     .FirstOrDefaultAsync(m => m.Id == id);
            var state = await _statesService.GetAsync((int)id);
            if (state == null)
            {
                return NotFound();
            }

            return View(state);
        }

        // POST: States/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var state = await _statesService.DeleteAsync(id);
            _cache.Remove(ContactCacheConstants.ALL_STATES);
            //var state = await _context.States.FindAsync(id);
            //_context.States.Remove(state);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StateExists(int id)
        {
            return Task.Run(() => _statesService.ExistsAsync(id)).Result;
            // return _context.States.Any(e => e.Id == id);
        }
    }
}
