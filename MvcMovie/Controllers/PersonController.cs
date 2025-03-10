using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MvcMovie.Data;
using MvcMovie.Models;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicatonDbContext _context;
        public PersonController(ApplicatonDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Person.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId, Fullname, Address")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Person == null)
            {
                return NotFound();
            }
            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId, FullName, Address")] Person person)
        {
            if(id != person.PersonId)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if(!PersonExists(person.PersonId))
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
            return View(person);
        }
        public async Task<IActionResult> Delete(string id)
        {
            if(id == null || _context.Person == null)
            {
                return NotFound();
            }
            var person = await _context.Person
            .FirstOrDefaultAsync(m =>m.PersonId == id);
            if(person==null)
            {
                return NotFound();
            }
            return View(person);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Person == null)
            {
                return Problem("Entity set 'ApplicatonDbContext.Person' is null");
            }
            var person = await _context.Person.FindAsync(id);
            if (person !=null)
            {
                _context.Person.Remove(person);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof (Index));
        }
        private bool PersonExists(string id)
        {
            return (_context.Person? .Any(e=>e.PersonId == id)) .GetValueOrDefault();
        } 
        // code cu
        // public IActionResult Index()
        // {
            // return View();
        // }
        // [HttpPost]
        // public IActionResult Index( Person ps)
        // {
            // string strOutput = "Xin chao " + ps.FullName + " co ID la: " + ps.PersonId + " den tu " + ps.Address;
            // ViewBag.infoPerson = strOutput;
            // return View();
        // }
        // public IActionResult Welcome()
        // {
            // return View();
        // }

    }
}