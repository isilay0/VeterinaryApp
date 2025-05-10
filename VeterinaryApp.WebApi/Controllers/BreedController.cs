using Microsoft.AspNetCore.Mvc;
using VeterinaryApp.WebApi.Business;
using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Core.Response;
using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BreedController : ControllerBase
    {
        private readonly IBreedService service;
        private readonly ILogger<BreedController> logger;

        public BreedController(IBreedService service, ILogger<BreedController> logger)
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

        public async Task<IActionResult> Add([FromBody] Breed breed)
        {
            try
            {
                await service.Add(breed);
                return Ok(new ResponseModel(true, message: "Cins Eklendi."));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Cins Eklenemedi."));
            }
        }

        [HttpPut]
        [ActionName("Update")]

        public async Task<IActionResult> Update([FromBody] Breed breed)
        {
            try
            {
                await service.Update(breed);
                return Ok(new ResponseModel(true, message: "Cins Güncellendi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Cins Güncellenemedi."));
            }
        }

        [HttpDelete("{id}")]
        [ActionName("Delete")]

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await service.Delete(id);
                return Ok(new ResponseModel(true, message: "Cins Silindi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Cins Silinemedi"));
            }

        }
        [HttpGet("by-species/{speciesId}")]
        [ActionName("GetBySpecies")]
        public IActionResult GetBreedBySpecies(int speciesId)
        {
            try
            {
                var breeds = service.GetBreedBySpecies(speciesId).Select(b => new { b.Id, b.BreedName }).ToList();
                return Ok(new ResponseModel(true, breeds));
            }
            catch (EntityNotFoundException ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Cinsler Getirilemedi"));
            }
        }
    }
}
