using HotelListing.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelListing.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/country")]
    [ApiController]
    public class CountryV2Controller : ControllerBase
    {
        private DatabaseContext _context;

        public CountryV2Controller(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            return Ok(_context.Countries);
        }
    }
}
