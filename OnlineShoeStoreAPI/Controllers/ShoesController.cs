using Microsoft.AspNetCore.Mvc;
using OnlineShoeStoreAPI.Models;
using OnlineShoeStoreAPI.Services;
using System.Collections.Generic;

namespace OnlineShoeStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoesController : ControllerBase
    {
        private readonly ShoeService _shoeService;

        public ShoesController(ShoeService shoeService)
        {
            _shoeService = shoeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Shoe>> GetAllShoes()
        {
            var shoes = _shoeService.GetAllShoes();
            return Ok(shoes);
        }

        [HttpGet("{id}")]
        public ActionResult<Shoe> GetShoeDetails(int id)
        {
            var shoe = _shoeService.GetShoeById(id);
            if (shoe == null)
            {
                return NotFound();
            }
            return Ok(shoe);
        }
    }
}