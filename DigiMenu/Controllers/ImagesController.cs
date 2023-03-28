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
    public class ImagesController : ControllerRepository<IImageService,ImageDto>
    {
        private readonly IImageService _imageService;

        public ImagesController(IImageService service) : base(service)
        {
            _imageService= service;
        }

        [HttpGet("getImageByCategoryId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetImageByCategoryId(int id)
        {
            var result = _imageService.GetImageByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
