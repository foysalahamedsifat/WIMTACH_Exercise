using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using AutoMapper;
using MyCollegeV1.Authorization;
using MyCollegeV1.Colleges.Dto;
using MyCollegeV1.Models;
using MyCollegeV1.Colleges.Dto;

namespace MyCollegeV1.Colleges
{

    [AbpAuthorize(PermissionNames.Pages_Colleges)]
    public class CollegeAppServiceV2 :
        AsyncCrudAppService<College, CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>,
        ICollegeAppService
    {

        private readonly IRepository<College, int> _collegeRepository;
        private readonly IObjectMapper _objectMapper;

        public CollegeAppServiceV2
        (
            IRepository<College, int> collegeRepository,
            IObjectMapper objectMapper
        )
            : base(collegeRepository)
        {
            _collegeRepository = collegeRepository;
            _objectMapper = objectMapper;
        }

        public async Task<List<CollegeDto>> GetMyCustomListAsync()
        {
            var colleges = await Repository.GetAllListAsync();
            colleges = colleges.Where(p => p.Id > 1).ToList();
            return _objectMapper.Map<List<CollegeDto>>(colleges);
        }

        public void CreateMyCustomCollegeV1(CreateCollegeDto input)
        {
            var college = _objectMapper.Map<College>(input);
            _collegeRepository.Insert(college);
        }

        public void CreateMyCustomCollegeV2(CreateCollegeDto input)
        {
            // >>>>>.....
            // Your custom logic code goes HERE .....
            // >>>>>.....
            var college = new College() 
            { 
                Name = input.Name + "-test"
            };
            college.Address = input.Address;
            college.GPSLatitude = input.GPSLatitude;
            college.Longitude = input.Longitude;
            college.IsActive = input.IsActive;
            college.IsFoysalSleep = input.IsFoysalSleep;

            Repository.Insert(college);
        }
    }

}
