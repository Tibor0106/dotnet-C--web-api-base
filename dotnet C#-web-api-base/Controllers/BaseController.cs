using dotnet_C__web_api_base.Database;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_C__web_api_base.Controllers
{
    [Route("[controller]Requets")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public BaseController(AppDbContext appDbcontext)
        {
            _appDbContext = appDbcontext;
        }

        [HttpPut]
        [Route("method-put")]
        public async Task<IActionResult> MethodPut()
        {    
            return Ok("Sikeres kérés");
        }

        [HttpPost]
        [Route("method-post")]
        public async Task<IActionResult> MethodPost()
        {
            return Ok("Sikeres kérés");
        }

        //pl: adat lekéresekor használatos
        [HttpGet]
        [Route("method-get")]
        public async Task<IActionResult> MethodGet()
        {
            return Ok("Sikeres kérés");
        }

        //pl: adat törlésekor használatos
        [HttpDelete]
        [Route("method-delete")]
        public async Task<IActionResult> MethodDelete()
        {
            return Ok("Sikeres kérés");
        }

        //pl: adat szerkesztéskor használatos
        [HttpPatch]
        [Route("method-patch")]
        public async Task<IActionResult> MethodPatch()
        {
            return Ok("Sikeres kérés");
        }

        [HttpOptions]
        [Route("method-options")]
        public async Task<IActionResult> MethodOptions()
        {
            return Ok("Sikeres kérés");
        }

        //pl: fejléc küldésekor
        [HttpHead]
        [Route("method-head")]
        public async Task<IActionResult> MethodHead()
        {
            return Ok("Sikeres kérés");
        }
    }
}
