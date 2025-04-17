using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Core.Response;
using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService service;
        private readonly ILogger<CustomerController> logger;

        public CustomerController(ICustomerService service, ILogger<CustomerController> logger)
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
        public async Task<IActionResult> Add([FromBody] Customer customer)
        {
            try
            {
                await service.Add(customer);
                return Ok(new ResponseModel(true, message : "Müşteri Eklendi"));
            }
            catch (EntityAlreadyExistsException ex)
            {
                return Conflict(new ResponseModel(false, message : ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Müşteri Eklenemedi."));
            }
        }

        [HttpPut]
        [ActionName("Update")]
        public async Task<IActionResult> Update([FromBody]Customer customer)
        {
            try
            {
                await service.Update(customer);
                return Ok(new ResponseModel(true, message: "Müşteri Güncellendi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Müşteri Güncellenemedi."));
            }

        }

        [HttpDelete("{id}")]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await service.Delete(id);
                return Ok(new ResponseModel(true, message: "Müşteri Silindi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Müşteri Silinemedi."));
            }
        }
    }
}
