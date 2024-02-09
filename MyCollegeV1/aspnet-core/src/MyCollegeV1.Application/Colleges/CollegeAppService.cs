using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using MyCollegeV1.Authorization;
using MyCollegeV1.Models;
using MyCollegeV1.Colleges.Dto;

namespace MyCollegeV1.Colleges
{

    [AbpAuthorize(PermissionNames.Pages_Students)]
    public class CollegeAppService : AsyncCrudAppService<College, CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>, ICollegeAppService
    {
        public CollegeAppService
        (
            IRepository<College, int> repository
        )
        : base(repository)
        {

        }

    }
}
