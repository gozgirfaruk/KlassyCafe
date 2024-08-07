﻿using KlassyCafe.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _UIMenuPreviewComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _UIMenuPreviewComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllProductPreiewAsync();
            return View(values);
        }
    }
}
