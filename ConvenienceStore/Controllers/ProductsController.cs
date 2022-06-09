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
    public class ProductsController : Controller
    {
        private readonly ConvenienceStoreContext _context;

        public ProductsController(ConvenienceStoreContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var convenienceStoreContext = _context.Products.Include(p => p.Brand).Include(p => p.Category);
            return View(await convenienceStoreContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                TempData["failed"] = "Produto Id não encontrado.";
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                TempData["failed"] = "Produto nulo, não encontrado no Banco de Dados.";
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name");
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryId,Name,BrandId,Description")] Product product)
        {
            if (ModelState.IsValid)
            {
                var contextProduct = _context.Products.Include(x => x.Brand).Include(x => x.Category).ToList();

                var productId = contextProduct.Find(x => x.Name == product.Name);
                if (!(productId == null))
                    if (productId.Brand.Id == product.BrandId)
                        if (productId.Category.Id == product.CategoryId)
                            if (productId.Description == product.Description)
                            {
                                ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name", product.BrandId);
                                ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
                                TempData["failed"] = "Nome de Marca, Categoria e Descrição igual, favor alterar.";
                                return View(product);

                            }

                TempData["successed"] = "Informação salva.";
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            TempData["failed"] = "Favor preencher todos os campos";
            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name", product.BrandId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                TempData["failed"] = "Produto Id não encontrado.";
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                TempData["failed"] = "Produto nulo, não encontrado no Banco de Dados.";
                return NotFound();
            }

            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name", product.BrandId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryId,Name,BrandId,Description")] Product product)
        {
            if (id != product.Id)
            {
                TempData["failed"] = "Id e Marca Id se divertgem.";
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var contextProduct = _context.Products.Include(x=>x.Brand).Include(x => x.Category).ToList();

                    var productId = contextProduct.Find(x => x.Name == product.Name);
                    if (!(productId == null))
                        if (productId.Brand.Id == product.BrandId)
                            if (productId.Category.Id == product.CategoryId)
                                if (productId.Name == product.Name)
                                    if (productId.Description == product.Description)
                                        {
                                    ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name", product.BrandId);
                                    ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
                                    TempData["failed"] = "Nome de Marca, Categoria e Descrição igual, favor alterar.";
                                            return View(product);
                                        }
                    productId = contextProduct.Find(x => x.Id == product.Id);
                    TempData["successed"] = "Informação salva.";
                    _context.Products.Remove(productId);
                    _context.Add(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        TempData["failed"] = "Product Id não encontrada.";
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
            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name", product.BrandId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                TempData["failed"] = "Produto Id não encontrada.";
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                TempData["failed"] = "Produto não encontrada no Banco de Dados.";
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            TempData["successed"] = "Produto Deletado.";
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }


        public IActionResult SelectEditProduct()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        public IActionResult SelectDetailProduct()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        public IActionResult SelectDeleteProduct()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }


    }
}
