using KlassyCafe.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _UIMenuCategoryComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _UIMenuCategoryComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var valeus = await _categoryService.GetAllCategoryAsync();
            return View(valeus);
        }
    }
}
