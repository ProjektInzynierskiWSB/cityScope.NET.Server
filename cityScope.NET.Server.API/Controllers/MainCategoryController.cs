using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Response;
using cityScope.NET.Server.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace cityScope.NET.Server.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainCategoryController : ControllerBase
    {
        private readonly IMainCategoryService _mainCategoryService;

        public MainCategoryController(IMainCategoryService mainCategoryService)
        {
            _mainCategoryService = mainCategoryService;
        }

        [HttpGet(Name = "GetCategories")]
        public async Task<ActionResult<BaseResponse<List<MainCategoryDto>>>> GetCategories()
        {
            var result = await _mainCategoryService.GetAllCategories();
            return Ok(result);
        }
    }
}
