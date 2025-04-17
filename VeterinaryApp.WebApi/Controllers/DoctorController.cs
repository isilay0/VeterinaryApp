using Microsoft.AspNetCore.Mvc;
using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Core.Response;
using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService service;
        private readonly ILogger<DoctorController> logger;

        public DoctorController(IDoctorService service, ILogger<DoctorController> logger)
        {
            this.service = service;
            this.logger = logger;
        }

        [HttpGet]
        [ActionName("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(new ResponseModel(true, await service.GetAll()));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message));
            }
        }

        [HttpGet("{id}")]
        [ActionName("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(new ResponseModel(true, await service.GetById(id)));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, message: ex.Message));
            }
        }

        [HttpPost]
        [ActionName("Add")]
        public async Task<IActionResult> Add([FromBody] Doctor doctor)
        {
            try
            {
                await service.Add(doctor);
                return Ok(new ResponseModel(true, message: "Doktor Eklendi"));
            }
            catch (EntityAlreadyExistsException ex)
            {
                return Conflict(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Doktor Eklenemedi."));
            }
        }

        [HttpPut]
        [ActionName("Update")]
        public async Task<IActionResult> Update([FromBody] Doctor doctor)
        {
            try
            {
                await service.Update(doctor);
                return Ok(new ResponseModel(true, message: "Doktor Güncellendi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Doktor Güncellenemedi."));
            }

        }

        [HttpDelete("{id}")]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await service.Delete(id);
                return Ok(new ResponseModel(true, message: "Doktor Silindi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Doktor Silinemedi."));
            }
        }

    }
}
