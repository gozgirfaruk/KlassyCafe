using KlassyCafe.Dtos.SliderDtos;
using KlassyCafe.Services.SliderServices;
using Microsoft.AspNetCore.Mvc;

namespace KlassyCafe.Controllers
{
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IActionResult> SliderList()
        {
            var values = await _sliderService.GetSliderListAsync();
            return View(values);
        }

        public IActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderDto createSliderDto)
        {
            createSliderDto.Status = true;
            await _sliderService.CreateSliderAsync(createSliderDto);
            return RedirectToAction("SliderList");

        }

        public async Task<IActionResult> DeleteSlider(int id)
        {
            await _sliderService.DeleteSliderAsync(id);
            return RedirectToAction("SliderList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSlider(int id)
        {
            var values = await _sliderService.GetSliderByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            await _sliderService.UpdateSliderAsync(updateSliderDto);
            return RedirectToAction("SliderList");
        }
        public async Task<IActionResult> ChangeToTrue(int id)
        {
            await _sliderService.ChangeStatusToTrue(id);
            return RedirectToAction("SliderList");
        }
        public async Task<IActionResult> ChangeToFalse(int id)
        {
            await _sliderService.ChangeStatusToFalse(id);
            return RedirectToAction("SliderList");
        }
    }
}
