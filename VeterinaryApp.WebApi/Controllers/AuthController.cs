using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Core.Response;
using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService service) : ControllerBase
    {
        private readonly IAuthService service = service;

        [HttpPost("Login")]
        [ActionName("Login")]
        public async Task<IActionResult> Login(LoginRequest req)
        {
            try
            {
                return Ok(new ResponseModel(true, await service.Login(req), "Başarılı"));
            } catch (EntityNotFoundException ex)
            {
                return NotFound(ex.Message);
            } catch (UnauthorizedAccessException ex)
            {
                return Unauthorized();
            } catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPost("SignUp")]
        [ActionName("SignUp")]
        public async Task<IActionResult> SignUp(Doctor req)
        {
            try
            {
                return Ok(new ResponseModel(true, await service.SignUp(req), "Başarılı"));
            } catch (EntityAlreadyExistsException)
            {
                return Conflict();
            } catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
