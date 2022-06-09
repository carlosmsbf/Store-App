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
    public class BrandsController : Controller
    {
        private readonly ConvenienceStoreContext _context;

        public BrandsController(ConvenienceStoreContext context)
        {
            _context = context;
        }

        // GET: Brands
        public async Task<IActionResult> Index()
        {
            return View(await _context.Brands.ToListAsync());
        }

        // GET: Brands/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brand = await _context.Brands
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brand == null)
            {
                return NotFound();
            }

            return View(brand);
        }

        // GET: Brands/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brands/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Brand brand)
        {

            if (ModelState.IsValid)
            {
                var contextBrand = _context.Brands.ToList();

                var brandItem = contextBrand.Find(x => x.Name == brand.Name);
              

                if(!(brandItem == null))
                if (brandItem.Name == brand.Name)
                {
                    TempData["failed"] = "Nome de Marca igual, favor alterar.";
                    return View(brand);

                }



                TempData["successed"] = "Informação Adicionada.";
                _context.Add(brand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            TempData["failed"] = "Favor preencher todos os campos";
            return View(brand);
        }

        // GET: Brands/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                TempData["failed"] = "Marca Id não encontrada.";
                return NotFound();
            }

            var brand = await _context.Brands.FindAsync(id);
            if (brand == null)
            {
                TempData["failed"] = "Marca não encontrada no Banco de Dados.";
                return NotFound();
            }
            return View(brand);
        }

        // POST: Brands/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Brand brand)
        {
            if (id != brand.Id)
            {
                TempData["failed"] = "Id e Marca Id se divertgem.";
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var contextBrand = await _context.Brands.ToListAsync();

                    foreach (var item in contextBrand)
                        if (item.Name == brand.Name)
                        {
                            TempData["failed"] = "Nome de Marca igual, favor alterar.";
                            return View(brand);

                        }
                    var removeBrand = contextBrand.Find(x => x.Id == brand.Id);

                    _context.Brands.Remove(removeBrand);
                    _context.Add(brand);
                    TempData["successed"] = "Informação salva.";
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrandExists(brand.Id))
                    {
                        TempData["failed"] = "Marca Id não encontrada.";
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
            return View(brand);
        }

        // GET: Brands/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                TempData["failed"] = "Marca Id não encontrada.";
                return NotFound();
            }

            var brand = await _context.Brands
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brand == null)
            {
                TempData["failed"] = "Marca não encontrada no Banco de Dados.";
                return NotFound();
            }

            return View(brand);
        }

        // POST: Brands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brand = await _context.Brands.FindAsync(id);
            _context.Brands.Remove(brand);
            await _context.SaveChangesAsync();
            TempData["successed"] = "Marca Deletada.";
            return RedirectToAction(nameof(Index));
        }

        private bool BrandExists(int id)
        {
            return _context.Brands.Any(e => e.Id == id);
        }

        public IActionResult SelectDeleteBrand()
        {
            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name");
            return View();
        }

        public IActionResult SelectEditBrand()
        {
            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name");
            return View();
        }


    }
}
