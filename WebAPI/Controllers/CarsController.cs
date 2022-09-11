using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("carsbycolor")]
        public IActionResult Cars(string color)
        {
            var cars = _carService.GetCarsbyColor(color);
            return Ok(cars);
        }
        [HttpPut("onoffheadLights")]
        public IActionResult OnOffHeadLights(int carId)
        {
            _carService.OnOffHeadLights(carId);
            return Ok();
        }
        [HttpPut("deletecarbyid")]
        public IActionResult DeleteCarById(int carId)
        {
            _carService.DeleteCarbyCarId(carId);
            return Ok();
        }
    }
}
