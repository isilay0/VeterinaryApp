using Microsoft.AspNetCore.Mvc;
using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Core.Response;
using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;
        private readonly ILogger<ProductController> logger;

        public ProductController(IProductService service, ILogger<ProductController> logger)
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
        public async Task<IActionResult> Add([FromBody] Product product)
        {
            try
            {
                await service.Add(product);
                return Ok(new ResponseModel(true, message: "Ürün Eklendi"));
            }
            catch (EntityAlreadyExistsException ex)
            {
                return Conflict(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Ürün Eklenemedi."));
            }
        }

        [HttpPut]
        [ActionName("Update")]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
            try
            {
                await service.Update(product);
                return Ok(new ResponseModel(true, message: "Ürün Güncellendi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Ürün Güncellenemedi."));
            }

        }

        [HttpDelete("{id}")]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await service.Delete(id);
                return Ok(new ResponseModel(true, message: "Ürün Silindi."));
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(new ResponseModel(false, message: ex.Message));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseModel(false, ex.Message, "Ürün Silinemedi."));
            }
        }
        [HttpGet("search/name/{name}")]
        [ActionName("SearchName")]
        public async Task<IActionResult> SearchName(string name)
        {
            try
            {
                return Ok(new ResponseModel(true, await service.SearchName(name)));
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
    }
}
