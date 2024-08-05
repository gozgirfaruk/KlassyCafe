using KlassyCafe.Dtos.ProductDtos;
using KlassyCafe.Dtos.ReservationDtos;
using KlassyCafe.Models;
using KlassyCafe.Services.ProductServices;
using KlassyCafe.Services.ReservationServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace KlassyCafe.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReservationService _reservationService;

        public HomeController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewBag.Id = id;    
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateReservation(CreateReservationDto dto)
        {
            await _reservationService.CreateReservationAsync(dto);
            var values = JsonConvert.SerializeObject(dto);
            return Json(values);
        }
  
  
    }
}
