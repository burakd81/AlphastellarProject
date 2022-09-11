using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatsController : ControllerBase
    {
        private readonly IBoatService _boatService;

        public BoatsController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet("boatsbycolor")]
        public IActionResult Boats(string color)
        {
            var boats = _boatService.GetCarsbyColor(color);
            return Ok(boats);
        }
    }
}
