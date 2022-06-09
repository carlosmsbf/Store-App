using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConvenienceStore.Models;
using ConvenienceStore.Helper.Store;

namespace ConvenienceStore.Controllers
{
    public class StoresController : Controller
    {
        private readonly ConvenienceStoreContext _context;

        public StoresController(ConvenienceStoreContext context)
        {
            _context = context;
        }

        // GET: Stores
        public async Task<IActionResult> Index()
        {
            var convenienceStoreContext = _context.Store
                .Include(s => s.Inventory)
                .Include(s => s.Inventory.Product)
                .Include(s => s.Inventory.Product.Brand)
                .Include(s => s.Inventory.Product.Category);
            return View(await convenienceStoreContext.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Index(int? id)
        {
            var convenienceStoreContext = await _context.Store
                .Include(s => s.Inventory)
                .Include(s => s.Inventory.Product)
                .Include(s => s.Inventory.Product.Brand)
                .Include(s => s.Inventory.Product.Category).ToListAsync();
            int i = 0;
            List<int> iList = new List<int>();

            if (id == 1)
            {
                foreach (var item in convenienceStoreContext)
                {
                    if (item.Quantity == 0)
                    {
                        iList.Add(i);
                    }
                    i++;
                }

               for(int x = iList.Count - 1; x >= 0; x--)
                    convenienceStoreContext.RemoveAt(iList[x]);
            }

            return View(convenienceStoreContext);
        }

        // GET: Stores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                TempData["failed"] = "Estoque Id não encontrado.";
                return NotFound();
            }

            var store = await _context.Store
                .Include(s => s.Inventory)
                .Include(s=>s.Inventory.Product)
                .Include(s => s.Inventory.Product.Category)
                .Include(s => s.Inventory.Product.Brand)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (store == null)
            {
                TempData["failed"] = "Produto nulo, não encontrado no Banco de Dados.";
                return NotFound();
            }

            return View(store);
        }

        // GET: Stores/Create
        public IActionResult Create()
        {
            var contextInventory = _context.Inventories.ToList();

            List<Inventory> inventoryItem = new List<Inventory>();

            foreach (var item in contextInventory)
            {
                if (item.Quantity != 0)
                {
                    inventoryItem.Add(item);
                }
            }

            ViewData["InventoryId"] = new SelectList(inventoryItem, "Id", "Id");
            return View();
        }

        // POST: Stores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,InventoryId,Quantity,Price,Date")] Store store)
        {
            var inventoryContext = await _context.Inventories.ToListAsync();

            if (ModelState.IsValid)
            {

           
                var inventory = inventoryContext.Find(x => x.Id == store.InventoryId);
                if(inventory.Quantity < store.Quantity)
                {
                    ViewData["InventoryId"] = new SelectList(_context.Inventories, "Id", "Id", store.InventoryId);
                    return View(store);
                }

                Inventory updatedInventory = new Inventory()
                {
                    Id = inventory.Id,
                    ProductId = inventory.ProductId,
                    Cost = inventory.Cost,
                    Date = inventory.Date,
                    Quantity = inventory.Quantity - store.Quantity
                };


                var productContext = await _context.Products.ToListAsync();
                var categoryContext = await _context.Categories.ToListAsync();
                var brandContext = await _context.Brands.ToListAsync();

                var product = productContext.Find(x => x.Id == inventory.ProductId);
                var category = categoryContext.Find(x => x.Id == product.CategoryId);
                var brand = brandContext.Find(x => x.Id == product.BrandId);



                var storeContext = await _context.Store.ToListAsync();
                int i = storeContext.Count+1;


                Report r = new Report()
                {
                    Brand = brand.Name,
                    Category = category.Name,
                    Product = product.Name,
                    Quantity = store.Quantity,
                    Cost = inventory.Cost,
                    Price = store.Price,
                    Date = store.Date,
                    Profit = store.Price - inventory.Cost,
                    TypeOfTransaction = "Loja - Exposto",
                    OperationId = i
                };

                _context.Report.Add(r);
                await _context.SaveChangesAsync();

                _context.Inventories.Remove(inventory);
                _context.Inventories.Add(updatedInventory);
                await _context.SaveChangesAsync();

                _context.Add(store);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            List<Inventory> inventoryItem = new List<Inventory>();

            foreach (var item in inventoryContext)
            {
                if (item.Quantity != 0)
                {
                    inventoryItem.Add(item);
                }
            }

            ViewData["InventoryId"] = new SelectList(inventoryItem, "Id", "Id",store.InventoryId);

            return View(store);
        }


        //public async Task<IActionResult> UpdateInventory()
        //{

        //    InventoryBalance ib = new InventoryBalance();




        //    Inventory  inventory = new Inventory() {
        //        Id = ib.Id,
        //        ProductId = ib.ProductId,
        //        Cost = ib.Cost,
        //        Date = ib.Date,
        //        Quantity = ib.Quantity
        //    };

        //    try
        //    {
        //            _context.Update(inventory);
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {

        //            return NotFound();
        //    }
        //    return RedirectToAction(nameof(Index));
        //}


        #region EDIT


        //// GET: Stores/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var store = await _context.Store.FindAsync(id);
        //    if (store == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["InventoryId"] = new SelectList(_context.Inventories, "Id", "Id", store.InventoryId);
        //    return View(store);
        //}

        //// POST: Stores/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,InventoryId,Quantity,Price,Date")] Store store)
        //{
        //    if (id != store.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(store);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!StoreExists(store.Id))
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
        //    ViewData["InventoryId"] = new SelectList(_context.Inventories, "Id", "Id", store.InventoryId);
        //    return View(store);
        //}

        #endregion Edit

        // GET: Stores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var store = await _context.Store
                .Include(s => s.Inventory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (store == null)
            {
                return NotFound();
            }

            return View(store);
        }

        // POST: Stores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var store = await _context.Store.FindAsync(id);
            _context.Store.Remove(store);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoreExists(int id)
        {
            return _context.Store.Any(e => e.Id == id);
        }
    }
}
