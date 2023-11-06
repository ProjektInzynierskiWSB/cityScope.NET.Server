using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Response;

namespace cityScope.NET.Server.Application.Services.Interfaces;

public interface IMainCategoryService
{
    Task<BaseResponse<List<MainCategoryDto>>> GetAllCategories();
}
