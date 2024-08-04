using KlassyCafe.Services.SliderServices;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.ViewComponents
{
    public class _UIBannerComponentPartial : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _UIBannerComponentPartial(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _sliderService.GetTrueSliderAsync();
            return View(values);
        }
    }
}
