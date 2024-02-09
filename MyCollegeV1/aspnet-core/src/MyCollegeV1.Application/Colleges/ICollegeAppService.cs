using Abp.Application.Services;
using MyCollegeV1.Colleges.Dto;
using MyCollegeV1.Students.Dto;

namespace MyCollegeV1.Colleges
{
    public interface ICollegeAppService : IAsyncCrudAppService<CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>
    {
      
    }
}

