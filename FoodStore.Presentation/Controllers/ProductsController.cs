using FoodStore.Business.Abstract;
using FoodStore.Entity.Concrete;
using FoodStore.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FoodStore.Presentation.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult ProductList()
        {
            var values = _productService.ProductsWithCategories();
            return View(values);
        }

        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return RedirectToAction("ProductList");
        }

        public IActionResult CreateProduct()
        {
            ViewBag.Categories = GetCategoriesSelectList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct([FromForm] ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "productImages", product.Image.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await product.Image.CopyToAsync(stream);
                }
                product.ImageUrl = product.Image.FileName;

                Product prod = new Product()
                {
                    ProductName = product.ProductName,
                    CategoryId = product.CategoryId,
                    Description = product.Description,
                    Price = product.Price,
                    Stock = product.Stock,
                    ImageUrl = product.ImageUrl,

                };
                _productService.TInsert(prod);
                return RedirectToAction("ProductList");
            }
            return View(product);
        }

        private SelectList GetCategoriesSelectList()
        {
            return new SelectList(
                _categoryService.TGetAll(),
                "CategoryId",
                "CategoryName",
                "1"
            );
        }

        public IActionResult UpdateProduct(int id)
        {
            var product = _productService.TGetById(id);
            ViewBag.Categories = GetCategoriesSelectList();
            ProductViewModel productViewModel = new ProductViewModel()
            {
                ProductID = product.ProductId,
                ProductName = product.ProductName,
                CategoryId = product.CategoryId,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                ImageUrl = product.ImageUrl,
            };
            return View(productViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateProduct([FromForm] ProductViewModel product)
        {
            if (product.Image is not null)
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "productImages", product.Image.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await product.Image.CopyToAsync(stream);
                }
                product.ImageUrl = product.Image.FileName;
            }
            Product prod = new Product()
            {
                ProductId = product.ProductID,
                ProductName = product.ProductName,
                CategoryId = product.CategoryId,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                ImageUrl = product.ImageUrl,

            };
            _productService.TUpdate(prod);
            return RedirectToAction("ProductList");
        }
    }
}
