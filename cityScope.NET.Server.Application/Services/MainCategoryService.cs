using cityScope.NET.Server.Application.Dtos;
using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Application.Response;
using cityScope.NET.Server.Application.Services.Interfaces;

namespace cityScope.NET.Server.Application.Services;

public class MainCategoryService : IMainCategoryService
{
	private readonly IMainCategoryRepository _mainCategoryRepository;

	public MainCategoryService(IMainCategoryRepository mainCategoryRepository)
	{
		_mainCategoryRepository = mainCategoryRepository;
	}

	public async Task<BaseResponse<List<MainCategoryDto>>> GetAllCategories()
	{
		BaseResponse<List<MainCategoryDto>> response = new();

		var result = await _mainCategoryRepository.GetAllAsync();
		if (result == null)
		{
			response.Data = new List<MainCategoryDto>();
			response.Success = false;
			response.Message = "List was empty";
			return response;
		}
		foreach (var item in result)
		{
			MainCategoryDto dto = new()
			{
				Id = item.Id,
				Name = item.Name
			};
			response.Data.Add(dto);
		}
		response.Success = true;
		return response;
	}
}
