using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Giris.Controllers
{
    // Route => kaynağın adresi
    [Route("dersimizapi")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        string[] ogrencilerim = { "Bilal", "Alper", "Emre", "Ahmet" };

        [HttpGet]
        public IActionResult Get()
        {
            //return Ok(ogrencilerim);
            return Ok(ogrencilerim);
        }

        [HttpGet("{index}")]
        public IActionResult Get(int index)
        {
            try
            {
                return Ok(ogrencilerim[index]);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
