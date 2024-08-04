using KlassyCafe.Dtos.CategoryDtos;
using KlassyCafe.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryService.GetAllCategoryAsync();
            return View(values);
        }
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public  IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            createCategoryDto.Status = false;
            await _categoryService.CreateCategoryAsync(createCategoryDto);
            return RedirectToAction("CategoryList");
        }

        public async Task<IActionResult> UpdateCategory(int id)
        {
            var values = await _categoryService.GetCategoryByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            await _categoryService.UpdateCategoryAsync(updateCategoryDto);
            return RedirectToAction("CategoryList");
        }
        public async Task<IActionResult> ChangeToTrue(int id)
        {
            await _categoryService.ChangeToTrue(id);
            return RedirectToAction("CategoryList");

        }

        public async Task<IActionResult> ChangeToFalse(int id)
        {
            await _categoryService.ChangeToFalse(id);
            return RedirectToAction("CategoryList");
        }
    }
}
