using BlazingPizza.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SpecialsController : Controller
    {
        private readonly PizzaStoreContext _db;
        public SpecialsController(PizzaStoreContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetSpecials()
        {
            var lista = (await _db.Specials.ToListAsync()).OrderByDescending(x => x.BasePrice).ToList();
            return Ok(lista);
        }
    }
}