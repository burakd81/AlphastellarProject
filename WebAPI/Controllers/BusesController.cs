using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusesController : ControllerBase
    {
        private readonly IBusService _busService;

        public BusesController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet("busesbycolor")]
        public IActionResult Buses(string color)
        {
            var buses = _busService.GetCarsbyColor(color);
            return Ok(buses);
        }
    }
}
