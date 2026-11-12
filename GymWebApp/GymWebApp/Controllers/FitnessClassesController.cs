using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GymWebApp.Models;
using GymWebApp.Data;

public class FitnessClassesController : Controller
{
    private readonly ApplicationDbContext _context;

    public FitnessClassesController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: FITNESSCLASSS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.FitnessClasses.ToListAsync());
    }

    // GET: FITNESSCLASSS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var fitnessclass = await _context.FitnessClasses
            .FirstOrDefaultAsync(m => m.Id == id);
        if (fitnessclass == null)
        {
            return NotFound();
        }

        return View(fitnessclass);
    }

    // GET: FITNESSCLASSS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: FITNESSCLASSS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,Duration,Capacity,TrainerId,Trainer")] FitnessClass fitnessclass)
    {
        if (ModelState.IsValid)
        {
            _context.Add(fitnessclass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(fitnessclass);
    }

    // GET: FITNESSCLASSS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var fitnessclass = await _context.FitnessClasses.FindAsync(id);
        if (fitnessclass == null)
        {
            return NotFound();
        }
        return View(fitnessclass);
    }

    // POST: FITNESSCLASSS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Name,Duration,Capacity,TrainerId,Trainer")] FitnessClass fitnessclass)
    {
        if (id != fitnessclass.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(fitnessclass);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FitnessClassExists(fitnessclass.Id))
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
        return View(fitnessclass);
    }

    // GET: FITNESSCLASSS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var fitnessclass = await _context.FitnessClasses
            .FirstOrDefaultAsync(m => m.Id == id);
        if (fitnessclass == null)
        {
            return NotFound();
        }

        return View(fitnessclass);
    }

    // POST: FITNESSCLASSS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var fitnessclass = await _context.FitnessClasses.FindAsync(id);
        if (fitnessclass != null)
        {
            _context.FitnessClasses.Remove(fitnessclass);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool FitnessClassExists(int? id)
    {
        return _context.FitnessClasses.Any(e => e.Id == id);
    }
}
