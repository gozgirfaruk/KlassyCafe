﻿using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _UIBannerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
