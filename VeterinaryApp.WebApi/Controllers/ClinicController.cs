using Microsoft.AspNetCore.Mvc;
using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Core.Response;
using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Controllers
{
    public class ClinicController : Controller
    {
        private readonly IClinicService service;
        private readonly ILogger<ClinicController> logger;

        public ClinicController(IClinicService service, ILogger<ClinicController> logger)
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
        public async Task<IActionResult> Add([FromBody] Clinic clinic)
        {
            try
            {
                await service.Add(clinic);
                return Ok(new ResponseModel(true, message: "Klinik Eklendi"));
            }
            catch (EntityAlreadyExistsException ex)
            {
                return Conflict(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Klinik Eklenemedi."));
            }
        }

        [HttpPut]
        [ActionName("Update")]
        public async Task<IActionResult> Update([FromBody] Clinic clinic)
        {
            try
            {
                await service.Update(clinic);
                return Ok(new ResponseModel(true, message: "Klinik Güncellendi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Klinik Güncellenemedi."));
            }

        }

        [HttpDelete("{id}")]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await service.Delete(id);
                return Ok(new ResponseModel(true, message: "Klinik Silindi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Klinik Silinemedi."));
            }
        }

    }
}
