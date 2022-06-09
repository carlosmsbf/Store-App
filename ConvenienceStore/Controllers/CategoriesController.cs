using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConvenienceStore.Models;

namespace ConvenienceStore.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ConvenienceStoreContext _context;

        public CategoriesController(ConvenienceStoreContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: Categories/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var category = await _context.Categories
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(category);
        //}

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Category category)
        {
            if (ModelState.IsValid)
            {
                var contextCategory = _context.Categories.ToList();
                var categoryItem = contextCategory.Find(x => x.Name == category.Name);

                if (!(categoryItem == null))
                    if (categoryItem.Name == category.Name)
                    {
                        TempData["failed"] = "Nome de Categoria igual, favor alterar.";
                        return View(category);
                    }

                TempData["successed"] = "Informação Adicionada.";

                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            TempData["failed"] = "Algum erro ocorreu, favor preencher novamente.";
            return View(category);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                TempData["failed"] = "Categoria Id não encontrada.";
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                TempData["failed"] = "Categoria não encontrada no Banco de Dados.";
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Category category)
        {
            if (id != category.Id)
            {
                TempData["failed"] = "Id e Category Id se divertgem.";
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var contextCategory = await _context.Categories.ToListAsync();

                    foreach(var item in contextCategory)
                        if ( item.Name == category.Name)
                        {
                            TempData["failed"] = "Nome de Categoria igual, favor alterar.";
                            return View(category);
                        }
                    var removeCategory = contextCategory.Find(x=>x.Id == category.Id);
                    
                    _context.Categories.Remove(removeCategory);
                    _context.Add(category);
                    TempData["successed"] = "Informação Adicionada.";

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
                    {
                        TempData["failed"] = "Categoria Id não encontrada.";
                        return NotFound();
                    }
                    else
                    {
                        TempData["failed"] = "Algum erro aconteceu.";
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            TempData["failed"] = "Favor preencher todos os campos";
            return View(category);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                TempData["failed"] = "Categoria Id não encontrada.";
                return NotFound();
            }

            var category = await _context.Categories.FirstOrDefaultAsync(m => m.Id == id);

            if (category == null)
            {
                TempData["failed"] = "Categoria não encontrada no Banco de Dados.";
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            TempData["successed"] = "Categoria Deletada.";
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }

        public IActionResult DeleteCategory()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        public IActionResult EditCategory()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

    }
}
