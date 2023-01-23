using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OlympiangodsAPI.Services.OlympiangodService;

namespace OlympiangodsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OlympiangodsController : ControllerBase
    {
        private readonly IOlympiangodService _olympiangodService;

        public OlympiangodsController(IOlympiangodService olympiangodService)
        {
            _olympiangodService = olympiangodService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Olympiangod>>> GetAllgods()
        {
            return _olympiangodService.GetAllgods();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Olympiangod>> GetbyId(int id)
        {
            var result = _olympiangodService.GetbyId(id);
            if (result is null)
                return NotFound("Entity not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Olympiangod>>> Addgod(Olympiangod god)
        {
            var result = _olympiangodService.Addgod(god);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Olympiangod>>> Updategod(int id, Olympiangod request)
        {
            var result = _olympiangodService.Updategod(id, request);
            if (result is null)
                return NotFound("Entity not found.");

            return Ok(result);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Olympiangod>>> Deletegod(int id)
        {
            var result = _olympiangodService.Deletegod(id);
            if (result is null)
                return NotFound("Entity not found.");

            return Ok(result);
        }
    }
}
