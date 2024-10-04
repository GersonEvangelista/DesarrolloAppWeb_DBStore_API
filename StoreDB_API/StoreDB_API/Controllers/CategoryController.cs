using Microsoft.AspNetCore.Mvc;
using StoreDB_DOMAIN.Core.DTO;
using StoreDB_DOMAIN.Core.Interfaces;


namespace StoreDB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        //private readonly ICategoryRepository _categoryRepository;
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            //_categoryRepository = categoryRepository;
            _categoryService = categoryService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryService.GetCategories();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id, [FromQuery] bool includeProducts)
        {
            if (includeProducts)
                return Ok(await _categoryService.GetCategoryWithProducts(id));

            return Ok(await _categoryService.GetCategoryById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryDescriptionDTO categoryDTO)
        {
            int categoryId = await _categoryService.Insert(categoryDTO);
            return Ok(categoryId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CategoryDTO categoryDTO)
        {
            if (id != categoryDTO.Id) return BadRequest();
            var result = await _categoryService.Update(categoryDTO);
            if (!result) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _categoryService.Delete(id);
            if (!result) return NotFound();
            return Ok(result);
        }

    }
}
