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

        [NonAction]
        public int GetUserId()
        {
            return int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
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
            var userId = GetUserId();


            //asp .net automatically reads json from request body,converts to prodct object, passes into method
            var created = await _service.CreateAsync(dto, userId);
            
            // createdAtAction returns 201, nameof -> reference  method safely, new {} -> route values, product -> response body
            return CreatedAtAction(nameof(GetProducts), new { id = dto.Name }, dto);
        }

        [Authorize]
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

        //[Authorize]
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateProduct(int id, Product updatedProduct)
        //{
        //    var userId = GetUserId();

        //    var product = await _service.GetByIdAsync(id);

        //    if(product == null)
        //    {
        //        return NotFound();
        //    }

        //    if(product.UserId != userId)
        //    {
        //        return Forbid(); // 403 return code
        //    }

        //    var success = await _service.UpdateAsync(id, updatedProduct);

        //    return NoContent();
        //}

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var userId = GetUserId();

            var product = await _service.GetByIdAsync(id);

            if(product == null)
            {
                return NotFound();
            }

            if(product.SellerId != userId)
            {
                return Forbid(); // 403
            }
            var success = await _service.DeleteAsync(id);

            return NoContent();
        }

        [Authorize]
        [HttpGet("my")]
        public async Task<IActionResult> GetMyProducts()
        {
            var userId = GetUserId();

            var products = await _service.GetMyProductsAsync(userId);

            return Ok(products);
        }

    }
}
