using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Core.Response;
using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {

        private readonly IAppoinmentService service;
        private readonly ILogger<AppointmentController> logger;

        public AppointmentController(IAppoinmentService service, ILogger<AppointmentController> logger)
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
                return BadRequest(new ResponseModel(false, message :  ex.Message));
            }
        }

        [HttpPost]
        [ActionName("Add")]

        public async Task<IActionResult> Add([FromBody] Appointment appointment)
        {
            try
            {
                await service.Add(appointment);
                return Ok(new ResponseModel(true, message : "Randevu Eklendi."));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Randevu Eklenemedi."));
            }
        }

        [HttpPut]
        [ActionName("Update")]

        public async Task<IActionResult> Update([FromBody]Appointment appointment)
        {
            try
            {
                await service.Update(appointment);
                return Ok(new ResponseModel(true, message: "Randevu Güncellendi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Randevu Güncellenemedi."));
            }
        }

        [HttpDelete("{id}")]
        [ActionName("Delete")]

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await service.Delete(id);
                return Ok(new ResponseModel(true, message: "Randevu Silindi."));
            }
            catch (EntityNotFoundException ex) 
            {
                return NotFound(new ResponseModel(false, message : ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Randevu Silinemedi"));
            }

        }
        
    }
}
