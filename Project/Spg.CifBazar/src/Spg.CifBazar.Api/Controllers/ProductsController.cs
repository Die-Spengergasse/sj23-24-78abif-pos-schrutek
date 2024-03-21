using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spg.CifBazar.DomainModel.Dtos;
using Spg.CifBazar.DomainModel.Exceptions;
using Spg.CifBazar.DomainModel.Interfaces;

namespace Spg.CifBazar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IWritableProductService _writableProductService;
        private readonly IReadOnlyProductService _readonlyProductService;

        public ProductsController(IWritableProductService writableProductService, IReadOnlyProductService readonlyProductService)
        {
            _writableProductService = writableProductService;
            _readonlyProductService = readonlyProductService;
        }

        [HttpGet()]
        public IActionResult GetAction(string name)
        {
            //_readonlyProductService.get...
            return null;
        }

        [HttpPost()]
        public IActionResult Create(CreateProductCommand command)
        {
            try
            {
                ProductDto dto = _writableProductService.Create(command);
                return Created($"api/products/{dto.Name}", dto);
            }
            catch (ProductServiceWriteException ex)
            {
                return BadRequest("Produkt konnte nicht angelegt werden!");
            }
        }
    }
}
