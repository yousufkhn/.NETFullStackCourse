using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniMartAPI.Data;
using UniMartAPI.Models;
using UniMartAPI.Services;
using System.Security.Claims;
using UniMartAPI.DTOs.Product;

namespace UniMartAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts(
            int page = 1,
            int pageSize =10,
            int? categoryId = null,
            string? search= null,
            string? sortBy = null,
            string? sortOrder = "asc")           
        {

            if(page<= 0 || pageSize<= 0)
            {
                return BadRequest("Invalid Pagination Parameters");
            }

            var (items, totalCount) = await _service.GetAllAsync(page, pageSize, categoryId, search, sortBy, sortOrder);

            // Ok() comes from controller baes this means it returns http 200 and json body 
            return Ok(new
            {
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize,
                Items = items
            });
        }

        [Authorize]
        [HttpPost("add")]
        public async Task<IActionResult> CreateProduct(CreateProductDto dto)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));


            //asp .net automatically reads json from request body,converts to prodct object, passes into method
            var created = await _service.CreateAsync(dto, userId);
            
            // createdAtAction returns 201, nameof -> reference  method safely, new {} -> route values, product -> response body
            return CreatedAtAction(nameof(GetProducts), new { id = dto.Name }, dto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductsById(int id)
        {
            var product = await _service.GetByIdAsync(id);

            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product updatedProduct)
        {
            var success = await _service.UpdateAsync(id, updatedProduct);

            if (!success) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var success = await _service.DeleteAsync(id);

            if (!success) return NotFound();

            return NoContent();
        }

    }
}
