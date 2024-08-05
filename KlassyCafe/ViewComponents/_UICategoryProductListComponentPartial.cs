using KlassyCafe.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _UICategoryProductListComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _UICategoryProductListComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllProductAsync();
            return View(values);
        }
    }
}
