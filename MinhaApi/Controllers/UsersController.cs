using CustomDomain.Intefaces.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1")]
    public class UsersController : ControllerBase
    {
        public IUserService _service { get; set; }

        public UsersController(IUserService service)
        {
            _service = service;
        }

        [Authorize("Bearer")]
        [HttpGet, Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  // 400 Bad Request - Solicitação Inválida
            }
            try
            {
                var item = await _service.GetAll();
                return Ok(item);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}