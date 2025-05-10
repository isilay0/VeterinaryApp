using Microsoft.AspNetCore.Mvc;
using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Core.Response;
using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TreatmentController : ControllerBase
    {
        private readonly ITreatmentService service;
        private readonly ILogger<TreatmentController> logger;

        public TreatmentController(ITreatmentService service, ILogger<TreatmentController> logger)
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
        public async Task<IActionResult> Add([FromBody] Treatment treatment)
        {
            try
            {
                await service.Add(treatment);
                return Ok(new ResponseModel(true, message: "Tedavi Eklendi"));
            }
            catch (EntityAlreadyExistsException ex)
            {
                return Conflict(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Tedavi Eklenemedi."));
            }
        }

        [HttpPut]
        [ActionName("Update")]
        public async Task<IActionResult> Update([FromBody] Treatment treatment)
        {
            try
            {
                await service.Update(treatment);
                return Ok(new ResponseModel(true, message: "Tedavi Güncellendi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Tedavi Güncellenemedi."));
            }

        }

        [HttpDelete("{id}")]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await service.Delete(id);
                return Ok(new ResponseModel(true, message: "Tedavi Silindi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Tedavi Silinemedi."));
            }
        }

        [HttpGet("search/name/{name}")]
        [ActionName("GetTreatmentsByAnimalName")]
        public async Task<IActionResult> GetTreatmentsByAnimalName(string name)
        {
            try
            {
                return Ok(new ResponseModel(true, await service.GetTreatmentsByAnimalNameAsync(name)));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Başarısız"));
            }
        }
    }
}
