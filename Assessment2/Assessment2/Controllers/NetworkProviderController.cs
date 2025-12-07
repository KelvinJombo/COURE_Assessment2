using Assessment2.Application.Dtos;
using Assessment2.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Assessment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NetworkProviderController : ControllerBase
    {
        private readonly IAnalyserService _analyserService;

        public NetworkProviderController(IAnalyserService analyserService)
        {
            _analyserService = analyserService;
        }


        [HttpPost("decode")]
        public IActionResult Decode([FromBody] DecodeNumberRequest request)
        {
            var result = _analyserService.DecodeNumber(request.PhoneNumber);
            return Ok(result);
        }





    }
}
