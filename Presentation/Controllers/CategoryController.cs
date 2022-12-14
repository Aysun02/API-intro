using Businness.DTOs.Category.Request;
using Businness.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        #region Documentation
        /// <summary>
        ///Returns a list of categories
        /// </summary>
        /// <returns></returns>
#endregion
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _categoryService.GetAllAsync());
        }

        #region Documentation
        /// <summary>
        ///Used to find a category by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        #endregion
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _categoryService.GetAsync(id));
        }

        #region Documentation
        /// <summary>
        /// It is used to create a category
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 
        #endregion
        [HttpPost("create")]
        public async Task<IActionResult> Create(CategoryCreateDTO model)
        {
            return Ok(await _categoryService.CreateAsync(model));
        }

        #region Documentation
        /// <summary>
        /// Used for category editing
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        #endregion
        [HttpPost("update")]
        public async Task<IActionResult> Update(CategoryUpdateDTO model)
        {
            return Ok(await _categoryService.UpdateAsync(model));
        }

        #region Documentation
        /// <summary>
        /// Used to delete a category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        #endregion
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _categoryService.DeleteAsync(id));
        }
    }
}