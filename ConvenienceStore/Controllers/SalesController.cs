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
    public class SalesController : Controller
    {
        private readonly ConvenienceStoreContext _context;

        public SalesController(ConvenienceStoreContext context)
        {
            _context = context;
        }

        // GET: Sales
        public async Task<IActionResult> Index()
        {
            var convenienceStoreContext = _context.Sales
                .Include(s => s.Store)
                .Include(s => s.Store.Inventory)
                .Include(s => s.Store.Inventory.Product)
                .Include(s => s.Store.Inventory.Product.Brand)
                .Include(s => s.Store.Inventory.Product.Category); 
            return View(await convenienceStoreContext.ToListAsync());
        }

        // GET: Sales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                TempData["failed"] = "Estoque Id não encontrado.";
                return NotFound();
            }

            var sale = await _context.Sales
                .Include(s => s.Store)
                .Include(s => s.Store.Inventory)
                .Include(s => s.Store.Inventory.Product)
                .Include(s => s.Store.Inventory.Product.Category)
                .Include(s => s.Store.Inventory.Product.Brand)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sale == null)
            {
                TempData["failed"] = "Produto nulo, não encontrado no Banco de Dados.";
                return NotFound();
            }

            return View(sale);
        }

        // GET: Sales/Create
        public IActionResult Create()
        {
            var contextStore = _context.Store.ToList();

            List<Store> itemStored = new List<Store>();

            foreach(var item in contextStore)
            {
                if(item.Quantity != 0)
                {
                    itemStored.Add(item);
                }
            }


            ViewData["StoreId"] = new SelectList(itemStored, "Id", "Id");
            return View();
        }

        // POST: Sales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StoreId,Quantity,Date")] Sale sale)
        {
            if (ModelState.IsValid)
            {

                var storeContext = await _context.Store.ToListAsync();
                var store = storeContext.Find(x => x.Id == sale.StoreId);


                if (store.Quantity < sale.Quantity)
                {
                    ViewData["StoreId"] = new SelectList(_context.Store, "Id", "Id", sale.StoreId);
                    return View(sale);
                }

                Store updatedStore = new Store()
                {
                    Id = store.Id,
                    InventoryId = store.InventoryId,
                    Quantity = store.Quantity - sale.Quantity,
                    Date = store.Date,
                    Price = store.Price
                };

                var productContext = await _context.Products.ToListAsync();
                var categoryContext = await _context.Categories.ToListAsync();
                var brandContext = await _context.Brands.ToListAsync();
                var inventoryContext = await _context.Inventories.ToListAsync();


                var inventory = inventoryContext.Find(x => x.Id == store.InventoryId);
                var product = productContext.Find(x => x.Id == inventory.ProductId);
                var category = categoryContext.Find(x => x.Id == product.CategoryId);
                var brand = brandContext.Find(x => x.Id == product.BrandId);

                var saleContext = await _context.Store.ToListAsync();
                int i = saleContext.Count+1;

                Report r = new Report()
                {
                    Brand = brand.Name,
                    Category = category.Name,
                    Product = product.Name,
                    Quantity = sale.Quantity,
                    Cost = inventory.Cost,
                    Price = store.Price,
                    Date = sale.Date,
                    Profit = store.Price - inventory.Cost,
                    TypeOfTransaction = "Vendas",
                    OperationId = i
                };

                //Create data to Report Database
                _context.Report.Add(r);
                await _context.SaveChangesAsync();

                //Update data to Store Database
                _context.Store.Remove(store);
                _context.Store.Add(updatedStore);
                await _context.SaveChangesAsync();

                //Create data to Sale Database
                _context.Sales.Add(sale);
                    await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            var contextStore = _context.Store.ToList();

            List<Store> itemStored = new List<Store>();

            foreach (var item in contextStore)
            {
                if (item.Quantity != 0)
                {
                    itemStored.Add(item);
                }
            }

            ViewData["StoreId"] = new SelectList(itemStored, "Id", "Id", sale.StoreId);

            return View(sale);
        }



        #region EDIT

        //// GET: Sales/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sale = await _context.Sales.FindAsync(id);
        //    if (sale == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["StoreId"] = new SelectList(_context.Store, "Id", "Id", sale.StoreId);
        //    return View(sale);
        //}

        //// POST: Sales/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,StoreId,Cost,Date")] Sale sale)
        //{
        //    if (id != sale.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(sale);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SaleExists(sale.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["StoreId"] = new SelectList(_context.Store, "Id", "Id", sale.StoreId);
        //    return View(sale);
        //}


        #endregion Edit

        // GET: Sales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sale = await _context.Sales
                .Include(s => s.Store)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sale == null)
            {
                return NotFound();
            }

            return View(sale);
        }

        // POST: Sales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sale = await _context.Sales.FindAsync(id);
            _context.Sales.Remove(sale);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaleExists(int id)
        {
            return _context.Sales.Any(e => e.Id == id);
        }
    }
}
