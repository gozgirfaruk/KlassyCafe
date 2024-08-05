using KlassyCafe.Dtos.ProductDtos;
using KlassyCafe.Services.CategoryServices;
using KlassyCafe.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KlassyCafe.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categorySevice;

        public ProductController(IProductService productService, ICategoryService categorySevice)
        {
            _productService = productService;
            _categorySevice = categorySevice;
        }

        public async Task<IActionResult> ProductList()
        {
            var valeus = await _productService.GetAllProductAsync();
            return View(valeus);
        }

        public async Task<IActionResult> CreateProduct()
        {
            ViewBag.categories = new SelectList(await _categorySevice.GetAllCategoryAsync(), "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProduct)
        {
            await _productService.CreateProductAsync(createProduct);
            return RedirectToAction("ProductList");
        }
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            ViewBag.categories = new SelectList(await _categorySevice.GetAllCategoryAsync(), "CategoryId", "CategoryName");
            var values = await _productService.GetProductByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProduct)
        {
            await _productService.UpdateProductAsync(updateProduct);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> ChangeToTrue(int id)
        {
            await _productService.ChangeToTrue(id);
            return RedirectToAction("ProductList");
        }
        public async Task<IActionResult> ChangeToFalse(int id)
        {
            await _productService.ChangeToFalse(id);
            return RedirectToAction("ProductList");
        }

    }
}
