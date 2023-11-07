using cityScope.NET.Server.Application.Interfaces;
using cityScope.NET.Server.Domain.Entities;

namespace cityScope.NET.Server.Persistence.Repository;

public class MainCategoryRepository : AsyncRepository<MainCategory>, IMainCategoryRepository
{
    public MainCategoryRepository(MyDbContext context) : base(context)
    {
    }


}
