using Business.Abstract;
using DataAccess.Entities.Concrete;
using DataAccess.Entities.DTOs.BaseDtos;
using DigiMenu.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DigiMenu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerRepository<ICategoryService,CategoryDto>
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService):base(categoryService)
        {
            _categoryService = categoryService; 
        }

        [HttpGet("getParentId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetByParentId(int id)
        {
            var result = _categoryService.GetByParentId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
