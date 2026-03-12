using Microsoft.AspNetCore.Mvc;
using UniMartAPI.Services;

namespace UniMartAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet("getproducts")]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _service.GetAllAsync();

            return Ok(categories);
        }
    }
}
