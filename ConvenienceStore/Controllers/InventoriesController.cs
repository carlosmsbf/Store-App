using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConvenienceStore.Models;
using ConvenienceStore.Models.ModelView;

namespace ConvenienceStore.Controllers
{
    public class InventoriesController : Controller
    {
        private readonly ConvenienceStoreContext _context;

        public InventoriesController(ConvenienceStoreContext context)
        {
            _context = context;
        }

        // GET: Inventories
        public async Task<IActionResult> Index()
        {
            var brandContext =await _context.Brands.ToListAsync();
            var categoryContext = await _context.Categories.ToListAsync();
            var productContext = await _context.Products.ToListAsync();
            var inventoryContext = await _context.Inventories.ToListAsync();


            InventoryModelView imv = new InventoryModelView() {
                BrandList = brandContext,
                CategoryList = categoryContext,
                ProductList = productContext,
                InventoryList = inventoryContext

            };

            return View(imv);
        }

        [HttpPost]
        public async Task<IActionResult> Index(int? id)
        {
            var ContextInventory = await _context.Inventories
                .Include(s => s.Product)
                .Include(s => s.Product.Brand)
                .Include(s => s.Product.Category).ToListAsync();
            int i = 0;
            List<int> iList = new List<int>();

            if (id == 1)
            {
                foreach (var item in ContextInventory)
                {
                    if (item.Quantity == 0)
                    {
                        iList.Add(i);
                    }
                    i++;
                }

                for (int x = iList.Count - 1; x >= 0; x--)
                    ContextInventory.RemoveAt(iList[x]);
            }

            InventoryModelView imv = new InventoryModelView()
            {
                InventoryList = ContextInventory

            };

            return View(imv);
        }
        // GET: Inventories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                TempData["failed"] = "Estoque Id não encontrado.";
                return NotFound();
            }

            var inventory = await _context.Inventories
                .Include(i => i.Product)
                .Include(i => i.Product.Brand)
                .Include(i => i.Product.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventory == null)
            {
                TempData["failed"] = "Estoque nulo, não encontrado no Banco de Dados.";
                return NotFound();
            }

            return View(inventory);
        }

        // GET: Inventories/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        // POST: Inventories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,Quantity,Cost,Date")] Inventory inventory)
        {
            if (ModelState.IsValid)
            {

                var productContext = await _context.Products.ToListAsync();
                var categoryContext = await _context.Categories.ToListAsync();
                var brandContext = await _context.Brands.ToListAsync();

                var product = productContext.Find(x => x.Id == inventory.ProductId);
                var category = categoryContext.Find(x => x.Id == product.CategoryId);
                var brand = brandContext.Find(x => x.Id == product.BrandId);



                var inventoryContext = await _context.Inventories.ToListAsync();
                int i = inventoryContext.Count+1;

                Report r = new Report()
                {
                    Brand  = brand.Name,
                    Category = category.Name,
                    Product = product.Name,
                    Quantity = inventory.Quantity,
                    Cost = inventory.Cost,
                    Date = inventory.Date,
                    TypeOfTransaction = "Estoque",
                    OperationId = i
                };

                _context.Report.Add(r);
                await _context.SaveChangesAsync();

                _context.Add(inventory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", inventory.ProductId);
            return View(inventory);
        }

        // GET: Inventories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventories.FindAsync(id);
            if (inventory == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", inventory.ProductId);
            return View(inventory);
        }

        // POST: Inventories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductId,Quantity,Cost,Date")] Inventory inventory)
        {
            if (id != inventory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventoryExists(inventory.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", inventory.ProductId);
            return View(inventory);
        }

        // GET: Inventories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventory = await _context.Inventories
                .Include(i => i.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inventory == null)
            {
                return NotFound();
            }

            return View(inventory);
        }

        // POST: Inventories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventory = await _context.Inventories.FindAsync(id);
            _context.Inventories.Remove(inventory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventoryExists(int id)
        {
            return _context.Inventories.Any(e => e.Id == id);
        }
    }
}
